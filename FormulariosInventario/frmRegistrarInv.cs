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

        // ─── Cargar combos (sin cambios) ──────────────────────────────────────
        private void CargarProveedores()
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();
            SqlCommand cmd = new SqlCommand(
                "SELECT nombre_comercial_proveedor FROM PROVEEDOR", obj.SqlC);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cmbProveedor.Items.Add(dr["nombre_comercial_proveedor"].ToString());
            obj.Cerrar();
        }

        private void CargarCategorias()
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();
            SqlCommand cmd = new SqlCommand(
                "SELECT nombre_categoria FROM CATEGORIA", obj.SqlC);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cmbCategoria.Items.Add(dr["nombre_categoria"].ToString());
            obj.Cerrar();
        }

        private void CargarSucursales()
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();
            SqlCommand cmd = new SqlCommand(
                "SELECT nombre_sucursal FROM SUCURSAL", obj.SqlC);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cmbSucursal.Items.Add(dr["nombre_sucursal"].ToString());
            obj.Cerrar();
        }

        // ─── Subir imagen del producto (sin cambios) ──────────────────────────
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

        // ─── REGISTRAR — ahora genera y guarda el código de barras ───────────
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // ── Validar con clsValidar (igual que antes) ──────────────────────
            if (!clsValidar.ValidarInventario(
                txtNombreProducto, txtPrecio, txtPrecioCosto, txtStockInicial,
                cmbCategoria, cmbSucursal, cmbProveedor, esNuevo: true))
                return;

            clsConexion obj = new clsConexion();
            obj.Abrir();

            try
            {
                int idCategoria = clsProductoDAL.ObtenerIdCategoria(
                    obj.SqlC, cmbCategoria.SelectedItem.ToString());
                int idProveedor = clsProductoDAL.ObtenerIdProveedor(
                    obj.SqlC, cmbProveedor.SelectedItem.ToString());
                int idSucursal = clsProductoDAL.ObtenerIdSucursal(
                    obj.SqlC, cmbSucursal.SelectedItem.ToString());

                // ── PASO 1: Insertar producto SIN código aún (necesitamos el ID) ──
                SqlCommand cmdProd = new SqlCommand(@"
                    INSERT INTO PRODUCTO
                        (nombre_producto, id_categoria, precio_unitario,
                         precio_costo, imagen_producto)
                    VALUES
                        (@nombre, @idCat, @precio, @costo, @imagen);
                    SELECT SCOPE_IDENTITY();", obj.SqlC);

                cmdProd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
                cmdProd.Parameters.AddWithValue("@idCat", idCategoria);
                cmdProd.Parameters.AddWithValue("@precio",
                    decimal.Parse(txtPrecio.Text, CultureInfo.InvariantCulture));
                cmdProd.Parameters.AddWithValue("@costo",
                    decimal.Parse(txtPrecioCosto.Text, CultureInfo.InvariantCulture));
                cmdProd.Parameters.Add("@imagen", System.Data.SqlDbType.VarBinary).Value =
                    imagenBytes != null ? (object)imagenBytes : DBNull.Value;

                int nuevoID = Convert.ToInt32(cmdProd.ExecuteScalar());

                // ── PASO 2: Generar código con el ID real ─────────────────────
                string codigoBarras = clsCodigoBarras.GenerarCodigo(nuevoID);
                // Ejemplo: nuevoID = 12  →  "PRD-00012"

                // ── PASO 3: Guardar el código en la columna codigo_barras ──────
                SqlCommand cmdCodigo = new SqlCommand(@"
                    UPDATE PRODUCTO
                    SET    codigo_barras = @codigo
                    WHERE  id_producto   = @id", obj.SqlC);
                cmdCodigo.Parameters.AddWithValue("@codigo", codigoBarras);
                cmdCodigo.Parameters.AddWithValue("@id", nuevoID);
                cmdCodigo.ExecuteNonQuery();

                // ── PASO 4: Relaciones proveedor y sucursal (igual que antes) ──
                SqlCommand cmdPP = new SqlCommand(@"
                    INSERT INTO PRODUCTO_PROVEEDOR (id_producto, id_proveedor)
                    VALUES (@idProd, @idProv)", obj.SqlC);
                cmdPP.Parameters.AddWithValue("@idProd", nuevoID);
                cmdPP.Parameters.AddWithValue("@idProv", idProveedor);
                cmdPP.ExecuteNonQuery();

                SqlCommand cmdPS = new SqlCommand(@"
                    INSERT INTO PRODUCTO_SUCURSAL (id_producto, id_sucursal, cantidad_stock)
                    VALUES (@idProd, @idSuc, @stock)", obj.SqlC);
                cmdPS.Parameters.AddWithValue("@idProd", nuevoID);
                cmdPS.Parameters.AddWithValue("@idSuc", idSucursal);
                cmdPS.Parameters.AddWithValue("@stock", int.Parse(txtStockInicial.Text));
                cmdPS.ExecuteNonQuery();

                // ── PASO 5: Preguntar si imprime la etiqueta ahora ────────────
                clsMensajes.Exito($"Producto registrado correctamente.\nCódigo generado: {codigoBarras}");

                if (clsMensajes.Confirmar("¿Deseas imprimir la etiqueta ahora?"))
                {
                    decimal precio = decimal.Parse(txtPrecio.Text, CultureInfo.InvariantCulture);
                    clsCodigoBarras.ImprimirEtiqueta(txtNombreProducto.Text, codigoBarras, precio);
                }

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

        // Eventos vacíos sin cambios
        private void txtStockInicial_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    
    }
}