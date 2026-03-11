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
        }

    }
    
}

