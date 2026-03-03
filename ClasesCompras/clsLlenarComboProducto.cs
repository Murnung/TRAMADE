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
        public static void llenarComboProducto(Krypton.Toolkit.KryptonComboBox cmb, clsConexion conexion,string texto = "")
        {
            try
            {
                conexion.Abrir();
                SqlCommand cmd;

                if (string.IsNullOrEmpty(texto))
                {
                    cmd = new SqlCommand("SELECT * FROM VistaProducto", conexion.SqlC);
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM VistaProducto WHERE nombre_producto LIKE @texto COLLATE SQL_Latin1_General_CP1_CI_AS", conexion.SqlC);
                    cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // <-- FALTABA cmd AQUÍ
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
