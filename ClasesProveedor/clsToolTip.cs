using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRAMADE.ClasesProveedor
{
    internal class clsToolTip
    {
        // ─── TOOLTIPS PARA AÑADIR Y EDITAR PROVEEDOR ─────────────────
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
            txtRazonSocial.ToolTipValues.Description = "Nombre legal registrado ante el SAR.\nEj: Maderas del Norte S.A. de C.V.";
            txtRazonSocial.ToolTipValues.Heading = "Razón Social";
            txtRazonSocial.ToolTipValues.EnableToolTips = true;

            txtNombreComercial.ToolTipValues.Description = "Nombre con el que opera o es conocido el proveedor.\nEj: Maderas del Norte";
            txtNombreComercial.ToolTipValues.Heading = "Nombre Comercial";
            txtNombreComercial.ToolTipValues.EnableToolTips = true;

            txtDireccionFiscal.ToolTipValues.Description = "Ej: Col. Las Palmas, Tegucigalpa";
            txtDireccionFiscal.ToolTipValues.Heading = "Dirección Fiscal";
            txtDireccionFiscal.ToolTipValues.EnableToolTips = true;

            txtRtn.ToolTipValues.Description = "Ej: 05011994000123  (14 dígitos: municipio + año + secuencial)";
            txtRtn.ToolTipValues.Heading = "RTN";
            txtRtn.ToolTipValues.EnableToolTips = true;

            txtTelefonoGeneral.ToolTipValues.Description = "Ej: 22345678  (8 dígitos, inicia con 2, 3, 8 o 9)";
            txtTelefonoGeneral.ToolTipValues.Heading = "Teléfono General";
            txtTelefonoGeneral.ToolTipValues.EnableToolTips = true;

            txtCorreoCentral.ToolTipValues.Description = "Ej: contacto@maderasnorte.com";
            txtCorreoCentral.ToolTipValues.Heading = "Correo Central";
            txtCorreoCentral.ToolTipValues.EnableToolTips = true;

            cmbClasificacion.ToolTipValues.Description = "Seleccione si el proveedor es de MADERA o VARIOS";
            cmbClasificacion.ToolTipValues.Heading = "Clasificación";
            cmbClasificacion.ToolTipValues.EnableToolTips = true;

            cmbTerminosdePago.ToolTipValues.Description = "Seleccione el plazo de pago según la clasificación";
            cmbTerminosdePago.ToolTipValues.Heading = "Términos de Pago";
            cmbTerminosdePago.ToolTipValues.EnableToolTips = true;
        }
    }
}
