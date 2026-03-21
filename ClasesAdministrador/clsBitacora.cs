using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.ClasesAdministrador
{
    internal class clsBitacora
    {
        // ─── OBTENER TODA LA BITÁCORA ─────────────────────────────────
        public DataTable obtenerBitacoraTabla(clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                string consulta = "SELECT * FROM VistaBitacora";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        // ─── FILTRAR BITÁCORA POR FECHA Y ROL ────────────────────────
        public DataTable filtrarBitacora(clsConexion conexion, DateTime desde, DateTime hasta, string rol)
        {
            try
            {
                conexion.Abrir();

                string consulta = @"SELECT * FROM VistaBitacora 
                            WHERE [Fecha de acción] >= @desde 
                              AND [Fecha de acción] <= @hasta";

                if (!string.IsNullOrWhiteSpace(rol))
                    consulta += " AND Rol = @rol";

                SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC);
                cmd.Parameters.AddWithValue("@desde", desde.Date);
                cmd.Parameters.AddWithValue("@hasta", hasta.Date.AddDays(1).AddSeconds(-1));

                if (!string.IsNullOrWhiteSpace(rol))
                    cmd.Parameters.AddWithValue("@rol", rol);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar la bitácora: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
    }
}
