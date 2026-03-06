using System;
using System.Data.SqlClient;

namespace TRAMADE
{
    public class clsClienteF
    {
        // Propiedades del cliente
        public int id_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string direccion_cliente { get; set; }

        // Método que busca en la base de datos (Devuelve true si lo encuentra)
        public bool BuscarClienteDNI(string rtnDni)
        {
            bool encontrado = false;
            clsConexion ObjConexion = new clsConexion();
            ObjConexion.Abrir();

            try
            {
                string consulta = "SELECT id_cliente, nombre_cliente, direccion_cliente FROM CLIENTE WHERE rtn_cliente = @rtn OR dni_cliente = @rtn";
                SqlCommand cmd = new SqlCommand(consulta, ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@rtn", rtnDni);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Llenamos las propiedades de la clase
                    id_cliente = Convert.ToInt32(reader["id_cliente"]);
                    nombre_cliente = reader["nombre_cliente"].ToString();
                    direccion_cliente = reader["direccion_cliente"].ToString();
                    encontrado = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en BD al buscar cliente: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }

            return encontrado;
        }
    }
}