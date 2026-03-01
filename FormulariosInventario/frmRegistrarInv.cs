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
    public partial class frmRegistrarInv : Form
    {

        byte[] imagenBytes;
        public frmRegistrarInv()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargarProveedores()
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();
            SqlCommand cmd = new SqlCommand("SELECT nombre_comercial_proveedor FROM PROVEEDOR", obj.SqlC);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbProveedor.Items.Add(dr["nombre_comercial_proveedor"].ToString());
            }
            obj.Cerrar();
        }

        private void CargarCategorias()
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();
            SqlCommand cmd = new SqlCommand("SELECT nombre_categoria FROM CATEGORIA", obj.SqlC);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCategoria.Items.Add(dr["nombre_categoria"].ToString());
            }
            obj.Cerrar();
        }

        private void CargarSucursales()
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();
            SqlCommand cmd = new SqlCommand("SELECT nombre_sucursal FROM SUCURSAL", obj.SqlC);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbSucursal.Items.Add(dr["nombre_sucursal"].ToString());
            }
            obj.Cerrar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();

            try
            {
                // Obtener ID de Categoría
                SqlCommand cmdCat = new SqlCommand("SELECT id_categoria FROM CATEGORIA WHERE nombre_categoria = @nombre", obj.SqlC);
                cmdCat.Parameters.AddWithValue("@nombre", cmbCategoria.SelectedItem.ToString());
                int idCategoria = (int)cmdCat.ExecuteScalar();

                // Obtener ID de Proveedor
                SqlCommand cmdProv = new SqlCommand("SELECT id_proveedor FROM PROVEEDOR WHERE nombre_comercial_proveedor = @nombre", obj.SqlC);
                cmdProv.Parameters.AddWithValue("@nombre", cmbProveedor.SelectedItem.ToString());
                int idProveedor = (int)cmdProv.ExecuteScalar();

                // Obtener ID de Sucursal
                SqlCommand cmdSuc = new SqlCommand("SELECT id_sucursal FROM SUCURSAL WHERE nombre_sucursal = @nombre", obj.SqlC);
                cmdSuc.Parameters.AddWithValue("@nombre", cmbSucursal.SelectedItem.ToString());
                int idSucursal = (int)cmdSuc.ExecuteScalar();

                // INSERT en PRODUCTO con imagen
                SqlCommand cmdProd = new SqlCommand("INSERT INTO PRODUCTO (nombre_producto, id_categoria, precio_unitario, precio_costo, imagen_producto) " +
                                                    "VALUES (@nombre, @idCat, @precio, @costo, @imagen); SELECT SCOPE_IDENTITY();", obj.SqlC);
                cmdProd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
                cmdProd.Parameters.AddWithValue("@idCat", idCategoria);
                cmdProd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text, System.Globalization.CultureInfo.InvariantCulture));
                cmdProd.Parameters.AddWithValue("@costo", decimal.Parse(txtPrecioCosto.Text, System.Globalization.CultureInfo.InvariantCulture));
                if (imagenBytes != null)
                    cmdProd.Parameters.Add("@imagen", System.Data.SqlDbType.VarBinary).Value = imagenBytes;
                else
                    cmdProd.Parameters.Add("@imagen", System.Data.SqlDbType.VarBinary).Value = DBNull.Value;
                int nuevoID = Convert.ToInt32(cmdProd.ExecuteScalar());

                // INSERT en PRODUCTO_PROVEEDOR
                SqlCommand cmdPP = new SqlCommand("INSERT INTO PRODUCTO_PROVEEDOR (id_producto, id_proveedor) " +
                                                  "VALUES (@idProd, @idProv)", obj.SqlC);
                cmdPP.Parameters.AddWithValue("@idProd", nuevoID);
                cmdPP.Parameters.AddWithValue("@idProv", idProveedor);
                cmdPP.ExecuteNonQuery();

                // INSERT en PRODUCTO_SUCURSAL
                SqlCommand cmdPS = new SqlCommand("INSERT INTO PRODUCTO_SUCURSAL (id_producto, id_sucursal, cantidad_stock) " +
                                                  "VALUES (@idProd, @idSuc, @stock)", obj.SqlC);
                cmdPS.Parameters.AddWithValue("@idProd", nuevoID);
                cmdPS.Parameters.AddWithValue("@idSuc", idSucursal);
                cmdPS.Parameters.AddWithValue("@stock", txtStockInicial.Text);
                cmdPS.ExecuteNonQuery();

                MessageBox.Show("Producto registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

        private void txtStockInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrarInv_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarCategorias();
            CargarSucursales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            openFile.Title = "Seleccionar imagen del producto";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imagenBytes = System.IO.File.ReadAllBytes(openFile.FileName);
                imgProducto.Image = Image.FromFile(openFile.FileName);
                imgProducto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
