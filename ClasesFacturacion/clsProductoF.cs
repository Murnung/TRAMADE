clsProductoF

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TRAMADE
{
    public class clsProductoF
    {
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public decimal precio_unitario { get; set; }
        public int existencia_producto { get; set; } // <-- AQUÍ GUARDAMOS EL STOCK REAL

        public List<clsProductoF> ObtenerProductos(string filtro = "")
        {
            List<clsProductoF> lista = new List<clsProductoF>();
            clsConexion conexion = new clsConexion();
            conexion.Abrir();

            try
            {
                // Le quitamos el estado_producto porque no existe en tu base de datos
                // y le dejamos WHERE 1=1 para que el buscador funcione bien
                string query = @"SELECT P.id_producto, P.nombre_producto, P.precio_unitario, PS.cantidad_stock 
                                 FROM PRODUCTO P
                                 INNER JOIN PRODUCTO_SUCURSAL PS ON P.id_producto = PS.id_producto
                                 WHERE 1=1 ";

                if (!string.IsNullOrEmpty(filtro))
                {
                    query += " AND P.nombre_producto LIKE @filtro";
                }

                SqlCommand cmd = new SqlCommand(query, conexion.SqlC);

                if (!string.IsNullOrEmpty(filtro))
                {
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                }

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    clsProductoF prod = new clsProductoF();
                    prod.id_producto = Convert.ToInt32(dr["id_producto"]);
                    prod.nombre_producto = dr["nombre_producto"].ToString();
                    prod.precio_unitario = Convert.ToDecimal(dr["precio_unitario"]);

                    // Capturamos el stock real de la base de datos
                    prod.existencia_producto = Convert.ToInt32(dr["cantidad_stock"]);

                    lista.Add(prod);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar productos: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
            return lista;
        }
    }
}
