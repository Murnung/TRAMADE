using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAMADE.ClasesCompras
{
    internal class clsLlenarListBox:clsCompras
        {

        public clsLlenarListBox() {
            listaProductos.Columns.Add("idProducto", typeof(int));
            listaProductos.Columns.Add("nombreProducto", typeof(string));
            listaProductos.Columns.Add("cantidad", typeof(int));
            listaProductos.Columns.Add("precioCosto", typeof(decimal));
        }

        // Lista interna de productos
        public DataTable listaProductos = new DataTable();


        // Vincular la lista al listbox
        public void vincularListBox(KryptonListBox lst)
        {
            lst.DataSource = listaProductos;
            lst.DisplayMember = "nombreProducto";
        }


        // Agregar un products a la lista
        public void agregarProducto()
        {
            // Validar que no se agregue el mismo producto dos veces
            bool existe = false;
            foreach (DataRow fila in listaProductos.Rows)
            {
                if (Convert.ToInt32(fila["idProducto"]) == getProducto())
                {
                    existe = true;
                    break;
                }
            }

            if (existe)
            {
                MessageBox.Show("Este producto ya fue agregado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow nuevaFila = listaProductos.NewRow();
            nuevaFila["idProducto"] = getProducto();
            nuevaFila["nombreProducto"] = getNombreProducto();
            nuevaFila["cantidad"] = getCantidad();
            nuevaFila["precioCosto"] = getPrecio();

            listaProductos.Rows.Add(nuevaFila); // El ListBox se actualiza automaticamente
        }


        // Eliminar producto seleccinado
        public void eliminarProducto(KryptonListBox lst)
        {
            if (lst.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            listaProductos.Rows[lst.SelectedIndex].Delete();
            listaProductos.AcceptChanges();
        }

        // Total de la lista
        public decimal TotalLista()
        {
            decimal total = 0;
            foreach (DataRow fila in listaProductos.Rows)
            {
                decimal subtotal = Convert.ToInt32(fila["cantidad"]) * Convert.ToDecimal(fila["precioCosto"]);
                total += subtotal * (1 + getIVA());
            }
            return total;
        }

        //Metodo para limpiar la lista
        public void limpiarLista()
        {
            listaProductos.Rows.Clear();
        }

        //Metodo pra obtener la fila 
        public DataRow obtenerFila(int indice)
        {
            return listaProductos.Rows[indice];
        }

    }
}
