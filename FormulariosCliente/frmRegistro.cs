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
            clsCliente.llenarcomboTipoCliente(cmbTipoCliente, ObjConexion);


            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFecha.ReadOnly = true;

            txtID.Text = "AUTOGENERADO";
            txtID.ReadOnly = true;
            txtID.BackColor = Color.LightGray;

            txtDNI.Enabled = false;
            txtDNI.BackColor = Color.LightGray;

            txtNombre.Focus();


        }

        private void label2_Click(object sender, EventArgs e)
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
            txtContacto.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";


            cmbTipoCliente.SelectedItem = null;
            cmbDepartamento.SelectedItem = null;

            cmbCiudad.DataSource = null;
            cmbCiudad.Items.Clear();

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

            txtNombre.Focus();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool esValido = clsValidarClientes.ValidarTodoElFormulario
                (
                 txtNombre.Text, txtNombre,
                 cmbTipoCliente.Text,
                 txtDNI.Text, txtDNI,
                 txtRTN.Text, txtRTN,
                 txtRazonSocial.Text, txtRazonSocial,
                 txtTelefono.Text, txtTelefono,
                 txtCorreo.Text, txtCorreo,
                 txtDireccion.Text, txtDireccion,
                 cmbDepartamento.SelectedValue,
                 cmbCiudad.SelectedValue,
                 0
                );

            if (!esValido) return;
            try
            {


                ObjCliente.setIdUsuario(clsSesion.id_usuario);
                ObjCliente.setNombre(txtNombre.Text);
                ObjCliente.setRazonSocial(txtRazonSocial.Text);

                ObjCliente.setContacto(txtContacto.Text);
                ObjCliente.setTelefono(txtTelefono.Text);
                ObjCliente.setCorreo(txtCorreo.Text);
                ObjCliente.setDireccion(txtDireccion.Text);


                ObjCliente.setRTN(txtRTN.Text);
                ObjCliente.setDNI(txtDNI.Text);
                DateTime fechaActual = DateTime.Now;
                ObjCliente.setFechaRegistro(fechaActual);
                ObjCliente.setTipoCliente(cmbTipoCliente.SelectedValue.ToString());
                ObjCliente.setDepartamento(cmbDepartamento.SelectedValue.ToString());
                ObjCliente.setCiudad(cmbCiudad.SelectedValue.ToString());

                bool Resultado = ObjCliente.InsertarCliente(ObjConexion);
                if (Resultado)
                {
                    MessageBox.Show("¡Cliente registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpiar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la información del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico al actualizar: " + ex.Message, "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cmbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoCliente.Text == "PERSONA JURÍDICA")
            {
                txtRTN.Enabled = true;
                txtRTN.BackColor = Color.White;

                txtRazonSocial.Enabled = true;
                txtRazonSocial.BackColor = Color.White;

                txtDNI.Enabled = false;
                txtDNI.Text = "";
                txtDNI.BackColor = Color.LightGray;
            }
            if (cmbTipoCliente.Text == "PERSONA NATURAL")
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

     
        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {

            clsValidar.SoloNumeros_KeyPress(e);
        }




        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu objMenu = new frmMenu();
            objMenu.recargarGraficaEstadoCli();
            objMenu.recargarGraficaDepa();
            objMenu.recargarClientes();
        }
    }
}
