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
        }

        private void frmRegistroNuevo_Load(object sender, EventArgs e)
        {

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFecha.ReadOnly = true;

            clsCliente.llenarcomboDepartamento(cmbDepartamento, ObjConexion);
            clsCliente.llenarcomboTipoCliente(cmbTipoCliente, ObjConexion);

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
            cmbTipoCliente.SelectedItem = null;
            cmbDepartamento.SelectedItem = null;
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
            string busqueda = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Por favor, ingrese el ID del cliente.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                ObjConexion.Abrir();
                string consulta = @"SELECT C.*, CI.id_departamento 
                    FROM CLIENTE C
                    INNER JOIN CIUDAD CI ON C.id_ciudad = CI.id_ciudad
                    WHERE C.id_cliente = @busqueda"; 
                SqlCommand cmd = new SqlCommand(consulta, ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@busqueda", busqueda);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    IdSeleccionado = Convert.ToInt32(row["id_cliente"]);

                   
                    txtID.Text = row["id_cliente"].ToString();
                    txtNombre.Text = row["nombre_cliente"].ToString();
                    txtContacto.Text = row["contacto_cliente"].ToString();
                    txtTelefono.Text = row["telefono_cliente"].ToString();
                    txtCorreo.Text = row["correo_electronico_cliente"].ToString();
                    txtDireccion.Text = row["direccion_cliente"].ToString();
                    txtDNI.Text = row["dni_cliente"].ToString();
                    txtRTN.Text = row["rtn_cliente"].ToString();
                    txtRazonSocial.Text = row["razon_social"].ToString();

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
                MessageBox.Show("Error al buscar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }
    }
}
