using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.ClasesCompras
{
    internal class clsLlenarComboFormaPago
    {
        clsLlenarComboFormaPago() { }

        public static void llenarComboFormaPago(Krypton.Toolkit.KryptonComboBox cmb, clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                string consulta = "SELECT * FROM VistaFormaPago";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmb.DataSource = dt;
                cmb.DisplayMember = "descripcion_forma_pago";
                cmb.ValueMember = "id_forma_pago";

                cmb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ComboBox: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
        }
    }
}
