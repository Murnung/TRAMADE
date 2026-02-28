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
using TRAMADE.ClasesCompras;

namespace TRAMADE
{

    public partial class frmSeguimiento : Form
    {
        public frmSeguimiento()
        {
            InitializeComponent();
        }
        clsConexion ObjConexion = new clsConexion();
        clsCompras ObjCompras = new clsCompras();
        clsFiltrarCompras ObjFc = new clsFiltrarCompras();

        private void recargarCompras()
        {

            try
            {
                ObjConexion.Abrir();
                string consulta = "SELECT * FROM VistaComprasTabla";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCompras.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recargar: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
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
            recargarCompras();
            dgvCompras.Columns["ID proveedor"].Visible = false;
            dgvCompras.Columns["ID producto"].Visible = false;
            dgvCompras.Columns["ID forma pago"].Visible = false;
            dgvCompras.Columns["ID estado"].Visible = false;

        }



        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = ObjFc.FiltrarFechas(ObjConexion, dtDesde, dtHasta, txtBuscar.Text);
            if (dt != null)
            {
                dgvCompras.DataSource = dt;
            }
        }
    }
}
