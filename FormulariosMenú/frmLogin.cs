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
        public void login (string usuario, string contraseña)
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
                    // Guarda los datos del usuario en la sesión
                    clsSesion.id_usuario = Convert.ToInt32(dr["id_usuario"]);
                    clsSesion.nombre_usuario = dr["nombre_usuario"].ToString();

                    MessageBox.Show("Inicio de sesión exitoso");
                        dr.Close();
                        conexion.Cerrar();

                    this.Hide(); 
                    frmMenuPrincipal menu = new frmMenuPrincipal();
                    menu.Show(); 
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == null || txtPassword == null)
            {
                MessageBox.Show("Necesita llenar ambos campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string usuario = txtUsuario.Text.Trim();  //Trim para eliminar espacios de ambos lados
                string contra = txtPassword.Text.Trim();
                login(usuario, contra);
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
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
