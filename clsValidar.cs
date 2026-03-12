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
        // ─── LIMPIAR CONTROL AL FALLAR (Accesible para hijos) ─────────
     

        // ─── VALIDACIONES GENERALES ──────────────────────────────────
        public static bool NullOVacio(string valor, string nombreCampo, Control campo = null)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                MessageBox.Show($"El campo '{nombreCampo}' no puede estar vacío.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false;
            }
            return true;
        }

        public static bool Correo(string valor, Control campo = null)
        {
            if (!Regex.IsMatch(valor.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false;
            }
            return true;
        }

        public static bool Telefono(string valor, Control campo = null)
        {
            if (!Regex.IsMatch(valor.Trim(), @"^[2389]\d{7}$"))
            {
                MessageBox.Show("El teléfono debe iniciar con 2, 3, 8 o 9 y tener 8 dígitos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                return false;
            }
            return true;
        }

        public static bool SoloNumeros_KeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return false;
            }
            return true;
        }

        // ─── VALIDAR DNI (13 DÍGITOS) ────────────────────────────────
        public static bool DNI(string valor, Control campo = null)
        {
            if (!Regex.IsMatch(valor.Trim(), @"^\d{13}$"))
            {
                MessageBox.Show("El número de Identidad (DNI) debe tener exactamente 13 dígitos numéricos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
                return false;
            }
            return true;
        }

        // ─── VALIDAR RTN (14 DÍGITOS) ────────────────────────────────
        public static bool RTN(string valor, Control campo = null)
        {
            if (!Regex.IsMatch(valor.Trim(), @"^\d{14}$"))
            {
                MessageBox.Show("El RTN debe tener exactamente 14 dígitos numéricos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                return false;
            }
            return true;
        }
    }
}
