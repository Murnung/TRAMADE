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
    public partial class frmAggProducto : Form
    {
        // Esto guarda: [ID del Producto, Cantidad]
        Dictionary<string, int> cantidadesTemporales = new Dictionary<string, int>();

        // 1. Este es el constructor (solo inicializa los componentes)
        public frmAggProducto()
        {
            InitializeComponent();
            CargarProductos();
        } // <--- ¡AQUÍ CERRAMOS EL CONSTRUCTOR!

        // 2. Este es tu método para cargar (ahora está AFUERA del constructor, donde debe ir)
        private void CargarProductos(string filtro = "")
        {
            try
            {
                // Limpiamos la tablita para que no se dupliquen los datos al buscar
                dgvProductos.Rows.Clear();

                clsConexion ObjConexion = new clsConexion();
                ObjConexion.Abrir();

                // Armamos el SELECT básico
                string consulta = "SELECT id_producto, nombre_producto, precio_unitario FROM PRODUCTO";

                // Si el usuario escribió algo en el buscador, le agregamos la condición LIKE
                if (filtro != "")
                {
                    consulta += " WHERE nombre_producto LIKE @filtro";
                }

                SqlCommand cmd = new SqlCommand(consulta, ObjConexion.SqlC);

                if (filtro != "")
                {
                    // El símbolo % sirve para buscar esa palabra en cualquier parte del nombre
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                }

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int indice = dgvProductos.Rows.Add();

                    // Llenamos las 5 columnas de texto que quedaron
                    dgvProductos.Rows[indice].Cells[0].Value = dr["id_producto"].ToString();
                    dgvProductos.Rows[indice].Cells[1].Value = dr["nombre_producto"].ToString();
                    dgvProductos.Rows[indice].Cells[2].Value = "N/A"; // Descripción
                    dgvProductos.Rows[indice].Cells[3].Value = "100"; // Stock
                    dgvProductos.Rows[indice].Cells[4].Value = dr["precio_unitario"].ToString();

                    // Ahora la Cantidad es la columna 5 (porque borramos las imágenes)
                    dgvProductos.Rows[indice].Cells[5].Value = "0";
                }

                dr.Close();
                ObjConexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el catálogo: " + ex.Message);
            }
        }

        // 3. Los demás eventos siguen normales abajo
        private void frmAggProducto_Load(object sender, EventArgs e)
        {
            // Cargamos todo el catálogo sin filtros
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

        private void kryptonGroup3_Panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
        }

        private void kryptonGroup1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void kryptonGroup1_Panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Usamos tus números confirmados
                int colMas = 5;
                int colCantidad = 6;
                int colMenos = 7;

                if (e.ColumnIndex == colMas || e.ColumnIndex == colMenos)
                {
                    int cantidadActual = 0;

                    // Leemos el valor
                    var valorCelda = dgvProductos.Rows[e.RowIndex].Cells[colCantidad].Value;
                    if (valorCelda != null)
                    {
                        int.TryParse(valorCelda.ToString(), out cantidadActual);
                    }

                    // Matemática
                    if (e.ColumnIndex == colMas)
                    {
                        cantidadActual++;
                    }
                    else if (e.ColumnIndex == colMenos)
                    {
                        if (cantidadActual > 0) cantidadActual--;
                    }

                    // Escribimos el nuevo valor
                    dgvProductos.Rows[e.RowIndex].Cells[colCantidad].Value = cantidadActual.ToString();

                    // ¡ESTO ES LO NUEVO! Obligamos a la tabla a repintarse para que veas el cambio
                    dgvProductos.RefreshEdit();
                    dgvProductos.EndEdit();
                }
            }
        }

        private void kryptonButton2_Click_1(object sender, EventArgs e)
        {
            txtBuscarProducto.Text = "";
        }

        private void dgvProductos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // No hacemos nada. Esto silencia el cuadro de error que te sale.
            e.ThrowException = false;
        }

        private void btnSeleccionarProducto_Click(object sender, EventArgs e)
        {
            frmFacturacion principal = Application.OpenForms.OfType<frmFacturacion>().FirstOrDefault();

            if (principal != null)
            {
                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    if (fila.Cells[1].Value != null)
                    {
                        int cantidad = 0;
                        int.TryParse(fila.Cells[5].Value.ToString(), out cantidad);

                        if (cantidad > 0)
                        {
                            // CAPTURAMOS EL ID (Está en la columna 0 de este grid)
                            string id = fila.Cells[0].Value.ToString();
                            string nombre = fila.Cells[1].Value.ToString();
                            decimal precio = Convert.ToDecimal(fila.Cells[4].Value);
                            decimal subtotal = precio * cantidad;

                            // IMPORTANTE: Ahora mandamos 6 datos. El primero es el ID.
                            principal.dgvDetalleFactura.Rows.Add(id, nombre, "Unidad", cantidad, precio.ToString("N2"), subtotal.ToString("N2"));
                            principal.CalcularTotales();
                        }
                    }
                }
                this.Close();
            }
        }

        private void dgvProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                dgvProductos.BeginEdit(true); // Inicia la edición de un solo
            }
        }

        private void dgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Si cambió la columna de cantidad (la 5) y no es el título
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                string id = dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                int cantidad = 0;
                int.TryParse(dgvProductos.Rows[e.RowIndex].Cells[5].Value.ToString(), out cantidad);

                // Guardamos o actualizamos en nuestra memoria
                cantidadesTemporales[id] = cantidad;
            }
        }
    }
}