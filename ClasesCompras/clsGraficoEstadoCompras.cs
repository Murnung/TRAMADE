using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace TRAMADE.ClasesCompras
{
    internal class clsGraficoEstadoCompras
    {
        private readonly Chart _chart;
        private readonly clsConexion _conexion;

        public clsGraficoEstadoCompras(Chart chart, clsConexion conexion)
        {
            _chart = chart;
            _conexion = conexion;
        }

        public void Cargar()
        {
            _chart.Series.Clear();
            _chart.Titles.Clear();
            _chart.Legends.Clear();

            _chart.Titles.Add("Estado de Compras");
            _chart.Titles[0].Font = new Font("Segoe UI", 11f, FontStyle.Bold);

            var serie = new Series("Compras");
            serie.ChartType = SeriesChartType.Pie;

            try
            {
                _conexion.Abrir();
                string query = "SELECT ComprasPendientes, ComprasAutorizadas FROM VistaGraficoComprasPendientes";
                SqlCommand cmd = new SqlCommand(query, _conexion.SqlC);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int pendientes = Convert.ToInt32(dr["ComprasPendientes"]);
                    int autorizadas = Convert.ToInt32(dr["ComprasAutorizadas"]);

                    serie.Points.AddXY("Pendientes", pendientes);
                    serie.Points[0].Color = Color.FromArgb(0, 128, 128);    // Teal

                    serie.Points.AddXY("Autorizadas", autorizadas);
                    serie.Points[1].Color = Color.FromArgb(255, 193, 68);   // Dorado
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                // Datos de respaldo si falla la conexión
                serie.Points.AddXY("Pendientes", 0);
                serie.Points.AddXY("Autorizadas", 0);
                serie.Points[0].Color = Color.FromArgb(0, 128, 128);    // Teal
                serie.Points[1].Color = Color.FromArgb(255, 193, 68);   // Dorado
                System.Windows.Forms.MessageBox.Show("Error al cargar gráfico: " + ex.Message);
            }
            finally
            {
                _conexion.Cerrar();
            }

            serie["PieLabelStyle"] = "Outside";
            serie.Label = "#VALX\n#PERCENT{P0}";
            serie.IsVisibleInLegend = false;

            // Tamaño del gráfico
            _chart.ChartAreas[0].Position.Auto = false;
            _chart.ChartAreas[0].Position = new ElementPosition(0, 12, 100, 75);

            _chart.Series.Add(serie);
            _chart.ChartAreas[0].BackColor = Color.Transparent;
            _chart.BackColor = Color.White;


        }

    }
}
