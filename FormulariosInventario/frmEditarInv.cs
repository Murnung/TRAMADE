using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using TRAMADE.ClasesInventario;

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
            CargarCategorias();
            CargarSucursales();
            CargarProveedores();
            CargarDatosProducto();
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

        private void CargarProveedores()
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();
            SqlCommand cmd = new SqlCommand("SELECT nombre_comercial_proveedor FROM PROVEEDOR", obj.SqlC);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cmbProveedorNuevo.Items.Add(dr["nombre_comercial_proveedor"].ToString());
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
                cmbSucursal.SelectedItem = dr["Sucursal"].ToString();

                object imagenObj = dr["imagen_producto"];
                if (imagenObj != null && imagenObj != DBNull.Value)
                {
                    imagenBytes = (byte[])imagenObj;
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        imgProducto.Image = Image.FromStream(ms);
                        imgProducto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }
            dr.Close();
            obj.Cerrar();

            CargarProveedoresDelProducto();
        }

        private void CargarProveedoresDelProducto()
        {
            lstProveedores.Items.Clear();
            clsConexion obj = new clsConexion();
            obj.Abrir();

            SqlCommand cmd = new SqlCommand("SELECT PV.nombre_comercial_proveedor FROM PROVEEDOR PV " +
                                            "INNER JOIN PRODUCTO_PROVEEDOR PP ON PV.id_proveedor = PP.id_proveedor " +
                                            "WHERE PP.id_producto = @id", obj.SqlC);
            cmd.Parameters.AddWithValue("@id", _idProducto);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
                lstProveedores.Items.Add(dr["nombre_comercial_proveedor"].ToString());

            obj.Cerrar();
        }

        private void lstProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProveedores.SelectedIndex == -1) return;

            string nombreProveedor = lstProveedores.SelectedItem.ToString();

            clsConexion obj = new clsConexion();
            obj.Abrir();

            SqlCommand cmd = new SqlCommand("SELECT * FROM VistaProductosDetalle WHERE ID = @id AND Proveedor = @proveedor", obj.SqlC);
            cmd.Parameters.AddWithValue("@id", _idProducto);
            cmd.Parameters.AddWithValue("@proveedor", nombreProveedor);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtNombreProducto.Text = dr["Nombre"].ToString();
                txtPrecio.Text = dr["Precio Uni"].ToString();
                txtPrecioCosto.Text = dr["Costo"].ToString();
                txtStock.Text = dr["Stock"].ToString();
                cmbCategoria.SelectedItem = dr["Categoría"].ToString();
                cmbSucursal.SelectedItem = dr["Sucursal"].ToString();

                object imagenObj = dr["imagen_producto"];
                if (imagenObj != null && imagenObj != DBNull.Value)
                {
                    imagenBytes = (byte[])imagenObj;
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        imgProducto.Image = Image.FromStream(ms);
                        imgProducto.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
            }

            obj.Cerrar();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            if (cmbProveedorNuevo.SelectedIndex == -1)
            {
                clsMensajes.Aviso("Selecciona un proveedor para agregar");
                return;
            }

            string nombreProveedor = cmbProveedorNuevo.SelectedItem.ToString();

            if (lstProveedores.Items.Contains(nombreProveedor))
            {
                clsMensajes.Aviso("Este proveedor ya está asignado al producto");
                return;
            }

            clsConexion obj = new clsConexion();
            obj.Abrir();

            try
            {
                int idProveedor = clsProductoDAL.ObtenerIdProveedor(obj.SqlC, nombreProveedor);
                SqlCommand cmd = new SqlCommand("INSERT INTO PRODUCTO_PROVEEDOR (id_producto, id_proveedor) VALUES (@idProd, @idProv)", obj.SqlC);
                cmd.Parameters.AddWithValue("@idProd", _idProducto);
                cmd.Parameters.AddWithValue("@idProv", idProveedor);
                cmd.ExecuteNonQuery();

                clsMensajes.Exito("Proveedor agregado correctamente");
                CargarProveedoresDelProducto();
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

        private void btnQuitarProveedor_Click(object sender, EventArgs e)
        {
            if (lstProveedores.SelectedIndex == -1)
            {
                clsMensajes.Aviso("Selecciona un proveedor para quitar");
                return;
            }

            if (lstProveedores.Items.Count == 1)
            {
                clsMensajes.Aviso("El producto debe tener al menos un proveedor");
                return;
            }

            if (clsMensajes.Confirmar("¿Estás seguro que deseas quitar este proveedor?"))
            {
                string nombreProveedor = lstProveedores.SelectedItem.ToString();
                clsConexion obj = new clsConexion();
                obj.Abrir();

                try
                {
                    int idProveedor = clsProductoDAL.ObtenerIdProveedor(obj.SqlC, nombreProveedor);
                    SqlCommand cmd = new SqlCommand("DELETE FROM PRODUCTO_PROVEEDOR WHERE id_producto = @idProd AND id_proveedor = @idProv", obj.SqlC);
                    cmd.Parameters.AddWithValue("@idProd", _idProducto);
                    cmd.Parameters.AddWithValue("@idProv", idProveedor);
                    cmd.ExecuteNonQuery();

                    clsMensajes.Exito("Proveedor quitado correctamente");
                    CargarProveedoresDelProducto();
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!clsValidar.ValidarInventario(
            txtNombreProducto, txtPrecio, txtPrecioCosto, txtStock,
            cmbCategoria, cmbSucursal)) return;

            if (lstProveedores.Items.Count == 0)
            {
                clsMensajes.Aviso("El producto debe tener al menos un proveedor");
                return;
            }

            clsConexion obj = new clsConexion();
            obj.Abrir();

            try
            {
                int idCategoria = clsProductoDAL.ObtenerIdCategoria(obj.SqlC, cmbCategoria.SelectedItem.ToString());
                int idSucursal = clsProductoDAL.ObtenerIdSucursal(obj.SqlC, cmbSucursal.SelectedItem.ToString());

                SqlCommand cmdProd = new SqlCommand("UPDATE PRODUCTO SET nombre_producto = @nombre, id_categoria = @idCat, " +
                                                    "precio_unitario = @precio, precio_costo = @costo, imagen_producto = @imagen WHERE id_producto = @id", obj.SqlC);
                cmdProd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
                cmdProd.Parameters.AddWithValue("@idCat", idCategoria);
                cmdProd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text, CultureInfo.InvariantCulture));
                cmdProd.Parameters.AddWithValue("@costo", decimal.Parse(txtPrecioCosto.Text, CultureInfo.InvariantCulture));
                if (imagenBytes != null)
                    cmdProd.Parameters.Add("@imagen", System.Data.SqlDbType.VarBinary).Value = imagenBytes;
                else
                    cmdProd.Parameters.Add("@imagen", System.Data.SqlDbType.VarBinary).Value = DBNull.Value;
                cmdProd.Parameters.AddWithValue("@id", _idProducto);
                cmdProd.ExecuteNonQuery();

                SqlCommand cmdPS = new SqlCommand("UPDATE PRODUCTO_SUCURSAL SET id_sucursal = @idSuc, cantidad_stock = @stock WHERE id_producto = @id", obj.SqlC);
                cmdPS.Parameters.AddWithValue("@idSuc", idSucursal);
                cmdPS.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                cmdPS.Parameters.AddWithValue("@id", _idProducto);
                cmdPS.ExecuteNonQuery();

                clsMensajes.Exito("Producto actualizado correctamente");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbProveedorNuevo.SelectedIndex == -1)
            {
                clsMensajes.Aviso("Selecciona un proveedor para agregar");
                return;
            }

            string nombreProveedor = cmbProveedorNuevo.SelectedItem.ToString();

            if (lstProveedores.Items.Contains(nombreProveedor))
            {
                clsMensajes.Aviso("Este proveedor ya está asignado al producto");
                return;
            }

            clsConexion obj = new clsConexion();
            obj.Abrir();

            try
            {
                int idProveedor = clsProductoDAL.ObtenerIdProveedor(obj.SqlC, nombreProveedor);
                SqlCommand cmd = new SqlCommand("INSERT INTO PRODUCTO_PROVEEDOR (id_producto, id_proveedor) VALUES (@idProd, @idProv)", obj.SqlC);
                cmd.Parameters.AddWithValue("@idProd", _idProducto);
                cmd.Parameters.AddWithValue("@idProv", idProveedor);
                cmd.ExecuteNonQuery();

                clsMensajes.Exito("Proveedor agregado correctamente");
                CargarProveedoresDelProducto();
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

        private void btnQuitarProveedor_Click_1(object sender, EventArgs e)
        {
            if (lstProveedores.SelectedIndex == -1)
            {
                clsMensajes.Aviso("Selecciona un proveedor para quitar");
                return;
            }

            if (lstProveedores.Items.Count == 1)
            {
                clsMensajes.Aviso("El producto debe tener al menos un proveedor");
                return;
            }

            if (clsMensajes.Confirmar("¿Estás seguro que deseas quitar este proveedor?"))
            {
                string nombreProveedor = lstProveedores.SelectedItem.ToString();
                clsConexion obj = new clsConexion();
                obj.Abrir();

                try
                {
                    int idProveedor = clsProductoDAL.ObtenerIdProveedor(obj.SqlC, nombreProveedor);
                    SqlCommand cmd = new SqlCommand("DELETE FROM PRODUCTO_PROVEEDOR WHERE id_producto = @idProd AND id_proveedor = @idProv", obj.SqlC);
                    cmd.Parameters.AddWithValue("@idProd", _idProducto);
                    cmd.Parameters.AddWithValue("@idProv", idProveedor);
                    cmd.ExecuteNonQuery();

                    clsMensajes.Exito("Proveedor quitado correctamente");
                    CargarProveedoresDelProducto();
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
        }
    }
}