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
using TRAMADE.Formularios_Login__Menú.Clases;

namespace TRAMADE
{

    public partial class frmMenuPrincipal : Form
    {
        Form1 dashboard;
        frmCompras compras;
        frmProveedores proveedores;
        frmInventario inventario;
        frmMenu clientes;
        frmReportes reportes;   
        frmFacturacion facturacion;


        public frmMenuPrincipal()
        {
            InitializeComponent();
            mdiProp();
        }


        bool sidebarExpand = true;

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }


        private void CerrarFormulariosHijos()
        {
            foreach (Form hijo in this.MdiChildren)
                hijo.Close();
        }

        private void AbrirFormulario(Form formulario)
        {
            CerrarFormulariosHijos();
            formulario.MdiParent = this;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Text = "";

            
            MdiClient mdiArea = Controls.OfType<MdiClient>().FirstOrDefault();
            if (mdiArea != null)
            {
                formulario.Show();
                formulario.Location = new Point(0, 0);
                formulario.Size = mdiArea.ClientSize;
            }
            else
            {
                formulario.WindowState = FormWindowState.Maximized;
                formulario.Show();
            }
        }

        private void tmrTransicionLateral_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                flpBarraLateral.Width -= 5;
                if (flpBarraLateral.Width <= 84)
                {
                    sidebarExpand = false;
                    tmrTransicionLateral.Stop();
                }
            }
            else
            {
                flpBarraLateral.Width += 5;
                if (flpBarraLateral.Width >= 239)
                {
                    sidebarExpand = true;
                    tmrTransicionLateral.Stop();

                    pnlDashboard.Width = flpBarraLateral.Width;
                    pnlClientes.Width = flpBarraLateral.Width;
                    pnlCompras.Width = flpBarraLateral.Width;
                    pnlInventario.Width = flpBarraLateral.Width;
                    pnlProveedores.Width = flpBarraLateral.Width;
                    pnlReportes.Width = flpBarraLateral.Width;
                    pnlVentas.Width = flpBarraLateral.Width;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tmrTransicionLateral.Start();
        }

        

        private void kryptonButton2_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormulario(new Form1());
        }

        private void frmMenuPrincipal_SizeChanged(object sender, EventArgs e)
        {
            MdiClient mdiArea = Controls.OfType<MdiClient>().FirstOrDefault();
            if (mdiArea != null)
            {
                foreach (Form hijo in MdiChildren)
                {
                    hijo.Location = new Point(0, 0);
                    hijo.Size = mdiArea.ClientSize;
                }
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form1());
        }

        

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmMenu());
        }

       

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmFacturacion());
        }

        

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInventario());
        }

        

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCompras());
        }

        

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProveedores());
        }

        

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReportes());
        }

        private void frmMenuPrincipal_Shown(object sender, EventArgs e)
        {
            flpBarraLateral.Width = 239;
            sidebarExpand = true;

            pnlDashboard.Width = 239;
            pnlClientes.Width = 239;
            pnlCompras.Width = 239;
            pnlInventario.Width = 239;
            pnlProveedores.Width = 239;
            pnlReportes.Width = 239;
            pnlVentas.Width = 239;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?",
        "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                
                clsSesion.id_usuario = 0;
                clsSesion.nombre_usuario = string.Empty;

                
                CerrarFormulariosHijos();

                
                frmLogin login = new frmLogin();
                login.Show();
                this.Close();
            }
        }
    }
}