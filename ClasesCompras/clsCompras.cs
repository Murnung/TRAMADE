using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace TRAMADE.ClasesCompras
{
    internal class clsCompras
    {
        private int cantidad, proveedor, producto, formaPago, estado = 7, idUsuario, idCompra;
        private DateTime entrega;
        private string contacto, direccion, telefono, nombreProducto;
        private decimal precioCosto;
        private bool autorizar = false;
        private const decimal IVA = 0.15m;

        //Constructor vacio
        public clsCompras()
        {
            
        }

        // Setters
        public void setProveedor(int valor) { proveedor = valor; }
        public void setProducto(int valor) { producto = valor; }
        public void setFormaPago(int valor) { formaPago = valor; }
        public void setCantidad(int valor) { cantidad = valor; }
        public void setContacto(string valor) { contacto = valor; }
        public void setDireccion(string valor) { direccion = valor; }
        public void setTelefono(string valor) { telefono = valor; }
        public void setNombreProducto(string valor) { nombreProducto = valor; }
        public void setPrecio(decimal valor) { precioCosto = valor; }
        public void setEntrega(DateTime valor) { entrega = valor; }
        public void setIdCompra(int valor) { idCompra = valor; }


        //Getters
        public int getProducto() { return producto; }
        public int getCantidad() { return cantidad; }
        public string getNombreProducto() { return nombreProducto; }
        public decimal getPrecio() { return precioCosto; }
        public decimal getIVA() { return IVA; }
        public int getProveedor() { return proveedor; }
        public int getFormaPago() { return formaPago; }
        public int getEstado() { return estado; }
        public int getIdUsuario() { return idUsuario; }
        public int getIdCompra() { return idCompra; }
        public DateTime getEntrega() { return entrega; }
        public string getContacto() { return contacto; }
        public string getDireccion() { return direccion; }
        public string getTelefono() { return telefono; }
        public bool getAutorizar() { return autorizar; }
        //Calculos 
        public void setIdUsuario(int valor) { idUsuario = valor; }
        public decimal Subtotal() { return cantidad * precioCosto; }
        public decimal Impuesto() { return Subtotal() * IVA; }
        public decimal Total() { return Subtotal() * (1 + IVA); }
       
        
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
        
        
        //Filtrar por fechas
        public DataTable FiltrarCompras(clsConexion conexion, KryptonDateTimePicker desde, KryptonDateTimePicker hasta, string textoBuscar)
        {
            try
            {
                conexion.Abrir();

                string consulta = "SELECT * FROM VistaComprasTabla WHERE [Fecha pedido] >= @desde AND [Fecha pedido] <= @hasta";

                int id = 0;
                bool filtrarPorId = int.TryParse(textoBuscar.Trim(), out id);

                if (filtrarPorId)
                {
                    consulta += " AND [ID compra] = @id";
                }

                using (SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC))
                {
                    cmd.Parameters.AddWithValue("@desde", desde.Value.Date);
                    cmd.Parameters.AddWithValue("@hasta", hasta.Value.Date.AddDays(1).AddSeconds(-1));

                    if (filtrarPorId)
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar compras: " + ex.Message);
                return null;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        //Buscar por id de compra
        public DataTable BuscarCompra(clsConexion conexion, string textoBuscar)
        {
            try
            {
                conexion.Abrir();

                string consulta = "SELECT * FROM VistaComprasTabla";

                int id = 0;
                bool filtrarPorId = int.TryParse(textoBuscar.Trim(), out id);

                if (filtrarPorId)
                {
                    consulta += " WHERE [ID compra] = @id";
                }

                using (SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC))
                {
                    if (filtrarPorId)
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar compra: " + ex.Message);
                return null;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
    }
}
    