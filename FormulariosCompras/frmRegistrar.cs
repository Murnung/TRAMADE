using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.ClasesCompras;
namespace TRAMADE
{
    public partial class frmRegistrar : Form
    {
        clsConexion ObjConexion = new clsConexion();
        clsOperacionesCompra ObjOp = new clsOperacionesCompra();

        Timer timerProveedor = new Timer() { Interval = 100 };
        Timer timerProducto = new Timer() { Interval = 100 };
        public frmRegistrar()
        {
            InitializeComponent();
            timerProveedor.Tick += (s, ev) =>
            {
                timerProveedor.Stop();
                if (cmbProveedor.Items.Count > 0)
                {
                    cmbProveedor.DroppedDown = true;
                    Cursor.Current = Cursors.Default;
                }
            };

            timerProducto.Tick += (s, ev) =>
            {
                timerProducto.Stop();
                if (cmbProducto.Items.Count > 0)
                {
                    cmbProducto.DroppedDown = true;
                    Cursor.Current = Cursors.Default;
                }
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
        
            cmbProveedor.SelectedIndex = -1;
            clsLlenarComboProducto.llenarComboProducto(cmbProducto,ObjConexion);
            clsLlenarComboProveedor.llenarComboProveedor(cmbProveedor, ObjConexion);
            clsLlenarComboFormaPago.llenarComboFormaPago(cmbFormaPago, ObjConexion);
            btnLimpiar_Click(sender, e);
            ObjOp.vincularListBox(lstProductos); // Vincular lista al ListBox
            


        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            if (!clsValidar.ComboSeleccionadoConIndiceMenorCero(cmbProducto.SelectedIndex, "Producto")) return;

            if (cmbProducto.SelectedIndex == -1 && cmbProducto.Items.Count > 0)
                cmbProducto.SelectedIndex = 0;

            if (cmbProducto.SelectedItem == null) return;



            DataRowView drv = (DataRowView)cmbProducto.SelectedItem;

            ObjOp.setProducto(Convert.ToInt32(drv["id_producto"]));
            ObjOp.setNombreProducto(drv["nombre_producto"].ToString());
            ObjOp.setCantidad(Convert.ToInt32(nudCantidad.Value));

            decimal precio = 0;
            decimal.TryParse(txtPrecio.Text, out precio);
            ObjOp.setPrecio(precio);

            ObjOp.agregarProducto();

            txtTotal.Text = ObjOp.TotalLista().ToString("0.00");

            nudCantidad.Value = 1;
            cmbProducto.SelectedIndex = -1;
            cmbProducto.Text = "";

        }

     
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex != -1 && cmbProducto.SelectedItem is DataRowView) //Verifica con selectedIndex que se este seleccionando algo y "is DataRowView": Revisa que lo que seleccionaste sea una fila de datos real y no un simple texto.
            {
             
                DataRowView drv = (DataRowView)cmbProducto.SelectedItem;
                int productoId = Convert.ToInt32(drv["id_producto"]); 
                string productoNombre = drv["nombre_producto"].ToString();
                clsLlenarTextoPrecioCosto.llenarTextoPrecio(txtPrecio, cmbProducto, ObjConexion);

                calcularTotales();
            }

        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedIndex != -1 && cmbProveedor.SelectedItem is DataRowView) //Verifica con selectedIndex que se este seleccionando algo y "is DataRowView": Revisa que lo que seleccionaste sea una fila de datos real y no un simple texto.
            {
                DataRowView drv = (DataRowView)cmbProveedor.SelectedItem;
                int proveedorlId = Convert.ToInt32(drv["id_proveedor"]);
                string proveedorNombre = drv["nombre_comercial_proveedor"].ToString();
            }
        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFormaPago.SelectedIndex != -1 && cmbFormaPago.SelectedItem is DataRowView)
            {
                DataRowView drv = (DataRowView)cmbFormaPago.SelectedItem;
                int formaPagoID = Convert.ToInt32(drv["id_forma_pago"]);
                string nombreFormaPago = drv["descripcion_forma_pago"].ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
        
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Si perdió la selección buscarla
            if (cmbProveedor.SelectedIndex == -1 && cmbProveedor.Items.Count > 0)
                cmbProveedor.SelectedIndex = 0;

            // Validaciones
            if (!clsValidar.ValidarCompras(cmbProveedor, cmbFormaPago)) return;
            if (!clsValidar.FechaEntrega(dtEntrega.Value)) return;
            if (!clsValidar.ListBoxConElementos(lstProductos, "producto")) return;
            if (!clsValidar.validarComboSinResultado(cmbProveedor, "proveedor")) return;


            try
            {
                // Asignación de datos
                ObjOp.setIdUsuario(clsSesion.id_usuario);
                ObjOp.setProveedor(Convert.ToInt32(cmbProveedor.SelectedValue));
                ObjOp.setFormaPago(Convert.ToInt32(cmbFormaPago.SelectedValue));
                ObjOp.setCantidad(Convert.ToInt32(nudCantidad.Value));
                ObjOp.setEntrega(dtEntrega.Value);
                

                bool resultadoFinal = ObjOp.insertarCompras(ObjConexion);

                if (resultadoFinal)
                {
                    MessageBox.Show("¡COMPRA REGISTRADA EXITOSAMENTE!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // btnLimpiar_Click(sender, e);
                }
                else
                {
                    // Si entra aquí, insertarCompras devolvió 'false'
                    MessageBox.Show("La compra no pudo ser registrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el formulario: " + ex.Message);
            }
            btnLimpiar_Click(sender, e);
       
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

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (!clsValidar.ListBoxConElementos(lstProductos,"producto")) return;
            ObjOp.eliminarProducto(lstProductos);
            txtTotal.Text = ObjOp.TotalLista().ToString("0.00");
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
        bool buscando = false;

        private void cmbProveedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up ||
           e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape) return;

            if (buscando) return;
            buscando = true;

            try
            {
                string texto = cmbProveedor.Text;
                clsLlenarComboProveedor.llenarComboProveedor(cmbProveedor, ObjConexion, texto);

                if (!string.IsNullOrWhiteSpace(texto))
                    timerProveedor.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                buscando = false;
            }
        }

        private void cmbProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                try
                {
                    string texto = cmbProveedor.Text ?? "";
                    int cursor = cmbProveedor.SelectionStart;

                    if (texto.Length > 0 && cursor > 0 && cursor <= texto.Length && texto[cursor - 1] == ' ')
                        e.SuppressKeyPress = true;
                }
                catch { }
            }

        }

        private void cmbProducto_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up ||
            e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape) return;

            if (buscando) return;
            buscando = true;

            try
            {
                string texto = cmbProducto.Text;
                clsLlenarComboProducto.llenarComboProducto(cmbProducto, ObjConexion, texto);

                if (!string.IsNullOrWhiteSpace(texto))
                    timerProducto.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                buscando = false;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                try
                {
                    string texto = cmbProducto.Text ?? "";
                    int cursor = cmbProducto.SelectionStart;

                    if (texto.Length > 0 && cursor > 0 && cursor <= texto.Length && texto[cursor - 1] == ' ')
                        e.SuppressKeyPress = true;
                }
                catch { }
            }
        }

        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
