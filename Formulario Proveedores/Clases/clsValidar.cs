using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE
{
    internal class clsValidar
    {
        // ─── VALIDAR CAMPO VACÍO ──────────────────────────────────────
        /*public static bool NullOVacio(string valor, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                MessageBox.Show($"El campo '{nombreCampo}' no puede estar vacío.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ─── VALIDAR LONGITUD MÍNIMA ──────────────────────────────────
        public static bool LongitudMinima(string valor, string nombreCampo, int minimo)
        {
            if (valor.Trim().Length < minimo)
            {
                MessageBox.Show($"El campo '{nombreCampo}' debe tener al menos {minimo} caracteres.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ─── VALIDAR LONGITUD MÁXIMA ──────────────────────────────────
        public static bool LongitudMaxima(string valor, string nombreCampo, int maximo)
        {
            if (valor.Trim().Length > maximo)
            {
                MessageBox.Show($"El campo '{nombreCampo}' no puede tener más de {maximo} caracteres.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ─── VALIDAR RTN (solo números, exactamente 13 o 14 dígitos) ─
        public static bool RTN(string valor)
        {
            string rtnLimpio = valor.Trim();
            if (!Regex.IsMatch(rtnLimpio, @"^\d{13,14}$"))
            {
                MessageBox.Show("El RTN debe contener solo números y tener entre 13 y 14 dígitos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ─── VALIDAR TELÉFONO (solo números, exactamente 8 dígitos) ──
        public static bool Telefono(string valor)
        {
            string telLimpio = valor.Trim();
            if (!Regex.IsMatch(telLimpio, @"^\d{8}$"))
            {
                MessageBox.Show("El teléfono debe contener solo números y tener 8 dígitos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ─── VALIDAR CORREO ELECTRÓNICO ───────────────────────────────
        public static bool Correo(string valor)
        {
            if (!Regex.IsMatch(valor.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ─── VALIDAR COMBO SELECCIONADO ───────────────────────────────
        public static bool ComboSeleccionado(int selectedValue, string nombreCampo)
        {
            if (selectedValue <= 0)
            {
                MessageBox.Show($"Debe seleccionar una opción en '{nombreCampo}'.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool ValidarProveedor(string nombre, string razon, string direccion,
                                             string rtn, string telefono, string correo,
                                             int idClasificacion, int idTerminos,
                                             int idProveedorActual = 0) // ← nuevo parámetro
        {
            if (!NullOVacio(nombre, "Nombre Comercial")) return false;
            if (!LongitudMinima(nombre, "Nombre Comercial", 3)) return false;
            if (!LongitudMaxima(nombre, "Nombre Comercial", 50)) return false;

            if (!NullOVacio(razon, "Razón Social")) return false;
            if (!LongitudMinima(razon, "Razón Social", 3)) return false;
            if (!LongitudMaxima(razon, "Razón Social", 50)) return false;

            if (!NullOVacio(direccion, "Dirección")) return false;
            if (!LongitudMinima(direccion, "Dirección", 5)) return false;

            if (!NullOVacio(rtn, "RTN")) return false;
            if (!RTN(rtn)) return false;
            if (!RTNDuplicado(rtn, idProveedorActual)) return false; // ← nueva

            if (!NullOVacio(telefono, "Teléfono")) return false;
            if (!Telefono(telefono)) return false;

            if (!NullOVacio(correo, "Correo Electrónico")) return false;
            if (!Correo(correo)) return false;

            if (!ComboSeleccionado(idClasificacion, "Clasificación")) return false;
            if (!ComboSeleccionado(idTerminos, "Términos de Pago")) return false;
            if (!ClasificacionTerminos(idClasificacion, idTerminos)) return false;

            return true;
        }



        // ─── LIMPIAR ESPACIOS ANTES Y DESPUÉS ────────────────────────
        public static string Limpiar(string valor)
        {
            return valor?.Trim() ?? string.Empty;
        }

        // ─── VALIDAR COMPATIBILIDAD CLASIFICACIÓN + TÉRMINOS DE PAGO ──
        public static bool ClasificacionTerminos(int idClasificacion, int idTerminos)
        {
            // MADERA (1) → solo CREDITO MADERA (1) y AL CONTADO (4)
            if (idClasificacion == 1 && idTerminos != 1 && idTerminos != 4)
            {
                MessageBox.Show(
                    "La clasificación MADERA solo permite los términos:\n• CREDITO MADERA\n• AL CONTADO",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // VARIOS (2) → solo CREDITO VARIOS 15 DIAS (2), CREDITO VARIOS 1 MES (3) y AL CONTADO (4)
            if (idClasificacion == 2 && idTerminos != 2 && idTerminos != 3 && idTerminos != 4)
            {
                MessageBox.Show(
                    "La clasificación VARIOS solo permite los términos:\n• CREDITO VARIOS 15 DIAS\n• CREDITO VARIOS 1 MES\n• AL CONTADO",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // ─── VALIDAR RTN DUPLICADO ────────────────────────────────────
        public static bool RTNDuplicado(string rtn, int idProveedorActual = 0)
        {
            clsConexion ObjConexion = new clsConexion();
            try
            {
                ObjConexion.Abrir();
                // idProveedorActual = 0 en Añadir, en Editar se pasa el ID para excluirse a sí mismo
                SqlCommand cmd = new SqlCommand(@"
            SELECT COUNT(*) FROM PROVEEDOR 
            WHERE rtn_proveedor = @rtn 
            AND id_proveedor != @idProveedorActual", ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@rtn", rtn.Trim());
                cmd.Parameters.AddWithValue("@idProveedorActual", idProveedorActual);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("El RTN ingresado ya está registrado en otro proveedor.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar RTN: " + ex.Message);
                return false;
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }*/

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

        // ─── VALIDAR LONGITUD MÍNIMA ──────────────────────────────────
        public static bool LongitudMinima(string valor, string nombreCampo, int minimo, Control campo = null)
        {
            if (valor.Trim().Length < minimo)
            {
                MessageBox.Show($"El campo '{nombreCampo}' debe tener al menos {minimo} caracteres.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControl(campo);
                return false;
            }
            return true;
        }

        // ─── VALIDAR LONGITUD MÁXIMA ──────────────────────────────────
        public static bool LongitudMaxima(string valor, string nombreCampo, int maximo, Control campo = null)
        {
            if (valor.Trim().Length > maximo)
            {
                MessageBox.Show($"El campo '{nombreCampo}' no puede tener más de {maximo} caracteres.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControl(campo);
                return false;
            }
            return true;
        }

        // ─── VALIDAR RTN ──────────────────────────────────────────────
        public static bool RTN(string valor, Control campo = null)
        {
            string rtnLimpio = valor.Trim();
            if (!Regex.IsMatch(rtnLimpio, @"^\d{13,14}$"))
            {
                MessageBox.Show("El RTN debe contener solo números y tener entre 13 y 14 dígitos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControl(campo);
                return false;
            }
            return true;
        }

        // ─── VALIDAR TELÉFONO ─────────────────────────────────────────
        public static bool Telefono(string valor, Control campo = null)
        {
            string telLimpio = valor.Trim();
            if (!Regex.IsMatch(telLimpio, @"^\d{8}$"))
            {
                MessageBox.Show("El teléfono debe contener solo números y tener 8 dígitos.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControl(campo);
                return false;
            }
            return true;
        }

        // ─── VALIDAR CORREO ELECTRÓNICO ───────────────────────────────
        public static bool Correo(string valor, Control campo = null)
        {
            if (!Regex.IsMatch(valor.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarControl(campo);
                return false;
            }
            return true;
        }

        // ─── VALIDAR COMBO SELECCIONADO ───────────────────────────────
        public static bool ComboSeleccionado(int selectedValue, string nombreCampo)
        {
            if (selectedValue <= 0)
            {
                MessageBox.Show($"Debe seleccionar una opción en '{nombreCampo}'.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ─── VALIDAR RTN DUPLICADO ────────────────────────────────────
        public static bool RTNDuplicado(string rtn, int idProveedorActual = 0, Control campo = null)
        {
            clsConexion ObjConexion = new clsConexion();
            try
            {
                ObjConexion.Abrir();
                SqlCommand cmd = new SqlCommand(@"
                    SELECT COUNT(*) FROM PROVEEDOR 
                    WHERE rtn_proveedor = @rtn 
                    AND id_proveedor != @idProveedorActual", ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@rtn", rtn.Trim());
                cmd.Parameters.AddWithValue("@idProveedorActual", idProveedorActual);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("El RTN ingresado ya está registrado en otro proveedor.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarControl(campo);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar RTN: " + ex.Message);
                return false;
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }

        // ─── VALIDAR COMPATIBILIDAD CLASIFICACIÓN + TÉRMINOS DE PAGO ──
        public static bool ClasificacionTerminos(int idClasificacion, int idTerminos)
        {
            if (idClasificacion == 1 && idTerminos != 1 && idTerminos != 4)
            {
                MessageBox.Show(
                    "La clasificación MADERA solo permite los términos:\n• CREDITO MADERA\n• AL CONTADO",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (idClasificacion == 2 && idTerminos != 2 && idTerminos != 3 && idTerminos != 4)
            {
                MessageBox.Show(
                    "La clasificación VARIOS solo permite los términos:\n• CREDITO VARIOS 15 DIAS\n• CREDITO VARIOS 1 MES\n• AL CONTADO",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ─── VALIDAR PROVEEDOR COMPLETO ───────────────────────────────
        public static bool ValidarProveedor(
            string nombre, Control ctrlNombre,
            string razon, Control ctrlRazon,
            string direccion, Control ctrlDireccion,
            string rtn, Control ctrlRtn,
            string telefono, Control ctrlTelefono,
            string correo, Control ctrlCorreo,
            int idClasificacion, int idTerminos,
            int idProveedorActual = 0)
        {
            if (!NullOVacio(nombre, "Nombre Comercial", ctrlNombre)) return false;
            if (!LongitudMinima(nombre, "Nombre Comercial", 3, ctrlNombre)) return false;
            if (!LongitudMaxima(nombre, "Nombre Comercial", 50, ctrlNombre)) return false;

            if (!NullOVacio(razon, "Razón Social", ctrlRazon)) return false;
            if (!LongitudMinima(razon, "Razón Social", 3, ctrlRazon)) return false;
            if (!LongitudMaxima(razon, "Razón Social", 50, ctrlRazon)) return false;

            if (!NullOVacio(direccion, "Dirección", ctrlDireccion)) return false;
            if (!LongitudMinima(direccion, "Dirección", 5, ctrlDireccion)) return false;

            if (!NullOVacio(rtn, "RTN", ctrlRtn)) return false;
            if (!RTN(rtn, ctrlRtn)) return false;
            if (!RTNDuplicado(rtn, idProveedorActual, ctrlRtn)) return false;

            if (!NullOVacio(telefono, "Teléfono", ctrlTelefono)) return false;
            if (!Telefono(telefono, ctrlTelefono)) return false;

            if (!NullOVacio(correo, "Correo Electrónico", ctrlCorreo)) return false;
            if (!Correo(correo, ctrlCorreo)) return false;
            if (!CorreoDuplicado(correo, idProveedorActual, ctrlCorreo)) return false;

            if (!ComboSeleccionado(idClasificacion, "Clasificación")) return false;
            if (!ComboSeleccionado(idTerminos, "Términos de Pago")) return false;
            if (!ClasificacionTerminos(idClasificacion, idTerminos)) return false;

            return true;
        }

        // ─── LIMPIAR ESPACIOS ─────────────────────────────────────────
        public static string Limpiar(string valor)
        {
            return valor?.Trim() ?? string.Empty;
        }

        // ─── VALIDAR CORREO DUPLICADO ─────────────────────────────────
        public static bool CorreoDuplicado(string correo, int idProveedorActual = 0, Control campo = null)
        {
            clsConexion ObjConexion = new clsConexion();
            try
            {
                ObjConexion.Abrir();
                SqlCommand cmd = new SqlCommand(@"
            SELECT COUNT(*) FROM PROVEEDOR 
            WHERE correo_electronico_proveedor = @correo 
            AND id_proveedor != @idProveedorActual", ObjConexion.SqlC);
                cmd.Parameters.AddWithValue("@correo", correo.Trim());
                cmd.Parameters.AddWithValue("@idProveedorActual", idProveedorActual);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("El correo ingresado ya está registrado en otro proveedor.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarControl(campo);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar correo: " + ex.Message);
                return false;
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }
    }
}
