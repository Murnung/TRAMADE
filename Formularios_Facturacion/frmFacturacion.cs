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

        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void btnAggProducto_Click(object sender, EventArgs e)
        {
            frmAggProducto objAggProducto = new frmAggProducto();
            objAggProducto.ShowDialog();
        }

        private void kryptonButton12_Click(object sender, EventArgs e)
        {
            frmVistaPrevia objVistaPrevia = new frmVistaPrevia();
            objVistaPrevia.txtNombreClienteVP.Text = txtNombreCliente.Text;
            objVistaPrevia.txtDNIClienteVP.Text = txtDNICliente.Text;
            objVistaPrevia.txtDireccionClienteVP.Text = txtDireccionCliente.Text;
            objVistaPrevia.lblNumeroFacturaVP.Text = lblNumeroFactura.Text;
            objVistaPrevia.ShowDialog();
        }

        private void kryptonButton13_Click(object sender, EventArgs e)
        {
            frmEmitirFactura objEmitirFactura = new frmEmitirFactura();
            objEmitirFactura.ShowDialog();
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
            dtpEmision.Value = DateTime.Now;
            dtpVencimiento  .Value = DateTime.Now;
            rbContado.Checked = false;
            rbCredito.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnLimpiar.PerformClick();
            numeroFactura++;
            lblNumeroFactura.Text = "INV/2026/" + numeroFactura.ToString("D4");
        }
    }
}
