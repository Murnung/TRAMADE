using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.ClasesCompras;

namespace TRAMADE
{
    public partial class frmActualizar : Form
    {
        public frmActualizar()
        {
            InitializeComponent();
        }
        clsConexion ObjConexion = new clsConexion();
        clsOperacionesCompra ObjOp = new clsOperacionesCompra();
        int compraIdSeleccionado = 0;
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtbBuscar.Text.Trim();
            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Ingrese el id de la solicitud de compra");
                return;
            }

            try
            {
                ObjConexion.Abrir();
                string consulta = "SELECT * FROM VistaBuscarCompra WHERE id_compra = @busqueda";
                SqlCommand cmd = new SqlCommand(consulta, ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@busqueda", busqueda);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    compraIdSeleccionado = Convert.ToInt32(reader["id_compra"]);

                    cmbProveedor.SelectedValue = reader["id_proveedor"];
                    cmbFormaPago.SelectedValue = reader["id_forma_pago"];

                    if (reader["fecha_entrega"] != DBNull.Value)
                        dtEntrega.Value = Convert.ToDateTime(reader["fecha_entrega"]);


                    dtEntrega.Enabled = true;
                    cmbProveedor.Enabled = true;
                    cmbProducto.Enabled = true;
                    cmbFormaPago.Enabled = true;
                    nudCantidad.Enabled = true;

                    reader.Close();

                    ObjConexion.Cerrar();

                    // Cargar productos al ListBox
                    ObjOp.cargarProductosPorCompra(compraIdSeleccionado, ObjConexion);

                    txtTotal.Text = ObjOp.TotalLista().ToString("0.00");
                }
                else
                {
                    reader.Close();
                    compraIdSeleccionado = 0;
                    MessageBox.Show("Solicitud de compra no encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                if (ObjConexion.SqlC.State == System.Data.ConnectionState.Open)
                    ObjConexion.Cerrar();
            }


        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {
            clsLlenarComboProveedor.llenarComboProveedor(cmbProveedor, ObjConexion);
            clsLlenarComboProducto.llenarComboProducto(cmbProducto, ObjConexion);
            clsLlenarComboFormaPago.llenarComboFormaPago(cmbFormaPago, ObjConexion);

            cmbProveedor.Enabled = false;
            cmbProducto.Enabled = false;
            cmbFormaPago.Enabled = false;

            txtPrecio.Enabled = false;
            txtSubtotal.Enabled = false;
            txtImpuesto.Enabled = false;
            txtTotal.Enabled = false;

            dtEntrega.Enabled = false;
            nudCantidad.Enabled = false;

         

            btnLimpiar_Click(sender, e);
            ObjOp.vincularListBox(lstProductos);

        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedIndex != -1 && cmbProveedor.SelectedItem is DataRowView) //Verifica con selectedIndex que se este seleccionando algo y "is DataRowView": Revisa que lo que seleccionaste sea una fila de datos real y no un simple texto.
            {
                DataRowView drv = (DataRowView)cmbProveedor.SelectedItem; //Toma todo el renglón que el usuario eligió (ID y Nombre) y lo guarda en una variable llamada drv para que podamos revisarlo 
                int proveedorId = Convert.ToInt32(drv["id_proveedor"]); //Busca en la fila la columna que se llama id_rol, toma el número (como el 1, 2 o 3) y lo guarda en la variable rolId. Este número es el que le importa a la base de datos.
                string proveedorNombre = drv["nombre_comercial_proveedor"].ToString();// Busca en la misma fila la columna descripcion_rol, toma el texto(como "Administrador" o "Vendedor") y lo guarda en rolNombre para saber qué eligió el usuario.
            }

        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex == -1) return;

            DataRow fila = ObjOp.obtenerFila(lstProductos.SelectedIndex);

            // Mostrar los datos del producto seleccionado
            decimal precio = Convert.ToDecimal(fila["precioCosto"]);
            int cantidadSel = Convert.ToInt32(fila["cantidad"]);

            // Setear en la clase para usar los calculos
            ObjOp.setPrecio(precio);
            ObjOp.setCantidad(cantidadSel);
            //Mostrar precio y cantidad
            txtPrecio.Text = ObjOp.getPrecio().ToString();
            nudCantidad.Value = Convert.ToInt32(ObjOp.getCantidad());
            // Mostrar calculos
            txtSubtotal.Text = ObjOp.Subtotal().ToString("0.00");
            txtImpuesto.Text = ObjOp.Impuesto().ToString("0.00");

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            
            ObjOp.eliminarProducto(lstProductos);
            txtTotal.Text = ObjOp.TotalLista().ToString("0.00");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRowView drv = (DataRowView)cmbProducto.SelectedItem;

            ObjOp.setProducto(Convert.ToInt32(cmbProducto.SelectedValue));
            ObjOp.setNombreProducto(drv["nombre_producto"].ToString());
            ObjOp.setCantidad(Convert.ToInt32(nudCantidad.Value));

            decimal precio = 0;
            decimal.TryParse(txtPrecio.Text, out precio);
            ObjOp.setPrecio(precio);

            ObjOp.agregarProducto();

            txtTotal.Text = ObjOp.TotalLista().ToString("0.00");

            btnActualizar.Enabled = true;
            nudCantidad.Value = 1;
        }



        private void calcularTotales()
        {
            decimal precio = 0;
            decimal.TryParse(txtPrecio.Text, out precio);
            ObjOp.setCantidad((int)nudCantidad.Value);
            ObjOp.setPrecio(precio);

            txtSubtotal.Text = ObjOp.Subtotal().ToString("0.00");
            txtImpuesto.Text = ObjOp.Impuesto().ToString("0.00");
            txtTotal.Text = ObjOp.Total().ToString("0.00");
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            calcularTotales();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbBuscar.Clear();
            dtEntrega.Value = DateTime.Now;
            cmbProducto.SelectedIndex = -1;
            cmbFormaPago.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            txtSubtotal.Clear();
            txtImpuesto.Clear();
            txtTotal.Clear();
            ObjOp.limpiarLista();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

           if (compraIdSeleccionado == 0)
            {
                MessageBox.Show("Ingrese una solicitud de compra primero","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (lstProductos.Items.Count == 0)
            {
                MessageBox.Show("Debe de existir al menos un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Asignación de datos
                ObjOp.setIdCompra(compraIdSeleccionado);
                ObjOp.setIdUsuario(clsSesion.id_usuario);
                ObjOp.setProveedor(Convert.ToInt32(cmbProveedor.SelectedValue));
                ObjOp.setFormaPago(Convert.ToInt32(cmbFormaPago.SelectedValue));
                ObjOp.setCantidad(Convert.ToInt32(nudCantidad.Value));
                ObjOp.setEntrega(dtEntrega.Value);
                

                bool resultadoFinal = ObjOp.actualizarCompra(ObjConexion);

                if (resultadoFinal)
                {
                    MessageBox.Show("¡COMPRA ACTUALIZADA EXITOSAMENTE!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpiar_Click(sender, e);
                }
                else
                {
                    // Si entra aquí, insertarCompras devolvió 'false'
                    MessageBox.Show("La compra no pudo ser actualizada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el formulario: " + ex.Message);
            }
            btnLimpiar_Click(sender, e);

        }
    }
}
