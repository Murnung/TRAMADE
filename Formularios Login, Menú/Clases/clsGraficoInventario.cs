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

            int disponibles = 0, enCamino = 0, agotados = 0;

            clsConexion cn = new clsConexion();
            try
            {
                cn.Abrir();
                string query = @"
                    SELECT 
                        SUM(CASE WHEN cantidad_stock > 10 THEN 1 ELSE 0 END) AS Disponibles,
                        SUM(CASE WHEN cantidad_stock BETWEEN 1 AND 10 THEN 1 ELSE 0 END) AS EnCamino,
                        SUM(CASE WHEN cantidad_stock = 0 THEN 1 ELSE 0 END) AS Agotados
                    FROM PRODUCTO_SUCURSAL";

                SqlCommand cmd = new SqlCommand(query, cn.SqlC);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    disponibles = dr["Disponibles"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Disponibles"]);
                    enCamino = dr["EnCamino"] == DBNull.Value ? 0 : Convert.ToInt32(dr["EnCamino"]);
                    agotados = dr["Agotados"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Agotados"]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al cargar gráfico: " + ex.Message);
            }
            finally { cn.Cerrar(); }

            var serie = new Series("Inventario");
            serie.ChartType = SeriesChartType.Pie;

            serie.Points.AddXY("Disponible", disponibles);
            serie.Points[0].Color = Color.FromArgb(72, 199, 174);
            serie.Points[0].Label = "#PERCENT{P0}";
            serie.Points[0].LegendText = "Disponible";

            serie.Points.AddXY("En camino", enCamino);
            serie.Points[1].Color = Color.FromArgb(255, 193, 68);
            serie.Points[1].Label = "#PERCENT{P0}";
            serie.Points[1].LegendText = "En camino";

            serie.Points.AddXY("Agotados", agotados);
            serie.Points[2].Color = Color.FromArgb(220, 53, 69);
            serie.Points[2].Label = "#PERCENT{P0}";
            serie.Points[2].LegendText = "Agotados";

            serie["PieLabelStyle"] = "Outside";
            serie["PieStartAngle"] = "90";
            _chart.ChartAreas[0].Area3DStyle.Enable3D = false;

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
