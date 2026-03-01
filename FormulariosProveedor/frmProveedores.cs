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
using TRAMADE.Formulario_Proveedores;
using TRAMADE.Formulario_Proveedores.Clases;

namespace TRAMADE
{
    public partial class frmProveedores : Form
    {
        
        clsConexion ObjConexion = new clsConexion();
        public frmProveedores()
        {
            InitializeComponent();
            RecargarProveedores();
        }

        private void tmrTransicionLateral(object sender, EventArgs e)
        {



        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        public void RecargarProveedores()
        {
            string consulta = "select * from VistaProveedorTabla";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvProveedores.DataSource = dt;
            dgvProveedores.Columns["id_proveedor"].Visible = false; // ← oculta pero existe para leerla
        }

        private void btnAñadirProveedor_Click(object sender, EventArgs e)
        {
            frmProveedores_Añadir frmAñadir = new frmProveedores_Añadir();
            frmAñadir.ShowDialog(); 

            RecargarProveedores(); 
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Leer columna 0 que sería id_proveedor si la agregas oculta
                int idProveedor = Convert.ToInt32(dgvProveedores.Rows[e.RowIndex].Cells[0].Value);
                frmProveedores_Perfil frmPerfil = new frmProveedores_Perfil(idProveedor);
                frmPerfil.Show();
            }
        }

        private void btnFiltrarActivo_Click(object sender, EventArgs e)
        {
            clsProveedores ObjProveedores = new clsProveedores();
            dgvProveedores.DataSource = ObjProveedores.FiltrarPorEstado("ACTIVO");
            dgvProveedores.Columns["id_proveedor"].Visible = false;
        }

        private void btnFiltrarInactivo_Click(object sender, EventArgs e)
        {
            clsProveedores ObjProveedores = new clsProveedores();
            dgvProveedores.DataSource = ObjProveedores.FiltrarPorEstado("INACTIVO");
            dgvProveedores.Columns["id_proveedor"].Visible = false;
        }

        public void RecargarProveedoresAC()
        {
            clsProveedores ObjProveedores = new clsProveedores();
            dgvProveedores.DataSource = ObjProveedores.ObtenerProveedores();
            dgvProveedores.Columns["id_proveedor"].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            clsProveedores ObjProveedores = new clsProveedores();

            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                // Si está vacío mostrar todos
                RecargarProveedores();
            }
            else
            {
                dgvProveedores.DataSource = ObjProveedores.BuscarProveedores(txtBuscar.Text);
                dgvProveedores.Columns["id_proveedor"].Visible = false;
            }
        }
    }
}

