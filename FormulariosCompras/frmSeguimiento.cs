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

namespace TRAMADE
{

    public partial class frmSeguimiento : Form
    {
        public frmSeguimiento()
        {
            InitializeComponent();
        }
        clsConexion ObjConexion = new clsConexion();

        private void RecargarUsuarios()
        {
            string consulta = "select * from VistaComprasTabla";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCompras.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmSeguimiento_Load(object sender, EventArgs e)
        {
            try
            {
                ObjConexion.Abrir(); // Abrir la conexión
                RecargarUsuarios();

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



        private void kryptonGroupBox1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ObjConexion.Abrir(); // Abrimos la conexión

                // Consulta base
                string consulta = "SELECT * FROM VistaComprasTabla WHERE [Fecha pedido] >= @desde AND [Fecha pedido] <= @hasta";

                int id = 0;
                bool filtrarPorId = int.TryParse(txtBuscar.Text.Trim(), out id);

                if (filtrarPorId)
                {
                    consulta += " AND [ID compra] = @id"; //Agregamos filsto para el id de la solicitud de compra por si aplica
                }

                using (SqlCommand cmd = new SqlCommand(consulta, ObjConexion.SqlC))
                {
                    // Parámetros de fecha
                    cmd.Parameters.AddWithValue("@desde", dtDesde.Value.Date);
                    cmd.Parameters.AddWithValue("@hasta", dtHasta.Value.Date.AddDays(1).AddSeconds(-1)); // hasta 23:59:59

                     //Parametros de ID por si aplieca
                    if (filtrarPorId)
                    {
                        cmd.Parameters.AddWithValue("@id",id);
                    }
                    // Llenar DataTable con los resultados
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Asignar al DataGridView
                    dgvCompras.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar compras: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar(); // Cerramos la conexión siempre
            }

        }
    }
}
