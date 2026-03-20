using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.ClasesCompras
{
    internal class clsValidacionesCompras
    {
   
        
        //Validar que exista una compra seleccionada a la hora de actualizar o insertar
        public static bool validarIdSeleccionado(int id)
        {
            if (id == 0)
            {
                MessageBox.Show("Ingrese una solicitud de compra primero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        


        //Validacion de existencia en lista de productos
        public static bool validarListBox(KryptonListBox lst)
        {

            if (lst.Items.Count == 0)
            {
                MessageBox.Show("Debe de agregar al menos un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        //Validacion de buscar
        public static bool validarBuscarId(string buscar)
        {
            if (string.IsNullOrWhiteSpace(buscar))
            {
                MessageBox.Show("Ingrese el id primero antes de buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(buscar, out int numero) || numero <= 0)
            {
                MessageBox.Show("Solo se permiten números enteros positivos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }
        
        // Validación para modificar cantidad
        public static bool validarModificarCantidad(int idSeleccionado, KryptonListBox lst, int cantidad)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Primero busca una compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (lst.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un producto de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        // Validación general que incluye todas
        public static bool validar_todosLosCampos(KryptonComboBox proveedor, KryptonComboBox formaPago, KryptonComboBox producto)
        {
            bool valido = true;

            if (proveedor.SelectedIndex == -1) valido = false;
            if (formaPago.SelectedIndex == -1) valido = false;
            if (producto.SelectedIndex == -1) valido = false;

            if (!valido)
            {
                MessageBox.Show("Por favor, llene todos los campos vacíos", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }
        // Validación para combo box sin resultado
        public static bool validarComboSinResultado(KryptonComboBox cmb, string nombreCampo)
        {
            if (cmb.SelectedIndex == -1 || cmb.SelectedValue == null)
            {
                MessageBox.Show($"No se encontró ningún {nombreCampo} con ese criterio de búsqueda.",
                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
