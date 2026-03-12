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
    public partial class frmSeguimientoCliente : Form
    {
        public frmSeguimientoCliente()
        {
            InitializeComponent();
        }
               
        private void frmSeguimiento_Load(object sender, EventArgs e)
        {
            recargarClientes();
            ActualizarContadores();
        }
        clsConexion ObjConexion = new clsConexion();
        clsCliente ObjCliente = new clsCliente();

        private void recargarClientes()
        {
            try
            {
                ObjConexion.Abrir();
                string consulta = "SELECT * FROM VistaClientes";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dvgSeguimiento.DataSource = dt;

                dvgSeguimiento.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dvgSeguimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dvgSeguimiento.ReadOnly = true;
                dvgSeguimiento.AllowUserToResizeRows = false;
                dvgSeguimiento.AllowUserToResizeColumns = false;
                dvgSeguimiento.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(148, 114, 71);
                dvgSeguimiento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dvgSeguimiento.EnableHeadersVisualStyles = false;
                dvgSeguimiento.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 154, 111);
                dvgSeguimiento.DefaultCellStyle.SelectionForeColor = Color.White;


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
       
        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        

        private void ActualizarContadores()
        {
            var stats = ObjCliente.ObtenerEstadisticas(ObjConexion);
            if (stats != null)
            {
                
                txtRegistrados.Text = stats.Total;
                txtActivos.Text = stats.Activos;
                txtInactivos.Text = stats.Inactivos;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ObjCliente.BuscarCliente(ObjConexion, txtBuscar.Text);
            if (dt != null)
            {
                dvgSeguimiento.DataSource = dt;
            }
        }
    }
}
