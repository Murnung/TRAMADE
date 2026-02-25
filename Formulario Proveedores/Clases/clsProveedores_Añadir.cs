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
    public class clsProveedores_Añadir
    {

        clsConexion ObjConexion = new clsConexion();
        public void InsertarProveedor(clsProveedores p)
        {
            try
            {
                ObjConexion.Abrir();

                SqlCommand cmd = new SqlCommand("PA_INSERTAR_PROVEEDOR", ObjConexion.SqlC);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre_comercial_proveedor", p.nombre_comercial_proveedor);
                cmd.Parameters.AddWithValue("@razon_social_proveedor", p.razon_social_proveedor);
                cmd.Parameters.AddWithValue("@direccion_proveedor", p.direccion_proveedor);
                cmd.Parameters.AddWithValue("@rtn_proveedor", p.rtn_proveedor);
                cmd.Parameters.AddWithValue("@id_clasificacion_proveedor", p.id_clasificacion_proveedor);
                cmd.Parameters.AddWithValue("@id_estado", p.id_estado);
                cmd.Parameters.AddWithValue("@id_terminos_de_pago_proveedor", p.id_terminos_de_pago_proveedor);
                cmd.Parameters.AddWithValue("@contacto_proveedor", p.contacto_proveedor);
                cmd.Parameters.AddWithValue("@correo_electronico_proveedor", p.correo_electronico_proveedor);

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

