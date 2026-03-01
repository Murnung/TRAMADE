using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Necesario para la conexión a SQL
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE
{
    public partial class frmEmitirFactura : Form
    {
        // Esta variable recibe el ID desde el formulario de Facturación
        public int IdFacturaRecibido;

        public frmEmitirFactura()
        {
            InitializeComponent();
        }

        private void frmEmitirFactura_Load(object sender, EventArgs e)
        {
            // Cuando abre el formulario, si hay un ID, cargamos todo
            if (IdFacturaRecibido > 0)
            {
                CargarDatosFactura();
            }
        }

        private void CargarDatosFactura()
        {
            try
            {
                clsConexion conexion = new clsConexion();
                conexion.Abrir();

                // 1. MAESTRO: Seleccionamos ambos (rtn y dni) por si acaso
                string queryMaestro = @"SELECT F.numero_factura, F.fecha_emision, F.fecha_vencimiento, 
                                       F.subtotal, F.impuesto, F.total, F.id_forma_pago,
                                       C.nombre_cliente, C.rtn_cliente, C.dni_cliente, C.direccion_cliente,
                                       U.id_usuario, U.nombre_usuario
                                FROM FACTURA F
                                INNER JOIN CLIENTE C ON F.id_cliente = C.id_cliente
                                INNER JOIN USUARIO U ON F.id_usuario = U.id_usuario
                                WHERE F.id_factura = @id";

                SqlCommand cmd = new SqlCommand(queryMaestro, conexion.SqlC);
                cmd.Parameters.AddWithValue("@id", IdFacturaRecibido);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    int numF = Convert.ToInt32(dr["numero_factura"]);
                    lblNumeroFacturaEF.Text = "INV/2026/" + numF.ToString("D4");

                    // --- CORRECCIÓN DNI/RTN ---
                    // Si rtn_cliente está vacío, intenta mostrar dni_cliente
                    string dni = dr["rtn_cliente"].ToString();
                    if (string.IsNullOrEmpty(dni)) dni = dr["dni_cliente"].ToString();
                    txtDNIClienteEF.Text = dni;

                    txtNombreClienteEF.Text = dr["nombre_cliente"].ToString();
                    txtDireccionClienteEF.Text = dr["direccion_cliente"].ToString();
                    txtIDVendedorEF.Text = dr["id_usuario"].ToString();
                    txtNombreVendedorEF.Text = dr["nombre_usuario"].ToString();
                    lblFechaEmisionEF.Text = Convert.ToDateTime(dr["fecha_emision"]).ToString("dd/MM/yyyy");
                    lblFechaVencimientoEF.Text = Convert.ToDateTime(dr["fecha_vencimiento"]).ToString("dd/MM/yyyy");
                    lblSubtotalEF.Text = "L. " + Convert.ToDecimal(dr["subtotal"]).ToString("N2");
                    lblImpuestoEF.Text = "L. " + Convert.ToDecimal(dr["impuesto"]).ToString("N2");
                    lblTotalEF.Text = "L. " + Convert.ToDecimal(dr["total"]).ToString("N2");

                    int formaPago = Convert.ToInt32(dr["id_forma_pago"]);
                    if (formaPago == 1) rbContadoEF.Checked = true;
                    else if (formaPago == 2) rbCreditoEF.Checked = true;
                }
                dr.Close();

                // 2. DETALLE: Corregir distorsión del Grid
                string queryDetalle = @"SELECT P.nombre_producto as Producto, 
                                       'Unidad' as Descripción, 
                                       FP.cantidad as Cantidad, 
                                       P.precio_unitario as [Precio Unitario], 
                                       (FP.cantidad * P.precio_unitario) as Subtotal
                                FROM FACTURA_PRODUCTO FP
                                INNER JOIN PRODUCTO P ON FP.id_producto = P.id_producto
                                WHERE FP.id_factura = @id";

                SqlDataAdapter da = new SqlDataAdapter(queryDetalle, conexion.SqlC);
                da.SelectCommand.Parameters.AddWithValue("@id", IdFacturaRecibido);

                DataTable dt = new DataTable();
                da.Fill(dt);

                // --- EL TRUCO PARA ELIMINAR LA DISTORSIÓN ---
                dgvEmitirFactura.DataSource = null; // Limpiamos el origen
                dgvEmitirFactura.Columns.Clear();   // Borramos las columnas viejas del diseño
                dgvEmitirFactura.DataSource = dt;   // Cargamos los datos nuevos

                // Ajustamos el ancho automáticamente para que se vea ordenado
                dgvEmitirFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                conexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la factura: " + ex.Message);
            }
        }

        private void btnListoEF_Click(object sender, EventArgs e)
        {
            // Cerramos el formulario
            this.Close();
        }

        // Eventos vacíos por si acaso diste doble clic sin querer en el diseño
        private void kryptonGroup4_Panel_Paint(object sender, PaintEventArgs e) { }
    }
}