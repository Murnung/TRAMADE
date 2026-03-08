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
    internal class clsGraficoProductosCompras
    {
        private readonly Chart _chart;
        private readonly clsConexion _conexion;

        public clsGraficoProductosCompras(Chart chart, clsConexion conexion)
        {
            _chart = chart;
            _conexion = conexion;
        }

        public void Cargar()
        {
            _chart.Series.Clear();
            _chart.Titles.Clear();
            _chart.Legends.Clear();

            _chart.Titles.Add("Top 5 Productos Más Comprados");
            _chart.Titles[0].Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            _chart.Titles[0].Docking = Docking.Top;
            _chart.Titles[0].Alignment = ContentAlignment.TopCenter;

            var serie = new Series("Productos");
            serie.ChartType = SeriesChartType.Bar;
            serie.IsVisibleInLegend = false;

            try
            {
                _conexion.Abrir();
                string query = "SELECT Producto, TotalComprado FROM VistaTop5ProductosComprados";
                SqlCommand cmd = new SqlCommand(query, _conexion.SqlC);
                SqlDataReader dr = cmd.ExecuteReader();

                int[] colores = new int[]
                {
                    Color.FromArgb(0,   128, 128).ToArgb(),  // Teal
                    Color.FromArgb(255, 193,  68).ToArgb(),  // Dorado
                    Color.FromArgb(72,  199, 174).ToArgb(),  // Verde agua
                    Color.FromArgb(255, 159,  64).ToArgb(),  // Naranja
                    Color.FromArgb(100, 181, 246).ToArgb(),  // Azul claro
                };

                int i = 0;
                while (dr.Read())
                {
                    string producto = dr["Producto"].ToString();
                    int cantidad = Convert.ToInt32(dr["TotalComprado"]);

                    serie.Points.AddXY(producto, cantidad);
                    serie.Points[i].Color = Color.FromArgb(colores[i]);
                    serie.Points[i].Label = cantidad.ToString();
                    i++;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al cargar gráfico: " + ex.Message);
            }
            finally
            {
                _conexion.Cerrar();
            }

            // Estilo de etiquetas
            serie.LabelForeColor = Color.Black;
            serie.Font = new Font("Segoe UI", 9f, FontStyle.Bold);

            // Área del gráfico
            _chart.ChartAreas[0].Position.Auto = false;
            _chart.ChartAreas[0].Position = new ElementPosition(0, 10, 100, 88);
            _chart.ChartAreas[0].BackColor = Color.Transparent;
            _chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            _chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            _chart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 8f);
            _chart.BackColor = Color.White;

            _chart.Series.Add(serie);
        }
    }
}
