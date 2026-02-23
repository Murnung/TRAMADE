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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios ObjUsuarios = new frmUsuarios();
            ObjUsuarios.Show();
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            frmBitacora ObjBitacora = new frmBitacora();
            ObjBitacora.Show();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
