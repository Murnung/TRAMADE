using System;
using System.Data.SqlClient;
using System.Globalization;
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
            if (!decimal.TryParse(campo.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out resultado))
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

        public static bool ValidarPositivo(TextBox campo)
        {
            decimal resultado;
            decimal.TryParse(campo.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out resultado);
            if (resultado <= 0)
            {
                MessageBox.Show("El campo '" + campo.Name + "' debe ser mayor a cero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campo.Focus();
                return false;
            }
            return true;
        }

        public static bool ValidarCostoMenorPrecio(TextBox txtPrecio, TextBox txtCosto)
        {
            decimal precio, costo;
            decimal.TryParse(txtPrecio.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out precio);
            decimal.TryParse(txtCosto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out costo);

            if (costo >= precio)
            {
                MessageBox.Show("El precio de costo no puede ser mayor o igual al precio de venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCosto.Focus();
                return false;
            }
            return true;
        }

        public static bool ValidarProductoExiste(string nombreProducto)
        {
            clsConexion obj = new clsConexion();
            obj.Abrir();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM PRODUCTO WHERE nombre_producto = @nombre", obj.SqlC);
            cmd.Parameters.AddWithValue("@nombre", nombreProducto);
            int count = (int)cmd.ExecuteScalar();
            obj.Cerrar();

            if (count > 0)
            {
                MessageBox.Show("El producto '" + nombreProducto + "' ya existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}