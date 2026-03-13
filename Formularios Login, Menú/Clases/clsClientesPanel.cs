using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace TRAMADE.Formularios_Login__Menú
{
    internal class clsClientesPanel
    {
        
        private readonly Label _lblTotal;
        private readonly Panel _pnlBarraFondo;
        private readonly Panel _pnlBarraActivos;

        public clsClientesPanel(Label lblTotal, Panel pnlBarraFondo, Panel pnlBarraActivos)
        {
            _lblTotal = lblTotal;
            _pnlBarraFondo = pnlBarraFondo;
            _pnlBarraActivos = pnlBarraActivos;
        }

        public void Cargar()
        {
            clsConexion cn = new clsConexion();
            try
            {
                cn.Abrir();
                int total = ToInt(EjecutarScalar(cn, "SELECT COUNT(*) FROM CLIENTE"));
                int activos = ToInt(EjecutarScalar(cn,
                    @"SELECT COUNT(*) FROM CLIENTE c
              INNER JOIN ESTADO e ON c.id_estado = e.id_estado
              INNER JOIN TIPO_ESTADO t ON e.id_tipo_estado = t.id_tipo_estado
              WHERE t.descripcion_tipo_estado = 'Activo'"));
                int inactivos = total - activos;
                int porcentaje = total > 0 ? (int)((activos * 100.0) / total) : 0;

                _lblTotal.Text = total.ToString("N0");

                _pnlBarraFondo.BackColor = Color.FromArgb(220, 220, 220);
                _pnlBarraActivos.Width = (int)(_pnlBarraFondo.Width * porcentaje / 100.0);
                _pnlBarraActivos.Height = _pnlBarraFondo.Height;
                _pnlBarraActivos.Location = new Point(0, 0);
                _pnlBarraActivos.BackColor = porcentaje >= 70 ? Color.FromArgb(72, 199, 174) :
                                             porcentaje >= 40 ? Color.FromArgb(255, 193, 68) :
                                                                Color.FromArgb(220, 53, 69);

                var tooltip = new ToolTip();
                tooltip.SetToolTip(_pnlBarraFondo, $"Activos: {activos} | Inactivos: {inactivos} | {porcentaje}%");
                tooltip.SetToolTip(_pnlBarraActivos, $"Activos: {activos} | Inactivos: {inactivos} | {porcentaje}%");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clientes: " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { cn.Cerrar(); }
        }

        private string EjecutarScalar(clsConexion cn, string query)
        {
            SqlCommand cmd = new SqlCommand(query, cn.SqlC);
            object res = cmd.ExecuteScalar();
            return res == null || res == DBNull.Value ? "0" : res.ToString();
        }

        private int ToInt(string v) { return int.TryParse(v, out int r) ? r : 0; }
    }
}
