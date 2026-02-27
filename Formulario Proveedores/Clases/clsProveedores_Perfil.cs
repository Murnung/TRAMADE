using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.Formulario_Proveedores.Clases
{
    internal class clsProveedores_Perfil : clsProveedores
    {
        clsConexion ObjConexion = new clsConexion();

        // Propiedades extra (de tablas relacionadas)
        public string descripcion_clasificacion { get; set; }
        public string descripcion_terminos_de_pago { get; set; }
        public int dias_credito { get; set; }

        // ─── OBTENER DATOS COMPLETOS DEL PROVEEDOR ───────────────────
        public clsProveedores_Perfil ObtenerPerfilProveedor(int idProveedor)
        {
            clsProveedores_Perfil ObjPerfil = null;
            try
            {
                ObjConexion.Abrir();
                SqlCommand cmd = new SqlCommand("PA_OBTENER_PERFIL_PROVEEDOR", ObjConexion.SqlC);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_proveedor", idProveedor);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ObjPerfil = new clsProveedores_Perfil();
                    ObjPerfil.id_proveedor = Convert.ToInt32(reader["id_proveedor"]);
                    ObjPerfil.nombre_comercial_proveedor = reader["nombre_comercial_proveedor"].ToString();
                    ObjPerfil.razon_social_proveedor = reader["razon_social_proveedor"].ToString();
                    ObjPerfil.direccion_proveedor = reader["direccion_proveedor"].ToString();
                    ObjPerfil.rtn_proveedor = reader["rtn_proveedor"].ToString();
                    ObjPerfil.id_clasificacion_proveedor = Convert.ToInt32(reader["id_clasificacion_proveedor"]);
                    ObjPerfil.id_estado = Convert.ToInt32(reader["id_estado"]);
                    ObjPerfil.id_terminos_de_pago_proveedor = Convert.ToInt32(reader["id_terminos_de_pago_proveedor"]);
                    ObjPerfil.contacto_proveedor = reader["contacto_proveedor"].ToString();
                    ObjPerfil.correo_electronico_proveedor = reader["correo_electronico_proveedor"].ToString();
                    ObjPerfil.descripcion_clasificacion = reader["descripcion_clasificacion_proveedor"].ToString();
                    ObjPerfil.descripcion_terminos_de_pago = reader["descripcion_terminos_de_pago"].ToString();
                    ObjPerfil.dias_credito = Convert.ToInt32(reader["dias_credito"]);
                }
                else
                {
                    MessageBox.Show("El reader no devolvió filas para id: " + idProveedor); // ← debug
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exacto: " + ex.Message); // ← antes solo decía "Error al obtener perfil"
            }
            finally
            {
                ObjConexion.Cerrar();
            }
            return ObjPerfil;
        }

        // ─── LLENAR lstInformacionGeneral ─────────────────────────────
        public void CargarInformacionGeneral(KryptonListBox lst, clsProveedores_Perfil ObjPerfil)
        {
            lst.Items.Clear();
            lst.Items.Add("ID Proveedor:       " + ObjPerfil.id_proveedor);
            lst.Items.Add("Nombre Comercial:   " + ObjPerfil.nombre_comercial_proveedor);
            lst.Items.Add("Razón Social:       " + ObjPerfil.razon_social_proveedor);
            lst.Items.Add("Dirección:          " + ObjPerfil.direccion_proveedor);
            lst.Items.Add("RTN:                " + ObjPerfil.rtn_proveedor);
        }

        // ─── LLENAR lstDatosdeContacto ────────────────────────────────
        public void CargarDatosContacto(KryptonListBox lst, clsProveedores_Perfil ObjPerfil)
        {
            lst.Items.Clear();
            lst.Items.Add("Contacto:           " + ObjPerfil.contacto_proveedor);
            lst.Items.Add("Correo Electrónico: " + ObjPerfil.correo_electronico_proveedor);
        }

        // ─── LLENAR lstClasificacion ──────────────────────────────────
        public void CargarClasificacion(KryptonListBox lst, clsProveedores_Perfil ObjPerfil)
        {
            lst.Items.Clear();
            lst.Items.Add("Clasificación:      " + ObjPerfil.descripcion_clasificacion);
            lst.Items.Add("Términos de Pago:   " + ObjPerfil.descripcion_terminos_de_pago);
            lst.Items.Add("Días de Crédito:    " + ObjPerfil.dias_credito + " días");
        }

        public void CargarPerfil(int idProveedor, KryptonListBox lstInformacionGeneral,
                          KryptonListBox lstDatosdeContacto, KryptonListBox lstClasificacion,
                          KryptonCheckBox chkActivo)
        {
            clsProveedores_Perfil ObjDatos = ObtenerPerfilProveedor(idProveedor);

            if (ObjDatos != null)
            {
                chkActivo.Checked = (ObjDatos.id_estado == 1);
                CargarInformacionGeneral(lstInformacionGeneral, ObjDatos);
                CargarDatosContacto(lstDatosdeContacto, ObjDatos);
                CargarClasificacion(lstClasificacion, ObjDatos);
            }
            else
            {
                MessageBox.Show("No se encontraron datos del proveedor.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
