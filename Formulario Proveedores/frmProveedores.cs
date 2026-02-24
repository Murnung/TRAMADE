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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void tmrTransicionLateral(object sender, EventArgs e)
        {



        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAñadirProveedor_Click(object sender, EventArgs e)
        {
            frmProveedores_Añadir frmAñadir = new frmProveedores_Añadir();

            frmAñadir.ShowDialog();
        }
    }
}
