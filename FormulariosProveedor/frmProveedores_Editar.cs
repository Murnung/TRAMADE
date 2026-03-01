using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.Formulario_Proveedores;
using TRAMADE.Formulario_Proveedores.Clases;

namespace TRAMADE
{
    public partial class frmProveedores_Editar : Form
    {
        private int _idProveedor;
        clsProveedores_Editar ObjEditar = new clsProveedores_Editar();
        clsConexion ObjConexion = new clsConexion();
        public frmProveedores_Editar(int idProveedor)
        {
            InitializeComponent();
            _idProveedor = idProveedor; // ← asignar el ID

            // En el constructor reemplazar llenarCombo por:
            clsCombobox.LlenarCombosProveedor(cmbClasificacion, cmbTerminosdePago, ObjConexion);
            ObjEditar.CargarDatosActuales(_idProveedor, txtRazonSocial, txtNombreComercial, txtDireccionFiscal, txtRtn, txtTelefonoGeneral, txtCorreoCentral, cmbClasificacion, cmbTerminosdePago);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            // En btnGuardar antes de guardar:
            if (!clsValidar.ValidarProveedor(
            txtNombreComercial.Text, txtRazonSocial.Text, txtDireccionFiscal.Text,
            txtRtn.Text, txtTelefonoGeneral.Text, txtCorreoCentral.Text,
            Convert.ToInt32(cmbClasificacion.SelectedValue),
            Convert.ToInt32(cmbTerminosdePago.SelectedValue),
            _idProveedor)) return; // ← pasar el ID del proveedor que se está editando

            clsProveedores ObjProveedores = new clsProveedores(
                clsValidar.Limpiar(txtNombreComercial.Text),
                clsValidar.Limpiar(txtRazonSocial.Text),
                clsValidar.Limpiar(txtDireccionFiscal.Text),
                clsValidar.Limpiar(txtRtn.Text),
                Convert.ToInt32(cmbClasificacion.SelectedValue),
                Convert.ToInt32(cmbTerminosdePago.SelectedValue),
                clsValidar.Limpiar(txtTelefonoGeneral.Text),
                clsValidar.Limpiar(txtCorreoCentral.Text));

            ObjProveedores.id_proveedor = _idProveedor;

            ObjEditar.ActualizarProveedor(ObjProveedores);

            // ─── Recargar ListBox en frmProveedores_Perfil ───────────────
            frmProveedores_Perfil frmPerfil = Application.OpenForms["frmProveedores_Perfil"] as frmProveedores_Perfil;
            if (frmPerfil != null)
                frmPerfil.RecargarPerfil();

            // ─── Recargar DGV en frmProveedores ──────────────────────────
            frmProveedores frmProv = Application.OpenForms["frmProveedores"] as frmProveedores;
            if (frmProv != null)
                frmProv.RecargarProveedores();

            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
