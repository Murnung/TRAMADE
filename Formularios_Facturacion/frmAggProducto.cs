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

        Dictionary<string, int> cantidadesTemporales = new Dictionary<string, int>();


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

                clsConexion ObjConexion = new clsConexion();
                ObjConexion.Abrir();

                string consulta = "SELECT id_producto, nombre_producto, precio_unitario FROM PRODUCTO";

  
                if (filtro != "")
                {
                    consulta += " WHERE nombre_producto LIKE @filtro";
                }

                SqlCommand cmd = new SqlCommand(consulta, ObjConexion.SqlC);

                if (filtro != "")
                {
        
                    cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                }

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int indice = dgvProductos.Rows.Add();

     
                    dgvProductos.Rows[indice].Cells[0].Value = dr["id_producto"].ToString();
                    dgvProductos.Rows[indice].Cells[1].Value = dr["nombre_producto"].ToString();
                    dgvProductos.Rows[indice].Cells[2].Value = "N/A"; 
                    dgvProductos.Rows[indice].Cells[3].Value = "100"; 
                    dgvProductos.Rows[indice].Cells[4].Value = dr["precio_unitario"].ToString();

            
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

                int colMas = 5;
                int colCantidad = 6;
                int colMenos = 7;

                if (e.ColumnIndex == colMas || e.ColumnIndex == colMenos)
                {
                    int cantidadActual = 0;


                    var valorCelda = dgvProductos.Rows[e.RowIndex].Cells[colCantidad].Value;
                    if (valorCelda != null)
                    {
                        int.TryParse(valorCelda.ToString(), out cantidadActual);
                    }


                    if (e.ColumnIndex == colMas)
                    {
                        cantidadActual++;
                    }
                    else if (e.ColumnIndex == colMenos)
                    {
                        if (cantidadActual > 0) cantidadActual--;
                    }


                    dgvProductos.Rows[e.RowIndex].Cells[colCantidad].Value = cantidadActual.ToString();

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

                            string id = fila.Cells[0].Value.ToString();
                            string nombre = fila.Cells[1].Value.ToString();
                            decimal precio = Convert.ToDecimal(fila.Cells[4].Value);
                            decimal subtotal = precio * cantidad;


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
                dgvProductos.BeginEdit(true); 
            }
        }

        private void dgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                string id = dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                int cantidad = 0;
                int.TryParse(dgvProductos.Rows[e.RowIndex].Cells[5].Value.ToString(), out cantidad);


                cantidadesTemporales[id] = cantidad;
            }
        }
    }
}