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
                // 1. Instanciamos el DataSet y cargamos los datos desde la BD
                dsCompras ds = new dsCompras();
                new DatasSet_Reportes.dsComprasTableAdapters.DataTable1TableAdapter()
                    .Fill(ds.DataTable1, fechaInicio, fechaFin, idSucursal);

                // 2. Creamos el objeto del reporte local
                var report = new LocalReport();

                // 3. Buscamos el recurso rptCompras.rdlc dinámicamente. 
                // Esto evita que el reporte "truene" si alguien en GitHub mueve el archivo de carpeta.
                string nombreRecurso = Assembly.GetExecutingAssembly()
                    .GetManifestResourceNames()
                    .FirstOrDefault(rn => rn.EndsWith("rptCompras.rdlc"));

                if (string.IsNullOrEmpty(nombreRecurso))
                {
                    MessageBox.Show("Error: No se encontró el archivo rptCompras.rdlc. " +
                        "Verifica que esté como 'Recurso incrustado'.", "ERROR DE RECURSO");
                    return null;
                }

                report.ReportEmbeddedResource = nombreRecurso;

                // 4. VINCULACIÓN: Aquí conectamos el código con el diseño del reporte.
                // Usamos "DataSet_Compras" porque es el nombre que configuraste en el .rdlc
                report.DataSources.Add(new ReportDataSource("DataSet_Compras", (DataTable)ds.DataTable1));

                // 5. IMPORTANTE: Retornamos el reporte listo para ser visualizado o descargado
                return report;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la generación del reporte: " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}