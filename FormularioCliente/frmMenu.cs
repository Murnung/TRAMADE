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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistro objRegis = new frmRegistro();
            objRegis.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmRegistroNuevo objRegisNue = new frmRegistroNuevo();
            objRegisNue.Show();
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            frmAprobacion objApro = new frmAprobacion();
            objApro.Show();
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            frmSeguimiento objSegui = new frmSeguimiento();
            objSegui.Show();
        }
    }
}
