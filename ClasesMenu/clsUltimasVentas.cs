using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TRAMADE.Formularios_Login__Menú
{
    internal class clsUltimasVentas
    {
        private readonly DataGridView _dgv;

        public clsUltimasVentas(DataGridView dgv)
        {
            _dgv = dgv;
        }

        public void Cargar()
        {
            clsConexion cn = new clsConexion();
            try
            {
                cn.Abrir();
                string query = @"
                    SELECT TOP 5
                        f.id_factura     AS 'ID Venta',
                        c.nombre_cliente AS 'Cliente',
                        SUM(fp.cantidad * p.precio_unitario) AS 'Monto',
                        f.fecha_emision  AS 'Fecha'
                    FROM FACTURA f
                    INNER JOIN CLIENTE c           ON f.id_cliente   = c.id_cliente
                    INNER JOIN FACTURA_PRODUCTO fp ON f.id_factura   = fp.id_factura
                    INNER JOIN PRODUCTO p          ON fp.id_producto = p.id_producto
                    GROUP BY f.id_factura, c.nombre_cliente, f.fecha_emision
                    ORDER BY f.fecha_emision DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, cn.SqlC);
                DataTable dt = new DataTable();
                da.Fill(dt);
                _dgv.DataSource = dt;
                EstiloGrid();
                _dgv.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
                _dgv.Columns["Monto"].DefaultCellStyle.Format = "L. #,##0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ventas: " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { cn.Cerrar(); }
        }

        private void EstiloGrid()
        {
            _dgv.EnableHeadersVisualStyles = false;
            _dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(139, 90, 43);
            _dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            _dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            _dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _dgv.DefaultCellStyle.Font = new Font("Segoe UI", 8.5f);
            _dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(212, 160, 48);
            _dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            _dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(253, 246, 238);
            _dgv.BorderStyle = BorderStyle.None;
            _dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            _dgv.GridColor = Color.FromArgb(220, 220, 220);
            _dgv.RowHeadersVisible = false;
            _dgv.ReadOnly = true;
            _dgv.AllowUserToAddRows = false;

            // 👇 Columnas con ancho proporcional
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            _dgv.Columns["ID Venta"].Width = 50;
            _dgv.Columns["Cliente"].FillWeight = 40;
            _dgv.Columns["Monto"].Width = 110;
            _dgv.Columns["Fecha"].Width = 90;
            _dgv.Columns["Cliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}