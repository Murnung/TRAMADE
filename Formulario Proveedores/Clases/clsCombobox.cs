using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.Formulario_Proveedores
{
    internal class clsCombobox
    {
        // ─── LLENAR COMBO CLASIFICACIÓN ──────────────────────────────
        public static void LlenarClasificacion(KryptonComboBox cmb, clsConexion ObjConexion)
        {
            try
            {
                ObjConexion.Abrir();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT id_clasificacion_proveedor, descripcion_clasificacion_proveedor FROM CLASIFICACION_PROVEEDOR",
                    ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmb.DataSource = new BindingSource { DataSource = dt };
                cmb.DisplayMember = "descripcion_clasificacion_proveedor";
                cmb.ValueMember = "id_clasificacion_proveedor";
                cmb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Clasificación: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }

        // ─── LLENAR COMBO TÉRMINOS DE PAGO ───────────────────────────
        public static void LlenarTerminosPago(KryptonComboBox cmb, clsConexion ObjConexion)
        {
            try
            {
                ObjConexion.Abrir();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT id_terminos_de_pago_proveedor, descripcion_terminos_de_pago FROM TERMINOS_DE_PAGO_PROVEEDOR",
                    ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmb.DataSource = new BindingSource { DataSource = dt };
                cmb.DisplayMember = "descripcion_terminos_de_pago";
                cmb.ValueMember = "id_terminos_de_pago_proveedor";
                cmb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Términos de Pago: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }

        // ─── LLENAR AMBOS COMBOS DE UNA VEZ ──────────────────────────
        public static void LlenarCombosProveedor(KryptonComboBox cmbClasificacion,
                                                  KryptonComboBox cmbTerminosdePago,
                                                  clsConexion ObjConexion)
        {
            LlenarClasificacion(cmbClasificacion, ObjConexion);
            LlenarTerminosPago(cmbTerminosdePago, ObjConexion);
        }

        
    }
}
