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
    public partial class frmBitacora : Form
    {
        public frmBitacora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios ObjUsusarios = new frmUsuarios();
            ObjUsusarios.Show();
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {

        }
    }
}
