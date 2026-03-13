using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.Formularios_Login__Menú;

namespace TRAMADE
{
    public partial class frmMenuPrincipal : Form
    {
        private readonly ResponsiveFormManager _responsive;

        public frmMenuPrincipal()
        {
            InitializeComponent();
            _responsive = new ResponsiveFormManager(this);
        }

        private const int SIDEBAR_COLLAPSED = 85;
        private const int SIDEBAR_EXPANDED = 245;
        private const int FORM_ORIGINAL_WIDTH = 1187;

        bool sidebarExpand = true;

        private float ScaleX => (float)this.ClientSize.Width / FORM_ORIGINAL_WIDTH;
        private int SidebarCollapsed => (int)(SIDEBAR_COLLAPSED * ScaleX);
        private int SidebarExpanded => (int)(SIDEBAR_EXPANDED * ScaleX);

        private void tmrTransicionLateral_Tick(object sender, EventArgs e)
        {
            int step = Math.Max(1, (int)(5 * ScaleX));

            if (sidebarExpand)
            {
                flpBarraLateral.Width -= step;
                if (flpBarraLateral.Width <= SidebarCollapsed)
                {
                    flpBarraLateral.Width = SidebarCollapsed;
                    sidebarExpand = false;
                    tmrTransicionLateral.Stop();
                }
            }
            else
            {
                flpBarraLateral.Width += step;
                if (flpBarraLateral.Width >= SidebarExpanded)
                {
                    flpBarraLateral.Width = SidebarExpanded;
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

        private void kryptonButton2_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            _responsive.Initialize();
        }

        private void frmMenuPrincipal_SizeChanged(object sender, EventArgs e)
        {
            _responsive.AdjustLayout();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Form1 frmLol = new Form1();
            frmLol.Show(); // Agregué el .Show() para que haga algo
        }
    }
}