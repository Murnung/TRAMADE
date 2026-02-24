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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        bool sidebarExpand = true;

        /*private void tmrTransicionLateral(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flpBarraLateral.Width -= 5;
                if (flpBarraLateral.Width <= 85)
                {
                    sidebarExpand = false;
                    tmrTransicionLateral.Stop();
                }
            }

            else
            {
                flpBarraLateral.Width += 5;
                if (flpBarraLateral.Width >= 245)
                {
                    sidebarExpand = true;
                    tmrTransicionLateral.Stop();
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tmrTransicionLateral.Start();
        }*/

        private void btnAñadirProveedor_Click(object sender, EventArgs e)
        {
            frmProveedores_Añadir frmAñadir = new frmProveedores_Añadir();
            frmAñadir.ShowDialog();
        }
    }
}
