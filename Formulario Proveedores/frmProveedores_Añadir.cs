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
    public partial class frmProveedores_Añadir : Form
    {
        clsConexion ObjConexion = new clsConexion();
        clsProveedores_Añadir objProv = new clsProveedores_Añadir();
        public frmProveedores_Añadir()
        {
            InitializeComponent();
            // En el constructor reemplazar llenarCombo por:
            clsCombobox.LlenarCombosProveedor(cmbClasificacion, cmbTerminosdePago, ObjConexion);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarCampos()
        {
            txtNombreComercial.Clear();
            txtRazonSocial.Clear();
            txtDireccionFiscal.Clear();
            txtRtn.Clear();
            txtTelefonoGeneral.Clear();
            txtCorreoCentral.Clear();

            cmbClasificacion.SelectedIndex = -1;
            cmbTerminosdePago.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            // En btnGuardar antes de guardar:
            if (!clsValidar.ValidarProveedor(
                txtNombreComercial.Text, txtRazonSocial.Text, txtDireccionFiscal.Text,
                txtRtn.Text, txtTelefonoGeneral.Text, txtCorreoCentral.Text,
                Convert.ToInt32(cmbClasificacion.SelectedValue),
                Convert.ToInt32(cmbTerminosdePago.SelectedValue))) return;

            clsProveedores ObjProveedores = new clsProveedores(
                clsValidar.Limpiar(txtNombreComercial.Text),
                clsValidar.Limpiar(txtRazonSocial.Text),
                clsValidar.Limpiar(txtDireccionFiscal.Text),
                clsValidar.Limpiar(txtRtn.Text),
                Convert.ToInt32(cmbClasificacion.SelectedValue),
                Convert.ToInt32(cmbTerminosdePago.SelectedValue),
                clsValidar.Limpiar(txtTelefonoGeneral.Text),
                clsValidar.Limpiar(txtCorreoCentral.Text));

            clsProveedores_Añadir ObjAñadir = new clsProveedores_Añadir();

            //clsProveedores ObjProveedores = new clsProveedores(txtNombreComercial.Text, txtRazonSocial.Text, txtDireccionFiscal.Text, txtRtn.Text, Convert.ToInt32(cmbClasificacion.SelectedValue), Convert.ToInt32(cmbTerminosdePago.SelectedValue), txtTelefonoGeneral.Text, txtCorreoCentral.Text);

            ObjAñadir.InsertarProveedor(ObjProveedores);

            this.Close(); 
        }

        private void cmbClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClasificacion.SelectedIndex != -1 && cmbClasificacion.SelectedItem is DataRowView)
            {
                DataRowView drv = (DataRowView)cmbClasificacion.SelectedItem;
                int id = Convert.ToInt32(drv["id_clasificacion_proveedor"]);
                string nombre = drv["descripcion_clasificacion_proveedor"].ToString();
            }
        }

        private void cmbTerminosdePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTerminosdePago.SelectedIndex != -1 && cmbTerminosdePago.SelectedItem is DataRowView)
            {
                DataRowView drv = (DataRowView)cmbTerminosdePago.SelectedItem;
                int terminosId = Convert.ToInt32(drv["id_terminos_de_pago_proveedor"]);
                string descripcion = drv["descripcion_terminos_de_pago"].ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
