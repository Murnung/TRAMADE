using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.ClasesProveedor;
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
            clsCombobox.LlenarCombosProveedor(cmbClasificacion, cmbTerminosdePago, ObjConexion);
            ObjEditar.CargarDatosActuales(_idProveedor, txtRazonSocial, txtNombreComercial, txtDireccionFiscal, txtRtn, txtTelefonoGeneral, txtCorreoCentral, cmbClasificacion, cmbTerminosdePago);
            clsToolTip.AplicarTooltipsProveedor(txtRazonSocial, txtNombreComercial, txtDireccionFiscal,
                                         txtRtn, txtTelefonoGeneral, txtCorreoCentral,
                                         cmbClasificacion, cmbTerminosdePago);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!clsValidar.ValidarProveedor(
            txtNombreComercial.Text, txtNombreComercial,
            txtRazonSocial.Text, txtRazonSocial,
            txtDireccionFiscal.Text, txtDireccionFiscal,
            txtRtn.Text, txtRtn,
            txtTelefonoGeneral.Text, txtTelefonoGeneral,
            txtCorreoCentral.Text, txtCorreoCentral,
            Convert.ToInt32(cmbClasificacion.SelectedValue),
            Convert.ToInt32(cmbTerminosdePago.SelectedValue),
            _idProveedor)) return;

            /*if (!clsValidar.ValidarProveedor(
            txtNombreComercial.Text, txtRazonSocial.Text, txtDireccionFiscal.Text,
            txtRtn.Text, txtTelefonoGeneral.Text, txtCorreoCentral.Text,
            Convert.ToInt32(cmbClasificacion.SelectedValue),
            Convert.ToInt32(cmbTerminosdePago.SelectedValue),
            _idProveedor)) return;*/

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

            frmProveedores_Perfil frmPerfil = Application.OpenForms["frmProveedores_Perfil"] as frmProveedores_Perfil;
            if (frmPerfil != null) frmPerfil.RecargarPerfil();

            frmProveedores frmProv = Application.OpenForms["frmProveedores"] as frmProveedores;
            if (frmProv != null) frmProv.RecargarProveedores();

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
