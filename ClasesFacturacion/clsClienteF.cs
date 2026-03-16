using System;
using System.Data.SqlClient;

namespace TRAMADE
{
    public class clsClienteF
    {
        public int id_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string direccion_cliente { get; set; }

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

        public int InsertarClienteRapido(string nombre, string direccion, int idUsuario, string documentoIdentidad)
        {
            int nuevoId = 0;
            clsConexion ObjConexion = new clsConexion();
            ObjConexion.Abrir();

            try
            {
                // Generamos un número único basado en el tiempo para evitar colisiones en la base de datos
                string ticks = DateTime.Now.Ticks.ToString().Substring(8);

                string dniParaBD = "SN-D" + ticks;
                string rtnParaBD = "SN-R" + ticks;
                string telParaBD = "SN-T" + ticks;
                string correoParaBD = "SN-C" + ticks;

                // Si el usuario SÍ escribió un documento válido (13 o 14 números)
                if (!string.IsNullOrWhiteSpace(documentoIdentidad))
                {
                    documentoIdentidad = documentoIdentidad.Trim();
                    if (documentoIdentidad.Length == 13) dniParaBD = documentoIdentidad; // Se va al DNI
                    if (documentoIdentidad.Length == 14) rtnParaBD = documentoIdentidad; // Se va al RTN
                }

                string query = @"INSERT INTO CLIENTE 
                                (nombre_cliente, direccion_cliente, rtn_cliente, dni_cliente, 
                                 id_usuario, id_clasificacion_cliente, id_estado, 
                                 id_ciudad, fecha_registro_cliente, telefono_cliente, 
                                 contacto_cliente, correo_electronico_cliente) 
                                 VALUES 
                                (@nombre, @direccion, @rtn, @dni, 
                                 @usuario, 1, 1, 
                                 1, GETDATE(), @tel, 
                                 'N/A', @correo);
                                 SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@usuario", idUsuario);
                cmd.Parameters.AddWithValue("@rtn", rtnParaBD); // El RTN único para que no falle el UQ_CLIENTE_RTN_FILTRO
                cmd.Parameters.AddWithValue("@dni", dniParaBD);
                cmd.Parameters.AddWithValue("@tel", telParaBD);
                cmd.Parameters.AddWithValue("@correo", correoParaBD);

                nuevoId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear cliente rápido: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }

            return nuevoId;
        }
    }
}
