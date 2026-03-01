using Krypton.Toolkit;
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
    internal class clsFiltrarCompras
    {
        public clsFiltrarCompras() { }

        //Filtrar por fechas
        public DataTable FiltrarFechas(clsConexion conexion, KryptonDateTimePicker desde, KryptonDateTimePicker hasta, string textoBuscar)
        {
            try
            {
                conexion.Abrir();

                string consulta = "SELECT * FROM VistaComprasTabla WHERE [Fecha pedido] >= @desde AND [Fecha pedido] <= @hasta";

                int id = 0;
                bool filtrarPorId = int.TryParse(textoBuscar.Trim(), out id);

                if (filtrarPorId)
                {
                    consulta += " AND [ID compra] = @id";
                }

                using (SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC))
                {
                    cmd.Parameters.AddWithValue("@desde", desde.Value.Date);
                    cmd.Parameters.AddWithValue("@hasta", hasta.Value.Date.AddDays(1).AddSeconds(-1));

                    if (filtrarPorId)
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar compras: " + ex.Message);
                return null;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        //Buscar por id de compra
        public DataTable BuscarCompra(clsConexion conexion, string textoBuscar)
        {
            try
            {
                conexion.Abrir();

                string consulta = "SELECT * FROM VistaComprasTabla";

                int id = 0;
                bool filtrarPorId = int.TryParse(textoBuscar.Trim(), out id);

                if (filtrarPorId)
                {
                    consulta += " WHERE [ID compra] = @id";
                }

                using (SqlCommand cmd = new SqlCommand(consulta, conexion.SqlC))
                {
                    if (filtrarPorId)
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar compra: " + ex.Message);
                return null;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
    }
}
