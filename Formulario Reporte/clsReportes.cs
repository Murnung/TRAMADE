using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TRAMADE.Formulario_Reporte
{
    internal class clsReportes
    {
        private readonly ComboBox _cmbSucursal;
        private readonly ComboBox _cmbTipoReporte;

        public clsReportes(ComboBox cmbSucursal, ComboBox cmbTipoReporte)
        {
            _cmbSucursal = cmbSucursal;
            _cmbTipoReporte = cmbTipoReporte;
        }

        public void CargarSucursales()
        {
            clsConexion cn = new clsConexion();
            try
            {
                cn.Abrir();
                string query = "SELECT id_sucursal, nombre_sucursal FROM SUCURSAL";
                SqlDataAdapter da = new SqlDataAdapter(query, cn.SqlC);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataRow row = dt.NewRow();
                row["id_sucursal"] = 0;
                row["nombre_sucursal"] = "Todas";
                dt.Rows.InsertAt(row, 0);

                _cmbSucursal.DataSource = dt;
                _cmbSucursal.DisplayMember = "nombre_sucursal";
                _cmbSucursal.ValueMember = "id_sucursal";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar sucursales: " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { cn.Cerrar(); }
        }

        public void CargarTiposReporte()
        {
            _cmbTipoReporte.Items.Clear();
            _cmbTipoReporte.Items.Add("Ventas por período");
            _cmbTipoReporte.Items.Add("Compras por período");
            _cmbTipoReporte.Items.Add("Stock por sucursal");
            _cmbTipoReporte.Items.Add("Productos más vendidos");
            _cmbTipoReporte.SelectedIndex = 0;
        }
    }
}
