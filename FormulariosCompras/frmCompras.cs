using Krypton.Toolkit;
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
    public partial class frmCompras : Form
    {
        public frmCompras()
        {
            InitializeComponent();
           
        }
        clsConexion ObjConexion = new clsConexion();
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void recargarCompras()
        {

            try
            {
                ObjConexion.Abrir();
                string consulta = "SELECT * FROM VistaComprasRecientes";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvComprasRecientes.DataSource = dt;

                dgvComprasRecientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgvComprasRecientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvComprasRecientes.ReadOnly = true;
                dgvComprasRecientes.AllowUserToResizeRows = false;
                dgvComprasRecientes.AllowUserToResizeColumns = false;
                dgvComprasRecientes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(148, 114, 71);
                dgvComprasRecientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvComprasRecientes.EnableHeadersVisualStyles = false;
                dgvComprasRecientes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 154, 111);
                dgvComprasRecientes.DefaultCellStyle.SelectionForeColor = Color.White;
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


        private void frmCompras_Load(object sender, EventArgs e)
        {
            recargarCompras();
            

            //Graficas

            var grafico = new clsGraficoEstadoCompras(chtComprasPendientes, ObjConexion);
            grafico.Cargar();
            var graficoProductos = new clsGraficoProductosCompras(chtProductosMasComprados, ObjConexion);
            graficoProductos.Cargar();
            var graficoProveedores = new clsGraficoProveedoresCompras(chtProveedores, ObjConexion);
            graficoProveedores.Cargar();


        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrar_Click_2(object sender, EventArgs e)
        {
            frmRegistrar ObjRegistrar = new frmRegistrar();
            ObjRegistrar.Show();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            frmRegistrar ObjRegistrar = new frmRegistrar();
            ObjRegistrar.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmActualizar ObjActualizar = new frmActualizar();
            ObjActualizar.Show();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            frmAutorizar ObjAutorizar = new frmAutorizar();
            ObjAutorizar.Show();
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            frmSeguimiento ObjSeguimiento = new frmSeguimiento();
            ObjSeguimiento.Show();
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_3(object sender, EventArgs e)
        {
            frmRegistrar ObjRegistrar = new frmRegistrar();
            ObjRegistrar.Show();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            frmActualizar ObjActualizar = new frmActualizar();
            ObjActualizar.Show();
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            frmAutorizar ObjAutorizar = new frmAutorizar();
            ObjAutorizar.Show();
        }

        private void btnSeguimiento_Click_1(object sender, EventArgs e)
        {
            frmSeguimiento ObjSeguimiento = new frmSeguimiento();
            ObjSeguimiento.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            recargarCompras();
        }
    }
}
