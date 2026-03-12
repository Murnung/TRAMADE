using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TRAMADE.Formularios_Login__Menú.Clases;

namespace TRAMADE
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUsuario.Text = "Ingrese su usuario";
            txtUsuario.ForeColor = Color.Gray;
            txtPassword.Text = "Ingrese su contraseña";
            txtPassword.ForeColor = Color.Gray;
        }

        clsConexion conexion = new clsConexion();
        clsDBCon dbc = new clsDBCon();

        VideoCapture grabber;
        CascadeClassifier face;
        // ✅ Umbral muy alto para no rechazar
        LBPHFaceRecognizer recognizer = new LBPHFaceRecognizer(1, 8, 8, 8, 1000);
        List<Mat> imagenesEntrenamiento = new List<Mat>();
        List<int> etiquetasIds = new List<int>();
        List<string> nombresUsuarios = new List<string>();
        string nombreReconocido = "";
        bool recognizerEntrenado = false;
        System.Windows.Forms.Timer timerCamara = new System.Windows.Forms.Timer();

        // ── LOGIN ──────────────────────────────────────────────────
        public void login(string usuario, string contraseña)
        {
            try
            {
                conexion.Abrir();
                string consulta = "SELECT * FROM VistaUsuariosLogin WHERE correo_usuario = @usuario AND password_usuario = @contra";
                SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contra", contraseña);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Inicio de sesión exitoso");
                    dr.Close();
                    conexion.Cerrar();
                    frmMenuPrincipal objMenu = new frmMenuPrincipal();
                    objMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    dr.Close();
                    conexion.Cerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ── LOAD ───────────────────────────────────────────────────
        private void frmLogin_Load(object sender, EventArgs e)
        {
            string xmlPath = Path.Combine(Application.StartupPath,
                "haarcascade_frontalface_default.xml");

            if (!File.Exists(xmlPath))
            {
                MessageBox.Show("No se encontró: " + xmlPath, "Error XML");
                return;
            }

            face = new CascadeClassifier(xmlPath);
            cargarRostros();
            iniciarCamara();
        }

        // ── CARGAR ROSTROS ─────────────────────────────────────────
        public void cargarRostros()
        {
            try
            {
                dbc.ObtenerBytesImagen();

                Dictionary<string, int> mapaUsuarios = new Dictionary<string, int>();
                int idActual = 0;

                for (int i = 0; i < dbc.totalUsuarios; i++)
                {
                    string nombreUsuario = dbc.nombre[i];

                    if (!mapaUsuarios.ContainsKey(nombreUsuario))
                    {
                        mapaUsuarios[nombreUsuario] = idActual;
                        nombresUsuarios.Add(nombreUsuario);
                        idActual++;
                    }

                    Bitmap bmp = new Bitmap(dbc.convertirByteAImg(i));
                    Mat img = new Mat();
                    Mat gris = new Mat();
                    CvInvoke.Imdecode(ImageToByteArray(bmp),
                        ImreadModes.AnyColor, img);
                    CvInvoke.CvtColor(img, gris, ColorConversion.Bgr2Gray);
                    CvInvoke.EqualizeHist(gris, gris); // ✅ mismo preprocesamiento que la cámara
                    CvInvoke.Resize(gris, gris, new System.Drawing.Size(100, 100));

                    imagenesEntrenamiento.Add(gris);
                    etiquetasIds.Add(mapaUsuarios[nombreUsuario]);
                    img.Dispose();
                    bmp.Dispose();
                }

                if (imagenesEntrenamiento.Count > 0)
                {
                    recognizer.Train(imagenesEntrenamiento.ToArray(),
                        etiquetasIds.ToArray());
                    recognizerEntrenado = true;
                    MessageBox.Show($"Entrenamiento OK: {imagenesEntrenamiento.Count} imágenes, {nombresUsuarios.Count} usuarios");
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
                    MessageBox.Show("No se pudo abrir la cámara");
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

                        // ── TEMPORAL: ver distancia ──────────────
                        lblEstado.ForeColor = Color.Orange;
                        lblEstado.Text = $"Dist: {resultado.Distance:F0} Label: {resultado.Label}";
                        // ─────────────────────────────────────────

                        // ✅ Umbral ajustado a 200
                        if (resultado.Distance < 150)
                        {
                            nombreReconocido = nombresUsuarios[resultado.Label];
                            CvInvoke.PutText(frame, nombreReconocido,
                                new System.Drawing.Point(r.X, r.Y - 5),
                                FontFace.HersheyTriplex, 0.5,
                                new MCvScalar(0, 255, 0), 1);
                        }
                        else
                        {
                            nombreReconocido = "";
                            CvInvoke.PutText(frame, "Desconocido",
                                new System.Drawing.Point(r.X, r.Y - 5),
                                FontFace.HersheyTriplex, 0.5,
                                new MCvScalar(0, 0, 255), 1);
                        }
                    }
                }

                // Mostrar en picCamara
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

        // ── BOTÓN INGRESAR ─────────────────────────────────────────
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Necesita llenar ambos campos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(nombreReconocido))
            {
                MessageBox.Show("No se reconoció ningún rostro. " +
                    "Asegúrese de estar frente a la cámara.",
                    "Acceso denegado", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            login(txtUsuario.Text.Trim(), txtPassword.Text.Trim());
        }

        // ── EVENTOS TEXTBOX ────────────────────────────────────────
        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese su usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese su usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Ingrese su contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Ingrese su contraseña";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        // ── BOTÓN SALIR ────────────────────────────────────────────
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ── CERRAR FORMULARIO ──────────────────────────────────────
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                timerCamara.Stop();
                if (grabber != null) grabber.Dispose();
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
    }
}