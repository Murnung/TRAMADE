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
    }
}
