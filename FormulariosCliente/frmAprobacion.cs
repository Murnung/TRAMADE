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
using TRAMADE.ClasesCliente;

namespace TRAMADE
{
    public partial class frmAprobacion : Form
    {

        public frmAprobacion()
        {
            InitializeComponent();
        }

        private void frmAprobacion_Load(object sender, EventArgs e)
        {
            recargarClientes();
            
        }

        clsConexion ObjConexion = new clsConexion();
        clsCliente ObjCliente = new clsCliente();
  

        private void recargarClientes()
        {
            try
            {
                ObjConexion.Abrir();
                string consulta = "SELECT * FROM vista_aprobacion_clientes";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvAprobacion.DataSource = dt;
             
                dgvAprobacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvAprobacion.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgvAprobacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dgvAprobacion.AllowUserToResizeRows = false;
                dgvAprobacion.AllowUserToResizeColumns = false;
                dgvAprobacion.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(148, 114, 71);
                dgvAprobacion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvAprobacion.EnableHeadersVisualStyles = false;
                dgvAprobacion.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 154, 111);
                dgvAprobacion.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            if (dgvAprobacion.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvAprobacion.SelectedRows)
                {
                    int idCliente = Convert.ToInt32(fila.Cells["ID Cliente"].Value);
                    ObjCliente.AutorizarCliente(ObjConexion, idCliente);
                }

                MessageBox.Show("Clientes seleccionados autorizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recargarClientes();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos una fila desde el encabezado (barra izquierda).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            recargarClientes();
        }

        private void btnNegar_Click(object sender, EventArgs e)
        {
            if (dgvAprobacion.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvAprobacion.SelectedRows)
                {
                    int idCliente = Convert.ToInt32(fila.Cells["ID Cliente"].Value);
                    ObjCliente.DenegarCliente(ObjConexion, idCliente);
                }

                MessageBox.Show("Clientes seleccionados autorizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recargarClientes();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos una fila desde el encabezado (barra izquierda).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            recargarClientes();
        }


        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ObjCliente.BuscarCliente(ObjConexion, txtBuscar.Text);
            if (dt != null)
            {
                dgvAprobacion.DataSource = dt;
            }
        }

    }
}
