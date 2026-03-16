using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TRAMADE
{
    // Una clase pequeñita para guardar cada producto que agregues
    public class clsDetalleFactura
    {
        public int id_producto { get; set; }
        public decimal cantidad { get; set; }
    }

    public class clsFacturaF
    {
        public int numero_factura { get; set; }
        public int id_usuario { get; set; }
        public int id_forma_pago { get; set; }
        public int id_cliente { get; set; }
        public DateTime fecha_emision { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public decimal subtotal { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }

        // Esta lista guardará cada producto que el usuario agregue a la factura, con su cantidad
        public List<clsDetalleFactura> Detalles { get; set; } = new List<clsDetalleFactura>();

        // Método que obtiene el siguiente número de factura
        public int ObtenerSiguienteNumeroFactura()
        {
            int siguiente = 1;
            clsConexion conexion = new clsConexion();
            conexion.Abrir();
            try
            {
                // Busca el número máximo. Si no hay nada (ISNULL), toma 0. Y le suma 1.
                string query = "SELECT ISNULL(MAX(numero_factura), 0) + 1 FROM FACTURA";
                SqlCommand cmd = new SqlCommand(query, conexion.SqlC);
                siguiente = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el número de factura: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
            return siguiente;
        }

        // Método que guarda TODO en SQL
        public int GuardarFacturaTransaccion()
        {
            int idFacturaGenerado = 0;
            clsConexion objConexion = new clsConexion();
            objConexion.Abrir();

            SqlTransaction transaccion = null;

            try
            {
                transaccion = objConexion.SqlC.BeginTransaction();

                // Inserta todo a la factura
                string queryFactura = @"INSERT INTO FACTURA 
                                      (numero_factura, id_usuario, id_forma_pago, id_cliente, 
                                       fecha_emision, fecha_vencimiento, subtotal, impuesto, total, id_tipo_factura) 
                                      VALUES 
                                      (@num, @user, @pago, @cliente, 
                                       @emision, @vence, @sub, @imp, @tot, 1);
                                      SELECT SCOPE_IDENTITY();";

                SqlCommand cmdFactura = new SqlCommand(queryFactura, objConexion.SqlC, transaccion);
                cmdFactura.Parameters.AddWithValue("@num", numero_factura);
                cmdFactura.Parameters.AddWithValue("@user", id_usuario);
                cmdFactura.Parameters.AddWithValue("@pago", id_forma_pago);
                cmdFactura.Parameters.AddWithValue("@cliente", id_cliente);
                cmdFactura.Parameters.AddWithValue("@emision", fecha_emision);
                cmdFactura.Parameters.AddWithValue("@vence", fecha_vencimiento);
                cmdFactura.Parameters.AddWithValue("@sub", subtotal);
                cmdFactura.Parameters.AddWithValue("@imp", impuesto);
                cmdFactura.Parameters.AddWithValue("@tot", total);

                idFacturaGenerado = Convert.ToInt32(cmdFactura.ExecuteScalar());

                // 2. INSERTAR LOS PRODUCTOS Y DESCONTAR INVENTARIO (Detalle)
                foreach (var detalle in Detalles)
                {
                    // A) Insertamos en FACTURA_PRODUCTO
                    string queryDetalle = @"INSERT INTO FACTURA_PRODUCTO 
                                          (id_factura, id_producto, cantidad) 
                                          VALUES (@idFac, @idProd, @cant)";

                    SqlCommand cmdDetalle = new SqlCommand(queryDetalle, objConexion.SqlC, transaccion);
                    cmdDetalle.Parameters.AddWithValue("@idFac", idFacturaGenerado);
                    cmdDetalle.Parameters.AddWithValue("@idProd", detalle.id_producto);
                    cmdDetalle.Parameters.AddWithValue("@cant", detalle.cantidad);
                    cmdDetalle.ExecuteNonQuery();

                    string queryDescuento = @"UPDATE PRODUCTO_SUCURSAL 
                                              SET cantidad_stock = cantidad_stock - @cantVendida 
                                              WHERE id_producto = @idProdDesc";

                    SqlCommand cmdDescuento = new SqlCommand(queryDescuento, objConexion.SqlC, transaccion);
                    cmdDescuento.Parameters.AddWithValue("@cantVendida", detalle.cantidad);
                    cmdDescuento.Parameters.AddWithValue("@idProdDesc", detalle.id_producto);
                    cmdDescuento.ExecuteNonQuery();
                }

                // 3. Confirmamos los cambios en la BD
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                if (transaccion != null)
                {
                    transaccion.Rollback();
                }
                throw new Exception("Error al guardar factura y descontar stock: " + ex.Message);
            }
            finally
            {
                objConexion.Cerrar();
            }

            return idFacturaGenerado;
        }
    }
}
