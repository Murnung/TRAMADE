using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TRAMADE.ClasesProveedor
{
    internal class clsToolTip
    {
        public static void AplicarTooltipsProveedor(
            KryptonTextBox txtRazonSocial,
            KryptonTextBox txtNombreComercial,
            KryptonTextBox txtDireccionFiscal,
            KryptonTextBox txtRtn,
            KryptonTextBox txtTelefonoGeneral,
            KryptonTextBox txtCorreoCentral,
            KryptonComboBox cmbClasificacion,
            KryptonComboBox cmbTerminosdePago)
        {
            ToolTip tip = new ToolTip();
            tip.AutoPopDelay = 5000;
            tip.InitialDelay = 500;
            tip.ReshowDelay = 200;
            tip.BackColor = Color.FromArgb(210, 180, 140);
            tip.ForeColor = Color.FromArgb(50, 30, 10);
            //tip.IsBalloon = true;

            tip.SetToolTip(txtRazonSocial.Controls[0], "Razón Social\nNombre legal registrado ante el SAR.\nEj: Maderas del Norte S.A. de C.V.");
            tip.SetToolTip(txtNombreComercial.Controls[0], "Nombre Comercial\nNombre con el que opera el proveedor.\nEj: Maderas del Norte");
            tip.SetToolTip(txtDireccionFiscal.Controls[0], "Dirección Fiscal\nEj: Col. Las Palmas, Tegucigalpa");
            tip.SetToolTip(txtRtn.Controls[0], "RTN\nEj: 05011994000123\n(14 dígitos: municipio + año + secuencial)");
            tip.SetToolTip(txtTelefonoGeneral.Controls[0], "Teléfono General\nEj: 22345678\n(8 dígitos, inicia con 2, 3, 8 o 9)");
            tip.SetToolTip(txtCorreoCentral.Controls[0], "Correo Central\nEj: contacto@maderasnorte.com");
            tip.SetToolTip(cmbClasificacion.Controls[0], "Clasificación\nSeleccione si el proveedor es de MADERA o VARIOS");
            tip.SetToolTip(cmbTerminosdePago.Controls[0], "Términos de Pago\nSeleccione el plazo de pago según la clasificación");
        }
    }
}
