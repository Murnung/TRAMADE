using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using TRAMADE.ClasesInventario;

namespace TRAMADE
{
    public partial class frmRegistrarInv : Form
    {
        byte[] imagenBytes;

        public frmRegistrarInv()
        {
            InitializeComponent();
        }

        private void frmRegistrarInv_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            CargarCategorias();
            CargarSucursales();
        }

        private void txtStockInicial_TextChanged(object sender, EventArgs e) 
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
                cmbProveedor.Items.Add(dr["nombre_comercial_proveedor"].ToString());
            obj.Cerrar();
        }

        private void CargarCategorias()
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();
            SqlCommand cmd = new SqlCommand("SELECT nombre_categoria FROM CATEGORIA", obj.SqlC);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cmbCategoria.Items.Add(dr["nombre_categoria"].ToString());
            obj.Cerrar();
        }

        private void CargarSucursales()
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();
            SqlCommand cmd = new SqlCommand("SELECT nombre_sucursal FROM SUCURSAL", obj.SqlC);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cmbSucursal.Items.Add(dr["nombre_sucursal"].ToString());
            obj.Cerrar();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            openFile.Title = "Seleccionar imagen del producto";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imagenBytes = File.ReadAllBytes(openFile.FileName);
                imgProducto.Image = Image.FromFile(openFile.FileName);
                imgProducto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            /*if (!clsValidaciones.ValidarCamposVacios(txtNombreProducto, txtPrecio, txtPrecioCosto, txtStockInicial))
                return;

            if (!clsValidaciones.ValidarComboBox(cmbProveedor, cmbCategoria, cmbSucursal))
                return;

            if (!clsValidaciones.ValidarDecimal(txtPrecio))
                return;

            if (!clsValidaciones.ValidarDecimal(txtPrecioCosto))
                return;

            if (!clsValidaciones.ValidarEntero(txtStockInicial))
                return;

            if (!clsValidaciones.ValidarPositivo(txtPrecio))
                return;

            if (!clsValidaciones.ValidarPositivo(txtPrecioCosto))
                return;

            if (!clsValidaciones.ValidarPositivo(txtStockInicial))
                return;

            if (!clsValidaciones.ValidarCostoMenorPrecio(txtPrecio, txtPrecioCosto))
                return;

            if (!clsValidaciones.ValidarProductoExiste(txtNombreProducto.Text))
                return;*/

            /*if (!clsValidar.ValidarInventario(
            txtNombreProducto, txtPrecio, txtPrecioCosto, txtStockInicial,
            cmbProveedor, cmbCategoria, cmbSucursal)) return;*/

            if (!clsValidar.ValidarInventario(
            txtNombreProducto, txtPrecio, txtPrecioCosto, txtStockInicial,
            cmbCategoria, cmbSucursal, cmbProveedor, esNuevo: true)) return;

            clsConexion obj = new clsConexion();
            obj.Abrir();

            try
            {
                int idCategoria = clsProductoDAL.ObtenerIdCategoria(obj.SqlC, cmbCategoria.SelectedItem.ToString());
                int idProveedor = clsProductoDAL.ObtenerIdProveedor(obj.SqlC, cmbProveedor.SelectedItem.ToString());
                int idSucursal = clsProductoDAL.ObtenerIdSucursal(obj.SqlC, cmbSucursal.SelectedItem.ToString());

                SqlCommand cmdProd = new SqlCommand("INSERT INTO PRODUCTO (nombre_producto, id_categoria, precio_unitario, precio_costo, imagen_producto) " +
                                                    "VALUES (@nombre, @idCat, @precio, @costo, @imagen); SELECT SCOPE_IDENTITY();", obj.SqlC);
                cmdProd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
                cmdProd.Parameters.AddWithValue("@idCat", idCategoria);
                cmdProd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text, CultureInfo.InvariantCulture));
                cmdProd.Parameters.AddWithValue("@costo", decimal.Parse(txtPrecioCosto.Text, CultureInfo.InvariantCulture));
                if (imagenBytes != null)
                    cmdProd.Parameters.Add("@imagen", System.Data.SqlDbType.VarBinary).Value = imagenBytes;
                else
                    cmdProd.Parameters.Add("@imagen", System.Data.SqlDbType.VarBinary).Value = DBNull.Value;
                int nuevoID = Convert.ToInt32(cmdProd.ExecuteScalar());

                SqlCommand cmdPP = new SqlCommand("INSERT INTO PRODUCTO_PROVEEDOR (id_producto, id_proveedor) VALUES (@idProd, @idProv)", obj.SqlC);
                cmdPP.Parameters.AddWithValue("@idProd", nuevoID);
                cmdPP.Parameters.AddWithValue("@idProv", idProveedor);
                cmdPP.ExecuteNonQuery();

                SqlCommand cmdPS = new SqlCommand("INSERT INTO PRODUCTO_SUCURSAL (id_producto, id_sucursal, cantidad_stock) VALUES (@idProd, @idSuc, @stock)", obj.SqlC);
                cmdPS.Parameters.AddWithValue("@idProd", nuevoID);
                cmdPS.Parameters.AddWithValue("@idSuc", idSucursal);
                cmdPS.Parameters.AddWithValue("@stock", int.Parse(txtStockInicial.Text));
                cmdPS.ExecuteNonQuery();

                clsMensajes.Exito("Producto registrado correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                clsMensajes.Error("Error: " + ex.Message);
            }
            finally
            {
                obj.Cerrar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}