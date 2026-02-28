using System;
using System.Collections.Generic;
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
        public static bool NullOVacio(string valor, string nombreCampo)
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
                                             int idClasificacion, int idTerminos)
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

            if (!NullOVacio(telefono, "Teléfono")) return false;
            if (!Telefono(telefono)) return false;

            if (!NullOVacio(correo, "Correo Electrónico")) return false;
            if (!Correo(correo)) return false;

            if (!ComboSeleccionado(idClasificacion, "Clasificación")) return false;
            if (!ComboSeleccionado(idTerminos, "Términos de Pago")) return false;
            if (!ClasificacionTerminos(idClasificacion, idTerminos)) return false; // ← nueva

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

    }
}
