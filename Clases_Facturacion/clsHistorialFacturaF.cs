using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TRAMADE
{
    public class clsHistorialFacturaF
    {
        public int id_factura { get; set; }
        public string factura_formateada { get; set; }
        public string id_usuario { get; set; }
        public string dni_rtn_cliente { get; set; }
        public string fecha_emision { get; set; }

        public int ObtenerTotalRegistros()
        {
            int total = 0;
            clsConexion conexion = new clsConexion();
            conexion.Abrir();
            try
            {
                string queryContar = "SELECT COUNT(*) FROM FACTURA";
                SqlCommand cmdContar = new SqlCommand(queryContar, conexion.SqlC);
                total = (int)cmdContar.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al contar las facturas: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
            return total;
        }

        public List<clsHistorialFacturaF> ObtenerHistorial(string filtro, DateTime? fecha, bool ordenAscendente)
        {
            List<clsHistorialFacturaF> lista = new List<clsHistorialFacturaF>();
            clsConexion conexion = new clsConexion();
            conexion.Abrir();

            try
            {
                string query = @"SELECT F.id_factura, F.numero_factura, F.id_usuario, 
                                        C.rtn_cliente, C.dni_cliente, F.fecha_emision 
                                 FROM FACTURA F
                                 INNER JOIN CLIENTE C ON F.id_cliente = C.id_cliente
                                 WHERE 1=1";

                if (!string.IsNullOrEmpty(filtro))
                {
                    string soloNumero = filtro.Replace("INV/2026/", "").TrimStart('0');
                    if (string.IsNullOrEmpty(soloNumero)) soloNumero = "0";
                    query += " AND (F.numero_factura LIKE @fNum OR C.rtn_cliente LIKE @fTxt OR C.dni_cliente LIKE @fTxt)";
                }

                if (fecha.HasValue)
                {
                    query += " AND CAST(F.fecha_emision AS DATE) = @fecha";
                }

                query += ordenAscendente ? " ORDER BY F.numero_factura ASC" : " ORDER BY F.fecha_emision DESC";

                SqlCommand cmd = new SqlCommand(query, conexion.SqlC);

                if (!string.IsNullOrEmpty(filtro))
                {
                    string soloNumero = filtro.Replace("INV/2026/", "").TrimStart('0');
                    cmd.Parameters.AddWithValue("@fNum", "%" + soloNumero + "%");
                    cmd.Parameters.AddWithValue("@fTxt", "%" + filtro + "%");
                }

                if (fecha.HasValue)
                {
                    cmd.Parameters.AddWithValue("@fecha", fecha.Value.Date);
                }

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    clsHistorialFacturaF hist = new clsHistorialFacturaF();

                    hist.id_factura = Convert.ToInt32(dr["id_factura"]);

                    int numF = Convert.ToInt32(dr["numero_factura"]);
                    hist.factura_formateada = "INV/2026/" + numF.ToString("D4");

                    hist.id_usuario = dr["id_usuario"].ToString();

                    // LÓGICA INTELIGENTE PARA EL HISTORIAL
                    string rtn_bd = dr["rtn_cliente"].ToString();
                    string dni_bd = dr["dni_cliente"].ToString();

                    if (!string.IsNullOrEmpty(rtn_bd) && !rtn_bd.StartsWith("SN-"))
                    {
                        hist.dni_rtn_cliente = rtn_bd;
                    }
                    else if (!string.IsNullOrEmpty(dni_bd) && !dni_bd.StartsWith("SN-"))
                    {
                        hist.dni_rtn_cliente = dni_bd;
                    }
                    else
                    {
                        hist.dni_rtn_cliente = "S/N";
                    }

                    hist.fecha_emision = Convert.ToDateTime(dr["fecha_emision"]).ToString("dd/MM/yyyy HH:mm");

                    lista.Add(hist);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar historial: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
            return lista;
        }
    }
}