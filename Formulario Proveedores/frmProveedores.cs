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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        bool sidebarExpand = true;

        private void tmrTransicionLateral(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flpBarraLateral.Width -= 5;
                if (flpBarraLateral.Width <= 85)
                {
                    sidebarExpand = false;
                    
                }
            }

            else
            {
                flpBarraLateral.Width += 5;
                if (flpBarraLateral.Width >= 245)
                {
                    sidebarExpand = true;
                    
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            
        }


        private void btnAñadirProveedor_Click(object sender, EventArgs e)
        {
            frmProveedores_Añadir ObjNuevo = new frmProveedores_Añadir();

            ObjNuevo.ShowDialog();
        }
    }
}
