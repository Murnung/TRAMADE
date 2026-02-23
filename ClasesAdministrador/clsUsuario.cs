using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace TRAMADE.ClasesAdministrador
{
    internal class clsUsuario
    {
        // Propiedades de usuario
        private string nombre, correo, contrasena;
        private int rol, sucursal, estado = 1;


        //Metodo constructor vacio
        public clsUsuario()
        {

        }

        //setters
        public void setNombre(string valor)
        {
            nombre = valor;
        }

        public void setRol(int valor)
        {
            rol = valor;
        }

        public void setSucursal(int valor)
        {
            sucursal = valor;
        }

        public void setCorreo(string valor)
        {
            correo = valor;
        }

        public void setContrasena(string valor)
        {
            contrasena = valor;
        }
        public static void llenarComboRol(Krypton.Toolkit.KryptonComboBox cmb, clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                string consulta = "SELECT id_rol, descripcion_rol FROM VistaRol";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion.SqlC); //mensajero que lleva la consulta a la base de datos y trae los resultados de vuelta.
                DataTable dt = new DataTable(); //Crea una tabla vacía en la memoria(como una hoja en blanco) y el mensajero(adapter) la llena(con fill) con los datos que trajo de la base de datos.
                adapter.Fill(dt);

                cmb.DataSource = dt; //Conecta el ComboBox con la tabla que acabamos de llenar. Ahora el ComboBox ya tiene los datos.
                cmb.DisplayMember = "descripcion_rol"; //Muestra al usuario el texto de la columna
                cmb.ValueMember = "id_rol"; //Guarda el ID como el valor real
                cmb.SelectedIndex = -1; // Para que no seleccione nada por defecto
            }
            catch (Exception ex) //Por si sale un error , lo atrapa y muetra un mensaje en lugar de que el programa se cierre de una
            {
                MessageBox.Show("Error al cargar ComboBox: " + ex.Message);
            }
            finally // Cierra la puerta de la base de datos siempre, pase lo que pase(haya error o no), para no desperdiciar memoria.
            {
                conexion.Cerrar();
            }
        }

        public static void llenarComboSucrusal(Krypton.Toolkit.KryptonComboBox cmb, clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                string consulta = "SELECT id_sucursal, nombre_sucursal FROM VistaSucursal";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmb.DataSource = dt;
                cmb.DisplayMember = "nombre_sucursal";
                cmb.ValueMember = "id_sucursal";
                cmb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ComboBox: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public bool insertarUsuarios(clsConexion conexion)
        {

            try
            {
                conexion.Abrir();
                SqlCommand comando = new SqlCommand("PA_INSERTAR_USUARIO", conexion.SqlC);
                comando.CommandType = CommandType.StoredProcedure; //Avisamos que es un Procedimiento Almacenado y no texto común
                comando.Parameters.AddWithValue("@id_rol", rol);
                comando.Parameters.AddWithValue("@id_estado", estado);
                comando.Parameters.AddWithValue("@id_sucursal", sucursal);
                comando.Parameters.AddWithValue("@nombre_usuario", nombre);
                comando.Parameters.AddWithValue("@correo_usuario", correo);
                comando.Parameters.AddWithValue("@password_usuario", contrasena);

                int filasAfectadas = comando.ExecuteNonQuery(); //Ejecutamos la orden

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar procedimiento: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
    }//Fin de clase cls usuio
} //Fin de namespace

