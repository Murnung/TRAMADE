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

                dgvCompras.Columns["ID proveedor"].Visible = false;
                dgvCompras.Columns["ID producto"].Visible = false;
                dgvCompras.Columns["ID forma pago"].Visible = false;
                dgvCompras.Columns["ID estado"].Visible = false;

                dgvCompras.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCompras.ReadOnly = true;
                dgvCompras.AllowUserToResizeRows = false;
                dgvCompras.AllowUserToResizeColumns = false;
                dgvCompras.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(148, 114, 71);
                dgvCompras.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvCompras.EnableHeadersVisualStyles = false;
                dgvCompras.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 154, 111);
                dgvCompras.DefaultCellStyle.SelectionForeColor = Color.White;
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
           

            

            clsIndicadoresCompras.totalSolicitudesRegistradas(ObjConexion, lblSolicitudesRegistradas);
            clsIndicadoresCompras.totalValorPendiente(ObjConexion, lblValorTotal);
            clsIndicadoresCompras.tiempoEsperaPromedio(ObjConexion, lblTiempoPromedio);


        }



        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Si hay texto en el buscador, busca por ID
            if (!string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                if (!clsValidar.NullOVacio(txtBuscar.Text.Trim(), "ID Solicitud")) return;
                DataTable dt = ObjFc.BuscarCompra(ObjConexion, txtBuscar.Text);
                if (dt != null)
                    dgvCompras.DataSource = dt;
            }
            else
            {
                // Si no hay texto, busca por fechas
                if (!clsValidar.FechaFiltro(dtDesde.Value, dtHasta.Value)) return;
                DataTable dt = ObjFc.FiltrarFechas(ObjConexion, dtDesde, dtHasta, txtBuscar.Text);
                if (dt != null)
                    dgvCompras.DataSource = dt;
            }


        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            recargarCompras();
        }
    }
}
