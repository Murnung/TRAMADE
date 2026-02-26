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
using TRAMADE.Formulario_Proveedores;
using TRAMADE.Formulario_Proveedores.Clases;

namespace TRAMADE
{
    public partial class frmProveedores : Form
    {
        
        clsConexion ObjConexion = new clsConexion();
        public frmProveedores()
        {
            InitializeComponent();
            RecargarProveedores();
        }

        private void tmrTransicionLateral(object sender, EventArgs e)
        {



        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void RecargarProveedores()
        {
            string consulta = "select * from VistaProveedorTabla";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvProveedores.DataSource = dt;
        }

        private void btnAñadirProveedor_Click(object sender, EventArgs e)
        {
            frmProveedores_Añadir frmAñadir = new frmProveedores_Añadir();
            frmAñadir.ShowDialog(); 

            RecargarProveedores(); 
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idProveedor = Convert.ToInt32(dgvProveedores.Rows[e.RowIndex].Cells["id_proveedor"].Value);

                frmProveedores_Perfil frmPerfil = new frmProveedores_Perfil(idProveedor);
                frmPerfil.Show();
            }
        }
    }
}

