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

namespace TRAMADE.Formulario_Proveedores
{
    public partial class frmProveedores_Perfil : Form
    {


        private int _idProveedor;
        public frmProveedores_Perfil(int idProveedor)
        {
            InitializeComponent();
            _idProveedor = idProveedor; // Asignar el valor del ID del proveedor al campo privado
            MessageBox.Show("ID: " + _idProveedor);
            clsProveedores_Perfil ObjPerfil = new clsProveedores_Perfil();
            ObjPerfil.CargarPerfil(_idProveedor, lstInformacionGeneral, lstDatosdeContacto, lstClasificacion, chkEstado);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        public void RecargarPerfil()
        {
            clsProveedores_Perfil ObjPerfil = new clsProveedores_Perfil();
            ObjPerfil.CargarPerfil(_idProveedor, lstInformacionGeneral, lstDatosdeContacto, lstClasificacion, chkEstado);
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            clsProveedores_Perfil ObjPerfil = new clsProveedores_Perfil();

            // Cambiar estado en BD
            ObjPerfil.CambiarEstado(_idProveedor, chkEstado.Checked);

            // Recargar perfil
            ObjPerfil.CargarPerfil(_idProveedor, lstInformacionGeneral,
                                    lstDatosdeContacto, lstClasificacion, chkEstado);

            // Recargar DGV en frmProveedores en tiempo real
            frmProveedores frmProv = Application.OpenForms["frmProveedores"] as frmProveedores;
            if (frmProv != null)
                frmProv.RecargarProveedoresAC();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            frmProveedores_Editar frmEditar = new frmProveedores_Editar(_idProveedor);
            frmEditar.ShowDialog();
        }
    }
}
