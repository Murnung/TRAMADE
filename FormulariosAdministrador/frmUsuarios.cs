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
                RecargarUsuarios();

                chkActivar.Enabled = false;
                dgbUsuarios.Columns["ID rol"].Visible = false;
                dgbUsuarios.Columns["ID sucursal"].Visible = false;
                dgbUsuarios.Columns["ID estado"].Visible = false;

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

            if (!chkActivar.Enabled)
            {
                MessageBox.Show("Seleccione un usuario de la tabla primero.");
                return;
            }

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
                MessageBox.Show("Estado de usuario actualizado.");
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

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string nombre = txtBuscar.Text.Trim();
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    RecargarUsuarios();
                    ObjConexion.Cerrar();
                    return;
                }
                ObjConexion.Abrir();

                // Prepara el comando SQL y agrega el parámetro con comodín %
                string consulta = "select * from VistaUsuarioTabla where Nombre like @nombre";
                SqlCommand cmd = new SqlCommand(consulta, ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@nombre",nombre);

                // Ejecuta la consulta y llena un DataTable con los resultados
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable resultado = new DataTable();
                adapter.Fill(resultado);

                dgbUsuarios.DataSource = resultado;

                ObjConexion.Cerrar();
            }
            catch (Exception ex)
            {
                ObjConexion.Cerrar();
                MessageBox.Show("Error al buscar: " + ex.Message);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingresá el nombre del usuario que querés buscar.");
                return;
            }

            // Deseleccionar todas las filas
            dgbUsuarios.ClearSelection();

            bool encontrado = false;

            // Buscar en todas las filas del DataGridView
            foreach (DataGridViewRow fila in dgbUsuarios.Rows)
            {
                if (fila.Cells["Nombre"].Value != null &&
                    fila.Cells["Nombre"].Value.ToString().IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    fila.Selected = true; // Selecciona la fila
                    dgbUsuarios.FirstDisplayedScrollingRowIndex = fila.Index; // Desplaza la vista a la fila
                    encontrado = true;
                    break; // Elimina esto si querés que seleccione múltiples coincidencias
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró ningún usuario con ese nombre.");
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RecargarUsuarios();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
