using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.ClasesCompras
{
    internal class clsIndicadores
    {

        public static void totalSolicitudesRegistradas(clsConexion conexion, System.Windows.Forms.Label lbl)
        {
            conexion.Abrir();
            string consulta = "\r\n SELECT count (Distinct [ID compra]) FROM VistaComprasTabla";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion.SqlC);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
                lbl.Text = dt.Rows[0][0].ToString();

            conexion.Cerrar();
        }

        public static void totalValorPendiente(clsConexion conexion, System.Windows.Forms.Label lbl)
        {
            conexion.Abrir();
            string consulta = "\r\n SELECT SUM([Precio costo] * Cantidad * 1.15)  FROM VistaComprasTabla";
            SqlDataAdapter adapater = new SqlDataAdapter(consulta, conexion.SqlC);
            DataTable dt = new DataTable();
            adapater.Fill(dt);

            if (dt.Rows.Count > 0)
                lbl.Text = "L " + dt.Rows[0][0].ToString();

            conexion.Cerrar();
        }

        public static void tiempoEsperaPromedio(clsConexion conexion, System.Windows.Forms.Label lbl)
        {
            conexion.Abrir();
            string consulta = "\r\n \r\nSELECT AVG(DATEDIFF(day, [Fecha pedido], [Fecha entrega]))  FROM VistaComprasTabla\r\n";
            SqlDataAdapter adapater = new SqlDataAdapter(consulta, conexion.SqlC);
            DataTable dt = new DataTable();
            adapater.Fill(dt);

            if (dt.Rows.Count > 0)
                lbl.Text = dt.Rows[0][0].ToString() + " dias";

            conexion.Cerrar();
        }
    }
}
