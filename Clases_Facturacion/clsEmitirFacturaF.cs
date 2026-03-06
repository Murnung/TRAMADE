using System;
using System.Data;
using System.Data.SqlClient;

namespace TRAMADE
{
    public class clsEmitirFacturaF
    {
        // Propiedades para los datos generales de la factura
        public int numero_factura { get; set; }
        public string dni_rtn_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string direccion_cliente { get; set; }
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public DateTime fecha_emision { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public decimal subtotal { get; set; }
        public decimal impuesto { get; set; }
        public decimal total { get; set; }
        public int id_forma_pago { get; set; }

        // 1. MÉTODO PARA TRAER LOS DATOS GENERALES
        public bool CargarMaestro(int idFactura)
        {
            bool encontrado = false;
            clsConexion conexion = new clsConexion();
            conexion.Abrir();

            try
            {
                string queryMaestro = @"SELECT F.numero_factura, F.fecha_emision, F.fecha_vencimiento, 
                                               F.subtotal, F.impuesto, F.total, F.id_forma_pago,
                                               C.nombre_cliente, C.rtn_cliente, C.dni_cliente, C.direccion_cliente,
                                               U.id_usuario, U.nombre_usuario
                                        FROM FACTURA F
                                        INNER JOIN CLIENTE C ON F.id_cliente = C.id_cliente
                                        INNER JOIN USUARIO U ON F.id_usuario = U.id_usuario
                                        WHERE F.id_factura = @id";

                SqlCommand cmd = new SqlCommand(queryMaestro, conexion.SqlC);
                cmd.Parameters.AddWithValue("@id", idFactura);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    numero_factura = Convert.ToInt32(dr["numero_factura"]);

                    // Lógica del DNI/RTN
                    dni_rtn_cliente = dr["rtn_cliente"].ToString();
                    if (string.IsNullOrEmpty(dni_rtn_cliente)) dni_rtn_cliente = dr["dni_cliente"].ToString();

                    nombre_cliente = dr["nombre_cliente"].ToString();
                    direccion_cliente = dr["direccion_cliente"].ToString();
                    id_usuario = Convert.ToInt32(dr["id_usuario"]);
                    nombre_usuario = dr["nombre_usuario"].ToString();
                    fecha_emision = Convert.ToDateTime(dr["fecha_emision"]);
                    fecha_vencimiento = Convert.ToDateTime(dr["fecha_vencimiento"]);
                    subtotal = Convert.ToDecimal(dr["subtotal"]);
                    impuesto = Convert.ToDecimal(dr["impuesto"]);
                    total = Convert.ToDecimal(dr["total"]);
                    id_forma_pago = Convert.ToInt32(dr["id_forma_pago"]);

                    encontrado = true;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar maestro de factura: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
            return encontrado;
        }

        // 2. MÉTODO PARA TRAER LA TABLA DE PRODUCTOS (Devuelve un DataTable)
        public DataTable CargarDetalles(int idFactura)
        {
            DataTable dt = new DataTable();
            clsConexion conexion = new clsConexion();
            conexion.Abrir();

            try
            {
                string queryDetalle = @"SELECT P.nombre_producto as Producto, 
                                               'Unidad' as Descripción, 
                                               FP.cantidad as Cantidad, 
                                               P.precio_unitario as [Precio Unitario], 
                                               (FP.cantidad * P.precio_unitario) as Subtotal
                                        FROM FACTURA_PRODUCTO FP
                                        INNER JOIN PRODUCTO P ON FP.id_producto = P.id_producto
                                        WHERE FP.id_factura = @id";

                SqlDataAdapter da = new SqlDataAdapter(queryDetalle, conexion.SqlC);
                da.SelectCommand.Parameters.AddWithValue("@id", idFactura);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar detalle de factura: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
            return dt;
        }
    }
}