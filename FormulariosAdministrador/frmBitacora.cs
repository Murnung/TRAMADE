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
using TRAMADE.ClasesAdministrador;

namespace TRAMADE
{
    public partial class frmBitacora : Form
    {
        clsConexion conexion = new clsConexion();
        clsUsuario ObjUsuario = new clsUsuario();
        clsBitacora ObjBitacora = new clsBitacora();
        public frmBitacora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RecargarBitacora()
        {
            DataTable dt = ObjBitacora.obtenerBitacoraTabla(conexion);
            if (dt != null)
                dgvBitacora.DataSource = dt;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios ObjUsusarios = new frmUsuarios();
            ObjUsusarios.Show();
            this.Close();
            conexion.Cerrar();
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            try
            {
                clsUsuario.llenarComboRol(cmbUsuario, conexion);
                RecargarBitacora();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvBitacora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbUsuario_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedIndex != -1 && cmbUsuario.SelectedItem is DataRowView)
            {
                DataRowView drv = (DataRowView)cmbUsuario.SelectedItem;
                int rolId = Convert.ToInt32(drv["id_rol"]);
                string rolNombre = drv["descripcion_rol"].ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!clsValidar.FechaFiltro(dtDesde.Value, dtHasta.Value)) return;

            string rol = cmbUsuario.Text.Trim();

            DataTable dt = ObjBitacora.filtrarBitacora(conexion, dtDesde.Value, dtHasta.Value, rol);
            if (dt != null)
                dgvBitacora.DataSource = dt;
        }
    }
    
}
