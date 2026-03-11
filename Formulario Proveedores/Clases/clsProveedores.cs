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

        // ─── OBTENER TABLA DE PROVEEDORES ────────────────────────────
        public DataTable ObtenerProveedores()
        {
            clsConexion ObjConexion = new clsConexion();
            DataTable dt = new DataTable();
            try
            {
                ObjConexion.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM VistaProveedorTabla", ObjConexion.SqlC);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener proveedores: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
            return dt;
        }

        // ─── BUSCAR PROVEEDORES ───────────────────────────────────────
        public DataTable BuscarProveedores(string criterio)
        {
            clsConexion ObjConexion = new clsConexion();
            DataTable dt = new DataTable();
            try
            {
                ObjConexion.Abrir();
                SqlCommand cmd = new SqlCommand(@"
            SELECT * FROM VistaProveedorTabla 
            WHERE [Razón Social]      LIKE @criterio
               OR [Nombre Comercial] LIKE @criterio
               OR [RTN]              LIKE @criterio", ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@criterio", "%" + criterio.Trim() + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
            return dt;
        }

        // ─── CAMBIAR ESTADO DESDE EL DGV ─────────────────────────────
        public bool CambiarEstado(int idProveedor, bool activar)
        {
            clsConexion ObjConexion = new clsConexion();
            try
            {
                ObjConexion.Abrir();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE PROVEEDOR SET id_estado = @estado WHERE id_proveedor = @id",
                    ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@estado", activar ? 1 : 2);
                cmd.Parameters.AddWithValue("@id", idProveedor);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar estado: " + ex.Message);
                return false;
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }

        // ─── OBTENER ESTADO ACTUAL DEL PROVEEDOR ─────────────────────
        public bool EstaActivo(int idProveedor)
        {
            clsConexion ObjConexion = new clsConexion();
            try
            {
                ObjConexion.Abrir();
                SqlCommand cmd = new SqlCommand(
                    "SELECT id_estado FROM PROVEEDOR WHERE id_proveedor = @id",
                    ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@id", idProveedor);
                int estado = Convert.ToInt32(cmd.ExecuteScalar());
                return estado == 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener estado: " + ex.Message);
                return false;
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }
    }
}
