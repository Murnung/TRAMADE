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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        bool sidebarExpand = true;

        private void tmrTransicionLateral_Tick(object sender, EventArgs e)
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
                if(flpBarraLateral.Width >= 245)
                {
                    sidebarExpand = true;
                    tmrTransicionLateral.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tmrTransicionLateral.Start();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
