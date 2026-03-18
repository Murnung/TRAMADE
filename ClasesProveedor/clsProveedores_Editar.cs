using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.Formulario_Proveedores.Clases
{
    internal class clsProveedores_Editar : clsProveedores
    {
        clsConexion ObjConexion = new clsConexion();

        public void ActualizarProveedor(clsProveedores ObjProveedores)
        {
            try
            {
                ObjConexion.Abrir();
                SqlCommand cmd = new SqlCommand("PA_ACTUALIZAR_PROVEEDOR", ObjConexion.SqlC);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_proveedor", ObjProveedores.id_proveedor);
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
                MessageBox.Show("Proveedor actualizado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }

        public void CargarDatosActuales(int idProveedor, KryptonComboBox cmbRazonSocial, KryptonTextBox txtNombreComercial,
                                        KryptonTextBox txtDireccionFiscal, KryptonTextBox txtRtn,
                                        KryptonTextBox txtTelefonoGeneral, KryptonTextBox txtCorreoCentral,
                                        KryptonComboBox cmbClasificacion,
                                        KryptonComboBox cmbTerminosdePago)
        {
            clsProveedores_Perfil ObjPerfil = new clsProveedores_Perfil();
            clsProveedores_Perfil ObjDatos = ObjPerfil.ObtenerPerfilProveedor(idProveedor);

            if (ObjDatos != null)
            {
                //txtRazonSocial.Text = ObjDatos.razon_social_proveedor;
                //cmbRazonSocial.Text = reader["razon_social_proveedor"].ToString();
                cmbRazonSocial.Text = ObjDatos.razon_social_proveedor;
                txtNombreComercial.Text = ObjDatos.nombre_comercial_proveedor;
                txtDireccionFiscal.Text = ObjDatos.direccion_proveedor;
                txtRtn.Text = ObjDatos.rtn_proveedor;
                txtTelefonoGeneral.Text = ObjDatos.contacto_proveedor;
                txtCorreoCentral.Text = ObjDatos.correo_electronico_proveedor;

                cmbClasificacion.SelectedValue = ObjDatos.id_clasificacion_proveedor;
                cmbTerminosdePago.SelectedValue = ObjDatos.id_terminos_de_pago_proveedor;
            }
            else
            {
                MessageBox.Show("No se encontraron datos del proveedor.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ─── CAMBIAR ESTADO DEL PROVEEDOR ────────────────────────────
        public void CambiarEstado(int idProveedor, bool activo)
        {
            try
            {
                ObjConexion.Abrir();
                SqlCommand cmd = new SqlCommand("UPDATE PROVEEDOR SET id_estado = @estado WHERE id_proveedor = @id", ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@estado", activo ? 1 : 2);
                cmd.Parameters.AddWithValue("@id", idProveedor);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar estado: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }
    }
}
