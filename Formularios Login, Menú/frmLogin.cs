using System;
using System.Data.SqlClient;
using System.Drawing;
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

        // ── BOTÓN INGRESAR ─────────────────────────────────────────
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtUsuario.Text == "Ingrese su usuario" ||
                txtPassword.Text == "" || txtPassword.Text == "Ingrese su contraseña")
            {
                MessageBox.Show("Necesita llenar ambos campos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string correo = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (validarCredenciales(correo, password))
            {
                // Credenciales correctas → abrir verificación facial
                frmVerificacionFacial frm = new frmVerificacionFacial(correo);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── VALIDAR CREDENCIALES ───────────────────────────────────
        private bool validarCredenciales(string correo, string password)
        {
            try
            {
                conexion.Abrir();
                string consulta = "SELECT COUNT(*) FROM VistaUsuariosLogin " +
                                  "WHERE correo_usuario = @usuario " +
                                  "AND password_usuario = @contra";
                SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC);
                cmd.Parameters.AddWithValue("@usuario", correo);
                cmd.Parameters.AddWithValue("@contra", password);
                int resultado = (int)cmd.ExecuteScalar();
                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}