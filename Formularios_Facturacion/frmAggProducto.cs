using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE
{
    public partial class frmAggProducto : Form
    {
        Dictionary<string, int> cantidadesTemporales = new Dictionary<string, int>();
        bool editandoCelda = false; // Bandera ninja para evitar ciclos infinitos al autocorregir

        public frmAggProducto()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos(string filtro = "")
        {
            try
            {
                dgvProductos.Rows.Clear();
                clsProductoF objProducto = new clsProductoF();
                List<clsProductoF> listaProductos = objProducto.ObtenerProductos(filtro);

                foreach (var prod in listaProductos)
                {
                    int indice = dgvProductos.Rows.Add();

                    dgvProductos.Rows[indice].Cells[0].Value = prod.id_producto.ToString();
                    dgvProductos.Rows[indice].Cells[1].Value = prod.nombre_producto;
                    dgvProductos.Rows[indice].Cells[2].Value = "N/A"; // Tu descripción

                    // MAGIA: Ahora usa el stock real de la tabla PRODUCTO_SUCURSAL
                    dgvProductos.Rows[indice].Cells[3].Value = prod.existencia_producto.ToString();

                    dgvProductos.Rows[indice].Cells[4].Value = prod.precio_unitario.ToString();

                    // Mantiene en memoria lo que ya habías tipeado si usás el buscador
                    string idStr = prod.id_producto.ToString();
                    if (cantidadesTemporales.ContainsKey(idStr))
                    {
                        dgvProductos.Rows[indice].Cells[5].Value = cantidadesTemporales[idStr].ToString();
                    }
                    else
                    {
                        dgvProductos.Rows[indice].Cells[5].Value = "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el catálogo: " + ex.Message);
            }
        }

        private void frmAggProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(txtBuscarProducto.Text.Trim());
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- BOTÓN SELECCIONAR (Con Sumatoria y Validación de Stock) ---
        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            frmFacturacion principal = Application.OpenForms.OfType<frmFacturacion>().FirstOrDefault();

            if (principal != null)
            {
                bool huboErrorStock = false; // Para no cerrar la ventana si se equivocó de cantidad

                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    if (fila.Cells[1].Value != null)
                    {
                        int cantidadNueva = 0;
                        int.TryParse(fila.Cells[5].Value?.ToString(), out cantidadNueva);

                        if (cantidadNueva > 0)
                        {
                            string idProdNuevo = fila.Cells[0].Value.ToString();
                            string nombreProd = fila.Cells[1].Value.ToString();
                            decimal precioProd = Convert.ToDecimal(fila.Cells[4].Value);
                            int stockDisponible = Convert.ToInt32(fila.Cells[3].Value);

                            bool productoYaExiste = false;

                            // 1. Buscamos si el producto ya está metido en la factura principal
                            foreach (DataGridViewRow filaPrincipal in principal.dgvDetalleFactura.Rows)
                            {
                                if (filaPrincipal.Cells[0].Value != null && !filaPrincipal.IsNewRow)
                                {
                                    string idProdExistente = filaPrincipal.Cells[0].Value.ToString();

                                    if (idProdNuevo == idProdExistente)
                                    {
                                        // Si ya existe, SUMAMOS las cantidades
                                        int cantidadExistente = Convert.ToInt32(filaPrincipal.Cells[3].Value);
                                        int cantidadTotal = cantidadExistente + cantidadNueva;

                                        // VALIDACIÓN: ¿La suma se pasa del inventario?
                                        if (cantidadTotal > stockDisponible)
                                        {
                                            MessageBox.Show($"Stock insuficiente para '{nombreProd}'. Ya tiene {cantidadExistente} en factura y quiere agregar {cantidadNueva} más. Solo hay {stockDisponible} disponibles.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            productoYaExiste = true;
                                            huboErrorStock = true;
                                            break; // Detiene este producto y sigue con los demás
                                        }

                                        // Si sí hay stock, actualizamos la fila existente
                                        filaPrincipal.Cells[3].Value = cantidadTotal;
                                        decimal nuevoSubtotal = precioProd * cantidadTotal;
                                        filaPrincipal.Cells[5].Value = nuevoSubtotal.ToString("N2");

                                        productoYaExiste = true;
                                        break;
                                    }
                                }
                            }

                            // 2. Si es un producto totalmente nuevo en la factura
                            if (!productoYaExiste)
                            {
                                // VALIDACIÓN: ¿Lo tipeado se pasa del inventario?
                                if (cantidadNueva > stockDisponible)
                                {
                                    MessageBox.Show($"No puede agregar {cantidadNueva} unidades de '{nombreProd}'. Solo hay {stockDisponible} en stock.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    huboErrorStock = true;
                                }
                                else
                                {
                                    decimal subtotalNuevo = precioProd * cantidadNueva;
                                    principal.dgvDetalleFactura.Rows.Add(idProdNuevo, nombreProd, "Unidad", cantidadNueva, precioProd.ToString("N2"), subtotalNuevo.ToString("N2"));
                                }
                            }
                        }
                    }
                }

                principal.CalcularTotales();

                // Si todo salió bien y no hay errores de stock, cerramos esta ventana
                if (!huboErrorStock)
                {
                    this.Close();
                }
            }
        }

        // --- VALIDACIONES DE ESCRITURA MANUAL EN LA CELDA ---
        private void dgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                dgvProductos.BeginEdit(true);
            }
        }

        private void dgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Evitamos que este evento se llame a sí mismo infinitamente
            if (editandoCelda) return;

            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                editandoCelda = true;

                try
                {
                    string id = dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int cantidad = 0;
                    string valorIngresado = dgvProductos.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? "0";

                    // 1. Validar que no escriban texto/letras (lo vuelve a 0)
                    if (!int.TryParse(valorIngresado, out cantidad))
                    {
                        dgvProductos.Rows[e.RowIndex].Cells[5].Value = "0";
                        cantidad = 0;
                    }

                    // 2. Validar que no escriban cantidades negativas (lo vuelve a 0)
                    if (cantidad < 0)
                    {
                        dgvProductos.Rows[e.RowIndex].Cells[5].Value = "0";
                        cantidad = 0;
                        MessageBox.Show("La cantidad no puede ser negativa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // 3. Validar de un solo que no se pase del stock visual
                    int stockDisponible = 0;
                    if (dgvProductos.Rows[e.RowIndex].Cells[3].Value != null)
                    {
                        int.TryParse(dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString(), out stockDisponible);
                    }

                    if (cantidad > stockDisponible)
                    {
                        dgvProductos.Rows[e.RowIndex].Cells[5].Value = stockDisponible.ToString();
                        cantidad = stockDisponible;
                        MessageBox.Show($"Solo hay {stockDisponible} unidades de este producto en existencia. Se ajustó automáticamente.", "Stock Limitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Guarda en memoria temporal por si usa la barra de búsqueda
                    cantidadesTemporales[id] = cantidad;
                }
                finally
                {
                    editandoCelda = false;
                }
            }
        }

        private void dgvProductos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false; // Silencia los errores internos molestos del Grid
        }

        private void kryptonGroup3_Panel_Paint(object sender, PaintEventArgs e) { }
        private void kryptonButton2_Click(object sender, EventArgs e) { }

        // Botón de Limpiar Búsqueda
        private void kryptonButton2_Click_1(object sender, EventArgs e)
        {
            txtBuscarProducto.Text = "";
        }

        private void kryptonGroup1_Paint(object sender, PaintEventArgs e) { }
        private void kryptonGroup1_Panel_Paint(object sender, PaintEventArgs e) { }

        // Función fantasma para que el Diseñador no llore
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // No hace nada, solo está aquí para quitar el error CS1061
        }
    }


}
