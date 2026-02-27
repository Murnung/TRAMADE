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
    public class clsProveedores
    {
        public int id_proveedor;
        public string nombre_comercial_proveedor;
        public string razon_social_proveedor;
        public string direccion_proveedor;
        public string rtn_proveedor;
        public int id_clasificacion_proveedor;
        public int id_estado;
        public int id_terminos_de_pago_proveedor;
        public string contacto_proveedor;
        public string correo_electronico_proveedor;

        public clsProveedores()
        {
            // Constructor vacío
            id_estado = 1; // Asignar estado activo por defecto
        }

        // CONSTRUCTOR
        public clsProveedores(string nombre, string razon, string direccion, string rtn, int clasificacion, int terminos, string contacto, string correo)
        {
            nombre_comercial_proveedor = nombre;
            razon_social_proveedor = razon;
            direccion_proveedor = direccion;
            rtn_proveedor = rtn;
            id_clasificacion_proveedor = clasificacion;
            id_estado = 1;
            id_terminos_de_pago_proveedor = terminos;
            contacto_proveedor = contacto;
            correo_electronico_proveedor = correo;
        }

        public DataTable FiltrarPorEstado(string estado)  // ← int a string
        {
            clsConexion ObjConexion = new clsConexion();
            DataTable dt = new DataTable();
            try
            {
                ObjConexion.Abrir();
                SqlCommand cmd = new SqlCommand("SELECT * FROM VistaProveedorTabla WHERE [Estado] = @estado", ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@estado", estado);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
            return dt;
        }

    }
}
