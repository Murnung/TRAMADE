using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE
{
    internal class clsValidar
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

        // ─── VALIDAR RTN (exactamente 14 dígitos con estructura válida) ──
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

            {
                MessageBox.Show("El RTN debe corresponder a una empresa registrada hace al menos 18 años.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // ─── VALIDAR TELÉFONO (inicia con 2, 3, 8 o 9 — exactamente 8 dígitos) ──
        public static bool Telefono(string valor, Control campo = null)
        {
            string tel = valor.Trim();

            if (!Regex.IsMatch(tel, @"^\d{8}$"))
            {
                MessageBox.Show("El teléfono debe contener solo números y tener exactamente 8 dígitos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(tel, @"^[2389]"))
            {
                MessageBox.Show("El teléfono debe iniciar con 2, 3, 8 o 9.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // ─── VALIDAR CORREO ELECTRÓNICO ───────────────────────────────
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

        // ─── LIMPIAR ESPACIOS ─────────────────────────────────────────
        public static string Limpiar(string valor)
        {
            return valor?.Trim() ?? string.Empty;
        }

        // ─── VALIDAR SOLO NÚMEROS EN TXT ─────────────────────────
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
            string dni = valor.Trim();

            // Solo números y exactamente 13 dígitos
            if (!Regex.IsMatch(dni, @"^\d{13}$"))
            {
                MessageBox.Show("El DNI debe contener solo números y tener exactamente 13 dígitos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            // Primeros 4 dígitos: código municipio Honduras (0101 al 1818)
            int codigoMunicipio = Convert.ToInt32(dni.Substring(0, 4));
            if (codigoMunicipio < 101 || codigoMunicipio > 1899)
            {
                MessageBox.Show("Los primeros 4 dígitos del DNI deben corresponder a un código de municipio válido (ej: 0101 - 1818).",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            // Dígitos 5-8: año de registro (1900 al año actual)
            int anioRegistro = Convert.ToInt32(dni.Substring(4, 4));
            int anioActual = DateTime.Now.Year;
            if (anioRegistro < 1900 || anioRegistro > anioActual)
            {
                MessageBox.Show($"Los dígitos 5 al 8 del DNI deben ser un año válido entre 1900 y {anioActual}.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            // Últimos 6 dígitos: secuencial, no puede ser 000000
            string secuencial = dni.Substring(8, 5);
            if (secuencial == "000000")
            {
                MessageBox.Show("Los últimos 5 dígitos del DNI no pueden ser todos ceros.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            return true;
        }

        // ─── VALIDAR SIN TRES LETRAS IGUALES SEGUIDAS ─────────────────
        public static bool SinTresLetrasIguales(string valor, string nombreCampo)
        {
            if (Regex.IsMatch(valor.Trim(), @"(.)\1\1"))
            {
                MessageBox.Show($"El campo '{nombreCampo}' contiene caracteres repetidos inválidos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ─── BLOQUEAR TECLAS EN TELÉFONO AL LLEGAR A 8 DÍGITOS ───────
        public static void TelefonoMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is Krypton.Toolkit.KryptonTextBox ktb)
            {
                if (!char.IsControl(e.KeyChar) && ktb.Text.Length >= 8)
                    e.Handled = true;
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }

        // ─── VALIDAR SIN CUATRO NÚMEROS IGUALES SEGUIDOS ──────────────
        public static bool SinCuatroNumerosIguales(string valor, string nombreCampo)
        {
            if (Regex.IsMatch(valor.Trim(), @"(\d)\1{3}"))
            {
                MessageBox.Show($"El campo '{nombreCampo}' no puede contener cuatro números iguales seguidos.",
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
            // ─── Nombre Comercial ─────────────────────────────────────
            if (!NullOVacio(nombre, "Nombre Comercial", ctrlNombre)) return false;
            if (!SinEspaciosExtremos(nombre, "Nombre Comercial", ctrlNombre)) return false;
            if (!SinDobleEspacio(nombre, "Nombre Comercial", ctrlNombre)) return false;
            if (!SinSoloEspeciales(nombre, "Nombre Comercial", ctrlNombre)) return false;
            if (!SinTresLetrasIguales(nombre, "Nombre Comercial")) return false;  // ← nueva
            if (!LongitudMinima(nombre, "Nombre Comercial", 3, ctrlNombre)) return false;
            if (!LongitudMaxima(nombre, "Nombre Comercial", 50, ctrlNombre)) return false;

            //ComboBox Razon Social 
            // ─── Razón Social ─────────────────────────────────────────────
            if (string.IsNullOrWhiteSpace(razon))
            {
                MessageBox.Show("Debe seleccionar una Razón Social.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // ─── Dirección ────────────────────────────────────────────
            if (!NullOVacio(direccion, "Dirección", ctrlDireccion)) return false;
            if (!SinEspaciosExtremos(direccion, "Dirección", ctrlDireccion)) return false;
            if (!SinDobleEspacio(direccion, "Dirección", ctrlDireccion)) return false;
            if (!SinTresLetrasIguales(direccion, "Dirección")) return false;
            if (!LongitudMinima(direccion, "Dirección", 5, ctrlDireccion)) return false;

            // ─── RTN ──────────────────────────────────────────────────
            if (!NullOVacio(rtn, "RTN", ctrlRtn)) return false;
            if (!RTN(rtn, ctrlRtn)) return false;
            if (!RTNDuplicado(rtn, idProveedorActual, ctrlRtn)) return false;

            // ─── Teléfono ─────────────────────────────────────────────
            if (!NullOVacio(telefono, "Teléfono", ctrlTelefono)) return false;
            if (!Telefono(telefono, ctrlTelefono)) return false;
            if (!SinCuatroNumerosIguales(telefono, "Teléfono")) return false;

            // ─── Correo ───────────────────────────────────────────────
            if (!NullOVacio(correo, "Correo Electrónico", ctrlCorreo)) return false;
            if (!SinEspaciosExtremos(correo, "Correo Electrónico", ctrlCorreo)) return false;
            if (!Correo(correo, ctrlCorreo)) return false;
            if (!CorreoDuplicado(correo, idProveedorActual, ctrlCorreo)) return false;

            // ─── Combos ───────────────────────────────────────────────
            if (!ComboSeleccionado(idClasificacion, "Clasificación")) return false;
            if (!ComboSeleccionado(idTerminos, "Términos de Pago")) return false;
            if (!ClasificacionTerminos(idClasificacion, idTerminos)) return false;

            return true;
        }

        // ─── VALIDAR FECHA DE ENTREGA ─────────────────────────────────
        public static bool FechaEntrega(DateTime entrega)
        {
            if (entrega.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha de entrega no puede ser menor a la fecha actual", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ─── VALIDAR RANGO DE FECHAS (FILTRO) ────────────────────────
        public static bool FechaFiltro(DateTime desde, DateTime hasta)
        {
            if (desde.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de inicio del filtro no puede ser mayor a la fecha actual", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (hasta.Date < desde.Date)
            {
                MessageBox.Show("La fecha final del filtro no puede ser menor a la fecha inicial", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // ─── VALIDAR FILA SELECCIONADA EN DATAGRIDVIEW ────────────────
        public static bool FilaSeleccionada(DataGridView dgv)
        {
            foreach (DataGridViewRow fila in dgv.Rows)
                if (Convert.ToBoolean(fila.Cells["Seleccionar"].Value))
                    return true;

            MessageBox.Show("Debe seleccionar al menos una fila", "Validación",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        //-----------------------------------------------------------------------------------------------------------
        //Validaciones de inventario

        // ─── VALIDAR CAMPOS VACÍOS (INVENTARIO) ──────────────────────
        /*public static bool ValidarCamposVacios(params TextBox[] campos)
        {
            foreach (TextBox campo in campos)
            {
                if (string.IsNullOrEmpty(campo.Text.Trim()))
                {
                    MessageBox.Show("Por favor complete todos los campos", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    campo.Focus();
                    return false;
                }
            }
            return true;
        }*/

        // ─── VALIDAR COMBOBOX (INVENTARIO) ───────────────────────────
        /*public static bool ValidarComboBox(params ComboBox[] combos)
        {
            foreach (ComboBox combo in combos)
            {
                if (combo.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione todos los campos", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    combo.Focus();
                    return false;
                }
            }
            return true;
        }*/

        // ─── VALIDAR DECIMAL (INVENTARIO) ────────────────────────────
        public static bool ValidarDecimal(TextBox campo)
        {
            if (!decimal.TryParse(campo.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show("El campo '" + campo.Name + "' debe ser un número válido", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campo.Focus();
                return false;
            }
            return true;
        }

        // ─── VALIDAR ENTERO (INVENTARIO) ─────────────────────────────
        public static bool ValidarEntero(TextBox campo)
        {
            if (!int.TryParse(campo.Text, out _))
            {
                MessageBox.Show("El campo '" + campo.Name + "' debe ser un número entero", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campo.Focus();
                return false;
            }
            return true;
        }

        // ─── VALIDAR POSITIVO (INVENTARIO) ───────────────────────────
        public static bool ValidarPositivo(TextBox campo)
        {
            decimal.TryParse(campo.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal resultado);
            if (resultado <= 0)
            {
                MessageBox.Show("El campo '" + campo.Name + "' debe ser mayor a cero", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campo.Focus();
                return false;
            }
            return true;
        }

        // ─── VALIDAR COSTO MENOR QUE PRECIO (INVENTARIO) ─────────────
        public static bool ValidarCostoMenorPrecio(TextBox txtPrecio, TextBox txtCosto)
        {
            decimal.TryParse(txtPrecio.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal precio);
            decimal.TryParse(txtCosto.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal costo);

            if (costo >= precio)
            {
                MessageBox.Show("El precio de costo no puede ser mayor o igual al precio de venta", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCosto.Focus();
                return false;
            }
            return true;
        }

        // ─── VALIDAR PRODUCTO EXISTENTE (INVENTARIO) ─────────────────
        public static bool ValidarProductoExiste(string nombreProducto)
        {
            clsConexion obj = new clsConexion();
            try
            {
                obj.Abrir();
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM PRODUCTO WHERE nombre_producto = @nombre", obj.SqlC);
                cmd.Parameters.AddWithValue("@nombre", nombreProducto);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("El producto '" + nombreProducto + "' ya existe", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            finally
            {
                obj.Cerrar();
            }
        }

        // ─── VALIDAR INVENTARIO COMPLETO ─────────────────────────────
        public static bool ValidarInventario(
            TextBox txtNombreProducto,
            TextBox txtPrecio,
            TextBox txtPrecioCosto,
            TextBox txtStockInicial,
            ComboBox cmbProveedor,
            ComboBox cmbCategoria,
            ComboBox cmbSucursal)
        {
            //if (!ValidarCamposVacios(txtNombreProducto, txtPrecio, txtPrecioCosto, txtStockInicial)) return false;
            //if (!ValidarComboBox(cmbProveedor, cmbCategoria, cmbSucursal)) return false;
            if (!NullOVacio(txtNombreProducto.Text, "Nombre Producto")) return false;
            if (!NullOVacio(txtPrecio.Text, "Precio")) return false;
            if (!NullOVacio(txtPrecioCosto.Text, "Precio Costo")) return false;
            if (!NullOVacio(txtStockInicial.Text, "Stock Inicial")) return false;
            if (!ComboSeleccionado(cmbProveedor.SelectedIndex, "Proveedor")) return false;
            if (!ComboSeleccionado(cmbCategoria.SelectedIndex, "Categoría")) return false;
            if (!ComboSeleccionado(cmbSucursal.SelectedIndex, "Sucursal")) return false;
            if (!ComboSeleccionado(cmbProveedor.SelectedIndex, "Proveedor")) return false;
            if (!ComboSeleccionado(cmbCategoria.SelectedIndex, "Categoría")) return false;
            if (!ComboSeleccionado(cmbSucursal.SelectedIndex, "Sucursal")) return false;
            if (!ValidarDecimal(txtPrecio)) return false;
            if (!ValidarDecimal(txtPrecioCosto)) return false;
            if (!ValidarEntero(txtStockInicial)) return false;
            if (!ValidarPositivo(txtPrecio)) return false;
            if (!ValidarPositivo(txtPrecioCosto)) return false;
            if (!ValidarPositivo(txtStockInicial)) return false;
            if (!ValidarCostoMenorPrecio(txtPrecio, txtPrecioCosto)) return false;
            if (!ValidarProductoExiste(txtNombreProducto.Text)) return false;
            return true;
        }
    }
}
