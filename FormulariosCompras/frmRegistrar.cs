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
            clsCompras.llenarComboProducto(cmbProducto,ObjConexion);
            clsCompras.llenarComboProveedor(cmbProveedor, ObjConexion);
            clsCompras.llenarComboFormaPago(cmbFormaPago, ObjConexion);
            txtPrecio.Clear();
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
            cmbProveedor.SelectedIndex = -1;
            txtDireccion.Clear();
            cmbProducto.SelectedIndex = -1;
            cmbFormaPago.SelectedIndex = -1;
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            txtSubtotal.Clear();
            txtImpuesto.Clear();
            txtTotal.Clear();
            lstProductos.Items.Clear();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedIndex == -1 || cmbProducto.SelectedIndex == -1 ||
            cmbFormaPago.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtCantidad.Text) ||
            string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ObjCompras.setProveedor(Convert.ToInt32(cmbProveedor.SelectedValue));
            ObjCompras.setProducto(Convert.ToInt32(cmbProducto.SelectedValue));
            ObjCompras.setFormaPago(Convert.ToInt32(cmbFormaPago.SelectedValue));
            ObjCompras.setCantidad(Convert.ToInt32(txtCantidad.Text.Trim()));
            ObjCompras.setPrecio(Convert.ToDecimal(txtPrecio.Text.Trim()));
       

            bool registrado = ObjCompras.insertarCompras(ObjConexion, idEstado: 1, idUsuario: usuarioIdActual);

            if (registrado)
            {
                MessageBox.Show("¡Compra registrada correctamente!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos
                cmbProveedor.SelectedIndex = -1;
                cmbProducto.SelectedIndex = -1;
                cmbFormaPago.SelectedIndex = -1;
                txtCantidad.Clear();
                txtPrecio.Clear();
                txtDescripcion.Clear();
            }
            else
            {
                MessageBox.Show("Error al registrar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
