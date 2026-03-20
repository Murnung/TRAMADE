using System;
using System.Windows.Forms;

namespace TRAMADE
{
    public class clsValidacionesF
    {
        /*
        public static bool ValidarCampoVacio(string texto, string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show(mensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;

        }
        public static bool ValidarUsuarioLogueado(int idUsuario)
        {
            if (idUsuario == 0)
            {
                MessageBox.Show("No se detectó ningún usuario logueado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool ValidarGridVacio(int cantidadFilas, string mensajeError)
        {
            if (cantidadFilas == 0)
            {
                MessageBox.Show(mensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        public static bool ValidarFilaSeleccionada(DataGridViewRow filaActual, string mensajeError)
        {
            if (filaActual == null)
            {
                MessageBox.Show(mensajeError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // VALIDACIÓN DE EMISIÓN (Exige 13/14 números sin espacios si el cliente decide meter DNI)
        public static string ValidarEmisionFactura(string nombreCliente, string direccionCliente, string idVendedor, DateTime fechaEmision, DateTime fechaVencimiento, int cantidadProductos, bool contado, bool credito, string dniRtn)
        {
            if (string.IsNullOrWhiteSpace(nombreCliente)) return "El Nombre del cliente es obligatorio.";
            if (string.IsNullOrWhiteSpace(direccionCliente)) return "La Dirección del cliente es obligatoria.";
            if (string.IsNullOrWhiteSpace(idVendedor)) return "Los datos del vendedor son obligatorios. Haga clic en el botón 'ID de vendedor'.";
            if (fechaVencimiento.Date < fechaEmision.Date) return "La fecha de vencimiento no puede ser menor a la fecha de emisión.";
            if (cantidadProductos == 0) return "La factura no puede ir vacía. Debe agregar al menos 1 producto.";
            if (!contado && !credito) return "Debe seleccionar una forma de pago (Contado o Crédito).";

            // VALIDACIÓN ESTRICTA DEL DNI ESCRITO A MANO
            if (!string.IsNullOrWhiteSpace(dniRtn))
            {
                if (dniRtn.Contains(" ")) return "El DNI/RTN no debe contener espacios en blanco.";
                if (dniRtn.Length != 13 && dniRtn.Length != 14) return "El DNI debe tener exactamente 13 números y el RTN 14 números.";
            }

            return "";
        }

        public static bool PedirConfirmacion(string mensajeProceso)
        {
            DialogResult respuesta = MessageBox.Show(mensajeProceso, "Confirmación de TRAMADE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return (respuesta == DialogResult.Yes);
        }

        // VALIDAR PARA EL BOTÓN DE BÚSQUEDA
        public static bool EsDniRtnValido(string documento)
        {
            if (documento.Contains(" ")) return false;
            return (documento.Length == 13 || documento.Length == 14);
        }
        */
    }
}