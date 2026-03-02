using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMADE.ClasesInventario
{
    internal class clsProductoDAL
    {
        public static DataTable ObtenerProductos(string filtro, int pagina, int registrosPorPagina)
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();
            int offset = (pagina - 1) * registrosPorPagina;
            SqlCommand cmd = new SqlCommand("SELECT * FROM VistaProductosDetalle " + filtro + " OFFSET @offset ROWS FETCH NEXT @cantidad ROWS ONLY", obj.SqlC);
            cmd.Parameters.AddWithValue("@offset", offset);
            cmd.Parameters.AddWithValue("@cantidad", registrosPorPagina);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            obj.Cerrar();
            return dt;
        }

        public static int ContarProductos()
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM VistaProductosDetalle", obj.SqlC);
            int total = (int)cmd.ExecuteScalar();
            obj.Cerrar();
            return total;
        }

        public static DataTable BuscarProductos(string busqueda)
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();
            SqlCommand cmd;
            int idBuscar;
            if (int.TryParse(busqueda, out idBuscar))
            {
                cmd = new SqlCommand("SELECT * FROM VistaProductosDetalle WHERE ID = @buscar", obj.SqlC);
                cmd.Parameters.AddWithValue("@buscar", idBuscar);
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM VistaProductosDetalle WHERE Nombre LIKE @buscar", obj.SqlC);
                cmd.Parameters.AddWithValue("@buscar", "%" + busqueda + "%");
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            obj.Cerrar();
            return dt;
        }

        public static void EliminarProducto(int idProducto)
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();
            try
            {
                SqlCommand cmdDC = new SqlCommand("DELETE FROM DETALLE_COMPRA WHERE id_producto = @id", obj.SqlC);
                cmdDC.Parameters.AddWithValue("@id", idProducto);
                cmdDC.ExecuteNonQuery();

                SqlCommand cmdPP = new SqlCommand("DELETE FROM PRODUCTO_PROVEEDOR WHERE id_producto = @id", obj.SqlC);
                cmdPP.Parameters.AddWithValue("@id", idProducto);
                cmdPP.ExecuteNonQuery();

                SqlCommand cmdPS = new SqlCommand("DELETE FROM PRODUCTO_SUCURSAL WHERE id_producto = @id", obj.SqlC);
                cmdPS.Parameters.AddWithValue("@id", idProducto);
                cmdPS.ExecuteNonQuery();

                SqlCommand cmdProd = new SqlCommand("DELETE FROM PRODUCTO WHERE id_producto = @id", obj.SqlC);
                cmdProd.Parameters.AddWithValue("@id", idProducto);
                cmdProd.ExecuteNonQuery();
            }
            finally
            {
                obj.Cerrar();
            }
        }

        public static int ObtenerIdCategoria(SqlConnection con, string nombre)
        {
            SqlCommand cmd = new SqlCommand("SELECT id_categoria FROM CATEGORIA WHERE nombre_categoria = @nombre", con);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            return (int)cmd.ExecuteScalar();
        }

        public static int ObtenerIdProveedor(SqlConnection con, string nombre)
        {
            SqlCommand cmd = new SqlCommand("SELECT id_proveedor FROM PROVEEDOR WHERE nombre_comercial_proveedor = @nombre", con);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            return (int)cmd.ExecuteScalar();
        }

        public static int ObtenerIdSucursal(SqlConnection con, string nombre)
        {
            SqlCommand cmd = new SqlCommand("SELECT id_sucursal FROM SUCURSAL WHERE nombre_sucursal = @nombre", con);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            return (int)cmd.ExecuteScalar();
        }
    }
}
