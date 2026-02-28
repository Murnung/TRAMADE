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

    public partial class frmSeguimiento : Form
    {
        public frmSeguimiento()
        {
            InitializeComponent();
        }
        clsConexion ObjConexion = new clsConexion();

        private void RecargarUsuarios()
        {
            string consulta = "select * from VistaComprasTabla";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCompras.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmSeguimiento_Load(object sender, EventArgs e)
        {
            try
            {
                ObjConexion.Abrir(); // Abrir la conexión
                string consulta = "SELECT * FROM VistaUsuarioTabla"; // Consulta SQL
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt); // Llenar el DataTable
                dgvCompras.DataSource = dt; // Asignar al DataGridView

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar(); // Siempre cerrar la conexión
            }

        }



        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
