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
    internal class clsLlenarComboProveedor
    {
        clsLlenarComboProveedor() { }
        public static void llenarComboProveedor(Krypton.Toolkit.KryptonComboBox cmb, clsConexion conexion,string texto = "")
        {
            try
            {
                conexion.Abrir();

                SqlCommand cmd;
              
                // Si no hay texto muestra todos, si hay texto filtra
                if (string.IsNullOrEmpty(texto))
                {
                    cmd = new SqlCommand("SELECT * FROM VistaProveedor", conexion.SqlC);
                }
                else
                {
                    cmd = new SqlCommand("SELECT * FROM VistaProveedor WHERE nombre_comercial_proveedor LIKE @texto", conexion.SqlC);
                    cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmb.DataSource = dt;
                cmb.DisplayMember = "nombre_comercial_proveedor";
                cmb.ValueMember = "id_proveedor";
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
