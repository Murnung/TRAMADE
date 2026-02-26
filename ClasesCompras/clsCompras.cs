using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TRAMADE.ClasesCompras
{
    internal class clsCompras
    {
        private int cantidad, proveedor, producto, formaPago, estado = 7, idUsuario;
        private DateTime entrega;
        private string contacto, direccion;
        private decimal precioCosto;
        private bool autorizar = false;


        //Constructor vacio
        public clsCompras()
        {

        }


        // Setters
        public void setProveedor(int valor)
        {
            proveedor = valor;
        }

        public void setProducto(int valor)
        {
            producto = valor;
        }

        public void setFormaPago(int valor)
        {
            formaPago = valor;
        }

        public void setCantidad(int valor)
        {
            cantidad = valor;
        }
        public void setContacto(string valor)
        {
            contacto = valor;
        }

        public void setDireccion(string valor)
        {
            direccion = valor;
        }

        public void setPrecio(decimal valor)
        {
            precioCosto = valor;
        }

        public void setEntrega(DateTime valor)
        {
            entrega = valor;
        }

        public void setIdUsuario(int valor)
        {
            idUsuario = valor;
        }

        //Metodo para calcular subtotal
        public decimal subtotal()
        {
            return cantidad * precioCosto;
        }


        //Metodo para calcular el impuesto
        public decimal impuesto()
        {
            return subtotal() * 0.15m;
        }

        //Metodo para calcular el total a pagar
        public decimal total()
        {
            return subtotal() + impuesto();
        }

        //Metodo para llenar combo box de producto 
        public static void llenarComboProducto(Krypton.Toolkit.KryptonComboBox cmb, clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                string consulta = "SELECT id_producto, nombre_producto FROM VistaProducto";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                cmb.DataSource = dt;
                cmb.DisplayMember = "nombre_producto";
                cmb.ValueMember = "id_producto";
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

        public static void llenarComboProveedor(Krypton.Toolkit.KryptonComboBox cmb, clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                string consulta = "SELECT * FROM VistaProveedor";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmb.DataSource = dt;
                cmb.DisplayMember = "nombre_comercial_proveedor";
                cmb.ValueMember = "id_proveedor";
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

        public static void llenarComboFormaPago(Krypton.Toolkit.KryptonComboBox cmb, clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                string consulta = "SELECT * FROM VistaFormaPago";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmb.DataSource = dt;
                cmb.DisplayMember = "descripcion_forma_pago";
                cmb.ValueMember = "id_forma_pago";

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


        public static void llenarTextoPrecio(KryptonTextBox txt, KryptonComboBox cmb, clsConexion conexion)
        {
            try
            {
                if (cmb.SelectedValue == null) return;

                conexion.Abrir();
                DataRowView drv = (DataRowView)cmb.SelectedItem; //Toma lo que el usuario seleccionó en el ComboBox y lo convierte en un DataRowView para poder leer sus columnas como drv["id_producto"]
                int idProducto = Convert.ToInt32(drv["id_producto"]);
                string consulta = "SELECT precio_costo FROM VistaProducto WHERE id_producto = @id";
                SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC);//Crea el comando SQL usando la consulta definida y la conexión abierta, es el objeto que ejecutará la consulta.
                cmd.Parameters.AddWithValue("@id", idProducto); //Reemplaza el @id de la consulta con el número real del producto seleccionado. Esto evita inyección SQL.
                object resultado = cmd.ExecuteScalar(); //Ejecuta la consulta y guarda el resultado en resultado. Se usa ExecuteScalar porque solo esperamos un único valor, el precio.

                if (resultado != null && resultado != DBNull.Value)
                    txt.Text = resultado.ToString(); //Si encontró un precio válido en la base de datos, lo convierte a texto y lo muestra en el TextBox.
                else
                    txt.Text = "0"; //Si no encontró precio o vino vacío, muestra 0 por defecto.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar precio: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public bool insertarCompras(clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                // 1. INSERTAR CABECERA Y OBTENER ID
                SqlCommand cmdCabecera = new SqlCommand("PA_INSERTAR_COMPRA", conexion.SqlC);
                cmdCabecera.CommandType = CommandType.StoredProcedure;

                cmdCabecera.Parameters.AddWithValue("@id_proveedor", proveedor);
                cmdCabecera.Parameters.AddWithValue("@id_forma_pago", formaPago);
                cmdCabecera.Parameters.AddWithValue("@id_estado", estado);
                cmdCabecera.Parameters.AddWithValue("@id_usuario", idUsuario);

                // Manejo de fecha nula por si el DateTimePicker no tiene fecha
                if (entrega == DateTime.MinValue)
                    cmdCabecera.Parameters.AddWithValue("@fecha_entrega", DBNull.Value);
                else
                    cmdCabecera.Parameters.AddWithValue("@fecha_entrega", entrega);

                // ExecuteScalar() ejecuta la consulta , toma solo el primer valor devuelto, en este caso select SCOPE_IDENTITY(), el cual devuelve el id de compra generado
                object resultado = cmdCabecera.ExecuteScalar();
                
                if (resultado != null) //Verific que SP si devolvio un ID
                {
                    int idGenerado = Convert.ToInt32(resultado); //Convierte el Object a entero
                    
                    // INSERTAR DETALLE
                    SqlCommand cmdDetalle = new SqlCommand("PA_INSERTAR_DETALLE_COMPRA", conexion.SqlC);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    cmdDetalle.Parameters.AddWithValue("@id_compra", idGenerado);
                    cmdDetalle.Parameters.AddWithValue("@id_producto", producto);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                    // Nota: Segun tu ultimo ALTER PROCEDURE, ya no pides precio_unitario en el detalle

                    int filasDetalle = cmdDetalle.ExecuteNonQuery();
                    return filasDetalle > 0;
                }
                
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
    }
}
    