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
            txtRtn.Enabled = false;
            _idProveedor = idProveedor; // ← asignar el ID
            clsCombobox.LlenarRazonSocial(cmbRazonSocial);
            clsCombobox.LlenarCombosProveedor(cmbClasificacion, cmbTerminosdePago, ObjConexion);
            ObjEditar.CargarDatosActuales(_idProveedor, cmbRazonSocial, txtNombreComercial, txtDireccionFiscal, txtRtn, txtTelefonoGeneral, txtCorreoCentral, cmbClasificacion, cmbTerminosdePago);
            clsToolTip.AplicarTooltipsProveedor(cmbRazonSocial, txtNombreComercial, txtDireccionFiscal,
                                         txtRtn, txtTelefonoGeneral, txtCorreoCentral,
                                         cmbClasificacion, cmbTerminosdePago);
            txtTelefonoGeneral.KeyPress += clsValidar.TelefonoMaximo_KeyPress;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!clsValidar.ValidarProveedor(
            txtNombreComercial.Text, txtNombreComercial,
            cmbRazonSocial.Text, cmbRazonSocial,
            txtDireccionFiscal.Text, txtDireccionFiscal,
            txtRtn.Text, txtRtn,
            txtTelefonoGeneral.Text, txtTelefonoGeneral,
            txtCorreoCentral.Text, txtCorreoCentral,
            Convert.ToInt32(cmbClasificacion.SelectedValue),
            Convert.ToInt32(cmbTerminosdePago.SelectedValue),
            _idProveedor)) return;

            clsProveedores ObjProveedores = new clsProveedores(
                clsValidar.Limpiar(txtNombreComercial.Text),
                clsValidar.Limpiar(cmbRazonSocial.Text),
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
