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
    internal class clsLlenarComboProducto
    {

        clsLlenarComboProducto () { }
        public static void llenarComboProducto(Krypton.Toolkit.KryptonComboBox cmb, clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                string consulta = "SELECT id_producto, nombre_producto FROM VistaProducto";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);


                cmb.DataSource = dt;
                cmb.DisplayMember = "nombre_producto";
                cmb.ValueMember = "id_producto";
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
