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
            clsProveedores ObjProveedores = new clsProveedores();
            dgvProveedor.DataSource = ObjProveedores.ObtenerProveedores();
            clsDataGridView.AplicarEstilo(dgvProveedor);
            clsDataGridView.OcultarColumna(dgvProveedor, "id_proveedor");
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
            dgvProveedor.DataSource = ObjProveedores.FiltrarPorEstado("ACTIVO");
            clsDataGridView.OcultarColumna(dgvProveedor, "id_proveedor");
        }

        private void btnFiltrarInactivo_Click(object sender, EventArgs e)
        {
            clsProveedores ObjProveedores = new clsProveedores();
            dgvProveedor.DataSource = ObjProveedores.FiltrarPorEstado("INACTIVO");
            clsDataGridView.OcultarColumna(dgvProveedor, "id_proveedor");

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

        private void dgvProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idProveedor = Convert.ToInt32(dgvProveedor.Rows[e.RowIndex].Cells["id_proveedor"].Value);

            // ─── Doble clic en columna Estado → cambiar estado ────────
            if (dgvProveedor.Columns[e.ColumnIndex].Name == "Estado")
            {
                clsProveedores ObjProveedores = new clsProveedores();
                bool estaActivo = ObjProveedores.EstaActivo(idProveedor);

                string mensaje = estaActivo
                    ? "¿Desea desactivar este proveedor?"
                    : "¿Desea activar este proveedor?";

                DialogResult confirmacion = MessageBox.Show(mensaje, "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    ObjProveedores.CambiarEstado(idProveedor, !estaActivo);
                    RecargarProveedores();
                }
            }
            else
            {
                // ─── Doble clic en cualquier otra columna → abrir perfil ──
                frmProveedores_Perfil frmPerfil = new frmProveedores_Perfil(idProveedor);
                frmPerfil.FormClosed += (s, ev) => RecargarProveedores();
                frmPerfil.Show();
            }

        }
    }
}

