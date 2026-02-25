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
using TRAMADE.FormulariosAdministrador;
using TRAMADE.ClasesAdministrador;

namespace TRAMADE
{
     
    public partial class frmUsuarios : Form
    {
        //Objeto de conexion a la base de datos

        clsConexion ObjConexion = new clsConexion();
        clsUsuario ObjUsuario = new clsUsuario();
        int usuarioIdSeleccionado;

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void RecargarUsuarios()
        {
            string consulta = "select * from VistaUsuarioTabla";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgbUsuarios.DataSource = dt;
        }



        private void btnBitacora_Click(object sender, EventArgs e)
        {
            frmBitacora ObjBitacora = new frmBitacora();
            ObjBitacora.Show();
            ObjConexion.Cerrar();
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
            try
            {
                ObjConexion.Abrir(); // Abrir la conexión
                string consulta = "SELECT * FROM VistaUsuarioTabla"; // Consulta SQL
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt); // Llenar el DataTable
                dgbUsuarios.DataSource = dt; // Asignar al DataGridView

                chkActivar.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar(); // Siempre cerrar la conexión
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditar ObjEditar = new frmEditar();
            ObjEditar.Show();   
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgbUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            int id = Convert.ToInt32(dgbUsuarios.CurrentRow.Cells["ID"].Value);

            
            int estado;

            if (chkActivar.Checked)
            {
                estado = 1; // activo
            }
            else
            {
                estado = 2; // inactivo
            }
            chkActivar.Enabled = false; // vuelve a deshabilitar


            bool ok = ObjUsuario.cambiarEstado(ObjConexion, id, estado);

            if (ok)
            {
                MessageBox.Show("Tabla actualizada.");
                RecargarUsuarios();
            }

            
        }

        private void dgbUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgbUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                chkActivar.Enabled = true;
                chkActivar.Checked = Convert.ToInt32(dgbUsuarios.Rows[e.RowIndex].Cells["ID estado"].Value) == 1;
            }
        }
    }
}
