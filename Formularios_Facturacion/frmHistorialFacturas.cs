using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Indispensable para conectar con SQL
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE
{
    public partial class frmHistorialFacturas : Form
    {
        public frmHistorialFacturas()
        {
            InitializeComponent();
        }

        private void frmHistorialFacturas_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        // 1. MÉTODO PARA CARGAR TODAS LAS FACTURAS
        private void CargarHistorial()
        {
            try
            {
                dgvHistorialFacturas.Rows.Clear(); // Limpiamos antes de cargar

                clsConexion conexion = new clsConexion();
                conexion.Abrir();

                // Traemos los datos necesarios haciendo JOIN con Cliente
                string query = @"SELECT F.id_factura, F.numero_factura, F.id_usuario, 
                                        C.rtn_cliente, C.dni_cliente, F.fecha_emision 
                                 FROM FACTURA F
                                 INNER JOIN CLIENTE C ON F.id_cliente = C.id_cliente
                                 ORDER BY F.fecha_emision DESC"; // Las más nuevas primero

                SqlCommand cmd = new SqlCommand(query, conexion.SqlC);
                SqlDataReader dr = cmd.ExecuteReader();

                int contador = 1; // Para el numeral (1, 2, 3...)

                while (dr.Read())
                {
                    // Formateamos el número de factura como quieres
                    int numF = Convert.ToInt32(dr["numero_factura"]);
                    string facturaFormateada = "INV/2026/" + numF.ToString("D4");

                    // Manejo de DNI o RTN
                    string dni = dr["rtn_cliente"].ToString();
                    if (string.IsNullOrEmpty(dni)) dni = dr["dni_cliente"].ToString();

                    // Agregamos la fila al Grid
                    // OJO: dgvHistorialFacturas.Rows.Add devuelve el índice de la fila agregada
                    int n = dgvHistorialFacturas.Rows.Add();

                    dgvHistorialFacturas.Rows[n].Cells[0].Value = contador; // Numeral
                    dgvHistorialFacturas.Rows[n].Cells[1].Value = facturaFormateada; // NumFactura
                    dgvHistorialFacturas.Rows[n].Cells[2].Value = dr["id_usuario"].ToString(); // IDVendedor
                    dgvHistorialFacturas.Rows[n].Cells[3].Value = dni; // DNIRTNClieten
                    dgvHistorialFacturas.Rows[n].Cells[4].Value = Convert.ToDateTime(dr["fecha_emision"]).ToString("dd/MM/yyyy HH:mm");

                    // ¡EL TRUCO! Guardamos el ID real de la DB en el Tag de la fila (invisible)
                    dgvHistorialFacturas.Rows[n].Tag = dr["id_factura"];

                    contador++;
                }

                dr.Close();
                conexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial: " + ex.Message);
            }
        }

        // 2. BOTÓN PARA VER LA FACTURA SELECCIONADA
        private void btnVerFacturaHF_Click(object sender, EventArgs e)
        {
            // 1. Verificamos que haya una fila seleccionada y que no sea la fila vacía del final
            if (dgvHistorialFacturas.CurrentRow != null && dgvHistorialFacturas.CurrentRow.Tag != null)
            {
                // 2. Recuperamos el ID que guardamos en el Tag
                int idFactura = Convert.ToInt32(dgvHistorialFacturas.CurrentRow.Tag);

                // --- PRUEBA (Borrala después de confirmar que funciona) ---
                // MessageBox.Show("Abriendo factura ID: " + idFactura); 
                // -----------------------------------------------------------

                // 3. Abrimos el formulario de emisión
                frmEmitirFactura objEmitir = new frmEmitirFactura();
                objEmitir.IdFacturaRecibido = idFactura;
                objEmitir.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una factura de la lista haciendo clic en la fila.", "TRAMADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegresarHF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonLabel2_Click(object sender, EventArgs e) { }

        private void dgvHistorialFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}