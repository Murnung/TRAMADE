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
            clsCliente.llenarcomboDepartamento(cmbDepartamento, ObjConexion);
            


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
            cmbTipoCliente.SelectedIndex = -1;
            cmbDepartamento.SelectedIndex = -1;
            cmbCiudad.SelectedIndex = -1;

            txtContacto.Text = "";
            txtTelefono.Text = "";
          
            txtCorreo.Text = "";
            txtDireccion.Text = "";
           
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtFecha.Text) ||
                string.IsNullOrEmpty(cmbTipoCliente.Text) ||
                string.IsNullOrEmpty(txtContacto.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) ||
              
                string.IsNullOrEmpty(txtCorreo.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text))
                
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

            if (cmbTipoCliente.Text == "Persona")
            {
                if (string.IsNullOrEmpty(txtDNI.Text))
                {
                    MessageBox.Show("El número de Identidad (DNI) es obligatorio para personas naturales.");
                    return;
                }
            }

            try
            {


                ObjCliente.setIdUsuario(clsSesion.id_usuario);
                ObjCliente.setNombre(txtNombre.Text);
                ObjCliente.setRazonSocial(txtRazonSocial.Text);
               
                ObjCliente.setContacto(txtContacto.Text);
                ObjCliente.setTelefono(txtTelefono.Text);
                ObjCliente.setCorreo(txtCorreo.Text);
                ObjCliente.setDireccion(txtDireccion.Text);

                ObjCliente.setTipoCliente(cmbTipoCliente.Text);
                ObjCliente.setDepartamento(cmbDepartamento.Text);
                ObjCliente.setCiudad(cmbCiudad.Text);

                ObjCliente.setRTN(txtRTN.Text);
                ObjCliente.setDNI(txtDNI.Text);
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

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartamento.SelectedIndex != -1 && cmbDepartamento.SelectedItem is DataRowView)
            {
                DataRowView drv = (DataRowView)cmbDepartamento.SelectedItem;
                
                int idSeleccionado = Convert.ToInt32(drv["id_departamento"]);

                
                clsCliente.llenarcombociudad(cmbCiudad, ObjConexion, idSeleccionado);
    }
        }
    }
}
