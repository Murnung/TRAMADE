using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.Formulario_Reporte;

namespace TRAMADE
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private clsReportes _reportes;

        private void frmReportes_Load(object sender, EventArgs e)
        {
            _reportes = new clsReportes(cmbSucursal, cmbTipoReporte, lstReportes);
            _reportes.CargarSucursales();
            _reportes.CargarTiposReporte();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            _reportes.Generar(dtpDesde.Value, dtpHasta.Value,
                Convert.ToInt32(cmbSucursal.SelectedValue));
        }

        private void lstReportes_DoubleClick(object sender, EventArgs e)
        {
            _reportes.AbrirReporte();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            _reportes.AbrirReporte();
        }
    }
}
