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
            string rtn = valor.Trim();

            // Solo números y exactamente 13 dígitos
            if (!Regex.IsMatch(rtn, @"^\d{13}$"))
            {
                MessageBox.Show("El DNI debe contener solo números y tener exactamente 13 dígitos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            // Primeros 4 dígitos: código municipio Honduras (0101 al 1818)
            int codigoMunicipio = Convert.ToInt32(rtn.Substring(0, 4));
            if (codigoMunicipio < 101 || codigoMunicipio > 1899)
            {
                MessageBox.Show("Los primeros 4 dígitos del DNI deben corresponder a un código de municipio válido (ej: 0101 - 1818).",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
   
                return false;
            }

            // Dígitos 5-8: año de registro (1900 al año actual)
            int anioRegistro = Convert.ToInt32(rtn.Substring(4, 4));
            int anioActual = DateTime.Now.Year;
            if (anioRegistro < 1900 || anioRegistro > anioActual)
            {
                MessageBox.Show($"Los dígitos 5 al 8 del DNI deben ser un año válido entre 1900 y {anioActual}.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          
                return false;
            }

            // Últimos 6 dígitos: secuencial, no puede ser 000000
            string secuencial = rtn.Substring(8, 6);
            if (secuencial == "000000")
            {
                MessageBox.Show("Los últimos 6 dígitos del DNI no pueden ser todos ceros.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
  
                return false;
            }

            return true;
        }

        // ─── VALIDAR RTN (14 DÍGITOS) ────────────────────────────────
        public static bool RTN(string valor, Control campo = null)
        {
            string rtn = valor.Trim();

            // Solo números y exactamente 14 dígitos
            if (!Regex.IsMatch(rtn, @"^\d{14}$"))
            {
                MessageBox.Show("El RTN debe contener solo números y tener exactamente 14 dígitos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            // Primeros 4 dígitos: código municipio Honduras (0101 al 1818)
            int codigoMunicipio = Convert.ToInt32(rtn.Substring(0, 4));
            if (codigoMunicipio < 101 || codigoMunicipio > 1899)
            {
                MessageBox.Show("Los primeros 4 dígitos del RTN deben corresponder a un código de municipio válido (ej: 0101 - 1818).",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            // Dígitos 5-8: año de registro (1900 al año actual)
            int anioRegistro = Convert.ToInt32(rtn.Substring(4, 4));
            int anioActual = DateTime.Now.Year;
            if (anioRegistro < 1900 || anioRegistro > anioActual)
            {
                MessageBox.Show($"Los dígitos 5 al 8 del RTN deben ser un año válido entre 1900 y {anioActual}.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            // Últimos 6 dígitos: secuencial, no puede ser 000000
            string secuencial = rtn.Substring(8, 6);
            if (secuencial == "000000")
            {
                MessageBox.Show("Los últimos 6 dígitos del RTN no pueden ser todos ceros.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
              
                return false;
            }
            return true;
        }

        // ─── VALIDAR DOBLE ESPACIO ────────────────────────────────────
        public static bool SinDobleEspacio(string valor, string nombreCampo, Control campo = null)
        {
            if (valor.Contains("  "))
            {
                MessageBox.Show($"El campo '{nombreCampo}' no puede contener espacios dobles.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      
                return false;
            }
            return true;
        }

        // ─── VALIDAR SIN ESPACIOS AL INICIO O FINAL ───────────────────
        public static bool SinEspaciosExtremos(string valor, string nombreCampo, Control campo = null)
        {
            if (valor != valor.Trim())
            {
                MessageBox.Show($"El campo '{nombreCampo}' no puede iniciar ni terminar con espacios.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false;
            }
            return true;
        }

        // ─── VALIDAR SIN SOLO CARACTERES ESPECIALES ───────────────────
        public static bool SinSoloEspeciales(string valor, string nombreCampo, Control campo = null)
        {
            if (Regex.IsMatch(valor.Trim(), @"^[^a-zA-Z0-9áéíóúÁÉÍÓÚñÑ]+$"))
            {
                MessageBox.Show($"El campo '{nombreCampo}' no puede contener solo caracteres especiales.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


    }
}
