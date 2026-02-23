using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace TRAMADE
{
    public partial class frmUsuarios : Form
    {
        //Objeto de conexion a la base de datos

        clsConexion ObjConexion = new clsConexion();

        public frmUsuarios()
        {
            InitializeComponent();
            ObjConexion.Abrir();
            string consulta = "select * from VistaUsurioTabla"
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgbUsuarios.DataSource = dt;
            this.reportViewer1.RefreshReport();
        }



        private void btnBitacora_Click(object sender, EventArgs e)
        {
            frmBitacora ObjBitacora = new frmBitacora();
            ObjBitacora.Show();
            this.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevo ObjNuevo = new frmNuevo();
            ObjNuevo.Show();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
