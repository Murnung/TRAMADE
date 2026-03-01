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

                // Leemos fila por fila y la metemos a tu DataGridView
                while (dr.Read())
                {
                    // OJO: El orden de estos datos debe coincidir con las columnas de tu diseño.
                    dgvProductos.Rows.Add(
                        dr["id_producto"].ToString(),
                        dr["nombre_producto"].ToString(),
                        "N/A", // Descripción 
                        "100", // Cantidad en stock (Temporal)
                        dr["precio_unitario"].ToString(),
                        "0"    // Cantidad por defecto
                    );
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
            // Verificamos que no le hayan dado clic a los títulos de arriba
            if (e.RowIndex >= 0)
            {
                // === COLOCA AQUÍ TU NÚMERO DE COLUMNA DE CANTIDAD ===
                int columnaCantidad = 6;

                // Agarramos el número que está escrito ahorita (empezará en 0)
                int cantidadActual = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells[columnaCantidad].Value);

                // Si le dio clic a la columna de la IMAGEN DE SUMAR (+)
                // === CAMBIA EL 7 POR TU COLUMNA DEL MÁS ===
                if (e.ColumnIndex == 7)
                {
                    cantidadActual++;
                }
                // Si le dio clic a la columna de la IMAGEN DE RESTAR (-)
                // === CAMBIA EL 5 POR TU COLUMNA DEL MENOS ===
                else if (e.ColumnIndex == 5)
                {
                    if (cantidadActual > 0)
                    {
                        cantidadActual--; // Le restamos 1 solo si es mayor a cero
                    }
                }

                // Devolvemos el número actualizado a la celda para que el usuario lo vea
                dgvProductos.Rows[e.RowIndex].Cells[columnaCantidad].Value = cantidadActual.ToString();
            }
        }

        private void kryptonButton2_Click_1(object sender, EventArgs e)
        {
            txtBuscarProducto.Text = "";
        }
    }
}