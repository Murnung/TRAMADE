using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TRAMADE
{
    internal class clsValidarClientes
    {
        // ─── LIMPIAR CONTROL AL FALLAR ────────────────────────────────
        private static void LimpiarControl(Control campo)
        {
            if (campo == null) return;
            if (campo is TextBox tb) { tb.Clear(); tb.Focus(); }
            else if (campo is Krypton.Toolkit.KryptonTextBox ktb) { ktb.Text = ""; ktb.Focus(); }
        }

        // ─── VALIDAR CAMPO VACÍO ──────────────────────────────────────
        public static bool NullOVacio(string valor, string nombreCampo, Control campo = null)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                MessageBox.Show($"El campo '{nombreCampo}' no puede estar vacío.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControl(campo);
                return false;
            }
            return true;
        }

        // ─── VALIDAR IDENTIDAD HONDURAS (13 Dígitos) ──────────────────
        public static bool Identidad(string valor, Control campo = null)
        {
            if (!Regex.IsMatch(valor.Trim(), @"^\d{13}$"))
            {
                MessageBox.Show("La Identidad debe contener exactamente 13 dígitos numéricos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControl(campo);
                return false;
            }
            return true;
        }

        // ─── VALIDAR RTN (14 Dígitos) ──────────────────────────────────
        public static bool RTN(string valor, Control campo = null)
        {
            if (!Regex.IsMatch(valor.Trim(), @"^\d{14}$"))
            {
                MessageBox.Show("El RTN debe contener exactamente 14 dígitos numéricos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControl(campo);
                return false;
            }
            return true;
        }

        // ─── VALIDAR TELÉFONO HONDURAS (8 Dígitos) ─────────────────────
        public static bool Telefono(string valor, Control campo = null)
        {
            string tel = valor.Trim();
            // Permite celulares (3, 8, 9) y fijos (2)
            if (!Regex.IsMatch(tel, @"^[2389]\d{7}$"))
            {
                MessageBox.Show("El teléfono debe iniciar con 2, 3, 8 o 9 y tener 8 dígitos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControl(campo);
                return false;
            }
            return true;
        }

        // ─── VALIDAR DUPLICADOS EN TABLA CLIENTE ──────────────────────
        public static bool ExisteDatoDuplicado(string valor, string columna, string mensaje, int idActual = 0, Control campo = null)
        {
            clsConexion ObjConexion = new clsConexion();
            try
            {
                ObjConexion.Abrir();
                string sql = $"SELECT COUNT(*) FROM CLIENTE WHERE {columna} = @valor AND id_cliente != @id";
                SqlCommand cmd = new SqlCommand(sql, ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@valor", valor.Trim());
                cmd.Parameters.AddWithValue("@id", idActual);

                if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                {
                    MessageBox.Show($"El {mensaje} ya está registrado en otro cliente.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarControl(campo);
                    return false;
                }
                return true;
            }
            catch (Exception ex) { MessageBox.Show("Error al validar duplicados: " + ex.Message); return false; }
            finally { ObjConexion.Cerrar(); }
        }

        // ─── MÉTODO PARA VALIDAR EL FORMULARIO COMPLETO ────────────────
        public static bool ValidarFormularioRegistro(
            string nombre, Control cNombre,
            string identidad, Control cIdentidad,
            string rtn, Control cRtn,
            string razonSocial, Control cRazon,
            string telefono, Control cTel,
            string correo, Control cCorreo,
            string direccion, Control cDireccion,
            object idTipo, object idDepto, object idCiudad)
        {
            // 1. Campos Básicos Obligatorios
            if (!NullOVacio(nombre, "Nombre Cliente", cNombre)) return false;
            if (!NullOVacio(direccion, "Dirección", cDireccion)) return false;
            if (!NullOVacio(telefono, "Teléfono", cTel)) return false;
            if (!Telefono(telefono, cTel)) return false;

            // 2. Validar según Tipo de Cliente (Si el control está habilitado)
            if (cIdentidad.Enabled) // Persona Natural
            {
                if (!NullOVacio(identidad, "Identidad", cIdentidad)) return false;
                if (!Identidad(identidad, cIdentidad)) return false;
                if (!ExisteDatoDuplicado(identidad, "identidad_cliente", "número de identidad", 0, cIdentidad)) return false;
            }

            if (cRtn.Enabled) // Persona Jurídica
            {
                if (!NullOVacio(rtn, "RTN", cRtn)) return false;
                if (!RTN(rtn, cRtn)) return false;
                if (!NullOVacio(razonSocial, "Razón Social", cRazon)) return false;
                if (!ExisteDatoDuplicado(rtn, "rtn_cliente", "RTN", 0, cRtn)) return false;
            }

            // 3. Correo (Validar solo si escribió algo)
            if (!string.IsNullOrWhiteSpace(correo))
            {
                if (!Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("El formato del correo electrónico no es válido.");
                    LimpiarControl(cCorreo);
                    return false;
                }
                if (!ExisteDatoDuplicado(correo, "correo_electronico_cliente", "correo electrónico", 0, cCorreo)) return false;
            }

            // 4. Validar Combos
            if (idTipo == null) { MessageBox.Show("Seleccione un Tipo de Cliente."); return false; }
            if (idDepto == null) { MessageBox.Show("Seleccione un Departamento."); return false; }
            if (idCiudad == null) { MessageBox.Show("Seleccione una Ciudad."); return false; }

            return true;
        }
    }
}