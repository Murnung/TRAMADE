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
        private const string VISTA = "SELECT * FROM VistaProveedorTabla";
        private readonly string[] OCULTAS = { "id_proveedor" };

        public frmProveedores()
        {
            InitializeComponent();
            clsDataGridView.AplicarEstilo(dgvProveedor);
            RecargarProveedores();
        }

        public void RecargarProveedores()
        {
            clsDataGridView.Cargar(dgvProveedor, VISTA, ObjConexion.SqlC, OCULTAS);
        }

        private void btnAñadirProveedor_Click(object sender, EventArgs e)
        {
            frmProveedores_Añadir frmAñadir = new frmProveedores_Añadir();
            frmAñadir.ShowDialog();
            RecargarProveedores();
        }


        private void btnFiltrarActivo_Click(object sender, EventArgs e)
        {
            clsDataGridView.FiltrarPorEstado(dgvProveedor, VISTA, ObjConexion.SqlC, "ACTIVO", OCULTAS);
        }

        private void btnFiltrarInactivo_Click(object sender, EventArgs e)
        {
            clsDataGridView.FiltrarPorEstado(dgvProveedor, VISTA, ObjConexion.SqlC, "INACTIVO", OCULTAS);
        }

        public void RecargarProveedoresAC()
        {
            clsProveedores ObjProveedores = new clsProveedores();
            dgvProveedor.DataSource = ObjProveedores.ObtenerProveedores();
            dgvProveedor.Columns["id_proveedor"].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            /*clsProveedores ObjProveedores = new clsProveedores();

            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                // Si está vacío mostrar todos
                RecargarProveedores();
            }
            else
            {
                dgvProveedor.DataSource = ObjProveedores.BuscarProveedores(txtBuscar.Text);
                dgvProveedor.Columns["id_proveedor"].Visible = false;
            }*/

            clsDataGridView.Buscar(dgvProveedor, txtBuscar.Text, VISTA, ObjConexion.SqlC, OCULTAS);
        }

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (e.RowIndex >= 0)
            {
                // Leer columna 0 que sería id_proveedor si la agregas oculta
                int idProveedor = Convert.ToInt32(dgvProveedor.Rows[e.RowIndex].Cells[0].Value);
                frmProveedores_Perfil frmPerfil = new frmProveedores_Perfil(idProveedor);
                frmPerfil.Show();
            }*/

            int id = clsDataGridView.ObtenerIdDobleClick(dgvProveedor, e);
            if (id == -1) return;
            frmProveedores_Perfil frmPerfil = new frmProveedores_Perfil(id);
            frmPerfil.Show();
        }
    }
}

