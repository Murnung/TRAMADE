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
    public partial class frmFacturacion : Form
    {
        int numeroFactura = 1;
        int id_cliente_seleccionado = 0;

        public frmFacturacion()
        {
            InitializeComponent();
        }

        // --- AHORA BUSCAMOS USANDO LA CLASE ---
        private void BuscarCliente(string rtnDni)
        {
            try
            {
                // Instanciamos la clase que acabas de crear
                clsClienteF objCliente = new clsClienteF();

                // Si la clase encuentra al cliente (devuelve true)
                if (objCliente.BuscarClienteDNI(rtnDni))
                {
                    id_cliente_seleccionado = objCliente.id_cliente;
                    txtNombreCliente.Text = objCliente.nombre_cliente;
                    txtDireccionCliente.Text = objCliente.direccion_cliente;
                }
                else
                {
                    id_cliente_seleccionado = 0;
                    MessageBox.Show("Cliente no encontrado en la base de datos. Verifique el RTN/DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreCliente.Text = "";
                    txtDireccionCliente.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void CalcularTotales()
        {
            decimal subtotalGeneral = 0;
            decimal impuesto = 0;
            decimal totalAPagar = 0;

            foreach (DataGridViewRow fila in dgvDetalleFactura.Rows)
            {
                if (fila.Cells[5].Value != null)
                {
                    subtotalGeneral += Convert.ToDecimal(fila.Cells[5].Value);
                }
            }

            impuesto = subtotalGeneral * 0.15m;
            totalAPagar = subtotalGeneral + impuesto;

            lblSubtotal.Text = "L. " + subtotalGeneral.ToString("N2");
            lblImpuesto.Text = "L. " + impuesto.ToString("N2");
            lblTotal.Text = "L. " + totalAPagar.ToString("N2");
        }

        private void btnAggProducto_Click(object sender, EventArgs e)
        {
            frmAggProducto objAggProducto = new frmAggProducto();
            objAggProducto.ShowDialog();
        }

        // --- VISTA PREVIA (Queda igual porque es pura UI) ---
        private void kryptonButton12_Click(object sender, EventArgs e)
        {
            if (dgvDetalleFactura.Rows.Count == 0)
            {
                MessageBox.Show("Agregue productos para ver la vista previa.", "Aviso");
                return;
            }

            frmVistaPrevia objVP = new frmVistaPrevia();
            objVP.txtNombreClienteVP.Text = txtNombreCliente.Text;
            objVP.txtDNIClienteVP.Text = txtDNICliente.Text;
            objVP.txtDireccionClienteVP.Text = txtDireccionCliente.Text;
            objVP.lblNumeroFacturaVP.Text = lblNumeroFactura.Text;
            objVP.txtIDVendedorVP.Text = txtIDVendedor.Text;
            objVP.txtNombreVendedorVP.Text = txtNombreVendedor.Text;
            objVP.lblFechaEmisionVP.Text = dtpEmision.Value.ToString("dd/MM/yyyy");
            objVP.lblfechaVencimientoVP.Text = dtpVencimiento.Value.ToString("dd/MM/yyyy");
            objVP.lblSubtotalVP.Text = lblSubtotal.Text;
            objVP.lblImpuestoVP.Text = lblImpuesto.Text;
            objVP.lblTotalVP.Text = lblTotal.Text;

            if (rbContado.Checked) objVP.rbContadoVP.Checked = true;
            if (rbCredito.Checked) objVP.rbCreditoVP.Checked = true;

            objVP.dgvFacturaVP.Rows.Clear();

            foreach (DataGridViewRow fila in dgvDetalleFactura.Rows)
            {
                if (fila.Cells[0].Value != null && !fila.IsNewRow)
                {
                    objVP.dgvFacturaVP.Rows.Add(new object[] {
                        fila.Cells[0].Value,
                        fila.Cells[1].Value,
                        fila.Cells[2].Value,
                        fila.Cells[3].Value,
                        fila.Cells[4].Value,
                        fila.Cells[5].Value
                    });
                }
            }
            objVP.ShowDialog();
        }

        // --- AHORA GUARDAMOS USANDO LA CLASE (Adiós SQL aquí) ---
        private void kryptonButton13_Click(object sender, EventArgs e)
        {
            if (dgvDetalleFactura.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos para facturar.", "Aviso");
                return;
            }

            if (id_cliente_seleccionado == 0)
            {
                MessageBox.Show("Por favor seleccione un cliente válido.", "Aviso");
                return;
            }

            try
            {
                // 1. Preparamos la "Caja" (La clase clsFactura)
                clsFacturaF nuevaFactura = new clsFacturaF();

                // 2. Metemos los datos de la pantalla a la clase
                nuevaFactura.numero_factura = numeroFactura;
                nuevaFactura.id_usuario = int.Parse(txtIDVendedor.Text);
                nuevaFactura.id_forma_pago = rbContado.Checked ? 1 : 2;
                nuevaFactura.id_cliente = id_cliente_seleccionado;
                nuevaFactura.fecha_emision = dtpEmision.Value;
                nuevaFactura.fecha_vencimiento = dtpVencimiento.Value;
                nuevaFactura.subtotal = decimal.Parse(lblSubtotal.Text.Replace("L. ", "").Trim());
                nuevaFactura.impuesto = decimal.Parse(lblImpuesto.Text.Replace("L. ", "").Trim());
                nuevaFactura.total = decimal.Parse(lblTotal.Text.Replace("L. ", "").Trim());

                // 3. Metemos los productos del Grid a la lista de la clase
                foreach (DataGridViewRow fila in dgvDetalleFactura.Rows)
                {
                    if (fila.Cells[0].Value != null && !fila.IsNewRow)
                    {
                        clsDetalleFactura detalle = new clsDetalleFactura();
                        detalle.id_producto = Convert.ToInt32(fila.Cells[0].Value);
                        detalle.cantidad = Convert.ToDecimal(fila.Cells[3].Value);

                        nuevaFactura.Detalles.Add(detalle);
                    }
                }

                // 4. Le decimos a la clase: ¡Guardate!
                int idGenerado = nuevaFactura.GuardarFacturaTransaccion();

                // 5. Si nos devuelve un ID mayor a 0, fue un éxito
                if (idGenerado > 0)
                {
                    MessageBox.Show("Factura emitida con éxito.", "TRAMADE");

                    frmEmitirFactura objEmitirFactura = new frmEmitirFactura();
                    objEmitirFactura.IdFacturaRecibido = idGenerado;
                    objEmitirFactura.ShowDialog();

                    dgvDetalleFactura.Rows.Clear();
                    CalcularTotales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al Emitir");
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            frmHistorialFacturas objHistorialFacturas = new frmHistorialFacturas();
            objHistorialFacturas.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreCliente.Text = "";
            txtDNICliente.Text = "";
            txtDireccionCliente.Text = "";
            txtIDVendedor.Text = "";
            txtNombreVendedor.Text = "";
            dtpEmision.Value = DateTime.Now;
            dtpVencimiento.Value = DateTime.Now;
            rbContado.Checked = false;
            rbCredito.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnLimpiar.PerformClick();
            numeroFactura++;
            lblNumeroFactura.Text = "INV/2026/" + numeroFactura.ToString("D4");
        }

        // Eventos vacíos
        private void txtDNICliente_TextChanged(object sender, EventArgs e) { }
        private void txtDNICliente_Leave(object sender, EventArgs e) { }
        private void frmFacturacion_Load(object sender, EventArgs e) { }

        private void btnIDVendedor_Click(object sender, EventArgs e)
        {
            if (clsSesion.id_usuario != 0)
            {
                txtIDVendedor.Text = clsSesion.id_usuario.ToString();
                txtNombreVendedor.Text = clsSesion.nombre_usuario;
                txtIDVendedor.ReadOnly = true;
                txtNombreVendedor.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("No se detectó ningún usuario logueado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDNICliente_Click(object sender, EventArgs e)
        {
            if (txtDNICliente.Text.Trim() != "")
            {
                BuscarCliente(txtDNICliente.Text.Trim());
            }
            else
            {
                MessageBox.Show("Por favor, escriba un DNI o RTN antes de buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDetalleFactura.CurrentRow != null)
            {
                dgvDetalleFactura.Rows.Remove(dgvDetalleFactura.CurrentRow);
                CalcularTotales();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista para eliminarlo.", "Aviso");
            }
        }

        private void dgvDetalleFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotales();
        }
    }
}