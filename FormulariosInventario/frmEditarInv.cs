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
    public partial class frmEditarInv : Form
    {
        int _idProducto;
        byte[] imagenBytes;
        public frmEditarInv(int idProducto)
        {
            InitializeComponent();
            _idProducto = idProducto;
        }

        private void frmEditarInv_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarCategorias();
            CargarSucursales();
            CargarDatosProducto();
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

        private void CargarDatosProducto()
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();

            SqlCommand cmd = new SqlCommand("SELECT * FROM VistaProductosDetalle WHERE ID = @id", obj.SqlC);
            cmd.Parameters.AddWithValue("@id", _idProducto);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtNombreProducto.Text = dr["Nombre"].ToString();
                txtPrecio.Text = dr["Precio Uni"].ToString();
                txtPrecioCosto.Text = dr["Costo"].ToString();
                txtStock.Text = dr["Stock"].ToString();
                cmbCategoria.SelectedItem = dr["Categoría"].ToString();
                cmbProveedor.SelectedItem = dr["Proveedor"].ToString();
                cmbSucursal.SelectedItem = dr["Sucursal"].ToString();

                object imagenObj = dr["imagen_producto"];
                if (imagenObj != null && imagenObj != DBNull.Value)
                {
                    imagenBytes = (byte[])imagenObj;
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBytes))
                    {
                        imgProducto.Image = Image.FromStream(ms);
                        imgProducto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }

            obj.Cerrar();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();

            try
            {
                // Obtener IDs
                SqlCommand cmdCat = new SqlCommand("SELECT id_categoria FROM CATEGORIA WHERE nombre_categoria = @nombre", obj.SqlC);
                cmdCat.Parameters.AddWithValue("@nombre", cmbCategoria.SelectedItem.ToString());
                int idCategoria = (int)cmdCat.ExecuteScalar();

                SqlCommand cmdProv = new SqlCommand("SELECT id_proveedor FROM PROVEEDOR WHERE nombre_comercial_proveedor = @nombre", obj.SqlC);
                cmdProv.Parameters.AddWithValue("@nombre", cmbProveedor.SelectedItem.ToString());
                int idProveedor = (int)cmdProv.ExecuteScalar();

                SqlCommand cmdSuc = new SqlCommand("SELECT id_sucursal FROM SUCURSAL WHERE nombre_sucursal = @nombre", obj.SqlC);
                cmdSuc.Parameters.AddWithValue("@nombre", cmbSucursal.SelectedItem.ToString());
                int idSucursal = (int)cmdSuc.ExecuteScalar();

                // UPDATE PRODUCTO
                SqlCommand cmdProd = new SqlCommand("UPDATE PRODUCTO SET nombre_producto = @nombre, id_categoria = @idCat, " +
                                                    "precio_unitario = @precio, precio_costo = @costo, imagen_producto = @imagen WHERE id_producto = @id", obj.SqlC);
                cmdProd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
                cmdProd.Parameters.AddWithValue("@idCat", idCategoria);
                cmdProd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text, System.Globalization.CultureInfo.InvariantCulture));
                cmdProd.Parameters.AddWithValue("@costo", decimal.Parse(txtPrecioCosto.Text, System.Globalization.CultureInfo.InvariantCulture));
                if (imagenBytes != null)
                    cmdProd.Parameters.Add("@imagen", System.Data.SqlDbType.VarBinary).Value = imagenBytes;
                else
                    cmdProd.Parameters.Add("@imagen", System.Data.SqlDbType.VarBinary).Value = DBNull.Value;
                cmdProd.Parameters.AddWithValue("@id", _idProducto);
                cmdProd.ExecuteNonQuery();

                // UPDATE PRODUCTO_PROVEEDOR
                SqlCommand cmdPP = new SqlCommand("UPDATE PRODUCTO_PROVEEDOR SET id_proveedor = @idProv WHERE id_producto = @id", obj.SqlC);
                cmdPP.Parameters.AddWithValue("@idProv", idProveedor);
                cmdPP.Parameters.AddWithValue("@id", _idProducto);
                cmdPP.ExecuteNonQuery();

                // UPDATE PRODUCTO_SUCURSAL
                SqlCommand cmdPS = new SqlCommand("UPDATE PRODUCTO_SUCURSAL SET id_sucursal = @idSuc, cantidad_stock = @stock WHERE id_producto = @id", obj.SqlC);
                cmdPS.Parameters.AddWithValue("@idSuc", idSucursal);
                cmdPS.Parameters.AddWithValue("@stock", txtStock.Text);
                cmdPS.Parameters.AddWithValue("@id", _idProducto);
                cmdPS.ExecuteNonQuery();

                MessageBox.Show("Producto actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
