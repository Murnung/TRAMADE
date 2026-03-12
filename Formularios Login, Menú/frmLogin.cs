using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Data;
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
        CascadeClassifier face = new CascadeClassifier(
     Path.Combine(Application.StartupPath, "haarcascade_frontalface_default.xml"));
        EigenFaceRecognizer recognizer = new EigenFaceRecognizer(); 
        Mat currentFrame = new Mat();
        List<Mat> imagenesEntrenamiento = new List<Mat>();
        List<int> etiquetasIds = new List<int>();
        List<string> nombresUsuarios = new List<string>();
        string nombreReconocido = "";
        bool recognizerEntrenado = false;
        System.Windows.Forms.Timer timerCamara = new System.Windows.Forms.Timer();

        //  LOGIN 
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

        // LOAD 
        private void frmLogin_Load(object sender, EventArgs e)
        {
            cargarRostros();
            iniciarCamara();
        }

        //  CARGAR ROSTROS DESDE BD 
        public void cargarRostros()
        {
            try
            {
                dbc.ObtenerBytesImagen();

                for (int i = 0; i < dbc.totalUsuarios; i++)
                {
                    Bitmap bmp = new Bitmap(dbc.convertirByteAImg(i));

                    // Convertir a Mat en escala de grises 100x100
                    Mat img = new Mat();
                    Mat gris = new Mat();
                    CvInvoke.Imdecode(ImageToByteArray(bmp), Emgu.CV.CvEnum.ImreadModes.AnyColor, img);
                    CvInvoke.CvtColor(img, gris, ColorConversion.Bgr2Gray);
                    CvInvoke.Resize(gris, gris, new System.Drawing.Size(100, 100));

                    imagenesEntrenamiento.Add(gris);
                    etiquetasIds.Add(i);
                    nombresUsuarios.Add(dbc.nombre[i]);
                }

                // Entrenar el reconocedor si hay imágenes
                if (imagenesEntrenamiento.Count > 0)
                {
                    recognizer.Train(imagenesEntrenamiento.ToArray(), etiquetasIds.ToArray());
                    recognizerEntrenado = true;
                }
            }
            catch
            {
                // Sin rostros, solo funciona login normal
            }
        }

        // INICIAR CÁMARA 
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

                timerCamara.Interval = 33; // ~30 FPS
                timerCamara.Tick += new EventHandler(frameGrabber);
                timerCamara.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cámara no disponible: " + ex.Message);
            }
        }

        // PROCESAR FRAMES 
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

                // Detectar rostros
                Rectangle[] rostrosDetectados = face.DetectMultiScale(
                    gris, 1.2, 10, new System.Drawing.Size(20, 20));

                foreach (Rectangle r in rostrosDetectados)
                {
                    // Dibujar rectángulo verde
                    CvInvoke.Rectangle(frame, r, new MCvScalar(0, 255, 0), 2);

                    if (recognizerEntrenado)
                    {
                        // Recortar y redimensionar el rostro
                        Mat rostro = new Mat(gris, r);
                        CvInvoke.Resize(rostro, rostro, new System.Drawing.Size(100, 100));

                        // Reconocer
                        FaceRecognizer.PredictionResult resultado = recognizer.Predict(rostro);

                        // Umbral de confianza (menor = más parecido)
                        if (resultado.Distance < 5000)
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

                // Actualizar label estado
                if (rostrosDetectados.Length == 0)
                {
                    lblEstado.ForeColor = Color.Gray;
                    lblEstado.Text = "Mirando a la cámara...";
                }
                else if (!string.IsNullOrEmpty(nombreReconocido))
                {
                    lblEstado.ForeColor = Color.Green;
                    lblEstado.Text = "✔ Reconocido: " + nombreReconocido;
                }
                else
                {
                    lblEstado.ForeColor = Color.Red;
                    lblEstado.Text = "✘ Rostro no reconocido";
                }

                // Mostrar en picCamara
                Bitmap bitmapFrame = new Bitmap(frame.Width, frame.Height,
                frame.Width * 3,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb,
                frame.DataPointer);
                            picCamara.Image = (Bitmap)bitmapFrame.Clone();
            }
            catch { }
        }

        // BOTÓN INGRESAR 
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
                MessageBox.Show("No se reconoció ningún rostro. Asegúrese de estar frente a la cámara.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuario = txtUsuario.Text.Trim();
            string contra = txtPassword.Text.Trim();

            if (!nombreReconocido.Equals(usuario, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El rostro no corresponde al usuario ingresado.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            login(usuario, contra);
        }

        // EVENTOS TEXTBOX 
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

        //BOTÓN SALIR 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // CERRAR FORMULARIO 
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Mat frame = new Mat();
                grabber.Read(frame);
                if (frame.IsEmpty) return;

                // ... resto de tu código de detección

                picCamara.Image = frame.ToBitmap();
            }
            catch { }
        }
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