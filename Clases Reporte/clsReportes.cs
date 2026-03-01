using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.Clases_Reporte;

namespace TRAMADE.Formulario_Reporte
{
    internal class clsReportes
    {
        private readonly ComboBox _cmbSucursal;
        private readonly ComboBox _cmbTipoReporte;
        private readonly ListView _lstReportes;

        public clsReportes(ComboBox cmbSucursal, ComboBox cmbTipoReporte, ListView lstReportes)
        {
            _cmbSucursal = cmbSucursal;
            _cmbTipoReporte = cmbTipoReporte;
            _lstReportes = lstReportes;
        }

        public void CargarSucursales()
        {
            clsConexion cn = new clsConexion();
            try
            {
                cn.Abrir();
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT id_sucursal, nombre_sucursal FROM SUCURSAL", cn.SqlC);
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

        public void Generar(DateTime fechaInicio, DateTime fechaFin, int idSucursal)
        {
            if (_cmbTipoReporte.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un tipo de reporte.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (_cmbTipoReporte.SelectedItem.ToString())
            {
                case "Ventas por período":
                    AgregarALista(
                        $"Ventas | {fechaInicio:dd/MM/yyyy} - {fechaFin:dd/MM/yyyy} | {_cmbSucursal.Text}",
                        "Ventas por período", fechaInicio, fechaFin, idSucursal);
                    break;
                case "Compras por período":
                    AgregarALista(
                        $"Compras | {fechaInicio:dd/MM/yyyy} - {fechaFin:dd/MM/yyyy} | {_cmbSucursal.Text}",
                        "Compras por período", fechaInicio, fechaFin, idSucursal);
                    break;
                case "Stock por sucursal":
                    AgregarALista(
                        $"Stock | {_cmbSucursal.Text}",
                        "Stock por sucursal", fechaInicio, fechaFin, idSucursal);
                    break;
                case "Productos más vendidos":
                    AgregarALista(
                        $"Productos más vendidos | {fechaInicio:dd/MM/yyyy} - {fechaFin:dd/MM/yyyy} | {_cmbSucursal.Text}",
                        "Productos más vendidos", fechaInicio, fechaFin, idSucursal);
                    break;
            }
        }

        public void AbrirReporte(string formato)
        {
            if (_lstReportes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un reporte de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            clsReportItem item = (clsReportItem)_lstReportes.SelectedItems[0].Tag;

            LocalReport report = null;

            switch (item.TipoReporte)
            {
                case "Ventas por período":
                    report = new clsRptVentas().Generar(item.FechaInicio, item.FechaFin, item.IdSucursal);
                    break;
                case "Compras por período":
                    report = new clsRptCompras().Generar(item.FechaInicio, item.FechaFin, item.IdSucursal);
                    break;
                case "Stock por sucursal":
                    report = new clsRptStock().Generar(item.IdSucursal);
                    break;
                case "Productos más vendidos":
                    report = new clsRptProductos().Generar(item.FechaInicio, item.FechaFin, item.IdSucursal);
                    break;
            }

            if (report != null)
                clsDescarga.Descargar(report, formato);
        }

        private void AgregarALista(string descripcion, string tipoReporte,
            DateTime fechaInicio, DateTime fechaFin, int idSucursal)
        {
            var item = new ListViewItem(descripcion);
            item.Tag = new clsReportItem
            {
                TipoReporte = tipoReporte,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin,
                IdSucursal = idSucursal
            };
            _lstReportes.Items.Add(item);
            item.Selected = true;
        }
    }
}
