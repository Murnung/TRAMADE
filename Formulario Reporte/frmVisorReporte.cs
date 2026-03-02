using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace TRAMADE
{
    public partial class frmVisorReporte : Form
    {
        private readonly LocalReport _report;

        public frmVisorReporte(LocalReport report)
        {
            InitializeComponent();
            _report = report;
        }

        private void frmVisorReporte_Load(object sender, EventArgs e)
        {
            try
            {
                rpvNum1.LocalReport.ReportEmbeddedResource = _report.ReportEmbeddedResource;
                rpvNum1.LocalReport.DataSources.Clear();

                foreach (ReportDataSource ds in _report.DataSources)
                    rpvNum1.LocalReport.DataSources.Add(
                        new ReportDataSource(ds.Name, ds.Value as DataTable));

                rpvNum1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar reporte: " + ex.Message +
                    "\n" + ex.InnerException?.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}