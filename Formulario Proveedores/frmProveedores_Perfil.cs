using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.Formulario_Proveedores
{
    public partial class frmProveedores_Perfil : Form
    {
        public frmProveedores_Perfil()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmProveedores_Editar frmEditar = new frmProveedores_Editar();
            frmEditar.Show();
        }
    }
}
