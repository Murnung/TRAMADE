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

        // Lista interna de productos
        private DataTable listaProductos = new DataTable();
        //Constructor vacio
        public clsCompras()
        {
            //Incializar las columnas en el constructor
            listaProductos.Columns.Add("idProducto", typeof(int));
            listaProductos.Columns.Add("nombreProducto", typeof(string));
            listaProductos.Columns.Add("cantidad", typeof(int));
            listaProductos.Columns.Add("precioCosto", typeof(decimal));

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
        public int getCantidad() { return cantidad; }
        public decimal getPrecio() { return precioCosto; }
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

        // Vincular la lista al listbox
        public void vincularListBox(KryptonListBox lst)
        {
            lst.DataSource = listaProductos;
            lst.DisplayMember = "nombreProducto";
        }


        // Agregar un products a la lista
        public void agregarProducto()
        {
            // Validar que no se agregue el mismo producto dos veces
            bool existe = false;
            foreach (DataRow fila in listaProductos.Rows)
            {
                if (Convert.ToInt32(fila["idProducto"]) == producto)
                {
                    existe = true;
                    break;
                }
            }

            if (existe)
            {
                MessageBox.Show("Este producto ya fue agregado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow nuevaFila = listaProductos.NewRow();
            nuevaFila["idProducto"] = producto;
            nuevaFila["nombreProducto"] = nombreProducto;
            nuevaFila["cantidad"] = cantidad;
            nuevaFila["precioCosto"] = precioCosto;

            listaProductos.Rows.Add(nuevaFila); // El ListBox se actualiza automaticamente
        }


        // Eliminar producto seleccinado
        public void eliminarProducto(KryptonListBox lst)
        {
            if (lst.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listaProductos.Rows[lst.SelectedIndex].Delete();
            listaProductos.AcceptChanges();
        }

        // Total de la lista
        public decimal TotalLista()
        {
            decimal total = 0;
            foreach (DataRow fila in listaProductos.Rows)
            {
                decimal subtotal = Convert.ToInt32(fila["cantidad"]) * Convert.ToDecimal(fila["precioCosto"]);
                total += subtotal * (1 + IVA);
            }
            return total;
        }

        //Metodo para limpiar la lista
        public void limpiarLista()
        {
            listaProductos.Clear();
        }

        //Metodo pra obtener la fila 
        public DataRow obtenerFila(int indice)
        {
            return listaProductos.Rows[indice];
        }

        public bool insertarCompras(clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                //INSERTAR COMPRA
                SqlCommand cmdCompra = new SqlCommand("PA_INSERTAR_COMPRA", conexion.SqlC);
                cmdCompra.CommandType = CommandType.StoredProcedure;

                cmdCompra.Parameters.AddWithValue("@id_proveedor", proveedor);
                cmdCompra.Parameters.AddWithValue("@id_forma_pago", formaPago);
                cmdCompra.Parameters.AddWithValue("@id_estado", estado);
                cmdCompra.Parameters.AddWithValue("@id_usuario", idUsuario);

                // Manejo de fecha nula por si el DateTimePicker no tiene fecha
                if (entrega == DateTime.MinValue)
                    cmdCompra.Parameters.AddWithValue("@fecha_entrega", DBNull.Value);
                else
                    cmdCompra.Parameters.AddWithValue("@fecha_entrega", entrega);

                cmdCompra.Parameters.AddWithValue("@direccion_entrega", direccion);
                cmdCompra.Parameters.AddWithValue("@contacto_entrega", contacto);
                cmdCompra.Parameters.AddWithValue("@telefono_entrega", telefono);


                // ExecuteScalar() ejecuta la consulta , toma solo el primer valor devuelto, en este caso select SCOPE_IDENTITY(), el cual devuelve el id de compra generado
                object resultado = cmdCompra.ExecuteScalar();

                if (resultado != null) //Verific que SP si devolvio un ID
                {
                    int idGenerado = Convert.ToInt32(resultado); //Convierte el Object a entero

                    foreach (DataRow fila in listaProductos.Rows)
                    {
                        // INSERTAR DETALLE

                        int idProductoFila = Convert.ToInt32(fila["idProducto"]);
                        int cantidadFila = Convert.ToInt32(fila["cantidad"]);

                        SqlCommand cmdDetalle = new SqlCommand("PA_INSERTAR_DETALLE_COMPRA", conexion.SqlC);
                        cmdDetalle.CommandType = CommandType.StoredProcedure;
                        cmdDetalle.Parameters.AddWithValue("@id_compra", idGenerado);
                        cmdDetalle.Parameters.AddWithValue("@id_producto", idProductoFila);
                        cmdDetalle.Parameters.AddWithValue("@cantidad", cantidadFila);
                        cmdDetalle.ExecuteNonQuery();

                        //INSERTAR PRODUCTO_PROVEEDOR
                        if (proveedor != 0 && producto != 0)
                        {
                            // Verificar si ya existe la relacion producto_proveedor
                            string sqlVerificar = "SELECT COUNT(*) FROM Vista_Producto_Proveedor  WHERE id_producto = @id_producto AND id_proveedor = @id_proveedor";
                            SqlCommand cmdVerificar = new SqlCommand(sqlVerificar, conexion.SqlC);
                            cmdVerificar.Parameters.AddWithValue("@id_producto", idProductoFila);
                            cmdVerificar.Parameters.AddWithValue("@id_proveedor", proveedor);

                            int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                            if (existe == 0) // Solo inserta si no existe
                            {
                                SqlCommand cmdProductoProveedor = new SqlCommand("PA_INSERTAR_PRODUCTO_PROVEEDOR", conexion.SqlC);
                                cmdProductoProveedor.CommandType = CommandType.StoredProcedure;
                                cmdProductoProveedor.Parameters.AddWithValue("@id_producto", idProductoFila);
                                cmdProductoProveedor.Parameters.AddWithValue("@id_proveedor", proveedor);
                                cmdProductoProveedor.ExecuteNonQuery();
                            }
                        }
                    }
                    listaProductos.Clear();
                    return true;
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
        
        public bool actualizarCompra(clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                //ACTUALIZAR COMPRA 
                SqlCommand cmdCompras = new SqlCommand("PA_ACTUALIZAR_COMPRA", conexion.SqlC);
                cmdCompras.CommandType = CommandType.StoredProcedure;
                cmdCompras.Parameters.AddWithValue("@id_compra", idCompra);
                cmdCompras.Parameters.AddWithValue("@id_proveedor", proveedor);
                cmdCompras.Parameters.AddWithValue("@id_forma_pago", formaPago);
                cmdCompras.Parameters.AddWithValue("@id_estado", estado);
                cmdCompras.Parameters.AddWithValue("@id_usuario", idUsuario);

                // Manejo de fecha nula por si el DateTimePicker no tiene fecha
                if (entrega == DateTime.MinValue)
                    cmdCompras.Parameters.AddWithValue("@fecha_entrega", DBNull.Value);
                else
                    cmdCompras.Parameters.AddWithValue("@fecha_entrega", entrega);

                cmdCompras.Parameters.AddWithValue("@autorizada", autorizar);
                cmdCompras.Parameters.AddWithValue("@direccion_entrega", direccion);
                cmdCompras.Parameters.AddWithValue("@contacto_entrega", contacto);
                cmdCompras.Parameters.AddWithValue("@telefono_entrega", telefono);

                //Ejecuta la consulta, toma solo el primer valor devuelto, en este caso SCPE_IDENTITY(), el cual devuelve el id de compra generada
                object resultado = cmdCompras.ExecuteScalar();

                int filas = Convert.ToInt32(resultado);

                if (filas > 0) //Verifica que SP si devolvio un 
                {
                    //Eliminar detalles antiguos usando el SP
                    SqlCommand cmdEliminarDetalles = new SqlCommand("PA_ELIMINAR_DETALLE_COMPRA", conexion.SqlC);
                    cmdEliminarDetalles.CommandType = CommandType.StoredProcedure;
                    cmdEliminarDetalles.Parameters.AddWithValue("@id_compra", idCompra);
                    cmdEliminarDetalles.ExecuteNonQuery();
                    foreach (DataRow fila in listaProductos.Rows)
                    {
                        //ACUTALIZAR DETALLE COMPRA

                        int idProductoFila = Convert.ToInt32(fila["idProducto"]);
                        int cantidadFila = Convert.ToInt32(fila["cantidad"]);

                        SqlCommand cmdDetalle = new SqlCommand("PA_INSERTAR_DETALLE_COMPRA", conexion.SqlC);
                        cmdDetalle.CommandType = CommandType.StoredProcedure;
                        cmdDetalle.Parameters.AddWithValue("@id_compra", idCompra);
                        cmdDetalle.Parameters.AddWithValue("@id_producto", idProductoFila);
                        cmdDetalle.Parameters.AddWithValue("@cantidad", cantidadFila);
                        cmdDetalle.ExecuteNonQuery();

                        //ACTUALIZAR PRODUCTO_PROVEEDOR
                        if (proveedor != 0 && idProductoFila != 0)
                        {
                            // Verificar si ya existe la relacion producto_proveedor
                            string sqlVerificar = "SELECT COUNT(*) FROM Vista_Producto_Proveedor  WHERE id_producto = @id_producto AND id_proveedor = @id_proveedor";
                            SqlCommand cmdVerificar = new SqlCommand(sqlVerificar, conexion.SqlC);
                            cmdVerificar.Parameters.AddWithValue("@id_producto", idProductoFila);
                            cmdVerificar.Parameters.AddWithValue("@id_proveedor", proveedor);

                            int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                            if (existe == 0) // Solo inserta si no existe
                            {
                                SqlCommand cmdProductoProveedor = new SqlCommand("PA_ACTUALIZAR_PRODUCTO_PROVEEDOR", conexion.SqlC);
                                cmdProductoProveedor.CommandType = CommandType.StoredProcedure;
                                cmdProductoProveedor.Parameters.AddWithValue("@id_producto", idProductoFila);
                                cmdProductoProveedor.Parameters.AddWithValue("@id_proveedor", proveedor);
                                cmdProductoProveedor.ExecuteNonQuery();
                            }
                        }
                    }
                    listaProductos.Clear();
                    return true;
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

        public void cargarProductosPorCompra(int idCompra, clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                string consulta = "SELECT * FROM VistaBuscarCompra WHERE id_compra = @id_compra";
                SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC);
                cmd.Parameters.AddWithValue("@id_compra", idCompra);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                listaProductos.Clear();

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow fila in dt.Rows)
                {
                    DataRow nuevaFila = listaProductos.NewRow();
                    nuevaFila["idProducto"] = fila["id_producto"];
                    nuevaFila["nombreProducto"] = fila["nombre_producto"];
                    nuevaFila["cantidad"] = fila["cantidad"];
                    nuevaFila["precioCosto"] = fila["precio_costo"]; // Verifica el nombre exacto en tu vista

                    listaProductos.Rows.Add(nuevaFila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public bool autorizarCompra(clsConexion conexion, int idCompra)
        {
            try
            {
                conexion.Abrir();

                using (SqlCommand cmd = new SqlCommand("PA_AUTORIZAR_COMPRA", conexion.SqlC))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_compra", idCompra);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al autorizar la compra: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public bool denegarCompra(clsConexion conexion, int idCompra)
        {
            try
            {
                conexion.Abrir();

                using (SqlCommand cmd = new SqlCommand("PA_DENEGAR_COMPRA", conexion.SqlC))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id_compra", idCompra);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al denegar la compra: " + ex.Message);
                return false;
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
    