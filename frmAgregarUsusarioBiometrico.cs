using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.Formularios_Login__Menú.Clases;
using System.IO;

namespace TRAMADE
{
    public partial class frmAgregarUsusarioBiometrico : Form
    {
        clsConexion conexion = new clsConexion();
        clsDBCon dbc = new clsDBCon();

        VideoCapture grabber;
        CascadeClassifier detector;
        System.Windows.Forms.Timer timerCamara = new System.Windows.Forms.Timer();

        Bitmap imagenCapturada = null;
        bool rostroDetectado = false;
        public frmAgregarUsusarioBiometrico()
        {
            InitializeComponent();
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarUsusarioBiometrico_Load(object sender, EventArgs e)
        {
            clsDBCon.llenarComboUsuarios(cmbUsuarios, conexion);
            iniciarCamara();
            btnGuardar.Enabled = false;
            lblEstado.Text = "Esperando.....";
        }

        //Inciar camara
        private void iniciarCamara()
        {
            try
            {
                detector = new CascadeClassifier(Path.Combine(Application.StartupPath, "haarcascade_frontalface_default.xml"));
                grabber = new VideoCapture();

                if (!grabber.IsOpened)
                {
                    MessageBox.Show("No se pudo abrir la cámara");
                    return;
                }

                timerCamara.Interval = 33;
                timerCamara.Tick += new EventHandler(procesarFrame);
                timerCamara.Start();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Cámara no disponible " + ex.Message);
            }
        }

        //Procesar frames
        private void procesarFrame(Object sender, EventArgs e)
        {
            try
            {
                Mat frame = new Mat();
                grabber.Read(frame);
                if (frame.IsEmpty) return;

                Mat gris = new Mat();
                CvInvoke.CvtColor(frame, gris, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(gris, gris);

                Rectangle[] rostros = detector.DetectMultiScale(gris, 1.2, 10, new Size(80, 80));

                rostroDetectado = rostros.Length > 0;

                foreach (Rectangle r in rostros)
                    CvInvoke.Rectangle(frame, r, new MCvScalar(0, 255, 0), 2);

                //Actualizar label estado
                if (rostroDetectado)
                {
                    lblEstado.ForeColor = Color.Green;
                    lblEstado.Text = "✔ Rostro detectado — listo para capturar";
                }
                else
                {
                    lblEstado.ForeColor = Color.Red;
                    lblEstado.Text = "✘ No se detecta rostro";
                }

                //Mostrar en picCamara
                Bitmap bmp = new Bitmap(
                    frame.Width, frame.Height,
                    frame.Width * 3,
                    System.Drawing.Imaging.PixelFormat.Format24bppRgb,
                    frame.DataPointer);
                picCamara.Image = (Bitmap)bmp.Clone();
                bmp.Dispose();
            }
            catch{ }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario primero.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!rostroDetectado)
            {
                MessageBox.Show("No se detecta ningún rostro. " +
                    "Asegúrese de estar frente a la cámara.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Mat frame = new Mat();
                grabber.Read(frame);

                imagenCapturada = new Bitmap(
                    frame.Width, frame.Height,
                    frame.Width * 3,
                    System.Drawing.Imaging.PixelFormat.Format24bppRgb,
                    frame.DataPointer);
                imagenCapturada = (Bitmap)imagenCapturada.Clone();

                picCamara.Image = imagenCapturada;
                timerCamara.Stop();

                btnGuardar.Enabled = true;
                lblEstado.ForeColor = Color.Blue;
                lblEstado.Text = "📷 Foto capturada — presione Guardar";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al capturar: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (imagenCapturada == null)
            {
                MessageBox.Show("Primero capture una imagen.");
                return;
            }

            try
            {
                int idUsuario = Convert.ToInt32(cmbUsuarios.SelectedValue);
                string nombreUsuario = cmbUsuarios.Text;

                // Convertir imagen a bytes
                byte[] imagenBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    imagenCapturada.Save(ms,
                        System.Drawing.Imaging.ImageFormat.Bmp);
                    imagenBytes = ms.ToArray();
                }

                bool guardado = dbc.guardarImagen(idUsuario, imagenBytes);

                if (guardado)
                {
                    MessageBox.Show(
                        $"Rostro de '{nombreUsuario}' guardado correctamente.",
                        "Éxito", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Resetear para siguiente registro
                    imagenCapturada = null;
                    btnGuardar.Enabled = false;
                    cmbUsuarios.SelectedIndex = -1;
                    timerCamara.Start();
                    lblEstado.ForeColor = Color.Gray;
                    lblEstado.Text = "Esperando...";
                }
                else
                {
                    MessageBox.Show("No se pudo guardar la imagen.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarUsusarioBiometrico_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                timerCamara.Stop();
                if (grabber != null) grabber.Dispose();
            }
            catch { }
        }
    }
}
