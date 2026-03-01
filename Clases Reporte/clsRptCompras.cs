using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.DatasSet_Reportes;
using TRAMADE.DatasSet_Reportes.dsComprasTableAdapters;

namespace TRAMADE
{
    internal class clsRptCompras
    {
        public LocalReport Generar(DateTime fechaInicio, DateTime fechaFin, int idSucursal)
        {
            try
            {
                dsCompras ds = new dsCompras();
                new DatasSet_Reportes.dsComprasTableAdapters.DataTable1TableAdapter()
                    .Fill(ds.DataTable1, fechaInicio, fechaFin, idSucursal);

                var report = new LocalReport();
                report.ReportEmbeddedResource = "TRAMADE.Reportes.rptCompras.rdlc";
                report.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)ds.DataTable1));
                return report;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reporte compras: " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}