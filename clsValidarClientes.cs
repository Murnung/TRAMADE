using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE
{
    internal class clsValidarClientes : clsValidar
    {
        public static bool ExisteDatoDuplicado(string valor, string columna, string mensaje, Control campo = null)
        {
            var columnasPermitidas = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                {
                    "dni_cliente", "rtn_cliente", "correo_electronico_cliente"
                };

            if (!columnasPermitidas.Contains(columna))
                throw new ArgumentException("Nombre de columna no permitido.", nameof(columna));

            clsConexion con = new clsConexion();
            try
            {
                con.Abrir();
                string sql = $"SELECT COUNT(*) FROM CLIENTE WHERE {columna} = @valor";
                SqlCommand cmd = new SqlCommand(sql, con.SqlC);
                cmd.Parameters.AddWithValue("@valor", valor.Trim());
                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    MessageBox.Show($"El {mensaje} ya está registrado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  
                    return false;
                }
                return true;
            }
            finally { con.Cerrar(); }
        }

        public static bool ValidarTodoElFormulario(
            string nombre, Control cNombre,
            string tipo,
            string dni, Control cDni,
            string rtn, Control cRtn,
            string razon, Control cRazon,
            string tel, Control cTel,
            string correo, Control cCorreo,
            string direccion, Control cDir,
            object depto, object ciudad)
        {
            // Validaciones básicas de la clase Padre
            if (!NullOVacio(nombre, "Nombre", cNombre)) return false;
            if (!NullOVacio(direccion, "Dirección", cDir)) return false;
            if (!Telefono(tel, cTel)) return false;

            // Lógica por Tipo de Cliente
            if (tipo == "PERSONA NATURAL")
            {
                if (!DNI(dni, cDni)) return false; // Llama a la base
                if (!ExisteDatoDuplicado(dni, "identidad_cliente", "DNI", cDni)) return false;
            }
            else
            {
                if (!RTN(rtn, cRtn)) return false; // Llama a la base
                if (!NullOVacio(razon, "Razón Social", cRazon)) return false;
                if (!ExisteDatoDuplicado(rtn, "rtn_cliente", "RTN", cRtn)) return false;
            }

            if (!string.IsNullOrEmpty(correo) && !Correo(correo, cCorreo)) return false;
            if (depto == null || ciudad == null) { MessageBox.Show("Seleccione ubicación."); return false; }

            return true;
        }
    }
}
