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
        public frmBitacora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RecargarBitacora()
        {
            string consulta = "SELECT * FROM VistaBitacora";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion.SqlC);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
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
                conexion.Abrir();
                RecargarBitacora();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar(); // Siempre cerrar la conexión
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
            try
            {
                conexion.Abrir(); // Abrimos la conexión

                // Consulta base
                string consulta = "SELECT * FROM VistaBitacora WHERE [Fecha de acción] >= @desde AND [Fecha de acción] <= @hasta";

                string rol = cmbUsuario.Text.Trim();

                if (!string.IsNullOrWhiteSpace(rol))
                {
                    consulta += " AND Rol = @rol"; // Agregamos filtro por rol si aplica
                }
               
                
                using (SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC))
                {
                    // Parámetros de fecha
                    cmd.Parameters.AddWithValue("@desde", dtDesde.Value.Date);
                    cmd.Parameters.AddWithValue("@hasta", dtHasta.Value.Date.AddDays(1).AddSeconds(-1)); // hasta 23:59:59

                    // Parámetro de rol si aplica
                    if (!string.IsNullOrWhiteSpace(rol))
                        cmd.Parameters.AddWithValue("@rol", rol);

                    // Llenar DataTable con los resultados
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Asignar al DataGridView
                    dgvBitacora.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar la bitácora: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar(); // Cerramos la conexión siempre
            }
        }
    }
    
}
