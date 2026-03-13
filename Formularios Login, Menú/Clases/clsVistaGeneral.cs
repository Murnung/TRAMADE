using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.Formularios_Login__Menú
{
    internal class clsVistaGeneral
    {
        private Panel _panelActivo = null;
        private readonly Form _form;

        public clsVistaGeneral(Form form)
        {
            _form = form;
            // Cierra el popup al hacer clic fuera
            _form.MouseClick += (s, e) => CerrarPopup();
        }

        // ── Métodos públicos para cada botón ────────────────────

        public void MostrarProductos(KryptonButton btn)
        {
            clsConexion cn = new clsConexion();
            try
            {
                cn.Abrir();
                int total = ToInt(EjecutarScalar(cn, "SELECT COUNT(*) FROM PRODUCTO"));
                int categorias = ToInt(EjecutarScalar(cn, "SELECT COUNT(*) FROM CATEGORIA"));
                int proveedores = ToInt(EjecutarScalar(cn, "SELECT COUNT(*) FROM PROVEEDOR"));

                MostrarPopup(btn, "📦 Total Productos", total.ToString(),
                    "productos registrados",
                    $"Categorías:   {categorias}",
                    $"Proveedores:  {proveedores}");
            }
            catch (Exception ex) { Error(ex); }
            finally { cn.Cerrar(); }
        }

        public void MostrarVentas(KryptonButton btn)
        {
            clsConexion cn = new clsConexion();
            try
            {
                cn.Abrir();
                int total = ToInt(EjecutarScalar(cn, "SELECT COUNT(*) FROM FACTURA"));
                int ultimoMes = ToInt(EjecutarScalar(cn,
                    "SELECT COUNT(*) FROM FACTURA WHERE MONTH(fecha_emision) = MONTH(GETDATE()) AND YEAR(fecha_emision) = YEAR(GETDATE())"));
                string monto = EjecutarScalar(cn, "SELECT ISNULL(SUM(f.precio_unitario * fp.cantidad), 0) FROM FACTURA_PRODUCTO fp JOIN PRODUCTO f ON fp.id_producto = f.id_producto");

                MostrarPopup(btn, "📈 Ventas Registradas", total.ToString(),
                    "ventas en total",
                    $"Último mes:    {ultimoMes}",
                    $"Monto total:   L. {ToDecimal(monto):N2}");
            }
            catch (Exception ex) { Error(ex); }
            finally { cn.Cerrar(); }
        }

        public void MostrarCompras(KryptonButton btn)
        {
            clsConexion cn = new clsConexion();
            try
            {
                cn.Abrir();
                int total = ToInt(EjecutarScalar(cn, "SELECT COUNT(*) FROM COMPRAS"));
                int ultimoMes = ToInt(EjecutarScalar(cn,
                    "SELECT COUNT(*) FROM COMPRAS WHERE MONTH(fecha_pedido) = MONTH(GETDATE()) AND YEAR(fecha_pedido) = YEAR(GETDATE())"));
                string monto = EjecutarScalar(cn, "SELECT ISNULL(SUM(dc.cantidad * p.precio_costo), 0) FROM DETALLE_COMPRA dc JOIN PRODUCTO p ON dc.id_producto = p.id_producto");

                MostrarPopup(btn, "🛒 Compras Realizadas", total.ToString(),
                    "compras en total",
                    $"Último mes:    {ultimoMes}",
                    $"Monto total:   L. {ToDecimal(monto):N2}");
            }
            catch (Exception ex) { Error(ex); }
            finally { cn.Cerrar(); }
        }

        public void MostrarAgotados(KryptonButton btn)
        {
            clsConexion cn = new clsConexion();
            try
            {
                cn.Abrir();
                int agotados = ToInt(EjecutarScalar(cn, "SELECT COUNT(*) FROM PRODUCTO_SUCURSAL WHERE cantidad_stock = 0"));
                int enCamino = ToInt(EjecutarScalar(cn, "SELECT COUNT(*) FROM PRODUCTO_SUCURSAL WHERE cantidad_stock BETWEEN 1 AND 10"));
                int disponibles = ToInt(EjecutarScalar(cn, "SELECT COUNT(*) FROM PRODUCTO_SUCURSAL WHERE cantidad_stock > 10"));

                MostrarPopup(btn, "❌ Productos Agotados", agotados.ToString(),
                    "sin stock",
                    $"En camino:     {enCamino}",
                    $"Disponibles:   {disponibles}");
            }
            catch (Exception ex) { Error(ex); }
            finally { cn.Cerrar(); }
        }

        // ── Motor del popup ─────────────────────────────────────

        private void MostrarPopup(KryptonButton btn, string titulo, string numero, string subtitulo, string linea1, string linea2)
        {
            CerrarPopup();

            var panel = new Panel
            {
                Size = new Size(220, 150),
                BackColor = Color.White,
                Tag = "popup"
            };

            // Sombra simulada con borde
            panel.Paint += (s, e) =>
            {
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(200, 200, 200), 1),
                    0, 0, panel.Width - 1, panel.Height - 1);
            };

            // Título
            var lblTitulo = new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                ForeColor = Color.FromArgb(60, 60, 60),
                Location = new Point(10, 10),
                AutoSize = true
            };

            // Separador
            var separador = new Panel
            {
                Location = new Point(10, 32),
                Size = new Size(200, 1),
                BackColor = Color.FromArgb(220, 220, 220)
            };

            // Número grande
            var lblNumero = new Label
            {
                Text = numero,
                Font = new Font("Segoe UI", 22f, FontStyle.Bold),
                ForeColor = Color.FromArgb(139, 90, 43), // Color café del tema
                Location = new Point(10, 38),
                AutoSize = true
            };

            // Subtítulo
            var lblSub = new Label
            {
                Text = subtitulo,
                Font = new Font("Segoe UI", 8f),
                ForeColor = Color.Gray,
                Location = new Point(12, 75),
                AutoSize = true
            };

            // Línea 1
            var lblLinea1 = new Label
            {
                Text = linea1,
                Font = new Font("Segoe UI", 8.5f),
                ForeColor = Color.FromArgb(60, 60, 60),
                Location = new Point(10, 100),
                AutoSize = true
            };

            // Línea 2
            var lblLinea2 = new Label
            {
                Text = linea2,
                Font = new Font("Segoe UI", 8.5f),
                ForeColor = Color.FromArgb(60, 60, 60),
                Location = new Point(10, 120),
                AutoSize = true
            };

            panel.Controls.AddRange(new Control[]
            {
                lblTitulo, separador, lblNumero, lblSub, lblLinea1, lblLinea2
            });

            // Posición debajo del botón
            Point pos = btn.Parent.PointToScreen(btn.Location);
            pos = _form.PointToClient(pos);
            panel.Location = new Point(pos.X, pos.Y + btn.Height + 2);

            // Cerrar al hacer clic dentro del popup también
            panel.MouseClick += (s, e) => CerrarPopup();
            foreach (Control ctrl in panel.Controls)
                ctrl.MouseClick += (s, e) => CerrarPopup();

            _form.Controls.Add(panel);
            panel.BringToFront();
            _panelActivo = panel;
        }

        public void CerrarPopup()
        {
            if (_panelActivo != null)
            {
                _form.Controls.Remove(_panelActivo);
                _panelActivo.Dispose();
                _panelActivo = null;
            }
        }

        // ── Helpers ─────────────────────────────────────────────

        private string EjecutarScalar(clsConexion cn, string query)
        {
            SqlCommand cmd = new SqlCommand(query, cn.SqlC);
            object res = cmd.ExecuteScalar();
            return res == null || res == DBNull.Value ? "0" : res.ToString();
        }

        private int ToInt(string v) { return int.TryParse(v, out int r) ? r : 0; }
        private decimal ToDecimal(string v) { return decimal.TryParse(v, out decimal r) ? r : 0; }
        private void Error(Exception ex) { MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }
}
