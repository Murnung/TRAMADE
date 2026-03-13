using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.Formulario_Proveedores.Clases
{
    internal class clsDataGridView
    {
        // ─── APLICAR ESTILO ESTÁNDAR ──────────────────────────────────
        public static void AplicarEstilo(DataGridView dgv)
        {
            // ─── COMPORTAMIENTO ───────────────────────────────────────
            dgv.ReadOnly = true;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // ─── ENCABEZADOS ──────────────────────────────────────────
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(148, 114, 71);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10f, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;  // ← nueva
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize; // ← cambiada
            dgv.RowHeadersVisible = false;

            // ─── FILAS ────────────────────────────────────────────────
            dgv.DefaultCellStyle.Font = new Font("Poppins", 9f, FontStyle.Regular);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgv.RowTemplate.Height = 35;

            // ─── SELECCIÓN ────────────────────────────────────────────
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 154, 111);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // ─── BORDES Y GRILLA ──────────────────────────────────────
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.FromArgb(220, 210, 195);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            // ─── COLUMNAS AUTO-AJUSTE ─────────────────────────────────
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ─── OCULTAR COLUMNA POR NOMBRE ──────────────────────────────
        public static void OcultarColumna(DataGridView dgv, string nombreColumna)
        {
            if (dgv.Columns[nombreColumna] != null)
                dgv.Columns[nombreColumna].Visible = false;
        }

        // ─── CARGAR DATOS DESDE VISTA O CONSULTA ─────────────────────
        public static void Cargar(DataGridView dgv, string consulta, SqlConnection conexion,
                                  params string[] columnasOcultas)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv.DataSource = dt;

                foreach (string col in columnasOcultas)
                    if (dgv.Columns[col] != null)
                        dgv.Columns[col].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── FILTRAR POR TEXTO (BÚSQUEDA EN TIEMPO REAL) ─────────────
        public static void Buscar(DataGridView dgv, string textoBuscar, string consulta,
                                  SqlConnection conexion, params string[] columnasOcultas)
        {
            if (string.IsNullOrWhiteSpace(textoBuscar))
            {
                Cargar(dgv, consulta, conexion, columnasOcultas);
                return;
            }

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataView dv = dt.DefaultView;

                string filtro = string.Empty;
                foreach (DataColumn col in dt.Columns)
                {
                    if (col.DataType == typeof(string))
                        filtro += $"[{col.ColumnName}] LIKE '%{textoBuscar.Replace("'", "''")}%' OR ";
                }
                if (!string.IsNullOrEmpty(filtro))
                    dv.RowFilter = filtro.TrimEnd(' ', 'O', 'R');

                dgv.DataSource = dv.ToTable();

                foreach (string col in columnasOcultas)
                    if (dgv.Columns[col] != null)
                        dgv.Columns[col].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── FILTRAR POR ESTADO (ACTIVO / INACTIVO) ───────────────────
        public static void FiltrarPorEstado(DataGridView dgv, string consulta,
                                            SqlConnection conexion, string estado,
                                            params string[] columnasOcultas)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataView dv = dt.DefaultView;
                dv.RowFilter = $"estado = '{estado}'";

                dgv.DataSource = dv.ToTable();

                foreach (string col in columnasOcultas)
                    if (dgv.Columns[col] != null)
                        dgv.Columns[col].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── OBTENER ID DE LA FILA SELECCIONADA ──────────────────────
        public static int ObtenerIdFila(DataGridView dgv, int columnaId = 0)
        {
            if (dgv.CurrentRow == null) return -1;
            return Convert.ToInt32(dgv.Rows[dgv.CurrentRow.Index].Cells[columnaId].Value);
        }

        // ─── OBTENER ID POR DOBLE CLIC ────────────────────────────────
        public static int ObtenerIdDobleClick(DataGridView dgv,
                                              DataGridViewCellEventArgs e, int columnaId = 0)
        {
            if (e.RowIndex < 0) return -1;
            return Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[columnaId].Value);
        }

        public static void AgregarColumnaCheckbox(DataGridView dgv)
        {
            if (!dgv.Columns.Contains("Seleccionar"))
            {
                DataGridViewCheckBoxColumn chkCol = new DataGridViewCheckBoxColumn();
                chkCol.Name = "Seleccionar";
                chkCol.HeaderText = "✔";
                chkCol.Width = 40;
                chkCol.ReadOnly = false;
                chkCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns.Add(chkCol);
            }


            // ─── Permitir edición solo en checkbox ────────────────────
            dgv.ReadOnly = false;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Name != "Seleccionar")
                    col.ReadOnly = true;
            }
        }
    }
}
