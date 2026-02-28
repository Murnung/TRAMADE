using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TRAMADE.ClasesCliente;

namespace TRAMADE
{
    public partial class frmRegistro : Form
    {
        clsConexion ObjConexion = new clsConexion();
        clsCliente ObjCliente = new clsCliente();

        public frmRegistro()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmRegistro_Load);
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFecha.ReadOnly = true;

            txtID.Text = "AUTOGENERADO";
            txtID.ReadOnly = true;
            txtID.BackColor = Color.LightGray;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = "AUTOGENERADO";
            txtNombre.Text = "";
            txtRazonSocial.Text = "";
            cmbTipoCliente.Text = "";
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

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtFecha.Text) ||
                string.IsNullOrEmpty(cmbTipoCliente.Text) ||
                string.IsNullOrEmpty(txtContacto.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) ||
                string.IsNullOrEmpty(txtDepartamento.Text) ||
                string.IsNullOrEmpty(txtCorreo.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text) ||
                string.IsNullOrEmpty(txtCiudad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (cmbTipoCliente.Text == "Empresa")
            {
                if (string.IsNullOrEmpty(txtRTN.Text) || string.IsNullOrEmpty(txtRazonSocial.Text))
                {
                    MessageBox.Show("Para empresas, el RTN y la Razón Social son obligatorios.");
                    return;
                }
            }

            try
            {


                ObjCliente.setIdUsuario(clsSesion.id_usuario);
                ObjCliente.setNombre(txtNombre.Text);
                ObjCliente.setRazonSocial(txtRazonSocial.Text);
                ObjCliente.setTipoCliente(cmbTipoCliente.Text);
                ObjCliente.setContacto(txtContacto.Text);
                ObjCliente.setTelefono(txtTelefono.Text);
                ObjCliente.setDepartamento(txtDepartamento.Text);
                ObjCliente.setCorreo(txtCorreo.Text);
                ObjCliente.setDireccion(txtDireccion.Text);
                ObjCliente.setCiudad(txtCiudad.Text);
                ObjCliente.setRTN(txtRTN.Text);
                DateTime fechaActual = DateTime.Now;
                ObjCliente.setFechaRegistro(fechaActual);

                bool Resultado = ObjCliente.InsertarCliente(ObjConexion);

                if (Resultado)
                {
                    MessageBox.Show("Cliente registrado exitosamente.");
                    btnLimpiar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("El Cliente no se pudo registrar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message);
            }
            
            
        }

        private void cmbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoCliente.Text == "Empresa")
            {
                txtRTN.Enabled = true;
                txtRTN.BackColor = Color.White;

                txtRazonSocial.Enabled = true;
                txtRazonSocial.BackColor = Color.White;
            }
            else
            {
                txtRTN.Enabled = false;
                txtRTN.Text = "";
                txtRTN.BackColor = Color.LightGray;

                txtRazonSocial.Enabled = false;
                txtRazonSocial.Text = "";
                txtRazonSocial.BackColor = Color.LightGray;
            }
        }
    }
}
