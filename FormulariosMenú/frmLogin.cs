using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void frmLogin_Load(object sender, EventArgs e) { }

        clsConexion conexion = new clsConexion();

        int intentosFallidos = 0; 
        const int MAX_INTENTOS = 3;

        public async Task login(string usuario, string contraseña)
        {
            int espera = 2000;
            int intentos = 3;

            for (int i = 0; i < intentos; i++)
            {
                try
                {
                    await conexion.AbrirAsync();
                    string consulta = "SELECT * FROM VistaUsuariosLogin WHERE correo_usuario = @usuario AND password_usuario = @contra";
                    SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contra", contraseña);
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();

                    if (dr.Read())
                    {
                        clsSesion.id_usuario = Convert.ToInt32(dr["id_usuario"]);
                        clsSesion.nombre_usuario = dr["nombre_usuario"].ToString();
                        dr.Close();
                        conexion.Cerrar();

                        intentosFallidos = 0; // ✅ Resetea intentos al lograr éxito
                        this.Hide();
                        frmVerificacionFacial frm = new frmVerificacionFacial(usuario);
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        dr.Close();
                        conexion.Cerrar();

                        // ✅ Criterio: Contraseña y usuarios incorrectos + máximo 3 intentos
                        intentosFallidos++;
                        int intentosRestantes = MAX_INTENTOS - intentosFallidos;

                        if (intentosFallidos >= MAX_INTENTOS)
                        {
                            MessageBox.Show("Ha alcanzado el máximo de intentos.\nEl sistema se cerrará.",
                                "Acceso bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                            return;
                        }

                        MessageBox.Show($"Usuario o contraseña incorrectos.\nIntentos restantes: {intentosRestantes}",
                            "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    return;
                }
                catch (Exception ex)
                {
                    conexion.Cerrar();
                    if (i < intentos - 1)
                        await Task.Delay(espera);
                    else
                        MessageBox.Show("Error al conectar: " + ex.Message);
                }
            }


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese su usuario" || txtUsuario.Text == "" ||
                txtPassword.Text == "Ingrese su contraseña" || txtPassword.Text == "")
            {
                MessageBox.Show("Necesita llenar ambos campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnIngresar.Enabled = false; // Evita doble clic mientras carga
                string usuario = txtUsuario.Text.Trim();
                string contra = txtPassword.Text.Trim();
                await login(usuario, contra);
                btnIngresar.Enabled = true;
            }
        }

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnIngresar.PerformClick();
        }
    }
}
