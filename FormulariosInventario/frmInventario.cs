using OfficeOpenXml;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TRAMADE.ClasesInventario;

namespace TRAMADE
{
    public partial class frmInventario : Form
    {
        int paginaActual = 1;
        int registrosPorPagina = 20;
        int totalPaginas;
        string filtroActual = "ORDER BY ID ASC";

        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            dgvInventario.ReadOnly = true;
            dgvInventario.AllowUserToResizeRows = false;
            dgvInventario.AllowUserToResizeColumns = false;
            dgvInventario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(148, 114, 71);
            dgvInventario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInventario.EnableHeadersVisualStyles = false;
            dgvInventario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 154, 111);
            dgvInventario.DefaultCellStyle.SelectionForeColor = Color.White;

            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            CargarProductos();

            cmbFiltrar.Items.Add("Orden Alfabético");
            cmbFiltrar.Items.Add("Categoría");
            cmbFiltrar.Items.Add("Sucursal");
            cmbFiltrar.Items.Add("Proveedor");
            cmbFiltrar.Items.Add("Mayor Stock");
            cmbFiltrar.Items.Add("Menor Stock");

            timer1.Start();
        }

        private void CargarProductos()
        {
            int totalRegistros = clsProductoDAL.ContarProductos();
            totalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);
            lblPagina.Text = "Página " + paginaActual + " de " + totalPaginas;

            DataTable dt = clsProductoDAL.ObtenerProductos(filtroActual, paginaActual, registrosPorPagina);
            dgvInventario.DataSource = dt;
            dgvInventario.Columns["imagen_producto"].Visible = false;
            dgvInventario.AllowUserToResizeColumns = false;
            dgvInventario.AllowUserToResizeRows = false;
            dgvInventario.ReadOnly = true;

            AplicarAlertas();

            if (dgvInventario.Rows.Count == 0)
                clsMensajes.Aviso("No hay productos registrados");
        }

        private void AplicarAlertas()
        {
            if (!dgvInventario.Columns.Contains("Alerta"))
            {
                DataGridViewTextBoxColumn colAlerta = new DataGridViewTextBoxColumn();
                colAlerta.Name = "Alerta";
                colAlerta.HeaderText = "Alerta";
                dgvInventario.Columns.Add(colAlerta);
            }

            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                int stock = Convert.ToInt32(row.Cells["Stock"].Value);
                if (stock <= 10)
                {
                    row.Cells["Alerta"].Value = "● Crítico";
                    row.Cells["Alerta"].Style.ForeColor = Color.Red;
                    row.Cells["Alerta"].Style.Font = new Font(dgvInventario.Font, FontStyle.Bold);
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220);
                }
                else if (stock <= 50)
                {
                    row.Cells["Alerta"].Value = "● Bajo";
                    row.Cells["Alerta"].Style.ForeColor = Color.Orange;
                    row.Cells["Alerta"].Style.Font = new Font(dgvInventario.Font, FontStyle.Bold);
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
                }
                else
                {
                    row.Cells["Alerta"].Value = "● Normal";
                    row.Cells["Alerta"].Style.ForeColor = Color.Green;
                    row.Cells["Alerta"].Style.Font = new Font(dgvInventario.Font, FontStyle.Bold);
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void dgvInventario_SelectionChanged(object sender, EventArgs e)
        {
            bool haySeleccion = dgvInventario.SelectedRows.Count > 0;
            btnEditar.Enabled = haySeleccion;
            btnEliminar.Enabled = haySeleccion;

            if (haySeleccion)
            {
                string nombre = dgvInventario.SelectedRows[0].Cells["Nombre"].Value?.ToString();
                lblNombreProducto.Text = nombre;

                object imagenObj = dgvInventario.SelectedRows[0].Cells["imagen_producto"].Value;
                if (imagenObj != null && imagenObj != DBNull.Value)
                {
                    byte[] imagenBytes = (byte[])imagenObj;
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBytes))
                    {
                        imgProducto.Image = Image.FromStream(ms);
                        imgProducto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                else
                {
                    imgProducto.Image = Properties.Resources.photo_8924441;
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrarInv frm = new frmRegistrarInv();
            frm.ShowDialog();
            CargarProductos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count == 0)
            {
                clsMensajes.Aviso("Selecciona un producto para editar");
                return;
            }

            int idProducto = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells["ID"].Value);
            frmEditarInv frm = new frmEditarInv(idProducto);
            frm.ShowDialog();
            CargarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count == 0)
            {
                clsMensajes.Aviso("Selecciona un producto para eliminar");
                return;
            }

            int idProducto = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells["ID"].Value);

            if (clsMensajes.Confirmar("¿Estás seguro que deseas eliminar este producto?"))
            {
                try
                {
                    clsProductoDAL.EliminarProducto(idProducto);
                    clsMensajes.Exito("Producto eliminado correctamente");
                    CargarProductos();
                }
                catch (Exception ex)
                {
                    clsMensajes.Error("Error: " + ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                CargarProductos();
                return;
            }

            DataTable dt = clsProductoDAL.BuscarProductos(txtBuscar.Text);
            dgvInventario.DataSource = dt;
            dgvInventario.Columns["imagen_producto"].Visible = false;
            AplicarAlertas();

            if (dgvInventario.Rows.Count == 0)
                clsMensajes.Aviso("No se encontraron resultados para: " + txtBuscar.Text);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            cmbFiltrar.SelectedIndex = -1;
            filtroActual = "ORDER BY ID ASC";
            paginaActual = 1;
            CargarProductos();
        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrar.SelectedItem == null) return;

            switch (cmbFiltrar.SelectedItem.ToString())
            {
                case "Orden Alfabético":
                    filtroActual = "ORDER BY Nombre ASC";
                    break;
                case "Categoría":
                    filtroActual = "ORDER BY Categoría ASC";
                    break;
                case "Sucursal":
                    filtroActual = "ORDER BY Sucursal ASC";
                    break;
                case "Proveedor":
                    filtroActual = "ORDER BY Proveedor ASC";
                    break;
                case "Mayor Stock":
                    filtroActual = "ORDER BY Stock DESC";
                    break;
                case "Menor Stock":
                    filtroActual = "ORDER BY Stock ASC";
                    break;
            }

            paginaActual = 1;
            CargarProductos();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (paginaActual < totalPaginas)
            {
                paginaActual++;
                CargarProductos();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                CargarProductos();
            }
        }

        private void btnExportarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Excel Files|*.xlsx";
                saveFile.FileName = "Inventario_" + DateTime.Now.ToString("dd-MM-yyyy");

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.License.SetNonCommercialPersonal("TRAMADE");

                    clsConexion obj = new clsConexion();
                    obj.Abrir();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM VistaProductosDetalle " + filtroActual, obj.SqlC);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    obj.Cerrar();

                    if (dt.Columns.Contains("imagen_producto"))
                        dt.Columns.Remove("imagen_producto");

                    using (ExcelPackage excel = new ExcelPackage())
                    {
                        ExcelWorksheet hoja = excel.Workbook.Worksheets.Add("Inventario");

                        hoja.Cells[1, 1].Value = "Fecha de exportación: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        hoja.Cells[1, 1].Style.Font.Bold = true;
                        hoja.Cells[1, 1, 1, dt.Columns.Count].Merge = true;

                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            hoja.Cells[2, i + 1].Value = dt.Columns[i].ColumnName;
                            hoja.Cells[2, i + 1].Style.Font.Bold = true;
                            hoja.Cells[2, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            hoja.Cells[2, i + 1].Style.Fill.BackgroundColor.SetColor(Color.Brown);
                            hoja.Cells[2, i + 1].Style.Font.Color.SetColor(Color.White);
                        }

                        for (int i = 0; i < dt.Rows.Count; i++)
                            for (int j = 0; j < dt.Columns.Count; j++)
                                hoja.Cells[i + 3, j + 1].Value = dt.Rows[i][j];

                        hoja.Cells.AutoFitColumns();
                        excel.SaveAs(new System.IO.FileInfo(saveFile.FileName));
                    }

                    clsMensajes.Exito("Inventario exportado correctamente");
                }
            }
            catch (Exception ex)
            {
                clsMensajes.Error("Error: " + ex.Message);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yy");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) { }
        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void lblFecha_Click(object sender, EventArgs e) { }
        private void lblHora_Click(object sender, EventArgs e) { }
    }
}