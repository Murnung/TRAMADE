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

        // Método para buscar al cliente en la base de datos usando el DNI o RTN
        private void BuscarCliente(string rtnDni)
        {
            try
            {
                // Instanciamos la clase de conexión de tu equipo
                clsConexion ObjConexion = new clsConexion();
                ObjConexion.Abrir();

                // Armamos la consulta para buscar por rtn_cliente
                string consulta = "SELECT nombre_cliente, direccion_cliente FROM CLIENTE WHERE rtn_cliente = @rtn OR dni_cliente = @rtn";
                SqlCommand cmd = new SqlCommand(consulta, ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@rtn", rtnDni);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Si lo encuentra, llenamos tus cajitas automáticamente
                    txtNombreCliente.Text = reader["nombre_cliente"].ToString();
                    txtDireccionCliente.Text = reader["direccion_cliente"].ToString();
                }
                else
                {
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
            frmEmitirFactura objEmitirFactura = new frmEmitirFactura();
            objEmitirFactura.ShowDialog();
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
    }
}
