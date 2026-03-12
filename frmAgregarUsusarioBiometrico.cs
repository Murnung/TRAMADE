using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TRAMADE.Formularios_Login__Menú.Clases;

namespace TRAMADE
{
    public partial class frmAgregarUsusarioBiometrico : Form
    {
        clsConexion conexion = new clsConexion();
        clsDBCon dbc = new clsDBCon();

        VideoCapture grabber;
        CascadeClassifier detector;
        System.Windows.Forms.Timer timerCamara = new System.Windows.Forms.Timer();

        bool rostroDetectado = false;
        bool capturandoAuto = false;
        int fotosCapturadas = 0;
        int totalFotos = 20;

        public frmAgregarUsusarioBiometrico()
        {
            InitializeComponent();
        }

        private void frmAgregarUsusarioBiometrico_Load(object sender, EventArgs e)
        {
            clsDBCon.llenarComboUsuarios(cmbUsuarios, conexion);
            iniciarCamara();
            btnGuardar.Enabled = false;
            btnCapturar.Enabled = false;
            lblEstado.Text = "Seleccione un usuario para comenzar";
        }

        // ── INICIAR CÁMARA ─────────────────────────────────────────
        private void iniciarCamara()
        {
            try
            {
                detector = new CascadeClassifier(
                    Path.Combine(Application.StartupPath,
                    "haarcascade_frontalface_default.xml"));

                grabber = new VideoCapture(0);

                if (!grabber.IsOpened)
                {
                    MessageBox.Show("No se pudo abrir la cámara.");
                    return;
                }

                timerCamara.Interval = 33;
                timerCamara.Tick += new EventHandler(procesarFrame);
                timerCamara.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cámara no disponible: " + ex.Message);
            }
        }

        // ── PROCESAR FRAMES ────────────────────────────────────────
        private void procesarFrame(object sender, EventArgs e)
        {
            try
            {
                Mat frame = new Mat();
                grabber.Read(frame);
                if (frame.IsEmpty) return;

                Mat gris = new Mat();
                CvInvoke.CvtColor(frame, gris, ColorConversion.Bgr2Gray);
                CvInvoke.EqualizeHist(gris, gris);

                Rectangle[] rostros = detector.DetectMultiScale(
                    gris, 1.2, 10, new Size(80, 80));

                rostroDetectado = rostros.Length > 0;

                foreach (Rectangle r in rostros)
                    CvInvoke.Rectangle(frame, r, new MCvScalar(0, 255, 0), 2);

                // Captura automática si está activa
                if (capturandoAuto && rostroDetectado && fotosCapturadas < totalFotos)
                {
                    guardarFoto(frame);
                }

                // Actualizar label
                if (!capturandoAuto)
                {
                    if (rostroDetectado)
                    {
                        lblEstado.ForeColor = Color.Green;
                        lblEstado.Text = "✔ Rostro detectado — presione Capturar";
                        btnCapturar.Enabled = cmbUsuarios.SelectedIndex != -1;
                    }
                    else
                    {
                        lblEstado.ForeColor = Color.Red;
                        lblEstado.Text = "✘ No se detecta rostro";
                        btnCapturar.Enabled = false;
                    }
                }

                // ✅ Conversión segura
                Image<Bgr, byte> imgConvertida = frame.ToImage<Bgr, byte>();
                Bitmap bmp = imgConvertida.ToBitmap();
                Bitmap copia = (Bitmap)bmp.Clone();

                if (picCamara.Image != null)
                    picCamara.Image.Dispose();

                picCamara.Image = copia;
                bmp.Dispose();
                imgConvertida.Dispose();
                gris.Dispose();
                frame.Dispose();
            }
            catch { }
        }

        // ── GUARDAR FOTO AUTOMÁTICA ────────────────────────────────
        private void guardarFoto(Mat frame)
        {
            try
            {
                int idUsuario = Convert.ToInt32(cmbUsuarios.SelectedValue);

                // ✅ Conversión segura
                Image<Bgr, byte> imgConvertida = frame.ToImage<Bgr, byte>();
                Bitmap bmp = imgConvertida.ToBitmap();
                Bitmap copia = (Bitmap)bmp.Clone();
                bmp.Dispose();
                imgConvertida.Dispose();

                byte[] imagenBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    copia.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    imagenBytes = ms.ToArray();
                }
                copia.Dispose();

                dbc.insertarImagenFacial(idUsuario, imagenBytes);
                fotosCapturadas++;

                lblEstado.ForeColor = Color.Blue;
                lblEstado.Text = $"📷 Capturando... {fotosCapturadas}/{totalFotos}";

                if (fotosCapturadas >= totalFotos)
                {
                    capturandoAuto = false;
                    btnCapturar.Enabled = false;
                    btnGuardar.Enabled = true;
                    lblEstado.ForeColor = Color.Green;
                    lblEstado.Text = $"✔ {totalFotos} fotos guardadas correctamente";
                }
            }
            catch (Exception ex)
            {
                capturandoAuto = false;
                MessageBox.Show("Error al guardar foto: " + ex.Message);
            }
        }

        // ── BOTÓN CAPTURAR ─────────────────────────────────────────
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
                MessageBox.Show("No se detecta rostro. Póngase frente a la cámara.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            fotosCapturadas = 0;
            capturandoAuto = true;
            btnCapturar.Enabled = false;
            lblEstado.ForeColor = Color.Blue;
            lblEstado.Text = "📷 Iniciando captura automática...";
        }

        // ── BOTÓN GUARDAR ──────────────────────────────────────────
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Registro completado. Se guardaron {totalFotos} fotos de '{cmbUsuarios.Text}'.",
                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            fotosCapturadas = 0;
            capturandoAuto = false;
            btnGuardar.Enabled = false;
            btnCapturar.Enabled = false;
            cmbUsuarios.SelectedIndex = -1;
            lblEstado.ForeColor = Color.Gray;
            lblEstado.Text = "Seleccione un usuario para comenzar";
        }

        // ── COMBO USUARIO CHANGED ──────────────────────────────────
        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedIndex != -1)
            {
                btnCapturar.Enabled = rostroDetectado;
                lblEstado.ForeColor = Color.Gray;
                lblEstado.Text = "Listo — póngase frente a la cámara y presione Capturar";
            }
        }

        // ── BOTÓN CERRAR ───────────────────────────────────────────
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ── CERRAR FORMULARIO ──────────────────────────────────────
        private void frmAgregarUsusarioBiometrico_FormClosing(object sender,
            FormClosingEventArgs e)
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