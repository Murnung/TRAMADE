using System;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace TRAMADE.Clases_Reporte
{
    internal class clsDescarga
    {
        public static void Descargar(LocalReport report, string formato)
        {
            // Si el reporte viene nulo o sin contenido, no podemos hacer nada
            if (report == null) return;

            try
            {
                string mimeType, encoding, extension;
                string[] streamids;
                Warning[] warnings;

                // IMPORTANTE: Usamos el 'report' que recibimos, NO creamos uno nuevo
                byte[] bytes = report.Render(
                    formato == "PDF" ? "PDF" : "EXCELOPENXML",
                    null, out mimeType, out encoding, out extension,
                    out streamids, out warnings);

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = formato == "PDF" ? "PDF|*.pdf" : "Excel|*.xlsx";
                    sfd.FileName = $"Reporte_Compras_{DateTime.Now:yyyyMMdd}";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(sfd.FileName, bytes);
                        MessageBox.Show("Archivo guardado con éxito.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Esto te dirá exactamente por qué falla el motor de renderizado
                MessageBox.Show("Error al guardar: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
        }
    }
}