using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE
{
    public partial class frmEmitirFactura : Form 
    {
        public int IdFacturaRecibido;

        public frmEmitirFactura() // Constructor
        {
            InitializeComponent();
        }

        private void frmEmitirFactura_Load(object sender, EventArgs e) // Evento Load del formulario
        {
            if (IdFacturaRecibido > 0)
            {
                CargarDatosFactura();
            }

            dgvEmitirFactura.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmitirFactura.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CargarDatosFactura()
        {
            try
            {
                // Se crea una instancia de la clase de negocio para cargar los datos
                clsEmitirFacturaF objFactura = new clsEmitirFacturaF();

                // Se cargan los datos maestros de la factura (Cliente, Vendedor, Fechas, Totales) 
                if (objFactura.CargarMaestro(IdFacturaRecibido))
                {
                    // Se asignan los datos a los controles del formulario
                    lblNumeroFacturaEF.Text = "INV/2026/" + objFactura.numero_factura.ToString("D4");

                    txtDNIClienteEF.Text = objFactura.dni_rtn_cliente;
                    txtNombreClienteEF.Text = objFactura.nombre_cliente;
                    txtDireccionClienteEF.Text = objFactura.direccion_cliente;

                    txtIDVendedorEF.Text = objFactura.id_usuario.ToString();
                    txtNombreVendedorEF.Text = objFactura.nombre_usuario;

                    lblFechaEmisionEF.Text = objFactura.fecha_emision.ToString("dd/MM/yyyy");
                    lblFechaVencimientoEF.Text = objFactura.fecha_vencimiento.ToString("dd/MM/yyyy");

                    lblSubtotalEF.Text = "L. " + objFactura.subtotal.ToString("N2");
                    lblImpuestoEF.Text = "L. " + objFactura.impuesto.ToString("N2");
                    lblTotalEF.Text = "L. " + objFactura.total.ToString("N2");

                    if (objFactura.id_forma_pago == 1) rbContadoEF.Checked = true;
                    else if (objFactura.id_forma_pago == 2) rbCreditoEF.Checked = true;
                }

                // Se cargan la tabla de productos (Detalle)
                dgvEmitirFactura.DataSource = null;
                dgvEmitirFactura.Columns.Clear();
                dgvEmitirFactura.DataSource = objFactura.CargarDetalles(IdFacturaRecibido);
                dgvEmitirFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la factura: " + ex.Message, "TRAMADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListoEF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonGroup4_Panel_Paint(object sender, PaintEventArgs e) { }
    }
}
