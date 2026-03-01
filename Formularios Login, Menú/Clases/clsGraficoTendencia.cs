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
    internal class clsGraficoTendencia
    {
        private readonly Chart _chart;

        public clsGraficoTendencia(Chart chart)
        {
            _chart = chart;
        }

        public void Cargar()
        {
            _chart.Series.Clear();
            _chart.Titles.Clear();
            _chart.Legends.Clear();

            _chart.Titles.Add("Tendencia de Ventas (Últimos 6 meses)");
            _chart.Titles[0].Font = new Font("Segoe UI", 11f, FontStyle.Bold);

            var serie = new Series("Ventas");
            serie.ChartType = SeriesChartType.Column;

            // Datos de prueba (últimos 6 meses)
            string[] meses = { "Sep 2024", "Oct 2024", "Nov 2024", "Dic 2024", "Ene 2025", "Feb 2025" };
            int[] valores = { 12, 19, 15, 27, 22, 30 };

            for (int i = 0; i < meses.Length; i++)
            {
                int idx = serie.Points.AddXY(meses[i], valores[i]);

                float pct = (float)i / (meses.Length - 1);
                int r = (int)(106 + (219 - 106) * pct);
                int g = (int)(90 + (53 - 90) * pct);
                int b = (int)(205 + (69 - 205) * pct);
                serie.Points[idx].Color = Color.FromArgb(r, g, b);
            }

            serie.IsValueShownAsLabel = true;
            serie.Font = new Font("Segoe UI", 8f, FontStyle.Bold);

            _chart.Series.Add(serie);

            var area = _chart.ChartAreas[0];
            area.BackColor = Color.Transparent;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 8f);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 8f);

            _chart.BackColor = Color.White;
        }
    }
}
