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
using TRAMADE.ClasesCliente;

namespace TRAMADE
{
    public partial class frmAprobacion : Form
    {

        public frmAprobacion()
        {
            InitializeComponent();
        }

        private void frmAprobacion_Load(object sender, EventArgs e)
        {
            recargarClientes();
            
        }

        clsConexion ObjConexion = new clsConexion();
        clsCliente ObjCliente = new clsCliente();
        public void AgregarConlumnaCheck()
        {
            if (dgvAprobacion.Columns.Contains("Seleccionar")) return;

            DataGridViewCheckBoxColumn Chk = new DataGridViewCheckBoxColumn();
            Chk.HeaderText = "Seleccionar para editar";
            Chk.Name = "Seleccionar";
            Chk.Width = 80;
            dgvAprobacion.Columns.Insert(0, Chk);
        }

        private void recargarClientes()
        {
            try
            {
                ObjConexion.Abrir();
                string consulta = "SELECT * FROM vista_aprobacion_clientes";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvAprobacion.DataSource = dt;
                dgvAprobacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvAprobacion.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dgvAprobacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvAprobacion.RowHeadersVisible = false;
                dgvAprobacion.AllowUserToResizeRows = false;
                dgvAprobacion.AllowUserToResizeColumns = false;
                dgvAprobacion.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(148, 114, 71);
                dgvAprobacion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvAprobacion.EnableHeadersVisualStyles = false;
                dgvAprobacion.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 154, 111);
                dgvAprobacion.DefaultCellStyle.SelectionForeColor = Color.White;
                AgregarConlumnaCheck();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            bool haySeleccionados = false;
            int contadorExitos = 0;

            
            foreach (DataGridViewRow fila in dgvAprobacion.Rows)
            {
                
                if (Convert.ToBoolean(fila.Cells["Seleccionar"].Value))
                {
                    haySeleccionados = true;

                    try
                    {
                        
                        int idCliente = Convert.ToInt32(fila.Cells["ID Cliente"].Value);

        
                        if (ObjCliente.AutorizarCliente(ObjConexion, idCliente))
                        {
                            contadorExitos++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al procesar un cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (haySeleccionados)
            {
                MessageBox.Show($"{contadorExitos} cliente(s) autorizado(s) correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recargarClientes();
            }
            else
            {
                MessageBox.Show("Por favor, marque la casilla 'Seleccionar' en los clientes que desea autorizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNegar_Click(object sender, EventArgs e)
        {
            bool haySeleccionados = false;
            int contadorNegados = 0;
            foreach (DataGridViewRow fila in dgvAprobacion.Rows)
            {
                if (fila.Cells["Seleccionar"].Value != null && Convert.ToBoolean(fila.Cells["Seleccionar"].Value) == true)
                {
                    haySeleccionados = true;

                    try
                    {
                        int idCliente = Convert.ToInt32(fila.Cells["ID Cliente"].Value);
                        bool exito = ObjCliente.DenegarCliente(ObjConexion, idCliente);

                        if (exito) contadorNegados++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al negar el cliente en la fila {fila.Index + 1}: {ex.Message}", "Error");
                    }
                }
            }
            if (haySeleccionados)
            {
                MessageBox.Show($"Se han negado {contadorNegados} solicitudes de clientes.", "TRAMADE - Rechazo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                recargarClientes();
            }
            else
            {
                MessageBox.Show("No has marcado la columna 'Seleccionar' en ningún cliente para negar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ObjCliente.BuscarCliente(ObjConexion, txtBuscar.Text);
            if (dt != null)
            {
                dgvAprobacion.DataSource = dt;
            }
        }
    }
}
