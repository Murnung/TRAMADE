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

            txtContraseña.Text = "Ingrese su contraseña";
            txtContraseña.ForeColor = Color.Gray;
        }

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

                        frmCompras frm = new frmCompras();
                        frm.ShowDialog();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == null || txtContraseña == null)
            {
                MessageBox.Show("Necesita llenar ambos campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string usuario = txtUsuario.Text.Trim();  //Trim para eliminar espacios de ambos lados
                string contra = txtContraseña.Text.Trim();
                login(usuario, contra);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese su usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ingrese su usuario";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Ingrese su contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Ingrese su contraseña";
                txtContraseña.ForeColor = Color.Gray;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
