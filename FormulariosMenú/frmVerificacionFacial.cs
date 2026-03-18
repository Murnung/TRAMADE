using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TRAMADE.ClasesMenu;

namespace TRAMADE
{
    public partial class frmVerificacionFacial : Form
    {
        private string correoEsperado;

        clsDBCon dbc = new clsDBCon();

        VideoCapture grabber;
        CascadeClassifier face;
        LBPHFaceRecognizer recognizer = new LBPHFaceRecognizer(1, 8, 8, 8, 95);

        List<Mat> imagenesEntrenamiento = new List<Mat>();
        List<int> etiquetasIds = new List<int>();

        Dictionary<int, string> mapaLabelCorreo = new Dictionary<int, string>();
        Dictionary<int, string> mapaLabelNombre = new Dictionary<int, string>();

        bool recognizerEntrenado = false;
        System.Windows.Forms.Timer timerCamara = new System.Windows.Forms.Timer();

        const double UMBRAL = 95.0;

        // ── CONSTRUCTOR ────────────────────────────────────────────
        public frmVerificacionFacial(string correo)
        {
            InitializeComponent();
            correoEsperado = correo;
        }

        // ── LOAD (único) ───────────────────────────────────────────
        private void frmVerificacionFacial_Load_1(object sender, EventArgs e)
        {
            string xmlPath = Path.Combine(Application.StartupPath,
                "haarcascade_frontalface_default.xml");

            if (!File.Exists(xmlPath))
            {
                MessageBox.Show("No se encontró: " + xmlPath, "Error XML");
                return;
            }

            face = new CascadeClassifier(xmlPath);
            lblMensaje.Text = "Coloque su rostro frente a la cámara...";
            lblMensaje.ForeColor = Color.Gray;
            cargarRostros();
            iniciarCamara();
        }

        // ── CARGAR ROSTROS ─────────────────────────────────────────
        private void cargarRostros()
        {
            try
            {
                dbc.ObtenerBytesImagen();

                if (dbc.totalUsuarios == 0) return;

                Dictionary<string, int> mapaUsuarios = new Dictionary<string, int>();
                int idActual = 0;

                imagenesEntrenamiento.Clear();
                etiquetasIds.Clear();
                mapaLabelCorreo.Clear();
                mapaLabelNombre.Clear();

                for (int i = 0; i < dbc.totalUsuarios; i++)
                {
                    string nombreUsuario = dbc.nombre[i];
                    string correoUsuario = dbc.correo[i];

                    if (!mapaUsuarios.ContainsKey(nombreUsuario))
                    {
                        mapaUsuarios[nombreUsuario] = idActual;
                        mapaLabelCorreo[idActual] = correoUsuario;
                        mapaLabelNombre[idActual] = nombreUsuario;
                        idActual++;
                    }

                    try
                    {
                        Bitmap bmp = new Bitmap(dbc.convertirByteAImg(i));
                        Mat gris = new Mat();

                        CvInvoke.Imdecode(ImageToByteArray(bmp),
                            ImreadModes.Grayscale, gris);

                        if (gris.IsEmpty) { bmp.Dispose(); continue; }

                        CvInvoke.EqualizeHist(gris, gris);
                        CvInvoke.Resize(gris, gris, new System.Drawing.Size(100, 100));

                        imagenesEntrenamiento.Add(gris);
                        etiquetasIds.Add(mapaUsuarios[nombreUsuario]);
                        bmp.Dispose();
                    }
                    catch { }
                }

                if (imagenesEntrenamiento.Count > 0)
                {
                    recognizer.Train(imagenesEntrenamiento.ToArray(),
                        etiquetasIds.ToArray());
                    recognizerEntrenado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo entrenar: ninguna imagen válida.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando rostros: " + ex.Message);
            }
        }

        // ── INICIAR CÁMARA ─────────────────────────────────────────
        private void iniciarCamara()
        {
            try
            {
                grabber = new VideoCapture(0);

                if (!grabber.IsOpened)
                {
                    MessageBox.Show("No se pudo abrir la cámara.");
                    return;
                }

                timerCamara.Interval = 33;
                timerCamara.Tick += new EventHandler(frameGrabber);
                timerCamara.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cámara no disponible: " + ex.Message);
            }
        }

        // ── PROCESAR FRAMES ────────────────────────────────────────
        private void frameGrabber(object sender, EventArgs e)
        {
            try
            {
                Mat frame = new Mat();
                grabber.Read(frame);
                if (frame.IsEmpty) return;

                Mat gris = new Mat();
                CvInvoke.CvtColor(frame, gris, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(gris, gris);

                Rectangle[] rostrosDetectados = face.DetectMultiScale(
                    gris, 1.1, 3, new System.Drawing.Size(30, 30));

                foreach (Rectangle r in rostrosDetectados)
                {
                    CvInvoke.Rectangle(frame, r, new MCvScalar(0, 255, 0), 2);

                    if (recognizerEntrenado)
                    {
                        Mat rostro = new Mat(gris, r);
                        CvInvoke.Resize(rostro, rostro,
                            new System.Drawing.Size(100, 100));

                        FaceRecognizer.PredictionResult resultado =
                            recognizer.Predict(rostro);
                        rostro.Dispose();

                        if (resultado.Distance < UMBRAL
                            && mapaLabelCorreo.ContainsKey(resultado.Label))
                        {
                            string correoDetectado = mapaLabelCorreo[resultado.Label];
                            string nombreDetectado = mapaLabelNombre[resultado.Label];


                            if (correoDetectado.ToLower() == correoEsperado.ToLower())
                            {
                                lblMensaje.ForeColor = Color.Green;
                                lblMensaje.Text = $"✔ Bienvenido, {nombreDetectado}";

                                timerCamara.Stop();
                                grabber.Dispose();

                                frmMenuPrincipal objMenu = new frmMenuPrincipal();
                                objMenu.Show();
                                this.Close();
                                return;
                            }
                            else
                            {
                                lblMensaje.ForeColor = Color.Orange;
                                lblMensaje.Text = "✘ Rostro no corresponde a la cuenta";
                            }
                        }
                        else
                        {
                           

                            lblMensaje.ForeColor = Color.Red;
                            lblMensaje.Text = "✘ Rostro no reconocido";
                        }
                    }
                }

                if (rostrosDetectados.Length == 0)
                {
                    lblMensaje.ForeColor = Color.Gray;
                    lblMensaje.Text = "Coloque su rostro frente a la cámara...";
                }

                Image<Bgr, byte> imgConvertida = frame.ToImage<Bgr, byte>();
                Bitmap bitmapFrame = imgConvertida.ToBitmap();

                if (picCamara.Image != null)
                    picCamara.Image.Dispose();

                picCamara.Image = (Bitmap)bitmapFrame.Clone();
                bitmapFrame.Dispose();
                imgConvertida.Dispose();
                gris.Dispose();
                frame.Dispose();
            }
            catch { }
        }

        // ── BOTÓN CANCELAR ─────────────────────────────────────────
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timerCamara.Stop();
            if (grabber != null) grabber.Dispose();
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }

        // ── CERRAR FORMULARIO ──────────────────────────────────────
        private void frmVerificacionFacial_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                timerCamara.Stop();
                if (grabber != null && grabber.IsOpened)
                    grabber.Dispose();
            }
            catch { }
        }

        // ── AUXILIAR ───────────────────────────────────────────────
        private byte[] ImageToByteArray(System.Drawing.Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                return ms.ToArray();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            timerCamara.Stop();
            if (grabber != null) grabber.Dispose();
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }

        private void picCamara_Click(object sender, EventArgs e)
        {

        }
    }
}