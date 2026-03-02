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
        public void AgregarConlumnaCheck()
        {
            if (dgvAprobacion.Columns.Contains("Seleccionar")) return;

            DataGridViewCheckBoxColumn Chk = new DataGridViewCheckBoxColumn();
            Chk.HeaderText = "Seleccionar";
            Chk.Name = "Seleccionar";
            Chk.Width = 80;
            dgvAprobacion.Columns.Insert(0, Chk);
        }

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
                AgregarConlumnaCheck();
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
            foreach (DataGridViewRow fila in dgvAprobacion.Rows)
            {
                bool marcado = Convert.ToBoolean(fila.Cells["Seleccionar"].Value);
                if (marcado)
                {
                    int idCliente = Convert.ToInt32(fila.Cells["ID Cliente"].Value);
                    ObjCliente.AutorizarCliente(ObjConexion, idCliente);
                }
            }
            MessageBox.Show("Clientes autorizados correctamente.");
            recargarClientes();
        }

        private void btnNegar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvAprobacion.Rows)
            {
                bool marcado = Convert.ToBoolean(fila.Cells["Seleccionar"].Value);
                if (marcado)
                {
                    int idCliente = Convert.ToInt32(fila.Cells["ID Cliente"].Value);
                    ObjCliente.DenegarCliente(ObjConexion, idCliente);
                }
            }
            MessageBox.Show("Clientes denegados correctamente.");
            recargarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = ObjCliente.BuscarCliente(ObjConexion, txtBuscar.Text);
            if (dt != null)
            {
                dgvAprobacion.DataSource = dt;
                AgregarConlumnaCheck();
            }
           
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
