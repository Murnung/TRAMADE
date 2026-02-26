using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE
{
    public partial class frmRegistroNuevo : Form
    {
        public frmRegistroNuevo()
        {
            InitializeComponent();
        }

        private void frmRegistroNuevo_Load(object sender, EventArgs e)
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
            txtID.Text = "";
            txtNombre.Text = "";
            txtRazon.Text = "";
            txtFecha.Text = "";
            cmbTipoCliente.Text = "";

            txtContacto.Text = "";
            txtTelefono.Text = "";
            txtDepartamento.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
        }
    }
}
