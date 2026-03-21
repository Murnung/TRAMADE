using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRAMADE.ClasesAdministrador;

namespace TRAMADE.FormulariosAdministrador
{
    public partial class frmEditar : Form
    {
        clsConexion ObjConexion = new clsConexion();
        clsUsuario clsUsuario = new clsUsuario();

        int usuarioIdSeleccionado = 0;

        public frmEditar()
        {
            InitializeComponent();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRol.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)cmbRol.SelectedItem;
                int rolId = Convert.ToInt32(drv["id_rol"]);
                string rolNombre = drv["descripcion_rol"].ToString();
            }

        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSucursal.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)cmbSucursal.SelectedItem;
                int sucursalId = Convert.ToInt32(drv["id_sucursal"]);
                string sucursalNombre = drv["nombre_sucursal"].ToString();
            }

        }

        private void frmEditar_Load(object sender, EventArgs e)
        {
            // Llenar combos con los datos de la base
            clsUsuario.llenarComboRol(cmbRol, ObjConexion);
            clsUsuario.llenarComboSucrusal(cmbSucursal, ObjConexion);

            // Inicialmente deshabilitar controles
            txtNombre.Enabled = false;
            txtCorreo.Enabled = false;
            txtContrasena.Enabled = false;
            cmbRol.Enabled = false;
            cmbSucursal.Enabled = false;
            btnConfirmar.Enabled = false;


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string busqueda = txtBuscar.Text.Trim();

            // Validar campo de búsqueda
            if (!clsValidar.NullOVacio(busqueda, "Nombre o Correo")) return;
            if (!clsValidar.LongitudMinima(busqueda, "Nombre o Correo", 3)) return;

            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Ingrese nombre o correo.");
                return;
            }

            ObjConexion.Abrir();

            string consulta = @"SELECT ID, Nombre, [Correo electrónico], 
                               [ID rol], [ID sucursal]
                        FROM VistaUsuarioTabla
                        WHERE Nombre=@busqueda 
                           OR [Correo electrónico]=@busqueda";

            SqlCommand cmd = new SqlCommand(consulta, ObjConexion.SqlC);
            cmd.Parameters.AddWithValue("@busqueda", busqueda);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                usuarioIdSeleccionado = Convert.ToInt32(reader["ID"]);

                
                txtNombre.Text = reader["Nombre"].ToString();
                txtCorreo.Text = reader["Correo electrónico"].ToString();
                txtContrasena.Text = "";

                cmbRol.SelectedValue = reader["ID rol"];
                cmbSucursal.SelectedValue = reader["ID sucursal"];

                txtNombre.Enabled = true;
                txtCorreo.Enabled = true;
                txtContrasena.Enabled = true;
                cmbRol.Enabled = true;
                cmbSucursal.Enabled = true;
                btnConfirmar.Enabled = true;
            }
            else
            {
                usuarioIdSeleccionado = 0;
                MessageBox.Show("Usuario no encontrado.");
            }

            reader.Close();
            ObjConexion.Cerrar();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {


            if (usuarioIdSeleccionado == 0)
            {
                MessageBox.Show("No hay usuario seleccionado.");
                return;
            }
            // ── Validar Nombre ────────────────────────────────────────────
            if (!clsValidar.NullOVacio(txtNombre.Text, "Nombre", txtNombre)) return;
            if (!clsValidar.SinEspaciosExtremos(txtNombre.Text, "Nombre", txtNombre)) return;
            if (!clsValidar.SinDobleEspacio(txtNombre.Text, "Nombre", txtNombre)) return;
            if (!clsValidar.LongitudMinima(txtNombre.Text, "Nombre", 3, txtNombre)) return;
            if (!clsValidar.LongitudMaxima(txtNombre.Text, "Nombre", 50, txtNombre)) return;

            // ── Validar Correo (pasando el id actual para excluirlo del duplicado) ──
            if (!clsValidar.ValidarCorreoUsuario(txtCorreo.Text.Trim(), txtCorreo, usuarioIdSeleccionado)) return;

            // ── Validar Contraseña (solo si fue modificada) ───────────────
            if (!string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                if (!clsValidar.LongitudMinima(txtContrasena.Text, "Contraseña", 6, txtContrasena)) return;
                if (!clsValidar.LongitudMaxima(txtContrasena.Text, "Contraseña", 20, txtContrasena)) return;
            }

            // ── Validar Combos ────────────────────────────────────────────
            if (!clsValidar.ComboSeleccionado(Convert.ToInt32(cmbRol.SelectedValue), "Rol")) return;
            if (!clsValidar.ComboSeleccionado(Convert.ToInt32(cmbSucursal.SelectedValue), "Sucursal")) return;

            // ── Guardar y actualizar ──────────────────────────────────────
            clsUsuario.setRol(Convert.ToInt32(cmbRol.SelectedValue));
            clsUsuario.setSucursal(Convert.ToInt32(cmbSucursal.SelectedValue));

            // guardar valores en el objeto
            clsUsuario.setRol(Convert.ToInt32(cmbRol.SelectedValue));
            clsUsuario.setSucursal(Convert.ToInt32(cmbSucursal.SelectedValue));

            bool actualizado = clsUsuario.actualizarUsuario(
                ObjConexion,
                usuarioIdSeleccionado,
                txtNombre.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtContrasena.Text.Trim()
            );

            if (actualizado)
            {

                MessageBox.Show("Usuario actualizado correctamente.");
                btnLimpiar_Click(sender, e);
            }
            else
                MessageBox.Show("Error al actualizar el usuario.");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ObjConexion.Cerrar();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtContrasena.Clear();
            cmbRol.SelectedIndex = -1;
            cmbSucursal.SelectedIndex = -1;
            txtNombre.Enabled = false;
            txtCorreo.Enabled = false;
            txtContrasena.Enabled = false;
            cmbRol.Enabled = false;
            cmbSucursal.Enabled = false;
            btnConfirmar.Enabled = false;
            usuarioIdSeleccionado = 0;
            txtBuscar.Focus();
        }
    }
}
