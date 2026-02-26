using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace TRAMADE.Formulario_Proveedores.Clases
{
    internal class clsProveedores_Añadir : clsProveedores
    {
        clsConexion ObjConexion = new clsConexion();

        public void InsertarProveedor(clsProveedores ObjProveedores)
        {
            try
            {
                ObjConexion.Abrir();

                SqlCommand cmd = new SqlCommand("PA_INSERTAR_PROVEEDOR", ObjConexion.SqlC);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre_comercial_proveedor", ObjProveedores.nombre_comercial_proveedor);
                cmd.Parameters.AddWithValue("@razon_social_proveedor", ObjProveedores.razon_social_proveedor);
                cmd.Parameters.AddWithValue("@direccion_proveedor", ObjProveedores.direccion_proveedor);
                cmd.Parameters.AddWithValue("@rtn_proveedor", ObjProveedores.rtn_proveedor);
                cmd.Parameters.AddWithValue("@id_clasificacion_proveedor", ObjProveedores.id_clasificacion_proveedor);
                cmd.Parameters.AddWithValue("@id_estado", ObjProveedores.id_estado);
                cmd.Parameters.AddWithValue("@id_terminos_de_pago_proveedor", ObjProveedores.id_terminos_de_pago_proveedor);
                cmd.Parameters.AddWithValue("@contacto_proveedor", ObjProveedores.contacto_proveedor);
                cmd.Parameters.AddWithValue("@correo_electronico_proveedor", ObjProveedores.correo_electronico_proveedor);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Proveedor agregado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }


            // Constructor vacío
        public clsProveedores_Añadir()
        {

        }


        /*
        public static void llenarComboClasificacion(Krypton.Toolkit.KryptonComboBox cmb, clsConexion ObjConexion)
        {
            try
            {
                ObjConexion.Abrir();

                string consulta = "SELECT * FROM VistaClasificacionProveedor";

                SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmb.DataSource = dt;
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

        
        // 🔹 Método para llenar combo de Términos de Pago
        public static void llenarComboTerminosPago(KryptonComboBox cmb, clsConexion ObjConexion)
        {
            try
            {
                ObjConexion.Abrir();

                string consulta = "SELECT * FROM VistaTerminosPagoProveedor";

                SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmb.DataSource = dt;
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
        }*/

        public static void llenarComboClasificacion(KryptonComboBox cmb, clsConexion ObjConexion)
        {
            try
            {
                ObjConexion.Abrir();
                string consulta = "SELECT id_clasificacion_proveedor, descripcion_clasificacion_proveedor FROM CLASIFICACION_PROVEEDOR";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                BindingSource bs = new BindingSource();
                bs.DataSource = dt;

                cmb.DataSource = bs;
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

        public static void llenarComboTerminosPago(KryptonComboBox cmb, clsConexion ObjConexion)
        {
            try
            {
                ObjConexion.Abrir();
                string consulta = "SELECT id_terminos_de_pago_proveedor, descripcion_terminos_de_pago FROM TERMINOS_DE_PAGO_PROVEEDOR";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                BindingSource bs = new BindingSource();
                bs.DataSource = dt;

                cmb.DataSource = bs;
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
    }
    
}

