using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.DatasSet_Reportes;
using TRAMADE.DatasSet_Reportes.dsStockTableAdapters;

namespace TRAMADE
{
    internal class clsRptStock
    {
        public LocalReport Generar(int idSucursal)
        {
            try
            {
                dsStock ds = new dsStock();
                new DatasSet_Reportes.dsStockTableAdapters.DataTable1TableAdapter()
                    .Fill(ds.DataTable1, idSucursal);

                // ✅ Validación
                if (ds.DataTable1.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró stock para la sucursal seleccionada.",
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }

                var report = new LocalReport();

                // ✅ Búsqueda dinámica
                string nombreRecurso = Assembly.GetExecutingAssembly()
                    .GetManifestResourceNames()
                    .FirstOrDefault(rn => rn.EndsWith("rptStock.rdlc"));

                if (string.IsNullOrEmpty(nombreRecurso))
                {
                    MessageBox.Show("Error: No se encontró el archivo rptStock.rdlc.",
                        "ERROR DE RECURSO");
                    return null;
                }

                report.ReportEmbeddedResource = nombreRecurso;
                // ✅ Nombre correcto del DataSource
                report.DataSources.Add(new ReportDataSource("DataSet_Stock", (DataTable)ds.DataTable1));
                return report;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reporte stock: " + ex.Message,
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}