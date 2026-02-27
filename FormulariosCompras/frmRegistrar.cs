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
        clsCompras ObjCompras = new clsCompras();

     
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {
            cmbProveedor.SelectedIndex = -1;
            clsCompras.llenarComboProducto(cmbProducto,ObjConexion);
            clsCompras.llenarComboProveedor(cmbProveedor, ObjConexion);
            clsCompras.llenarComboFormaPago(cmbFormaPago, ObjConexion);
            btnLimpiar_Click(sender, e);
            ObjCompras.vincularListBox(lstProductos); // Vincular lista al ListBox
            btnAgregar.Enabled = true;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataRowView drv = (DataRowView)cmbProducto.SelectedItem;

            ObjCompras.setProducto(Convert.ToInt32(drv["id_producto"]));
            ObjCompras.setNombreProducto(drv["nombre_producto"].ToString());
            ObjCompras.setCantidad(Convert.ToInt32(nudCantidad.Value));

            decimal precio = 0;
            decimal.TryParse(txtPrecio.Text, out precio);
            ObjCompras.setPrecio(precio);

            ObjCompras.agregarProducto();

            txtTotal.Text = ObjCompras.TotalLista().ToString("0.00");

            btnAgregar.Enabled = true;
            

        }

        private void btnRegresar_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex != -1 && cmbProducto.SelectedItem is DataRowView) //Verifica con selectedIndex que se este seleccionando algo y "is DataRowView": Revisa que lo que seleccionaste sea una fila de datos real y no un simple texto.
            {
             
                DataRowView drv = (DataRowView)cmbProducto.SelectedItem;
                int productoId = Convert.ToInt32(drv["id_producto"]); 
                string productoNombre = drv["nombre_producto"].ToString();
                clsCompras.llenarTextoPrecio(txtPrecio, cmbProducto, ObjConexion);

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
            txtId.Clear();
            dtEntrega.Value = DateTime.Now;
            txtContacto.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            cmbProducto.SelectedIndex = -1;
            cmbFormaPago.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            txtSubtotal.Clear();
            txtImpuesto.Clear();
            txtTotal.Clear();
            ObjCompras.limpiarLista();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (cmbProveedor.SelectedValue == null || cmbProducto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un proveedor y un producto.");
                return;
            }

            if (cmbFormaPago.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una forma de pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Asignación de datos
                ObjCompras.setIdUsuario(clsSesion.id_usuario);
                ObjCompras.setProveedor(Convert.ToInt32(cmbProveedor.SelectedValue));
                ObjCompras.setFormaPago(Convert.ToInt32(cmbFormaPago.SelectedValue));
                ObjCompras.setCantidad(Convert.ToInt32(nudCantidad.Value));
                ObjCompras.setContacto(txtContacto.Text.Trim());
                ObjCompras.setDireccion(txtDireccion.Text.Trim());
                ObjCompras.setTelefono(txtTelefono.Text.Trim());
                ObjCompras.setEntrega(dtEntrega.Value);
                

                bool resultadoFinal = ObjCompras.insertarCompras(ObjConexion);

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
        }

        private void calcularTotales()
        {
            decimal precio = 0;
            decimal.TryParse(txtPrecio.Text, out precio);
            ObjCompras.setCantidad((int)nudCantidad.Value);
            ObjCompras.setPrecio(precio);

            txtSubtotal.Text = ObjCompras.Subtotal().ToString("0.00");
            txtImpuesto.Text = ObjCompras.Impuesto().ToString("0.00");
            txtTotal.Text = ObjCompras.Total().ToString("0.00");
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            calcularTotales();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            ObjCompras.eliminarProducto(lstProductos);
            txtTotal.Text = ObjCompras.TotalLista().ToString("0.00");
        }
    }
}
