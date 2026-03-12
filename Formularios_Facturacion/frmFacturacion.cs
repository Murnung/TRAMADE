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

        private void GenerarCorrelativo()
        {
            try
            {
                clsFacturaF objFactura = new clsFacturaF();
                numeroFactura = objFactura.ObtenerSiguienteNumeroFactura();
                lblNumeroFactura.Text = "INV/2026/" + numeroFactura.ToString("D4");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al generar correlativo");
            }
        }

        // --- NUEVO MÉTODO: CARGA EL VENDEDOR AUTOMÁTICAMENTE ---
        private void CargarVendedorAuto()
        {
            if (clsSesion.id_usuario != 0) // Si hay un usuario logueado en el sistema
            {
                txtIDVendedor.Text = clsSesion.id_usuario.ToString();
                txtNombreVendedor.Text = clsSesion.nombre_usuario;
                txtIDVendedor.ReadOnly = true;
                txtNombreVendedor.ReadOnly = true;
            }
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            GenerarCorrelativo();

            // LLAMAMOS AL VENDEDOR DE FORMA AUTOMÁTICA AL ABRIR
            CargarVendedorAuto();

            dtpVencimiento.Value = dtpEmision.Value.AddMonths(1);
            dtpEmision.ValueChanged += (s, args) => { dtpVencimiento.Value = dtpEmision.Value.AddMonths(1); };
        }

        private void BuscarCliente(string rtnDni)
        {
            try
            {
                clsClienteF objCliente = new clsClienteF();

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

        private void kryptonButton12_Click(object sender, EventArgs e)
        {
            if (clsValidacionesF.ValidarGridVacio(dgvDetalleFactura.Rows.Count, "Agregue productos para ver la vista previa.")) return;

            frmVistaPrevia objVP = new frmVistaPrevia();
            objVP.txtNombreClienteVP.Text = txtNombreCliente.Text;

            string dniMostrar = txtDNICliente.Text.Trim();
            if (string.IsNullOrEmpty(dniMostrar) || dniMostrar.StartsWith("SN-")) dniMostrar = "S/N";
            objVP.txtDNIClienteVP.Text = dniMostrar;

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

        private void kryptonButton13_Click(object sender, EventArgs e)
        {
            int productosReales = 0;
            foreach (DataGridViewRow fila in dgvDetalleFactura.Rows)
            {
                if (fila.Cells[0].Value != null && !fila.IsNewRow)
                {
                    productosReales++;
                }
            }

            string error = clsValidacionesF.ValidarEmisionFactura(
                txtNombreCliente.Text.Trim(),
                txtDireccionCliente.Text.Trim(),
                txtIDVendedor.Text.Trim(),
                dtpEmision.Value,
                dtpVencimiento.Value,
                productosReales,
                rbContado.Checked,
                rbCredito.Checked,
                txtDNICliente.Text.Trim()
            );

            if (error != "")
            {
                MessageBox.Show(error, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!clsValidacionesF.PedirConfirmacion("¿Está seguro que desea emitir y guardar esta factura?")) return;

            try
            {
                if (id_cliente_seleccionado == 0)
                {
                    clsClienteF objClienteR = new clsClienteF();
                    int idVendedor = int.Parse(txtIDVendedor.Text);
                    id_cliente_seleccionado = objClienteR.InsertarClienteRapido(txtNombreCliente.Text.Trim(), txtDireccionCliente.Text.Trim(), idVendedor, txtDNICliente.Text.Trim());
                }

                clsFacturaF nuevaFactura = new clsFacturaF();

                nuevaFactura.numero_factura = numeroFactura;
                nuevaFactura.id_usuario = int.Parse(txtIDVendedor.Text);
                nuevaFactura.id_forma_pago = rbContado.Checked ? 1 : 2;
                nuevaFactura.id_cliente = id_cliente_seleccionado;
                nuevaFactura.fecha_emision = dtpEmision.Value;
                nuevaFactura.fecha_vencimiento = dtpVencimiento.Value;
                nuevaFactura.subtotal = decimal.Parse(lblSubtotal.Text.Replace("L. ", "").Trim());
                nuevaFactura.impuesto = decimal.Parse(lblImpuesto.Text.Replace("L. ", "").Trim());
                nuevaFactura.total = decimal.Parse(lblTotal.Text.Replace("L. ", "").Trim());

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

                int idGenerado = nuevaFactura.GuardarFacturaTransaccion();

                if (idGenerado > 0)
                {
                    MessageBox.Show("Factura emitida con éxito.", "TRAMADE");

                    frmEmitirFactura objEmitirFactura = new frmEmitirFactura();
                    objEmitirFactura.IdFacturaRecibido = idGenerado;
                    objEmitirFactura.ShowDialog();

                    dgvDetalleFactura.Rows.Clear();
                    CalcularTotales();

                    txtNombreCliente.Text = "";
                    txtDNICliente.Text = "";
                    txtDireccionCliente.Text = "";
                    id_cliente_seleccionado = 0;

                    rbContado.Checked = false;
                    rbCredito.Checked = false;

                    dtpEmision.Value = DateTime.Now;
                    dtpVencimiento.Value = DateTime.Now.AddMonths(1);

                    GenerarCorrelativo();
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

            // Ya NO limpiamos los datos del vendedor aquí
            CargarVendedorAuto();

            dtpEmision.Value = DateTime.Now;
            dtpVencimiento.Value = DateTime.Now.AddMonths(1);

            rbContado.Checked = false;
            rbCredito.Checked = false;
            id_cliente_seleccionado = 0;

            dgvDetalleFactura.Rows.Clear();
            CalcularTotales();

            GenerarCorrelativo();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnLimpiar.PerformClick();
        }

        private void txtDNICliente_TextChanged(object sender, EventArgs e) { }
        private void txtDNICliente_Leave(object sender, EventArgs e) { }

        // El botón sigue existiendo por si alguna vez ocupan recargarlo a mano, pero ya se hace solo
        private void btnIDVendedor_Click(object sender, EventArgs e)
        {
            CargarVendedorAuto();
        }

        private void btnDNICliente_Click(object sender, EventArgs e)
        {
            if (clsValidacionesF.ValidarCampoVacio(txtDNICliente.Text, "Por favor, escriba un DNI o RTN antes de buscar.")) return;

            if (!clsValidacionesF.EsDniRtnValido(txtDNICliente.Text))
            {
                MessageBox.Show("Formato incorrecto. No use espacios en blanco. El DNI debe tener exactamente 13 números y el RTN 14 números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BuscarCliente(txtDNICliente.Text.Trim());
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (clsValidacionesF.ValidarFilaSeleccionada(dgvDetalleFactura.CurrentRow, "Por favor, seleccione un producto de la lista para eliminarlo."))
            {
                dgvDetalleFactura.Rows.Remove(dgvDetalleFactura.CurrentRow);
                CalcularTotales();
            }
        }

        private void dgvDetalleFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotales();
        }
    }
}
