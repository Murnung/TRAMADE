using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace TRAMADE.Formularios_Login__Menú
{
    internal class clsGraficoInventario
    {
        private readonly Chart _chart;

        public clsGraficoInventario(Chart chart)
        {
            _chart = chart;
        }

        public void Cargar()
        {
            _chart.Series.Clear();
            _chart.Titles.Clear();
            _chart.Legends.Clear();

            _chart.Titles.Add("Gestión de Inventario");
            _chart.Titles[0].Font = new Font("Segoe UI", 11f, FontStyle.Bold);

            var serie = new Series("Inventario");
            serie.ChartType = SeriesChartType.Pie;

            // Datos de prueba
            serie.Points.AddXY("Disponible", 60);
            serie.Points[0].Color = Color.FromArgb(72, 199, 174);

            serie.Points.AddXY("En camino", 25);
            serie.Points[1].Color = Color.FromArgb(255, 193, 68);

            serie.Points.AddXY("Agotados", 15);
            serie.Points[2].Color = Color.FromArgb(220, 53, 69);

            serie["PieLabelStyle"] = "Outside";
            serie.Label = "#PERCENT{P0}";

            _chart.Series.Add(serie);
            _chart.ChartAreas[0].BackColor = Color.Transparent;
            _chart.BackColor = Color.White;

            var leyenda = new Legend();
            leyenda.Docking = Docking.Right;
            leyenda.Font = new Font("Segoe UI", 9f);
            _chart.Legends.Add(leyenda);
            serie.Legend = leyenda.Name;
            serie.IsVisibleInLegend = true;
        }
    }

}
