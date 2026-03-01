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
            _reportes = new clsReportes(cmbSucursal, cmbTipoReporte);
            _reportes.CargarSucursales();
            _reportes.CargarTiposReporte();
        }
    }
}
