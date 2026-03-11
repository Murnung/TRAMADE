using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace TRAMADE.Formulario_Proveedores.Clases
{
    internal class clsProveedores_Añadir : clsProveedores
    {
        /*clsConexion ObjConexion = new clsConexion();

        public void InsertarProveedor(clsProveedores ObjProveedores)
        {
            try
            {
                ObjConexion.Abrir();

                SqlCommand cmd = new SqlCommand("PA_INSERTAR_PROVEEDOR", ObjConexion.SqlC);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre_comercial_proveedor", ObjProveedores.nombre_comercial_proveedor);
                cmd.Parameters.AddWithValue("@razon_social_proveedor", ObjProveedores.razon_social_proveedor);
                cmd.Parameters.AddWithValue("@direccion_proveedor", ObjProveedores.direccion_proveedor);
                cmd.Parameters.AddWithValue("@rtn_proveedor", ObjProveedores.rtn_proveedor);
                cmd.Parameters.AddWithValue("@id_clasificacion_proveedor", ObjProveedores.id_clasificacion_proveedor);
                cmd.Parameters.AddWithValue("@id_estado", ObjProveedores.id_estado);
                cmd.Parameters.AddWithValue("@id_terminos_de_pago_proveedor", ObjProveedores.id_terminos_de_pago_proveedor);
                cmd.Parameters.AddWithValue("@contacto_proveedor", ObjProveedores.contacto_proveedor);
                cmd.Parameters.AddWithValue("@correo_electronico_proveedor", ObjProveedores.correo_electronico_proveedor);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Proveedor agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }*/


        clsConexion ObjConexion = new clsConexion();
        clsProveedores_Añadir objProv = new clsProveedores_Añadir();
        public frmProveedores_Añadir()
        {
            InitializeComponent();
            // En el constructor reemplazar llenarCombo por:
            clsCombobox.LlenarCombosProveedor(cmbClasificacion, cmbTerminosdePago, ObjConexion);
            clsToolTip.AplicarTooltipsProveedor(txtRazonSocial, txtNombreComercial, txtDireccionFiscal,
                                         txtRtn, txtTelefonoGeneral, txtCorreoCentral,
                                         cmbClasificacion, cmbTerminosdePago);
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
            if (!clsValidar.ValidarProveedor(
            txtNombreComercial.Text, txtNombreComercial,
            txtRazonSocial.Text, txtRazonSocial,
            txtDireccionFiscal.Text, txtDireccionFiscal,
            txtRtn.Text, txtRtn,
            txtTelefonoGeneral.Text, txtTelefonoGeneral,
            txtCorreoCentral.Text, txtCorreoCentral,
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

