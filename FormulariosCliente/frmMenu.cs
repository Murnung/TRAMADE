using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TRAMADE.ClasesCliente;

namespace TRAMADE
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            ControlBox = false;
        }
        clsConexion ObjConexion = new clsConexion();
        clsCliente ObjCliente = new clsCliente();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            recargarClientes();
            recargarGraficaEstadoCli();
            recargarGraficaDepa();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistro objRegis = new frmRegistro();
            objRegis.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmRegistroNuevo objRegisNue = new frmRegistroNuevo();
            objRegisNue.Show();
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            frmAprobacion objApro = new frmAprobacion();
            objApro.Show();
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            frmSeguimientoCliente objSegui = new frmSeguimientoCliente();
            objSegui.Show();
        }

        public void recargarClientes()
        {
            try
            {
                ObjConexion.Abrir();
                string consulta = "SELECT * FROM Ultimos_Clientes";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dvgUltimos.DataSource = dt;

                dvgUltimos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dvgUltimos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dvgUltimos.ReadOnly = true;
                dvgUltimos.AllowUserToResizeRows = false;
                dvgUltimos.AllowUserToResizeColumns = false;
                dvgUltimos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(148, 114, 71);
                dvgUltimos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dvgUltimos.EnableHeadersVisualStyles = false;
                dvgUltimos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 154, 111);
                dvgUltimos.DefaultCellStyle.SelectionForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }

        public void recargarGraficaDepa()
        {
            try
            {
                chtDepas.Series.Clear();
                chtDepas.Titles.Clear();
                chtDepas.Legends.Clear();
                Title titulo = chtDepas.Titles.Add("Top 5 Departamentos con más Clientes");
                titulo.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
                titulo.Alignment = ContentAlignment.TopCenter;
                titulo.ForeColor = Color.FromArgb(45, 45, 45);


                Series serieDepas = chtDepas.Series.Add("Departamentos");
                serieDepas.ChartType = SeriesChartType.Bar;
                serieDepas.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
                serieDepas.IsValueShownAsLabel = true;
                serieDepas.LabelForeColor = Color.DimGray;
                serieDepas["PointWidth"] = "0.7";


                ChartArea area = chtDepas.ChartAreas[0];
                area.BackColor = Color.White;
                area.BorderColor = Color.Transparent;
                area.AxisX.MajorGrid.Enabled = false;
                area.AxisX.LineColor = Color.FromArgb(200, 200, 200);
                area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9f);
                area.AxisX.IsReversed = true;
                area.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);
                area.AxisY.LineColor = Color.Transparent;
                area.AxisY.LabelStyle.ForeColor = Color.Silver;

                DataTable dtDepas = ObjCliente.ObtenerTopDepartamentos(ObjConexion);
                chtDepas.DataSource = dtDepas;
                serieDepas.XValueMember = "nombre_departamento";
                serieDepas.YValueMembers = "Total";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la gráfica: " + ex.Message);
            }
        }

        public void recargarGraficaEstadoCli()
        {
            try
            {
                DataTable dtEstados = ObjCliente.ObtenerPorcentajeEstados(ObjConexion);

                chtClientes.Series.Clear();
                chtClientes.Titles.Clear();
                chtClientes.Legends.Clear();

                Title titulo = chtClientes.Titles.Add("Estado de Clientes");
                titulo.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
                titulo.ForeColor = Color.FromArgb(45, 45, 45);

                Legend leyenda = chtClientes.Legends.Add("Default");
                leyenda.Font = new Font("Segoe UI", 9f);
                leyenda.ForeColor = Color.FromArgb(64, 64, 64);
                leyenda.Docking = Docking.Bottom;
                leyenda.Alignment = StringAlignment.Center;

                Series serie = chtClientes.Series.Add("Estados");
                serie.ChartType = SeriesChartType.Pie;
                serie.Font = new Font("Segoe UI", 9f, FontStyle.Bold);

                ChartArea area = chtClientes.ChartAreas[0];
                area.BackColor = Color.White;

                Color verdeActivo = Color.FromArgb(107, 184, 80);
                Color rojoInactivo = Color.FromArgb(233, 28, 62);
                Color amarilloPendiente = Color.FromArgb(255, 193, 7);

                foreach (DataRow r in dtEstados.Rows)
                {
                    string estado = r["Estado"].ToString().ToUpper().Trim();
                    double valor = Convert.ToDouble(r["Cantidad"]);

                    int p = serie.Points.AddXY(estado, valor);

                    if (estado.Contains("ACTIVO") || estado.Contains("AUTORIZADO"))
                        serie.Points[p].Color = verdeActivo;
                    if (estado.Contains("INACTIVO") || estado.Contains("NEGADO"))
                        serie.Points[p].Color = rojoInactivo;
                    if (estado.Contains("PENDIENTE") || estado.Contains("ESPERA"))
                    {
                        serie.Points[p].Color = amarilloPendiente;
                    }
                    serie.Points[p].Label = "#PERCENT{P0}";
                    serie.Points[p].LegendText = "#VALX";
                    serie.Points[p].LabelForeColor = Color.White;
                    if (serie.Points[p].Color == rojoInactivo)
                        serie.Points[p].LabelForeColor = Color.White;
                    else
                        serie.Points[p].LabelForeColor = Color.Black;
                }

                serie["PieLabelStyle"] = "Inside";
                serie.BorderColor = Color.White;
                serie.BorderWidth = 2;
                serie["PieDrawingStyle"] = "SoftEdge";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gráfica de estados: " + ex.Message);
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            recargarClientes();
            recargarGraficaDepa();
            recargarGraficaEstadoCli();
        }
    }
}
