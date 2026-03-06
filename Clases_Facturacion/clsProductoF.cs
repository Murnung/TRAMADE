using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TRAMADE
{
    public class clsProductoF
    {
        // Propiedades de tu producto
        public int id_producto { get; set; }
        public string nombre_producto { get; set; }
        public decimal precio_unitario { get; set; }

        // Método que busca en la base de datos y devuelve una lista
        public List<clsProductoF> ObtenerProductos(string filtro = "")
        {
            List<clsProductoF> lista = new List<clsProductoF>();
            clsConexion ObjConexion = new clsConexion();
            ObjConexion.Abrir();

            try
            {
                string consulta = "SELECT id_producto, nombre_producto, precio_unitario FROM PRODUCTO";

                if (filtro != "")
                {
                    consulta += " WHERE nombre_producto LIKE @filtro";
                }

                SqlCommand cmd = new SqlCommand(consulta, ObjConexion.SqlC);

                if (filtro != "")
                {
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                }

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // Por cada fila en SQL, creamos un objeto ProductoF
                    clsProductoF prod = new clsProductoF();
                    prod.id_producto = Convert.ToInt32(dr["id_producto"]);
                    prod.nombre_producto = dr["nombre_producto"].ToString();
                    prod.precio_unitario = Convert.ToDecimal(dr["precio_unitario"]);

                    // Lo metemos a la lista
                    lista.Add(prod);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar productos desde la base de datos: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }

            return lista;
        }
    }
}