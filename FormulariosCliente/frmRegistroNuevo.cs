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
using TRAMADE.ClasesCliente;
using TRAMADE.ClasesCompras;
using TRAMADE.Formulario_Proveedores;

namespace TRAMADE
{
    public partial class frmRegistroNuevo : Form
    {
        clsConexion ObjConexion = new clsConexion();
        clsCliente ObjCliente = new clsCliente();
        int IdSeleccionado = 0;
        public frmRegistroNuevo()
        {
            InitializeComponent();
            txtID.ReadOnly = true;
            txtBuscar.Focus();
        }

        private void frmRegistroNuevo_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFecha.ReadOnly = true;
            txtID.ReadOnly = true;
            txtID.BackColor = Color.LightGray;
            clsCliente.llenarcomboDepartamento(cmbDepartamento, ObjConexion);
            clsCliente.llenarcomboTipoCliente(cmbTipoCliente, ObjConexion);
            clsCombobox.LlenarRazonSocial(cmbRazonSocial);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtID.ReadOnly = true;
            txtID.BackColor = Color.LightGray;

            txtNombre.Text = "";
            cmbTipoCliente.SelectedIndex = -1;
            cmbTipoCliente.SelectedItem = null;
            cmbDepartamento.SelectedItem = null;
            cmbCiudad.DataSource = null;
            cmbCiudad.Items.Clear();
            txtContacto.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtBuscar.Text = "";

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            cmbRazonSocial.SelectedIndex = -1;           
            txtRTN.Text = txtDNI.Text = "";
            txtRTN.BackColor = txtDNI.BackColor = cmbRazonSocial.BackColor = Color.LightGray;
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            

            string busqueda = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Por favor, ingrese el DNI/RTN del cliente.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {

                DataTable dt = ObjCliente.BuscarCliente(busqueda, ObjConexion);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    IdSeleccionado = Convert.ToInt32(row["id_cliente"]);

                    txtDNI.ReadOnly = true;
                    txtDNI.Enabled = false;
                    txtDNI.BackColor = Color.LightGray;
                    txtRTN.ReadOnly = true;
                    txtRTN.BackColor = Color.LightGray;
                    txtRTN.Enabled = false;


                    txtID.Text = row["id_cliente"].ToString();
                    txtID.ReadOnly = true;
                    txtID.BackColor = Color.LightGray;
                    

                    txtNombre.Text = row["nombre_cliente"].ToString();
                    txtContacto.Text = row["contacto_cliente"].ToString();
                    txtTelefono.Text = row["telefono_cliente"].ToString();
                    txtCorreo.Text = row["correo_electronico_cliente"].ToString();
                    txtDireccion.Text = row["direccion_cliente"].ToString();
                    txtDNI.Text = row["dni_cliente"].ToString();
                    txtRTN.Text = row["rtn_cliente"].ToString();
                    cmbRazonSocial.Text = row["razon_social"].ToString();
                   

                    cmbTipoCliente.SelectedValue = row["id_clasificacion_cliente"];

                    if (row["id_departamento"] != DBNull.Value)
                    {
                        int idDepa = Convert.ToInt32(row["id_departamento"]);
                        cmbDepartamento.SelectedValue = idDepa;

                        clsCliente.llenarcombociudad(cmbCiudad, ObjConexion, idDepa);
                        
                        if (row["id_ciudad"] != DBNull.Value)
                        {
                            cmbCiudad.SelectedValue = row["id_ciudad"];
                        }
                    }


                }
                else
                {
                  MessageBox.Show("No se encontró ningún cliente con el ID proporcionado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cmbTipoCliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ObjCliente.ConfigurarTipo(cmbTipoCliente.Text, txtRTN, cmbRazonSocial, txtDNI);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtID.Text, out int idActual))
            {
                MessageBox.Show("ID de cliente no válido.");
                return;
            }


            bool esValido = clsValidar.ValidarTodoElFormulario
                (
                 txtNombre.Text, txtNombre,
                 cmbTipoCliente.Text,
                 txtDNI.Text, txtDNI,
                 txtRTN.Text, txtRTN,
                 cmbRazonSocial.Text, cmbRazonSocial,
                 txtTelefono.Text, txtTelefono,
                 txtCorreo.Text, txtCorreo,
                 txtDireccion.Text, txtDireccion,
                 cmbDepartamento.SelectedValue,
                 cmbCiudad.SelectedValue,
                 idActual
                );

            if (!esValido) return;

            try
            {

                ObjCliente.setID(txtID.Text);

                ObjCliente.setIdUsuario(clsSesion.id_usuario);
                ObjCliente.setNombre(txtNombre.Text);
                ObjCliente.setRazonSocial(cmbRazonSocial.Text);
                ObjCliente.setContacto(txtContacto.Text);
                ObjCliente.setTelefono(txtTelefono.Text);
                ObjCliente.setCorreo(txtCorreo.Text);
                ObjCliente.setDireccion(txtDireccion.Text);
                ObjCliente.setRTN(txtRTN.Text);
                ObjCliente.setDNI(txtDNI.Text);

                ObjCliente.setTipoCliente(cmbTipoCliente.SelectedValue.ToString());
                ObjCliente.setCiudad(cmbCiudad.SelectedValue.ToString());

                bool Resultado = ObjCliente.ActulizarCliente(ObjConexion);

                if (Resultado)
                {
                    MessageBox.Show("¡Datos del cliente actualizados exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {

            clsValidar.SoloNumeros_KeyPress(e);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
