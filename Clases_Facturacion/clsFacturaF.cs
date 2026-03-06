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
        // Propiedades de la Factura Maestro
        public int numero_factura { get; set; }
        public int id_usuario { get; set; }
        public int id_forma_pago { get; set; }
        public int id_cliente { get; set; }
        public DateTime fecha_emision { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public decimal subtotal { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }

        // ¡EL TRUCO! Una lista que guardará todos los productos de esta factura
        public List<clsDetalleFactura> Detalles { get; set; } = new List<clsDetalleFactura>();

        // Método que guarda TODO en SQL
        public int GuardarFacturaTransaccion()
        {
            int idGenerado = 0;
            clsConexion conexion = new clsConexion();
            conexion.Abrir();
            SqlTransaction transaccion = conexion.SqlC.BeginTransaction();

            try
            {
                // 1. GUARDAR MAESTRO
                string qFactura = @"INSERT INTO FACTURA (numero_factura, id_usuario, id_forma_pago, id_cliente, id_estado, id_tipo_factura, fecha_emision, fecha_vencimiento, subtotal, impuesto, total) 
                                    VALUES (@num, @user, @pago, @cliente, 1, 1, @fechaE, @fechaV, @sub, @isv, @total); 
                                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmdF = new SqlCommand(qFactura, conexion.SqlC, transaccion);
                cmdF.Parameters.AddWithValue("@num", numero_factura);
                cmdF.Parameters.AddWithValue("@user", id_usuario);
                cmdF.Parameters.AddWithValue("@pago", id_forma_pago);
                cmdF.Parameters.AddWithValue("@cliente", id_cliente);
                cmdF.Parameters.AddWithValue("@fechaE", fecha_emision);
                cmdF.Parameters.AddWithValue("@fechaV", fecha_vencimiento);
                cmdF.Parameters.AddWithValue("@sub", subtotal);
                cmdF.Parameters.AddWithValue("@isv", impuesto);
                cmdF.Parameters.AddWithValue("@total", total);

                idGenerado = Convert.ToInt32(cmdF.ExecuteScalar());

                // 2. GUARDAR DETALLE
                foreach (var item in Detalles)
                {
                    string qDetalle = "INSERT INTO FACTURA_PRODUCTO (id_factura, id_producto, cantidad) VALUES (@id, @prod, @cant)";
                    SqlCommand cmdD = new SqlCommand(qDetalle, conexion.SqlC, transaccion);
                    cmdD.Parameters.AddWithValue("@id", idGenerado);
                    cmdD.Parameters.AddWithValue("@prod", item.id_producto);
                    cmdD.Parameters.AddWithValue("@cant", item.cantidad);
                    cmdD.ExecuteNonQuery();
                }

                // Si todo sale bien, confirmamos a la BD
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                throw new Exception("Error al guardar en BD: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }

            // Devolvemos el ID de la factura que se acaba de crear
            return idGenerado;
        }
    }
}