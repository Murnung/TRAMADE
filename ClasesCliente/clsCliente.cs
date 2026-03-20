using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Krypton.Toolkit;
using System.Linq.Expressions;
using System.Drawing;


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

                cmdCliente.Parameters.AddWithValue("@id_usuario", idUsuario);
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
        public bool ActulizarCliente(clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                SqlCommand cmdCliente = new SqlCommand("PA_ACTUALIZAR_CLIENTE", conexion.SqlC);
                cmdCliente.CommandType = CommandType.StoredProcedure;

                cmdCliente.Parameters.AddWithValue("@id_cliente", Convert.ToInt32(id));
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


                cmdCliente.Parameters.AddWithValue("@id_usuario", idUsuario);

                cmdCliente.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar en la base de datos: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public bool AutorizarCliente(clsConexion conexion, int idCliente)
        {
            try
            {
                conexion.Abrir();
                using (SqlCommand cmd = new SqlCommand("PA_AUTORIZAR_CLIENTE", conexion.SqlC))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al autorizar cliente: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public bool DenegarCliente(clsConexion conexion, int idCliente)
        {
            try
            {
                conexion.Abrir();
                using (SqlCommand cmd = new SqlCommand("PA_DENEGAR_CLIENTE", conexion.SqlC))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al denegar cliente: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public DataTable BuscarCliente(clsConexion conexion, string textoBuscar)
        {
            try
            {
                conexion.Abrir();

                string consulta = "select * from vista_aprobacion_clientes where [Nombre Cliente] like @nombre";

                using (SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC))
                {
                    cmd.Parameters.AddWithValue("@nombre", "%" + textoBuscar.Trim() + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message);
                return null;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public dynamic ObtenerEstadisticas(clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
          
                string consulta = "PA_OBTENER_CONTADORES ";

                SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new
                    {
                        Total = reader["Total"].ToString(),
                        Activos = reader["Activos"].ToString(),
                        Inactivos = reader["Inactivos"].ToString()
                    };
                }
                return null;
            }
            finally 
            { 
                conexion.Cerrar(); 
            }
        }

        public DataTable ObtenerPorcentajeEstados(clsConexion conexion)
        {
            DataTable dt = new DataTable();
            string sql = " PA_PorcentajeEstados ";
            try
            {
                conexion.Abrir();
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion.SqlC);
                da.Fill(dt);
            }
            finally { conexion.Cerrar(); }
            return dt;
        }

        public DataTable ObtenerTopDepartamentos(clsConexion conexion)
        {
            DataTable dt = new DataTable();
            string sql = "PA_TopDepartamentos";
            try
            {
                conexion.Abrir();
                SqlDataAdapter da = new SqlDataAdapter(sql, conexion.SqlC);
                da.Fill(dt);
            }
            finally { conexion.Cerrar(); }
            return dt;
        }

        public  void ConfigurarTipo(string tipoCliente,Control txtRTN,Control cmbRazonSocial,Control txtDNI)
        {
            if (tipoCliente == "PERSONA JURÍDICA")
            {
             
                txtRTN.Enabled = true;
                txtRTN.BackColor = Color.White;

                cmbRazonSocial.Enabled = true;
                cmbRazonSocial.BackColor = Color.White;

                txtDNI.Enabled = false;
                txtDNI.Text = "";
                txtDNI.BackColor = Color.LightGray;
            }
            if (tipoCliente == "PERSONA NATURAL")
            {
                
                txtRTN.Enabled = false;
                txtRTN.Text = "";
                txtRTN.BackColor = Color.LightGray;

                cmbRazonSocial.Enabled = false;
                if (cmbRazonSocial is ComboBox cb) 
                {
                    cb.SelectedIndex = -1;
                }
                cmbRazonSocial.BackColor = Color.LightGray;

              
                txtDNI.Enabled = true;
                txtDNI.BackColor = Color.White;
            }
            
        }
        public  DataTable BuscarCliente(string busqueda, clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                
                string consulta = @"SELECT C.*, CI.id_departamento 
                            FROM CLIENTE C 
                            INNER JOIN CIUDAD CI ON C.id_ciudad = CI.id_ciudad 
                            WHERE C.rtn_cliente = @busqueda OR C.dni_cliente = @busqueda";

                SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC);
                cmd.Parameters.AddWithValue("@busqueda", busqueda);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la consulta de búsqueda: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
        }

    }
}
