using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE
{
    internal class clsConexion
    {
        string conexion = "Data Source=db-tramade.database.windows.net;Initial Catalog=DB_TRAMADE;User ID=TMSS;Password=Elmaster8;";

        public SqlConnection SqlC = new SqlConnection();
        public clsConexion()
        {
            SqlC.ConnectionString = conexion;
        }
        public void Abrir()
        {
            try
            {
                if (SqlC.State == ConnectionState.Closed)
                {
                    SqlC.Open();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Cerrar()
        {
            try
            {
                if (SqlC.State == System.Data.ConnectionState.Open)
                {
                    SqlC.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
