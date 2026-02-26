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
    internal class clsUltimasCompras
    {
        private readonly DataGridView _dgv;

        public clsUltimasCompras(DataGridView dgv)
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
                        c.id_compra      AS 'ID Compra',
                        p.nombre_comercial_proveedor AS 'Proveedor',
                        SUM(dc.cantidad * pr.precio_costo) AS 'Monto',
                        c.fecha_pedido   AS 'Fecha'
                    FROM COMPRAS c
                    INNER JOIN PROVEEDOR p  ON c.id_proveedor  = p.id_proveedor
                    INNER JOIN DETALLE_COMPRA dc ON c.id_compra = dc.id_compra
                    INNER JOIN PRODUCTO pr  ON dc.id_producto  = pr.id_producto
                    GROUP BY c.id_compra, p.nombre_comercial_proveedor, c.fecha_pedido
                    ORDER BY c.fecha_pedido DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, cn.SqlC);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Formatear fecha y monto
                foreach (DataRow row in dt.Rows)
                {
                    row["Fecha"] = Convert.ToDateTime(row["Fecha"]).ToString("dd/MM/yyyy");
                    row["Monto"] = $"L. {Convert.ToDecimal(row["Monto"]):N2}";
                }

                _dgv.DataSource = dt;
                EstiloGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error compras: " + ex.Message, "ERROR",
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
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgv.ReadOnly = true;
            _dgv.AllowUserToAddRows = false;
        }
    }
}
