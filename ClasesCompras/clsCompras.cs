using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace TRAMADE.ClasesCompras
{
    internal class clsCompras
    {
        private int cantidad, proveedor, producto, formaPago, estado = 7, idUsuario, idCompra;
        private DateTime entrega;
        private string nombreProducto;
        private decimal precioCosto;
        private bool autorizar = false;
        private const decimal IVA = 0.15m;
        clsConexion ObjConexion = new clsConexion();

        //Constructor vacio
        public clsCompras()
        {
            
        }

        // Setters
        public void setProveedor(int valor) { proveedor = valor; }
        public void setProducto(int valor) { producto = valor; }
        public void setFormaPago(int valor) { formaPago = valor; }
        public void setCantidad(int valor) { cantidad = valor; }
        public void setNombreProducto(string valor) { nombreProducto = valor; }
        public void setPrecio(decimal valor) { precioCosto = valor; }
        public void setEntrega(DateTime valor) { entrega = valor; }
        public void setIdCompra(int valor) { idCompra = valor; }


        //Getters
        public int getProducto() { return producto; }
        public int getCantidad() { return cantidad; }
        public string getNombreProducto() { return nombreProducto; }
        public decimal getPrecio() { return precioCosto; }
        public decimal getIVA() { return IVA; }
        public int getProveedor() { return proveedor; }
        public int getFormaPago() { return formaPago; }
        public int getEstado() { return estado; }
        public int getIdUsuario() { return idUsuario; }
        public int getIdCompra() { return idCompra; }
        public DateTime getEntrega() { return entrega; }
        public bool getAutorizar() { return autorizar; }

        //Calculos 
        public void setIdUsuario(int valor) { idUsuario = valor; }
        public decimal Subtotal() { return cantidad * precioCosto; }
        public decimal Impuesto() { return Subtotal() * IVA; }
        public decimal Total() { return Subtotal() * (1 + IVA); }


        //Carga datos 
        public DataTable obtenerTablaCompras()
        {
            try
            {
                clsConexion ObjConexion = new clsConexion();
                ObjConexion.Abrir();
                string consulta = "SELECT * FROM VistaComprasTabla";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, ObjConexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al recargar: " + ex.Message);
                return null;
            }
            finally
            {
                ObjConexion.Cerrar();
            }
        }

    }
}
    