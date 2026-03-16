using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE
{
    public partial class frmHistorialFacturas : Form
    {
        bool ordenAscendente = false;

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

                // 1. Instanciamos la nueva clase
                clsHistorialFacturaF objHistorial = new clsHistorialFacturaF();

                // 2. Obtenemos el total de registros para tu lógica de conteo
                int totalRegistros = objHistorial.ObtenerTotalRegistros();

                // 3. Obtenemos la lista ya filtrada y ordenada
                List<clsHistorialFacturaF> listaFacturas = objHistorial.ObtenerHistorial(filtro, fecha, ordenAscendente);

                // 4. Lógica del numeral
                int contador = ordenAscendente ? 1 : totalRegistros;

                // 5. Llenamos el Grid
                foreach (var fac in listaFacturas)
                {
                    int n = dgvHistorialFacturas.Rows.Add();
                    dgvHistorialFacturas.Rows[n].Cells[0].Value = contador;
                    dgvHistorialFacturas.Rows[n].Cells[1].Value = fac.factura_formateada;
                    dgvHistorialFacturas.Rows[n].Cells[2].Value = fac.id_usuario;
                    dgvHistorialFacturas.Rows[n].Cells[3].Value = fac.dni_rtn_cliente;
                    dgvHistorialFacturas.Rows[n].Cells[4].Value = fac.fecha_emision;

                    // El truco del Tag sigue intacto
                    dgvHistorialFacturas.Rows[n].Tag = fac.id_factura;

                    if (ordenAscendente) contador++; else contador--;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message, "TRAMADE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtBuscarFactura_TextChanged(object sender, EventArgs e)
        {
            CargarHistorial(txtBuscarFactura.Text.Trim());
        }

        private void btnCalendarioFacturas_Click(object sender, EventArgs e)
        {
            CargarHistorial("", dtpCalendario.Value);
        }

        private void btnOrdenarFacturas_Click(object sender, EventArgs e)
        {
            ordenAscendente = !ordenAscendente;
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

        private void dgvHistorialFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
