using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.ClasesAdministrador;

namespace TRAMADE
{
    public partial class frmNuevo : Form
    {
        
        clsConexion ObjConexion = new clsConexion();
        clsUsuario ObjUsuario = new clsUsuario();
        public frmNuevo()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void frmNuevo_Load(object sender, EventArgs e)
        {
            clsUsuario.llenarComboRol(cmbRol, ObjConexion);
            clsUsuario.llenarComboSucrusal(cmbSucursal, ObjConexion);
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e) //Es el nombre del evento ,Se dispara automáticamente cada vez que el usuario hace clic en una opción diferente de la lista desplegable.
        {
            if (cmbRol.SelectedIndex != -1 && cmbRol.SelectedItem is DataRowView) //Verifica con selectedIndex que se este seleccionando algo y "is DataRowView": Revisa que lo que seleccionaste sea una fila de datos real y no un simple texto.
            {
                DataRowView drv = (DataRowView)cmbRol.SelectedItem; //Toma todo el renglón que el usuario eligió (ID y Nombre) y lo guarda en una variable llamada drv para que podamos revisarlo 
                int rolId = Convert.ToInt32(drv["id_rol"]); //Busca en la fila la columna que se llama id_rol, toma el número (como el 1, 2 o 3) y lo guarda en la variable rolId. Este número es el que le importa a la base de datos.
                string rolNombre = drv["descripcion_rol"].ToString();// Busca en la misma fila la columna descripcion_rol, toma el texto(como "Administrador" o "Vendedor") y lo guarda en rolNombre para saber qué eligió el usuario.
            }
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSucursal.SelectedIndex != -1 && cmbSucursal.SelectedItem is DataRowView)
            {
                DataRowView drv = (DataRowView)cmbSucursal.SelectedItem;
                int sucursalId = Convert.ToInt32(drv["id_sucursal"]);
                string sucursalNombre = drv["nombre_sucursal"].ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                cmbRol.SelectedIndex == -1 ||
                cmbSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validar nombre
             if (!clsValidar.NullOVacio(txtNombre.Text, "Nombre", txtNombre)) return;
            if (!clsValidar.SinEspaciosExtremos(txtNombre.Text, "Nombre", txtNombre)) return;
            if (!clsValidar.SinDobleEspacio(txtNombre.Text, "Nombre", txtNombre)) return;
            if (!clsValidar.LongitudMinima(txtNombre.Text, "Nombre", 3, txtNombre)) return;
            if (!clsValidar.LongitudMaxima(txtNombre.Text, "Nombre", 50, txtNombre)) return;

            // Validar correo electrónico completo
            if (!clsValidar.ValidarCorreoUsuario(txtCorreo.Text.Trim(), txtCorreo)) return;

            // Validar contraseña
            if (!clsValidar.LongitudMinima(txtContraseña.Text, "Contraseña", 6, txtContraseña)) return;
            if (!clsValidar.LongitudMaxima(txtContraseña.Text, "Contraseña", 20, txtContraseña)) return;

            //Asignar valores al objeto
            ObjUsuario.setNombre(txtNombre.Text.Trim());
            ObjUsuario.setCorreo(txtCorreo.Text.Trim());
            ObjUsuario.setContrasena(txtContraseña.Text.Trim());
            ObjUsuario.setRol(Convert.ToInt32(cmbRol.SelectedValue));
            ObjUsuario.setSucursal(Convert.ToInt32(cmbSucursal.SelectedValue));

            //Intentar insertar
            if (ObjUsuario.insertarUsuarios(ObjConexion))
            {
                MessageBox.Show("¡Usuario registrado con éxito!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos para registrar otro usuario
                txtNombre.Clear();
                txtCorreo.Clear();
                txtContraseña.Clear();
                cmbRol.SelectedIndex = -1;
                cmbSucursal.SelectedIndex = -1;
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("No se pudo completar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
            cmbRol.SelectedIndex = -1;
            cmbSucursal.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
