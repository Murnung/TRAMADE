using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.ClasesCompras
{
    internal class clsOperacionesCompra:clsLlenarListBox
    {
        public clsOperacionesCompra() { }

        // INSERTAR 
        public bool insertarCompras(clsConexion conexion)
        {
            try
            {
                conexion.Abrir();

                SqlCommand cmdCompra = new SqlCommand("PA_INSERTAR_COMPRA", conexion.SqlC);
                cmdCompra.CommandType = CommandType.StoredProcedure;
                cmdCompra.Parameters.AddWithValue("@id_proveedor", getProveedor());
                cmdCompra.Parameters.AddWithValue("@id_forma_pago", getFormaPago());
                cmdCompra.Parameters.AddWithValue("@id_estado", getEstado());
                cmdCompra.Parameters.AddWithValue("@id_usuario", getIdUsuario());
                cmdCompra.Parameters.AddWithValue("@fecha_entrega",
                    getEntrega() == DateTime.MinValue ? (object)DBNull.Value : getEntrega());
         
                object resultado = cmdCompra.ExecuteScalar();
                if (resultado == null) return false;

                int idGenerado = Convert.ToInt32(resultado);
                InsertarDetallesYProveedor(conexion, idGenerado);

                limpiarLista(); // heredado de clsLlenarListBox
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico al insertar: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        // ACTUALIZAR 
        public bool actualizarCompra(clsConexion conexion)
        {
            try
            {
                
                    conexion.Abrir();

                    SqlCommand cmdCompra = new SqlCommand("PA_ACTUALIZAR_COMPRA", conexion.SqlC);
                    cmdCompra.CommandType = CommandType.StoredProcedure;
                    cmdCompra.Parameters.AddWithValue("@id_compra", getIdCompra());
                    cmdCompra.Parameters.AddWithValue("@id_proveedor", getProveedor());
                    cmdCompra.Parameters.AddWithValue("@id_forma_pago", getFormaPago());
                    cmdCompra.Parameters.AddWithValue("@id_usuario", getIdUsuario());
                    cmdCompra.Parameters.AddWithValue("@fecha_entrega",
                        getEntrega() == DateTime.MinValue ? (object)DBNull.Value : getEntrega());

                    object resultado = cmdCompra.ExecuteScalar();


                    if (Convert.ToInt32(resultado) <= 0) return false;

                    // Eliminar detalles antiguos y reinsertar
                    SqlCommand cmdEliminar = new SqlCommand("PA_ELIMINAR_DETALLE_COMPRA", conexion.SqlC);
                    cmdEliminar.CommandType = CommandType.StoredProcedure;
                    cmdEliminar.Parameters.AddWithValue("@id_compra", getIdCompra());
                    cmdEliminar.ExecuteNonQuery();

                    InsertarDetallesYProveedor(conexion, getIdCompra());

                    limpiarLista(); // heredado de clsLlenarListBox
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error crítico al actualizar: " + ex.Message);
                    return false;
                }
                finally
                {
                    conexion.Cerrar();
                }

            }

        // MÉTODO PRIVADO COMPARTIDO ENTRE INSERTAR Y ACTUALIZAR 
        private void InsertarDetallesYProveedor(clsConexion conexion, int idCompraParam)
        {
            foreach (DataRow fila in listaProductos.Rows) // listaProductos heredado de clsLlenarListBox
            {
                int idProductoFila = Convert.ToInt32(fila["idProducto"]);
                int cantidadFila = Convert.ToInt32(fila["cantidad"]);

                SqlCommand cmdDetalle = new SqlCommand("PA_INSERTAR_DETALLE_COMPRA", conexion.SqlC);
                cmdDetalle.CommandType = CommandType.StoredProcedure;
                cmdDetalle.Parameters.AddWithValue("@id_compra", idCompraParam);
                cmdDetalle.Parameters.AddWithValue("@id_producto", idProductoFila);
                cmdDetalle.Parameters.AddWithValue("@cantidad", cantidadFila);
                cmdDetalle.ExecuteNonQuery();

                if (getProveedor() != 0 && idProductoFila != 0)
                {
                    string sqlVerificar = @"SELECT COUNT(*) FROM Vista_Producto_Proveedor 
                                            WHERE id_producto  = @id_producto 
                                              AND id_proveedor = @id_proveedor";

                    SqlCommand cmdVerificar = new SqlCommand(sqlVerificar, conexion.SqlC);
                    cmdVerificar.Parameters.AddWithValue("@id_producto", idProductoFila);
                    cmdVerificar.Parameters.AddWithValue("@id_proveedor", getProveedor());

                    int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());
                    if (existe == 0)
                    {
                        SqlCommand cmdPP = new SqlCommand("PA_INSERTAR_PRODUCTO_PROVEEDOR", conexion.SqlC);
                        cmdPP.CommandType = CommandType.StoredProcedure;
                        cmdPP.Parameters.AddWithValue("@id_producto", idProductoFila);
                        cmdPP.Parameters.AddWithValue("@id_proveedor", getProveedor());
                        cmdPP.ExecuteNonQuery();
                    }
                }
            }
        }

        // METODO PARA CARGAR PRODUCTOS POR COMPRA
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
        //METODO PARA AUTORIZAR COMPRA
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

        //METODDO PARA DENEGAR COMPRA
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
    }
}
