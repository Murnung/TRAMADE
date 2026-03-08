using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.ClasesCompras
{
    internal class clsValidacioesCompras
    {
        clsValidacioesCompras() { }

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
        public static bool  validarListBox(KryptonListBox lst)
         {
            
              if (lst.Items.Count == 0)
               {
                 MessageBox.Show("Debe de agregar al menos un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return false;
                }
            return true;
        }

        //Validacion de agregar producto
        public static bool validarComboProducto(KryptonComboBox cmb)
        {
            if (cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        //Validacion de agregar proveedor
        public static bool validarComboProveedor(KryptonComboBox cmb)
        {
            if (cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un proveedor primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        //Validacion de agregar forma de pago
        public static bool validarComboFormaPago(KryptonComboBox cmb)
        {
            if (cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una forma de pago primero primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        //Validacion de buscar
        public static bool validarBuscarId(string buscar)
        {
            if (string.IsNullOrWhiteSpace(buscar))
            {
                MessageBox.Show("Ingrese el id de la solicitud de compra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(buscar, out int numero) || numero <= 0)
            {
                MessageBox.Show("Solo se permiten números enteros positivos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        //Valdacion de fecha de entrega
        public static bool validarFechaEntrega(DateTime entrega)
        {
            if (entrega.Date < DateTime.Today)
            {
                MessageBox.Show( "La fecha de entrega no puede ser menor a la fecha actual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        //Validacion de fecha desde
        public static bool validarFechaFiltro(DateTime desde,DateTime hasta)
        {

            if (desde.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de inicio del filtro no puede ser mayor a la fecha actual ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (hasta.Date < desde.Date)
            {
                MessageBox.Show("La fecha final del filtro  no puede ser menor a la fecha inicial ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
