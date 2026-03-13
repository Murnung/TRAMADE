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
using TRAMADE.ClasesProveedor;

namespace TRAMADE
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
            clsDataGridView.AplicarEstilo(dgvProveedor);
            lblInstrucciones.Text = clsProveedores.InstruccionesDGV();
            RecargarProveedores();

            dgvProveedor.CellBeginEdit += (s, ev) =>  
            {
                if (dgvProveedor.Columns[ev.ColumnIndex].Name != "Seleccionar")
                    ev.Cancel = true;
            };
        }

        public void RecargarProveedores()
        {
            clsProveedores ObjProveedores = new clsProveedores();
            dgvProveedor.DataSource = ObjProveedores.ObtenerProveedores();
            clsDataGridView.AplicarEstilo(dgvProveedor);
            clsDataGridView.OcultarColumna(dgvProveedor, "id_proveedor");
            clsDataGridView.AgregarColumnaCheckbox(dgvProveedor); 
        }

        private void btnAñadirProveedor_Click(object sender, EventArgs e)
        {
            frmProveedores_Añadir frmAñadir = new frmProveedores_Añadir();
            frmAñadir.ShowDialog(); 

            RecargarProveedores(); 
        }

        private void btnFiltrarActivo_Click(object sender, EventArgs e)
        {
            clsProveedores ObjProveedores = new clsProveedores();
            ObjProveedores.CambiarEstadoMasivo_Activo(dgvProveedor);
            RecargarProveedores();
        }

        private void btnFiltrarInactivo_Click(object sender, EventArgs e)
        {
            clsProveedores ObjProveedores = new clsProveedores();
            ObjProveedores.CambiarEstadoMasivo_Inactivo(dgvProveedor);
            RecargarProveedores();
        }

        
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            clsProveedores ObjProveedores = new clsProveedores();

            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                RecargarProveedores();
            else
            {
                dgvProveedor.DataSource = ObjProveedores.BuscarProveedores(txtBuscar.Text);
                clsDataGridView.OcultarColumna(dgvProveedor, "id_proveedor");
            }
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {

        }

        private void dgvProveedorCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvProveedor.Columns[e.ColumnIndex].Name == "Seleccionar") return;

            int idProveedor = Convert.ToInt32(dgvProveedor.Rows[e.RowIndex].Cells["id_proveedor"].Value);

            frmProveedores_Perfil frmPerfil = new frmProveedores_Perfil(idProveedor);
            frmPerfil.FormClosed += (s, ev) => RecargarProveedores();
            frmPerfil.Show();
        }
    }
}

