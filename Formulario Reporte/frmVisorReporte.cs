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
            rpvNum1.LocalReport.ReportEmbeddedResource = _report.ReportEmbeddedResource;

            foreach (var ds in _report.DataSources)
                rpvNum1.LocalReport.DataSources.Add(ds);

            rpvNum1.RefreshReport();
        }
    }
}
