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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        clsConexion ObjConexion = new clsConexion();
        clsCliente ObjCliente = new clsCliente();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            recargarClientes();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
                frmRegistro objRegis = new frmRegistro();
            objRegis.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmRegistroNuevo objRegisNue = new frmRegistroNuevo();
            objRegisNue.Show();
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            frmAprobacion objApro = new frmAprobacion();
            objApro.Show();
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            frmSeguimiento objSegui = new frmSeguimiento();
            objSegui.Show();
        }

        private void recargarClientes()
        {
            try
            {
                ObjConexion.Abrir();
                string consulta = "SELECT * FROM Ultimos_Clientes";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dvgUltimos.DataSource = dt;

                dvgUltimos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
    }
}
