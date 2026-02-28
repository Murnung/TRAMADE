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
using System.Linq.Expressions;

namespace TRAMADE.ClasesCliente
{
    internal class clsCliente
    {
        private string id, nombre, razonSocial, tipoCliente, contacto, dni;
        private string correo, direccion, ciudad, telefono, departamento;
        private int estado = 7, idUsuario;
        private string RTN;
        private bool autorizar = false;
        private DateTime fechaRegistro;

        private DataTable ListaDepar = new DataTable();
        private DataTable ListaCiudad = new DataTable();
        private DataTable ListaTipoCliente = new DataTable();
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


        public static void llenarcomboDepartamento(Krypton.Toolkit.KryptonComboBox cmbDepartamento, clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                string consulta = "SELECT id_departamento, nombre_departamento FROM DEPARTAMENTO";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbDepartamento.DataSource = dt;
                cmbDepartamento.DisplayMember = "nombre_departamento";
                cmbDepartamento.ValueMember = "id_departamento";

                cmbDepartamento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar departamentos: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
        }


        public static void llenarcombociudad(KryptonComboBox cmbCiudad, clsConexion conexion, int idDepartamento)
        {
            try
            {
                    conexion.Abrir();
                    
                    string consulta = "SELECT id_ciudad, nombre_ciudad FROM CIUDAD WHERE id_departamento = @idDep";
                    SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC);
                    cmd.Parameters.AddWithValue("@idDep", idDepartamento);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbCiudad.DataSource = dt;
                    cmbCiudad.DisplayMember = "nombre_ciudad";
                    cmbCiudad.ValueMember = "id_ciudad";

                    cmbCiudad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ciudades: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public static void llenarcomboTipoCliente(KryptonComboBox cmbTipoCliente, clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                string consulta = "SELECT id_clasificacion_cliente, descripcion_clasificacion_cliente FROM CLASIFICACION_CLIENTE";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbTipoCliente.DataSource = dt;
                cmbTipoCliente.DisplayMember = "descripcion_clasificacion_cliente";
                cmbTipoCliente.ValueMember = "id_clasificacion_cliente";
                cmbTipoCliente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de cliente: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
        }


        public bool InsertarCliente(clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                SqlCommand cmdCliente = new SqlCommand("PA_INSERTAR_CLIENTE", conexion.SqlC);
                cmdCliente.CommandType = CommandType.StoredProcedure;

                cmdCliente.Parameters.AddWithValue("@nombre_cliente", nombre);
               
                cmdCliente.Parameters.AddWithValue("@rtn_cliente", string.IsNullOrWhiteSpace(RTN) ? (object)DBNull.Value : RTN); 
                cmdCliente.Parameters.AddWithValue("@razon_social", string.IsNullOrWhiteSpace(razonSocial) ? (object)DBNull.Value : razonSocial);
                cmdCliente.Parameters.AddWithValue("@dni_cliente", string.IsNullOrWhiteSpace(dni) ? (object)DBNull.Value : dni);


                cmdCliente.Parameters.AddWithValue("@telefono_cliente", telefono);
                cmdCliente.Parameters.AddWithValue("@contacto_cliente", contacto);
                cmdCliente.Parameters.AddWithValue("@correo_electronico_cliente", correo);
                cmdCliente.Parameters.AddWithValue("@direccion_cliente", direccion);
                cmdCliente.Parameters.AddWithValue("@id_estado", Convert.ToInt32(estado));
                cmdCliente.Parameters.AddWithValue("@id_clasificacion_cliente", Convert.ToInt32(tipoCliente));
                cmdCliente.Parameters.AddWithValue("@id_ciudad", Convert.ToInt32(ciudad));
                
                cmdCliente.Parameters.AddWithValue("@id_usuario", 2);
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
        /*public void ActulizarCliente(clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                SqlCommand cmdCliente = new SqlCommand("PA_ACTUALIZAR_CLIENTE", conexion.SqlC);
                cmdCliente.CommandType = CommandType.StoredProcedure;

                cmdCliente.Parameters.AddWithValue("@nombre_cliente", nombre);

                cmdCliente.Parameters.AddWithValue("@rtn_cliente", string.IsNullOrWhiteSpace(RTN) ? (object)DBNull.Value : RTN);
                cmdCliente.Parameters.AddWithValue("@razon_social", string.IsNullOrWhiteSpace(razonSocial) ? (object)DBNull.Value : razonSocial);
                cmdCliente.Parameters.AddWithValue("@dni_cliente", string.IsNullOrWhiteSpace(dni) ? (object)DBNull.Value : dni);


                cmdCliente.Parameters.AddWithValue("@telefono_cliente", telefono);
                cmdCliente.Parameters.AddWithValue("@contacto_cliente", contacto);
                cmdCliente.Parameters.AddWithValue("@correo_electronico_cliente", correo);
                cmdCliente.Parameters.AddWithValue("@direccion_cliente", direccion);
                cmdCliente.Parameters.AddWithValue("@id_clasificacion_cliente", Convert.ToInt32(tipoCliente));
                cmdCliente.Parameters.AddWithValue("@id_ciudad", Convert.ToInt32(ciudad));
                cmdCliente.Parameters.AddWithValue("@id_estado", Convert.ToInt32(estado));

                cmdCliente.Parameters.AddWithValue("@id_usuario", 2);

                cmdCliente.ExecuteNonQuery();
            }
        }*/



    }
}
