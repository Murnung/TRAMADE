using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE
{
    internal class clsRptStock
    {
        public LocalReport Generar(int idSucursal)
        {
            try
            {
                dsStock ds = new dsStock();
                new dsStockTableAdapters.DataTable1TableAdapter()
                    .Fill(ds.DataTable1, idSucursal);

                var report = new LocalReport();
                report.ReportEmbeddedResource = "TRAMADE.Reportes.rptStock.rdlc";
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.DataTable1));
                return report;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reporte stock: " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}