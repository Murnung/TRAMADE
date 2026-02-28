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
    public partial class frmAutorizar : Form
    {
        public frmAutorizar()
        {
            InitializeComponent();
        }
        clsConexion ObjConexion = new clsConexion();
        private void RecargarCompras()
        {
            string consulta = "select * from VistaComprasTabla";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCompras.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAutorizar_Load(object sender, EventArgs e)
        {
            try
            {
                ObjConexion.Abrir();
                RecargarCompras();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }
    }
}
