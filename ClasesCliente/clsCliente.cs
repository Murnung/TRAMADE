using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Krypton.Toolkit;

namespace TRAMADE.ClasesCliente
{
    internal class clsCliente
    {
        private string id, nombre, razonSocial, tipoCliente, contacto, dni;
        private string correo, direccion, ciudad, telefono, departamento;
        private string RTN;
        private int idUsuario;
        private DateTime fechaRegistro;


        public clsCliente()
        {

        }
        public void setID(String valor)
        {
            id = valor;
        }

        public void setNombre(String valor)
        {
            nombre = valor;
        }

        public void setRazonSocial(String valor)
        {
            razonSocial = valor;
        }

        public void setTipoCliente(String valor)
        {
            tipoCliente = valor;
        }

        public void setContacto(String valor)
        {
            contacto = valor;
        }

        public void setTelefono(String valor)
        {
            telefono = valor;
        }

        public void setDepartamento(String valor)
        {
            departamento = valor;
        }

        public void setCorreo(String valor)
        {
            correo = valor;
        }

        public void setDireccion(String valor)
        {
            direccion = valor;
        }

        public void setCiudad(String valor)
        {
            ciudad = valor;
        }

        public void setFechaRegistro(DateTime valor)
        {
            fechaRegistro = valor;
        }

        public void setRTN(string valor)
        {
            RTN = valor;
        }

        public void setIdUsuario(int valor)
        {
            idUsuario = valor;
        }

        public void setDNI(string valor)
        {
            dni = valor;
        }

        public bool InsertarCliente(clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                SqlCommand cmdCliente = new SqlCommand("PA_INSERTAR_CLIENTE", conexion.SqlC);
                cmdCliente.CommandType = CommandType.StoredProcedure;

                cmdCliente.Parameters.AddWithValue("@nombre_cliente", nombre);
                cmdCliente.Parameters.AddWithValue("@razon_social", string.IsNullOrWhiteSpace(razonSocial) ? (object)DBNull.Value : razonSocial);
                cmdCliente.Parameters.AddWithValue("@rtn_cliente", string.IsNullOrWhiteSpace(RTN) ? (object)DBNull.Value : RTN);
                cmdCliente.Parameters.AddWithValue("@dni_cliente", string.IsNullOrWhiteSpace(dni) ? (object)DBNull.Value : dni);
                
                cmdCliente.Parameters.AddWithValue("@telefono_cliente", telefono);
                cmdCliente.Parameters.AddWithValue("@contacto_cliente", contacto);
                cmdCliente.Parameters.AddWithValue("@correo_electronico_cliente", correo);
                cmdCliente.Parameters.AddWithValue("@direccion_cliente", direccion);
                
                //Provisionales
                cmdCliente.Parameters.AddWithValue("@id_usuario", 2);
                cmdCliente.Parameters.AddWithValue("@id_clasificacion_cliente", 1);
                cmdCliente.Parameters.AddWithValue("@id_estado", 7);
                cmdCliente.Parameters.AddWithValue("@id_ciudad", 19);

                cmdCliente.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
    }
}
