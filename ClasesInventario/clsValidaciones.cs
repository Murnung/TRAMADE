using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.ClasesInventario
{
    internal class clsValidaciones
    {
        public static bool ValidarCamposVacios(params TextBox[] campos)
        {
            foreach (TextBox campo in campos)
            {
                if (string.IsNullOrEmpty(campo.Text.Trim()))
                {
                    MessageBox.Show("Por favor complete todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    campo.Focus();
                    return false;
                }
            }
            return true;
        }

        public static bool ValidarComboBox(params ComboBox[] combos)
        {
            foreach (ComboBox combo in combos)
            {
                if (combo.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    combo.Focus();
                    return false;
                }
            }
            return true;
        }

        public static bool ValidarDecimal(TextBox campo)
        {
            decimal resultado;
            if (!decimal.TryParse(campo.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out resultado))
            {
                MessageBox.Show("El campo '" + campo.Name + "' debe ser un número válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campo.Focus();
                return false;
            }
            return true;
        }

        public static bool ValidarEntero(TextBox campo)
        {
            int resultado;
            if (!int.TryParse(campo.Text, out resultado))
            {
                MessageBox.Show("El campo '" + campo.Name + "' debe ser un número entero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campo.Focus();
                return false;
            }
            return true;
        }

    }
}
