using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.DatasSet_Reportes;
using TRAMADE.DatasSet_Reportes.dsComprasTableAdapters;
using System.Reflection;

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

                // Esto busca el archivo rptCompras.rdlc en tu proyecto de GitHub
                string nombreRecurso = Assembly.GetExecutingAssembly()
                    .GetManifestResourceNames()
                    .FirstOrDefault(rn => rn.EndsWith("rptCompras.rdlc"));
                
                string todosLosRecursos = string.Join("\n", Assembly.GetExecutingAssembly().GetManifestResourceNames());
                MessageBox.Show("Recursos encontrados:\n" + todosLosRecursos);

                if (string.IsNullOrEmpty(nombreRecurso))
                {
                    MessageBox.Show("Error: No se encontró el recurso rptCompras.rdlc");
                    return null;
                }

                report.ReportEmbeddedResource = nombreRecurso;

                // ESTO ES LO QUE TE FALTA Y POR ESO NO SALE:
                report.DataSources.Add(new ReportDataSource("DataSet1", (DataTable)ds.DataTable1));

                return report; // <--- SIN ESTO, EL REPORTE NUNCA VA A EXISTIR
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
    }

}