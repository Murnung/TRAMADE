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
using TRAMADE.Formulario_Proveedores.Clases;

namespace TRAMADE
{
    public partial class frmProveedores_Añadir : Form
    {
        public frmProveedores_Añadir()
        {
            InitializeComponent();
        }

        clsConexion ObjConexion = new clsConexion();
        clsProveedores_Añadir objProv = new clsProveedores_Añadir();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarCampos()
        {
            txtNombreComercial.Clear();
            txtRazonSocial.Clear();
            txtDireccionFiscal.Clear();
            txtRtn.Clear();
            txtTelefonoGeneral.Clear();
            txtCorreoCentral.Clear();

            cmbClasificacion.SelectedIndex = -1;
            cmbTerminosdePago.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsProveedores_Añadir objAdd = new clsProveedores_Añadir();

            clsProveedores objP = new clsProveedores(txtNombreComercial.Text, txtRazonSocial.Text, txtDireccionFiscal.Text, txtRtn.Text, Convert.ToInt32(cmbClasificacion.SelectedValue), Convert.ToInt32(cmbTerminosdePago.SelectedValue), txtTelefonoGeneral.Text, txtCorreoCentral.Text);

            objAdd.InsertarProveedor(objP);

            LimpiarCampos();

            this.Close(); 
        }
    
    }
}
