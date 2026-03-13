using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection; // Necesario para buscar el reporte en el repositorio de GitHub
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

                // ✅ Validación
                if (ds.DataTable1.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron compras para el período y sucursal seleccionados.",
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }

                var report = new LocalReport();
                string nombreRecurso = Assembly.GetExecutingAssembly()
                    .GetManifestResourceNames()
                    .FirstOrDefault(rn => rn.EndsWith("rptCompras.rdlc"));

                if (string.IsNullOrEmpty(nombreRecurso))
                {
                    MessageBox.Show("Error: No se encontró el archivo rptCompras.rdlc.",
                        "ERROR DE RECURSO");
                    return null;
                }

                report.ReportEmbeddedResource = nombreRecurso;
                report.DataSources.Add(new ReportDataSource("DataSet_Compras", (DataTable)ds.DataTable1));
                return report;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la generación del reporte: " + ex.Message,
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}