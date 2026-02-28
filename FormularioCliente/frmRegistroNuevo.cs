using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.ClasesCliente;

namespace TRAMADE
{
    public partial class frmRegistroNuevo : Form
    {
        clsConexion ObjConexion = new clsConexion();
        clsCliente ObjCliente = new clsCliente();
        public frmRegistroNuevo()
        {
            InitializeComponent();
        }

        private void frmRegistroNuevo_Load(object sender, EventArgs e)
        {
          

            
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFecha.ReadOnly = true;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNombre.Text = "";
            cmbTipoCliente.SelectedIndex = -1;
            txtContacto.Text = "";
            txtTelefono.Text = "";
            txtDepartamento.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtRTN.Text = "";
            txtRTN.Enabled = false;
            txtRTN.BackColor = Color.LightGray;

            txtDNI.Text = "";
            txtDNI.Enabled = false;
            txtDNI.BackColor = Color.LightGray;

            txtRazonSocial.Text = "";
            txtRazonSocial.Enabled = false;
            txtRazonSocial.BackColor = Color.LightGray;
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoCliente.Text == "Empresa")
            {
                txtRTN.Enabled = true;
                txtRTN.BackColor = Color.White;

                txtRazonSocial.Enabled = true;
                txtRazonSocial.BackColor = Color.White;

                txtDNI.Enabled = false;
                txtDNI.Text = "";
                txtDNI.BackColor = Color.LightGray;
            }
            else
            {
                txtRTN.Enabled = false;
                txtRTN.Text = "";
                txtRTN.BackColor = Color.LightGray;

                txtRazonSocial.Enabled = false;
                txtRazonSocial.Text = "";
                txtRazonSocial.BackColor = Color.LightGray;

                txtDNI.Enabled = true;
                txtDNI.BackColor = Color.White;

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           /* if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Por favor, ingrese el ID del cliente para buscar.");
                txtBuscar.Focus();
                return;
            }
            DataTable datos = ObjCliente.BusquedaClienteID(txtBuscar.Text, ObjConexion);

            if (datos.Rows.Count > 0)
            {
                DataRow fila = datos.Rows[0];

                txtID.Text = fila["id_cliente"].ToString();
                txtID.ReadOnly = true;
                txtID.BackColor = Color.LightGray;
                cmbTipoCliente.SelectedIndex = 0;
                txtNombre.Text = fila["nombre_cliente"].ToString();
                txtDNI.Text = fila["dni_cliente"].ToString();
                txtRazonSocial.Text = fila["razon_social"].ToString();
                txtRTN.Text = fila["rtn_cliente"].ToString();

                txtContacto.Text = fila["contacto_cliente"].ToString();
                txtTelefono.Text = fila["telefono_cliente"].ToString();
                txtDepartamento.Text = fila["departamento_cliente"].ToString();
                txtCorreo.Text = fila["correo_electronico_cliente"].ToString();
                txtDireccion.Text = fila["direccion_cliente"].ToString();
                //Pendiente de cambio por cmb
                txtCiudad.Text = fila["ciudad_cliente"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró ningún cliente con ese ID.");
            } */
        }
    }
}
