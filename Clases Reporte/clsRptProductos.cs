using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE
{
    internal class clsRptProductos
    {
        public LocalReport Generar(DateTime fechaInicio, DateTime fechaFin, int idSucursal)
        {
            try
            {
                dsProductos ds = new dsProductos();
                new dsProductosTableAdapters.DataTable1TableAdapter()
                    .Fill(ds.DataTable1, fechaInicio, fechaFin, idSucursal);

                var report = new LocalReport();
                report.ReportEmbeddedResource = "TRAMADE.Reportes.rptProductos.rdlc";
                report.DataSources.Add(new ReportDataSource("DataSet1", ds.DataTable1));
                return report;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reporte productos: " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}