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
    public partial class frmAutorizar : Form
    {
        public frmAutorizar()
        {
            InitializeComponent();
        }

        clsConexion ObjConexion = new clsConexion();
        clsCompras ObjCompras = new clsCompras();
        clsOperacionesCompra ObjOp = new clsOperacionesCompra();
        clsFiltrarCompras ObjFc= new clsFiltrarCompras();
        private void AgregarColumnaCheck()
        {
            // Evitar duplicar la columna si ya existe
            if (dgvCompras.Columns.Contains("Seleccionar")) return;

            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.Name= "Seleccionar";
            chk.HeaderText= "Seleccionar";
            chk.Width = 80;
            dgvCompras.Columns.Insert(0, chk); // La pone de primera
        }

        private void recargarCompras()
        {
            DataTable dt = ObjCompras.obtenerTablaCompras();
            if (dt == null) return;

            dgvCompras.DataSource = dt;
            AgregarColumnaCheck();

            dgvCompras.Columns["ID proveedor"].Visible = false;
            dgvCompras.Columns["ID producto"].Visible = false;
            dgvCompras.Columns["ID forma pago"].Visible = false;
            dgvCompras.Columns["ID estado"].Visible = false;

            dgvCompras.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.AllowUserToResizeRows = false;
            dgvCompras.AllowUserToResizeColumns = false;
            dgvCompras.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(148, 114, 71);
            dgvCompras.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCompras.EnableHeadersVisualStyles = false;
            dgvCompras.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 154, 111);
            dgvCompras.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCompras.AllowUserToAddRows = false;
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
            recargarCompras();
           

        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            if (!clsValidar.FilaSeleccionada(dgvCompras)) return;

            foreach (DataGridViewRow fila in dgvCompras.Rows)
            {
                if (fila.IsNewRow) continue;

                bool marcado = Convert.ToBoolean(fila.Cells["Seleccionar"].Value);

                if (marcado && fila.Cells["ID compra"].Value != DBNull.Value && fila.Cells["ID compra"].Value != null)
                {
                    int idCompra = Convert.ToInt32(fila.Cells["ID compra"].Value);
                    ObjOp.autorizarCompra(ObjConexion, idCompra);
                }
            }
            MessageBox.Show("Compras autorizadas correctamente.");
            recargarCompras();

        }

        private void btnDenegar_Click(object sender, EventArgs e)
        {
            if (!clsValidar.FilaSeleccionada(dgvCompras)) return;

            foreach (DataGridViewRow fila in dgvCompras.Rows)
            {
                if (fila.IsNewRow) continue;

                bool marcado = Convert.ToBoolean(fila.Cells["Seleccionar"].Value);

                if (marcado && fila.Cells["ID compra"].Value != DBNull.Value && fila.Cells["ID compra"].Value != null)
                {
                    int idCompra = Convert.ToInt32(fila.Cells["ID compra"].Value);
                    ObjOp.denegarCompra(ObjConexion, idCompra);
                }
            }
            MessageBox.Show("Compras denegadas correctamente.");
            recargarCompras();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!clsValidar.BuscarId(txtBuscar.Text.Trim())) return;
            DataTable dt = ObjFc.BuscarCompra(ObjConexion, txtBuscar.Text);
            if (dt != null)
            {
                dgvCompras.DataSource = dt;
                AgregarColumnaCheck();
            }

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            recargarCompras();
        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
