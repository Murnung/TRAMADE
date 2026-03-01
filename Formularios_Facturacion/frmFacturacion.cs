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
    public partial class frmFacturacion : Form
    {
        int numeroFactura = 1;
        int id_cliente_seleccionado = 0; // Esta variable guardará el ID del cliente que seleccionemos, para usarlo al guardar la factura.

        // Método para buscar al cliente en la base de datos usando el DNI o RTN
        private void BuscarCliente(string rtnDni)
        {
            try
            {
                // Instanciamos la clase de conexión de tu equipo
                clsConexion ObjConexion = new clsConexion();
                ObjConexion.Abrir();

                // Armamos la consulta para buscar por rtn_cliente
                string consulta = "SELECT id_cliente, nombre_cliente, direccion_cliente FROM CLIENTE WHERE rtn_cliente = @rtn OR dni_cliente = @rtn";
                SqlCommand cmd = new SqlCommand(consulta, ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@rtn", rtnDni);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    id_cliente_seleccionado = Convert.ToInt32(reader["id_cliente"]); // Guardamos el ID del cliente para usarlo al guardar la factura

                    // Si lo encuentra, llenamos tus cajitas automáticamente
                    txtNombreCliente.Text = reader["nombre_cliente"].ToString();
                    txtDireccionCliente.Text = reader["direccion_cliente"].ToString();
                }
                else
                {
                    id_cliente_seleccionado = 0; // Reiniciamos el ID del cliente si no se encuentra
                    // Si el cliente no existe, limpiamos y avisamos
                    MessageBox.Show("Cliente no encontrado en la base de datos. Verifique el RTN/DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreCliente.Text = "";
                    txtDireccionCliente.Text = "";
                }

                reader.Close();
                ObjConexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message);
            }
        }

        public frmFacturacion()
        {
            InitializeComponent();
        }

        //METODO PARA CALCULAR LOS TOTALES DE LA FACTURA
        public void CalcularTotales()
        {
            decimal subtotalGeneral = 0;
            decimal impuesto = 0;
            decimal totalAPagar = 0;

            foreach (DataGridViewRow fila in dgvDetalleFactura.Rows)
            {
                
                if (fila.Cells[5].Value != null)
                {
                    subtotalGeneral += Convert.ToDecimal(fila.Cells[5].Value);
                }
            }

            impuesto = subtotalGeneral * 0.15m;
            totalAPagar = subtotalGeneral + impuesto;

            lblSubtotal.Text = "L. " + subtotalGeneral.ToString("N2");
            lblImpuesto.Text = "L. " + impuesto.ToString("N2");
            lblTotal.Text = "L. " + totalAPagar.ToString("N2");
        }

        private void btnAggProducto_Click(object sender, EventArgs e)
        {
            frmAggProducto objAggProducto = new frmAggProducto();
            objAggProducto.ShowDialog();
        }

        private void kryptonButton12_Click(object sender, EventArgs e)
        {
            frmVistaPrevia objVistaPrevia = new frmVistaPrevia();
            objVistaPrevia.txtNombreClienteVP.Text = txtNombreCliente.Text;
            objVistaPrevia.txtDNIClienteVP.Text = txtDNICliente.Text;
            objVistaPrevia.txtDireccionClienteVP.Text = txtDireccionCliente.Text;
            objVistaPrevia.lblNumeroFacturaVP.Text = lblNumeroFactura.Text;
            objVistaPrevia.ShowDialog();
        }

        private void kryptonButton13_Click(object sender, EventArgs e)
        {
            // 1. Validaciones
            if (dgvDetalleFactura.Rows.Count == 0)
            {
                MessageBox.Show("No hay productos para facturar.", "Aviso");
                return;
            }

            clsConexion conexion = new clsConexion();
            conexion.Abrir();
            SqlTransaction transaccion = conexion.SqlC.BeginTransaction();

            try
            {
                // 2. GUARDAR MAESTRO (Ajustado a tu tabla real)
                // Nota: Asegúrate de tener los valores para id_usuario, id_forma_pago, etc.
                string qFactura = @"INSERT INTO FACTURA (numero_factura, id_usuario, id_forma_pago, id_cliente, id_estado, id_tipo_factura, fecha_emision, fecha_vencimiento, subtotal, impuesto, total) 
                            VALUES (@num, @user, @pago, @cliente, @estado, @tipo, @fechaE, @fechaV, @sub, @isv, @total); 
                            SELECT SCOPE_IDENTITY();";

                SqlCommand cmdF = new SqlCommand(qFactura, conexion.SqlC, transaccion);

                // Parámetros basados en tu imagen de la tabla
                cmdF.Parameters.AddWithValue("@num", numeroFactura);
                cmdF.Parameters.AddWithValue("@user", int.Parse(txtIDVendedor.Text)); // El ID que ya tenés del login
                cmdF.Parameters.AddWithValue("@pago", rbContado.Checked ? 1 : 2); // 1 para Contado, 2 para Crédito (ajustalo según tu DB)
                cmdF.Parameters.AddWithValue("@cliente", id_cliente_seleccionado); // El ID del cliente que seleccionamos
                cmdF.Parameters.AddWithValue("@estado", 1); // 1 = Emitida/Activa
                cmdF.Parameters.AddWithValue("@tipo", 1); // 1 = Factura Normal
                cmdF.Parameters.AddWithValue("@fechaE", dtpEmision.Value);
                cmdF.Parameters.AddWithValue("@fechaV", dtpVencimiento.Value);
                cmdF.Parameters.AddWithValue("@sub", decimal.Parse(lblSubtotal.Text.Replace("L. ", "")));
                cmdF.Parameters.AddWithValue("@isv", decimal.Parse(lblImpuesto.Text.Replace("L. ", "")));
                cmdF.Parameters.AddWithValue("@total", decimal.Parse(lblTotal.Text.Replace("L. ", "")));

                int idGenerado = Convert.ToInt32(cmdF.ExecuteScalar());

                // 3. GUARDAR DETALLE (FACTURA_PRODUCTO)
                foreach (DataGridViewRow fila in dgvDetalleFactura.Rows)
                {
                    // Validamos que la fila tenga datos y no sea la fila vacía del final
                    if (fila.Cells[0].Value != null && !fila.IsNewRow)
                    {
                        string qDetalle = "INSERT INTO FACTURA_PRODUCTO (id_factura, id_producto, cantidad) VALUES (@id, @prod, @cant)";
                        SqlCommand cmdD = new SqlCommand(qDetalle, conexion.SqlC, transaccion);

                        cmdD.Parameters.AddWithValue("@id", idGenerado);

                        // ¡EL CAMBIO IMPORTANTE! 
                        // fila.Cells[0] ahora tiene el ID (el número que SQL sí acepta)
                        cmdD.Parameters.AddWithValue("@prod", Convert.ToInt32(fila.Cells[0].Value));

                        // La cantidad ahora sería la celda 3 (si moviste las columnas)
                        // Ajustá los índices según cómo quedaron tus columnas en el Grid
                        cmdD.Parameters.AddWithValue("@cant", fila.Cells[3].Value);

                        cmdD.ExecuteNonQuery();
                    }
                }

                transaccion.Commit();
                MessageBox.Show("Factura emitida con éxito.", "TRAMADE");

                // 4. ABRIR EMISIÓN
                frmEmitirFactura objEmitirFactura = new frmEmitirFactura();
                objEmitirFactura.IdFacturaRecibido = idGenerado;
                objEmitirFactura.ShowDialog();

                // 5. LIMPIEZA
                dgvDetalleFactura.Rows.Clear();
                CalcularTotales();
            }
            catch (Exception ex)
            {
                if (transaccion != null) transaccion.Rollback();
                MessageBox.Show("Error al emitir factura: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            frmHistorialFacturas objHistorialFacturas = new frmHistorialFacturas();
            objHistorialFacturas.ShowDialog();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreCliente.Text = "";
            txtDNICliente.Text = "";
            txtDireccionCliente.Text = "";
            txtIDVendedor.Text = "";
            txtNombreVendedor.Text = "";
            dtpEmision.Value = DateTime.Now;
            dtpVencimiento  .Value = DateTime.Now;
            rbContado.Checked = false;
            rbCredito.Checked = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnLimpiar.PerformClick();
            numeroFactura++;
            lblNumeroFactura.Text = "INV/2026/" + numeroFactura.ToString("D4");
        }

        private void txtDNICliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNICliente_Leave(object sender, EventArgs e)
        {
           
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void btnIDVendedor_Click(object sender, EventArgs e)
        {
            if (clsSesion.id_usuario != 0)
            {
                // Jalamos los datos de la memoria global
                txtIDVendedor.Text = clsSesion.id_usuario.ToString();
                txtNombreVendedor.Text = clsSesion.nombre_usuario;

                // Bloqueamos las cajitas para que no lo borren
                txtIDVendedor.ReadOnly = true;
                txtNombreVendedor.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("No se detectó ningún usuario logueado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDNICliente_Click(object sender, EventArgs e)
        {
            if (txtDNICliente.Text.Trim() != "")
            {
                // Llamamos al método que ya tenías creado
                BuscarCliente(txtDNICliente.Text.Trim());
            }
            else
            {
                MessageBox.Show("Por favor, escriba un DNI o RTN antes de buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDetalleFactura.CurrentRow != null)
            {
                dgvDetalleFactura.Rows.Remove(dgvDetalleFactura.CurrentRow);

                CalcularTotales();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista para eliminarlo.", "Aviso");
            }
        }

        private void dgvDetalleFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalcularTotales(); //Por si se cambia algo en la area de productos, recalculamos los totales automáticamente.
        }
    }
}
