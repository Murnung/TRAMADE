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
    public partial class frmHistorialFacturas : Form
    {
        bool ordenAscendente = false; // Por defecto: más nuevas primero

        public frmHistorialFacturas()
        {
            InitializeComponent();
        }

        private void frmHistorialFacturas_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial(string filtro = "", DateTime? fecha = null)
        {
            try
            {
                dgvHistorialFacturas.Rows.Clear();
                clsConexion conexion = new clsConexion();
                conexion.Abrir();

                // 1. Primero contamos cuántas facturas hay en total para el numeral descendente
                string queryContar = "SELECT COUNT(*) FROM FACTURA";
                SqlCommand cmdContar = new SqlCommand(queryContar, conexion.SqlC);
                int totalRegistros = (int)cmdContar.ExecuteScalar();

                // 2. Consulta principal
                string query = @"SELECT F.id_factura, F.numero_factura, F.id_usuario, 
                                        C.rtn_cliente, C.dni_cliente, F.fecha_emision 
                                 FROM FACTURA F
                                 INNER JOIN CLIENTE C ON F.id_cliente = C.id_cliente
                                 WHERE 1=1";

                if (!string.IsNullOrEmpty(filtro))
                {
                    // Limpiamos el formato INV/2026/000X para buscar el número real
                    string soloNumero = filtro.Replace("INV/2026/", "").TrimStart('0');
                    if (string.IsNullOrEmpty(soloNumero)) soloNumero = "0";

                    query += " AND (F.numero_factura LIKE @fNum OR C.rtn_cliente LIKE @fTxt OR C.dni_cliente LIKE @fTxt)";
                }

                if (fecha.HasValue)
                {
                    query += " AND CAST(F.fecha_emision AS DATE) = @fecha";
                }

                // Aplicamos el orden
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

                // Lógica del numeral: si es DESC (más nueva arriba), empezamos desde el total
                int contador = ordenAscendente ? 1 : totalRegistros;

                while (dr.Read())
                {
                    int numF = Convert.ToInt32(dr["numero_factura"]);
                    string facturaFormateada = "INV/2026/" + numF.ToString("D4");
                    string dni = dr["rtn_cliente"].ToString();
                    if (string.IsNullOrEmpty(dni)) dni = dr["dni_cliente"].ToString();

                    int n = dgvHistorialFacturas.Rows.Add();
                    dgvHistorialFacturas.Rows[n].Cells[0].Value = contador; // Numeral dinámico
                    dgvHistorialFacturas.Rows[n].Cells[1].Value = facturaFormateada;
                    dgvHistorialFacturas.Rows[n].Cells[2].Value = dr["id_usuario"].ToString();
                    dgvHistorialFacturas.Rows[n].Cells[3].Value = dni;
                    dgvHistorialFacturas.Rows[n].Cells[4].Value = Convert.ToDateTime(dr["fecha_emision"]).ToString("dd/MM/yyyy HH:mm");
                    dgvHistorialFacturas.Rows[n].Tag = dr["id_factura"];

                    // Si es ASC sumamos, si es DESC restamos
                    if (ordenAscendente) contador++; else contador--;
                }

                dr.Close();
                conexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }

        private void txtBuscarFactura_TextChanged(object sender, EventArgs e)
        {
            CargarHistorial(txtBuscarFactura.Text.Trim());
        }

        private void btnCalendarioFacturas_Click(object sender, EventArgs e)
        {
            // Mostramos el valor del DateTimePicker que agregaste
            CargarHistorial("", dtpCalendario.Value);
        }

        private void btnOrdenarFacturas_Click(object sender, EventArgs e)
        {
            ordenAscendente = !ordenAscendente; // Cambia entre ASC y DESC
            CargarHistorial(txtBuscarFactura.Text.Trim());
        }

        private void btnVerFacturaHF_Click(object sender, EventArgs e)
        {
            if (dgvHistorialFacturas.CurrentRow != null && dgvHistorialFacturas.CurrentRow.Tag != null)
            {
                int idFactura = Convert.ToInt32(dgvHistorialFacturas.CurrentRow.Tag);
                frmEmitirFactura objEmitir = new frmEmitirFactura();
                objEmitir.IdFacturaRecibido = idFactura;
                objEmitir.ShowDialog();
            }
        }

        private void btnRegresarHF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHistorialFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}