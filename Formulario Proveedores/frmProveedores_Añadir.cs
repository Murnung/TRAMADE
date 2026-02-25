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

            clsConexion ObjConexion = new clsConexion();
            //PAra que no agarre el valor 0 en la base de datos
            //Clasificación
            SqlDataAdapter ad1 = new SqlDataAdapter(
                "SELECT id_clasificacion_proveedor, descripcion_clasificacion_proveedor FROM CLASIFICACION_PROVEEDOR",
                ObjConexion.SqlC);

            DataTable dt1 = new DataTable();
            ad1.Fill(dt1);

            cmbClasificacion.DataSource = dt1;
            cmbClasificacion.DisplayMember = "descripcion_clasificacion_proveedor";
            cmbClasificacion.ValueMember = "id_clasificacion_proveedor";


            //Terminos de pago
            SqlDataAdapter ad2 = new SqlDataAdapter(
                "SELECT id_terminos_de_pago_proveedor, descripcion_terminos_de_pago FROM TERMINOS_DE_PAGO_PROVEEDOR",
                ObjConexion.SqlC);

            DataTable dt2 = new DataTable();
            ad2.Fill(dt2);

            cmbTerminosdePago.DataSource = dt2;
            cmbTerminosdePago.DisplayMember = "descripcion_terminos_de_pago";
            cmbTerminosdePago.ValueMember = "id_terminos_de_pago_proveedor";
        }



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

            clsProveedores objP = new clsProveedores(
                txtNombreComercial.Text,
                txtRazonSocial.Text,
                txtDireccionFiscal.Text,
                txtRtn.Text,
                Convert.ToInt32(cmbClasificacion.SelectedValue),
                Convert.ToInt32(cmbTerminosdePago.SelectedValue),
                txtTelefonoGeneral.Text,
                txtCorreoCentral.Text
            );

            objAdd.InsertarProveedor(objP);

            this.Close(); // 🔥 cierra añadir

            LimpiarCampos();
        }
    
    }
}
