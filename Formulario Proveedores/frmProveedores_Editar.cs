using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.Formulario_Proveedores.Clases;

namespace TRAMADE
{
    public partial class frmProveedores_Editar : Form
    {
        private int _idProveedor;
        clsProveedores_Editar ObjEditar = new clsProveedores_Editar();
        clsConexion ObjConexion = new clsConexion();
        public frmProveedores_Editar(int idProveedor)
        {
            InitializeComponent();
            _idProveedor = idProveedor; // ← asignar el ID

            // ← usar ObjEditar, NO clsProveedores_Editar directamente
            clsProveedores_Añadir.llenarComboClasificacion(cmbClasificacion, ObjConexion);
            clsProveedores_Añadir.llenarComboTerminosPago(cmbTerminosdePago, ObjConexion);
            ObjEditar.CargarDatosActuales(_idProveedor, txtRazonSocial, txtNombreComercial,
                                          txtDireccionFiscal, txtRtn, txtTelefonoGeneral,
                                          txtCorreoCentral, cmbClasificacion, cmbTerminosdePago);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsProveedores ObjProveedores = new clsProveedores(
            txtNombreComercial.Text,
            txtRazonSocial.Text,
            txtDireccionFiscal.Text,
            txtRtn.Text,
            Convert.ToInt32(cmbClasificacion.SelectedValue),
            Convert.ToInt32(cmbTerminosdePago.SelectedValue),
            txtTelefonoGeneral.Text,
            txtCorreoCentral.Text);

            ObjProveedores.id_proveedor = _idProveedor;

            ObjEditar.ActualizarProveedor(ObjProveedores);

            this.Close();
            Application.OpenForms["frmProveedores_Perfil"]?.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
