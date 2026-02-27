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

            MessageBox.Show("ID: " + _idProveedor); // debug
            clsProveedores_Perfil ObjPerfil = new clsProveedores_Perfil();
            ObjPerfil.CargarPerfil(_idProveedor, lstInformacionGeneral, lstDatosdeContacto, lstClasificacion, chkEstado);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmProveedores_Editar frmEditar = new frmProveedores_Editar();
            frmEditar.Show();
        }

    }
}
