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
        int id_cliente_seleccionado = 0;
        private void BuscarCliente(string rtnDni)
        {
            try
            {

                clsConexion ObjConexion = new clsConexion();
                ObjConexion.Abrir();


                string consulta = "SELECT id_cliente, nombre_cliente, direccion_cliente FROM CLIENTE WHERE rtn_cliente = @rtn OR dni_cliente = @rtn";
                SqlCommand cmd = new SqlCommand(consulta, ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@rtn", rtnDni);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    id_cliente_seleccionado = Convert.ToInt32(reader["id_cliente"]); 


                    txtNombreCliente.Text = reader["nombre_cliente"].ToString();
                    txtDireccionCliente.Text = reader["direccion_cliente"].ToString();
                }
                else
                {
                    id_cliente_seleccionado = 0;
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
            
            if (dgvDetalleFactura.Rows.Count == 0)
            {
                MessageBox.Show("Agregue productos para ver la vista previa.", "Aviso");
                return;
            }

            frmVistaPrevia objVP = new frmVistaPrevia();

            objVP.txtNombreClienteVP.Text = txtNombreCliente.Text;
            objVP.txtDNIClienteVP.Text = txtDNICliente.Text;
            objVP.txtDireccionClienteVP.Text = txtDireccionCliente.Text;
            objVP.lblNumeroFacturaVP.Text = lblNumeroFactura.Text;

            objVP.txtIDVendedorVP.Text = txtIDVendedor.Text;
            objVP.txtNombreVendedorVP.Text = txtNombreVendedor.Text;

            objVP.lblFechaEmisionVP.Text = dtpEmision.Value.ToString("dd/MM/yyyy");
            objVP.lblfechaVencimientoVP.Text = dtpVencimiento.Value.ToString("dd/MM/yyyy");

            objVP.lblSubtotalVP.Text = lblSubtotal.Text;
            objVP.lblImpuestoVP.Text = lblImpuesto.Text;
            objVP.lblTotalVP.Text = lblTotal.Text;

            if (rbContado.Checked) objVP.rbContadoVP.Checked = true;
            if (rbCredito.Checked) objVP.rbCreditoVP.Checked = true;

            objVP.dgvFacturaVP.Rows.Clear(); 

            foreach (DataGridViewRow fila in dgvDetalleFactura.Rows)
            {

                if (fila.Cells[0].Value != null && !fila.IsNewRow)
                {
                    objVP.dgvFacturaVP.Rows.Add(new object[] {
                fila.Cells[0].Value, 
                fila.Cells[1].Value, 
                fila.Cells[2].Value, 
                fila.Cells[3].Value, 
                fila.Cells[4].Value, 
                fila.Cells[5].Value  
            });
                }
            }

            objVP.ShowDialog();
        }

        private void kryptonButton13_Click(object sender, EventArgs e)
        {
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
               
                string qFactura = @"INSERT INTO FACTURA (numero_factura, id_usuario, id_forma_pago, id_cliente, id_estado, id_tipo_factura, fecha_emision, fecha_vencimiento, subtotal, impuesto, total) 
                            VALUES (@num, @user, @pago, @cliente, @estado, @tipo, @fechaE, @fechaV, @sub, @isv, @total); 
                            SELECT SCOPE_IDENTITY();";

                SqlCommand cmdF = new SqlCommand(qFactura, conexion.SqlC, transaccion);

                cmdF.Parameters.AddWithValue("@num", numeroFactura);
                cmdF.Parameters.AddWithValue("@user", int.Parse(txtIDVendedor.Text));
                cmdF.Parameters.AddWithValue("@pago", rbContado.Checked ? 1 : 2);
                cmdF.Parameters.AddWithValue("@cliente", id_cliente_seleccionado);
                cmdF.Parameters.AddWithValue("@estado", 1); 
                cmdF.Parameters.AddWithValue("@tipo", 1); 
                cmdF.Parameters.AddWithValue("@fechaE", dtpEmision.Value);
                cmdF.Parameters.AddWithValue("@fechaV", dtpVencimiento.Value);
                cmdF.Parameters.AddWithValue("@sub", decimal.Parse(lblSubtotal.Text.Replace("L. ", "")));
                cmdF.Parameters.AddWithValue("@isv", decimal.Parse(lblImpuesto.Text.Replace("L. ", "")));
                cmdF.Parameters.AddWithValue("@total", decimal.Parse(lblTotal.Text.Replace("L. ", "")));

                int idGenerado = Convert.ToInt32(cmdF.ExecuteScalar());

                foreach (DataGridViewRow fila in dgvDetalleFactura.Rows)
                {
                    if (fila.Cells[0].Value != null && !fila.IsNewRow)
                    {
                        string qDetalle = "INSERT INTO FACTURA_PRODUCTO (id_factura, id_producto, cantidad) VALUES (@id, @prod, @cant)";
                        SqlCommand cmdD = new SqlCommand(qDetalle, conexion.SqlC, transaccion);

                        cmdD.Parameters.AddWithValue("@id", idGenerado);

                        cmdD.Parameters.AddWithValue("@prod", Convert.ToInt32(fila.Cells[0].Value));

                        cmdD.Parameters.AddWithValue("@cant", fila.Cells[3].Value);

                        cmdD.ExecuteNonQuery();
                    }
                }

                transaccion.Commit();
                MessageBox.Show("Factura emitida con éxito.", "TRAMADE");

                frmEmitirFactura objEmitirFactura = new frmEmitirFactura();
                objEmitirFactura.IdFacturaRecibido = idGenerado;
                objEmitirFactura.ShowDialog();

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

                txtIDVendedor.Text = clsSesion.id_usuario.ToString();
                txtNombreVendedor.Text = clsSesion.nombre_usuario;

   
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
