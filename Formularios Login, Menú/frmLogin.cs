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

        clsConexion conexion = new clsConexion();

         public void login (string usuario, string contraseña)
        {
            try
            {
                conexion.Abrir();  //Abrir la conexion a la base de datos

                string consulta = "SELECT * FROM VistaUsuariosLogin WHERE correo_usuario = @usuario AND password_usuario = @contra";  //Consulta con parametros
                SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC);//Nuevo comado sql que sera ejecuta contra la base de datos
                cmd.Parameters.AddWithValue("@usuario", usuario); //Agrega un parametro llamado @usuario al comando SQL y le asigna el valor que escribio el ususario en el text box
                cmd.Parameters.AddWithValue("@contra", contraseña); //esto remplazqa el @Usuario en SQL con el valor real 

                //ejecuta y lee los resultados
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())  //Intenta lee una fila
                {
                    MessageBox.Show("Inicio de seccion exitoso");
                    frmMenuPrincipal objMenu = new frmMenuPrincipal();
                    objMenu.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
                dr.Close(); //Librea recursos del sqldatareader
                conexion.Cerrar(); //Cierra la conexion a labase de datos
                
            } catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
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
    }
}
