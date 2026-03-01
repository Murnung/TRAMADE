using OfficeOpenXml;
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

namespace TRAMADE
{
    public partial class frmInventario : Form
    {
        string connectionString = "Server=db-tramade;Database=DB_TRAMADE;Integrated Security=True;";
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
            CargarProductos();

            cmbFiltrar.Items.Add("Orden Alfabético");
            cmbFiltrar.Items.Add("Categoría");
            cmbFiltrar.Items.Add("Sucursal");
            cmbFiltrar.Items.Add("Proveedor");
            cmbFiltrar.Items.Add("Mayor Stock");
            cmbFiltrar.Items.Add("Menor Stock");


            lblFecha.Text = DateTime.Now.ToString("dd/MM/yy");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timer1.Start();
        }

        private void CargarProductos()
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();

            SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM VistaProductosDetalle", obj.SqlC);
            int totalRegistros = (int)cmdCount.ExecuteScalar();
            totalPaginas = (int)Math.Ceiling((double)totalRegistros / registrosPorPagina);
            lblPagina.Text = "Página " + paginaActual + " de " + totalPaginas;

            int offset = (paginaActual - 1) * registrosPorPagina;
            SqlCommand cmd = new SqlCommand("SELECT * FROM VistaProductosDetalle " + filtroActual + " OFFSET @offset ROWS FETCH NEXT @cantidad ROWS ONLY", obj.SqlC);
            cmd.Parameters.AddWithValue("@offset", offset);
            cmd.Parameters.AddWithValue("@cantidad", registrosPorPagina);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvInventario.DataSource = dt;

            obj.Cerrar();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrarInv frm = new frmRegistrarInv();
            frm.ShowDialog();
            CargarProductos(); // Recarga el DGV después de registrar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProducto = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells[0].Value);

            DialogResult confirmacion = MessageBox.Show("¿Estás seguro que deseas eliminar este producto?",
                                                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacion == DialogResult.Yes)
            {
                clsConexion obj = new clsConexion();
                obj.Abrir();

                try
                {
                    // Eliminar de PRODUCTO_PROVEEDOR primero
                    SqlCommand cmdPP = new SqlCommand("DELETE FROM PRODUCTO_PROVEEDOR WHERE id_producto = @id", obj.SqlC);
                    cmdPP.Parameters.AddWithValue("@id", idProducto);
                    cmdPP.ExecuteNonQuery();

                    // Eliminar de PRODUCTO_SUCURSAL
                    SqlCommand cmdPS = new SqlCommand("DELETE FROM PRODUCTO_SUCURSAL WHERE id_producto = @id", obj.SqlC);
                    cmdPS.Parameters.AddWithValue("@id", idProducto);
                    cmdPS.ExecuteNonQuery();

                    // Eliminar de PRODUCTO
                    SqlCommand cmdProd = new SqlCommand("DELETE FROM PRODUCTO WHERE id_producto = @id", obj.SqlC);
                    cmdProd.Parameters.AddWithValue("@id", idProducto);
                    cmdProd.ExecuteNonQuery();

                    MessageBox.Show("Producto eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    obj.Cerrar();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProducto = Convert.ToInt32(dgvInventario.SelectedRows[0].Cells[0].Value);
            frmEditarInv frm = new frmEditarInv(idProducto);
            frm.ShowDialog();
            CargarProductos();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (paginaActual < totalPaginas)
            {
                paginaActual++;
                CargarProductos();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                CargarProductos();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                CargarProductos();
                return;
            }

            clsConexion obj = new clsConexion();
            obj.Abrir();

            SqlCommand cmd;

            int idBuscar;
            if (int.TryParse(txtBuscar.Text, out idBuscar))
            {
                cmd = new SqlCommand("SELECT * FROM VistaProductosDetalle WHERE ID = @buscar", obj.SqlC);
                cmd.Parameters.AddWithValue("@buscar", idBuscar);
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM VistaProductosDetalle WHERE Nombre = @buscarNombre", obj.SqlC);
                cmd.Parameters.AddWithValue("@buscarNombre", txtBuscar.Text);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvInventario.DataSource = dt;

            obj.Cerrar();
        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            cmbFiltrar.SelectedIndex = -1;
            filtroActual = "ORDER BY ID ASC";
            paginaActual = 1;
            CargarProductos();
        }

        private void btnExportarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Excel Files|*.xlsx";
                saveFile.FileName = "Inventario";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.License.SetNonCommercialPersonal("TRAMADE");

                    // Traer TODOS los datos de la BD
                    clsConexion obj = new clsConexion();
                    obj.Abrir();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM VistaProductosDetalle " + filtroActual, obj.SqlC);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    obj.Cerrar();

                    using (ExcelPackage excel = new ExcelPackage())
                    {
                        ExcelWorksheet hoja = excel.Workbook.Worksheets.Add("Inventario");

                        // Encabezados
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            hoja.Cells[1, i + 1].Value = dt.Columns[i].ColumnName;
                            hoja.Cells[1, i + 1].Style.Font.Bold = true;
                            hoja.Cells[1, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            hoja.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Brown);
                            hoja.Cells[1, i + 1].Style.Font.Color.SetColor(System.Drawing.Color.White);
                        }

                        // Datos
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            for (int j = 0; j < dt.Columns.Count; j++)
                            {
                                hoja.Cells[i + 2, j + 1].Value = dt.Rows[i][j];
                            }
                        }

                        hoja.Cells.AutoFitColumns();
                        excel.SaveAs(new System.IO.FileInfo(saveFile.FileName));
                    }

                    MessageBox.Show("Inventario exportado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yy");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
