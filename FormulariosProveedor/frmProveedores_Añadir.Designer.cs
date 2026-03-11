namespace TRAMADE
{
    partial class frmProveedores_Añadir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores_Añadir));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new Krypton.Toolkit.KryptonTextBox();
            this.txtDireccionFiscal = new Krypton.Toolkit.KryptonTextBox();
            this.txtNombreComercial = new Krypton.Toolkit.KryptonTextBox();
            this.txtRtn = new Krypton.Toolkit.KryptonTextBox();
            this.txtTelefonoGeneral = new Krypton.Toolkit.KryptonTextBox();
            this.txtCorreoCentral = new Krypton.Toolkit.KryptonTextBox();
            this.btnGuardar = new Krypton.Toolkit.KryptonButton();
            this.btnCancelar = new Krypton.Toolkit.KryptonButton();
            this.cmbClasificacion = new Krypton.Toolkit.KryptonComboBox();
            this.cmbTerminosdePago = new Krypton.Toolkit.KryptonComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClasificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTerminosdePago)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 120);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(751, 23);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(37, 38);
            this.btnSalir.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnSalir.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnSalir.StatePressed.Back.Color1 = System.Drawing.Color.Red;
            this.btnSalir.StatePressed.Back.Color2 = System.Drawing.Color.Red;
            this.btnSalir.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnSalir.StateTracking.Back.Color2 = System.Drawing.Color.Red;
            this.btnSalir.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalir.Values.Image = global::TRAMADE.Properties.Resources.Cerrar;
            this.btnSalir.Values.Text = "";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(39, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Añadir Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Información general";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datos de contacto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clasificación";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtRazonSocial.CueHint.CueHintText = "RAZÓN SOCIAL";
            this.txtRazonSocial.CueHint.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(60, 189);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(331, 34);
            this.txtRazonSocial.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.TabIndex = 5;
            // 
            // txtDireccionFiscal
            // 
            this.txtDireccionFiscal.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtDireccionFiscal.CueHint.CueHintText = "DIRECCION FISCAL";
            this.txtDireccionFiscal.CueHint.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionFiscal.Location = new System.Drawing.Point(411, 189);
            this.txtDireccionFiscal.Name = "txtDireccionFiscal";
            this.txtDireccionFiscal.Size = new System.Drawing.Size(331, 34);
            this.txtDireccionFiscal.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionFiscal.TabIndex = 6;
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtNombreComercial.CueHint.CueHintText = "NOMBRE COMERCIAL";
            this.txtNombreComercial.CueHint.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComercial.Location = new System.Drawing.Point(60, 275);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(331, 34);
            this.txtNombreComercial.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComercial.TabIndex = 7;
            // 
            // txtRtn
            // 
            this.txtRtn.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtRtn.CueHint.CueHintText = "RTN";
            this.txtRtn.CueHint.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRtn.Location = new System.Drawing.Point(411, 275);
            this.txtRtn.Name = "txtRtn";
            this.txtRtn.Size = new System.Drawing.Size(331, 34);
            this.txtRtn.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRtn.TabIndex = 8;
            // 
            // txtTelefonoGeneral
            // 
            this.txtTelefonoGeneral.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtTelefonoGeneral.CueHint.CueHintText = "TELEFÓNO GENERAL";
            this.txtTelefonoGeneral.CueHint.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoGeneral.Location = new System.Drawing.Point(60, 388);
            this.txtTelefonoGeneral.Name = "txtTelefonoGeneral";
            this.txtTelefonoGeneral.Size = new System.Drawing.Size(331, 34);
            this.txtTelefonoGeneral.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoGeneral.TabIndex = 9;
            // 
            // txtCorreoCentral
            // 
            this.txtCorreoCentral.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtCorreoCentral.CueHint.CueHintText = "CORREO CENTRAL";
            this.txtCorreoCentral.CueHint.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCentral.Location = new System.Drawing.Point(58, 467);
            this.txtCorreoCentral.Name = "txtCorreoCentral";
            this.txtCorreoCentral.Size = new System.Drawing.Size(331, 34);
            this.txtCorreoCentral.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCentral.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(598, 526);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(72)))), ((int)(((byte)(229)))));
            this.btnGuardar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(72)))), ((int)(((byte)(229)))));
            this.btnGuardar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.Size = new System.Drawing.Size(144, 50);
            this.btnGuardar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(72)))), ((int)(((byte)(229)))));
            this.btnGuardar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(72)))), ((int)(((byte)(229)))));
            this.btnGuardar.StateCommon.Border.Rounding = 10F;
            this.btnGuardar.StateCommon.Content.ShortText.Color1 = System.Drawing.SystemColors.Control;
            this.btnGuardar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnGuardar.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnGuardar.Values.Text = "GUARDAR";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(434, 526);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.btnCancelar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.btnCancelar.OverrideFocus.Back.Color1 = System.Drawing.Color.Silver;
            this.btnCancelar.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.btnCancelar.Size = new System.Drawing.Size(144, 50);
            this.btnCancelar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.btnCancelar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.btnCancelar.StateCommon.Border.Rounding = 10F;
            this.btnCancelar.StateCommon.Content.ShortText.Color1 = System.Drawing.SystemColors.Control;
            this.btnCancelar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.btnCancelar.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btnCancelar.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnCancelar.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancelar.Values.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbClasificacion
            // 
            this.cmbClasificacion.CueHint.Color1 = System.Drawing.Color.Gray;
            this.cmbClasificacion.CueHint.CueHintText = "SELECCIONE LA CLASIFICACION";
            this.cmbClasificacion.CueHint.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasificacion.DropDownWidth = 331;
            this.cmbClasificacion.Location = new System.Drawing.Point(411, 388);
            this.cmbClasificacion.Name = "cmbClasificacion";
            this.cmbClasificacion.Size = new System.Drawing.Size(331, 33);
            this.cmbClasificacion.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClasificacion.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbClasificacion.TabIndex = 14;
            this.cmbClasificacion.SelectedIndexChanged += new System.EventHandler(this.cmbClasificacion_SelectedIndexChanged);
            // 
            // cmbTerminosdePago
            // 
            this.cmbTerminosdePago.CueHint.Color1 = System.Drawing.Color.Gray;
            this.cmbTerminosdePago.CueHint.CueHintText = "TERMINOS DE PAGO";
            this.cmbTerminosdePago.CueHint.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTerminosdePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerminosdePago.DropDownWidth = 331;
            this.cmbTerminosdePago.Location = new System.Drawing.Point(411, 468);
            this.cmbTerminosdePago.Name = "cmbTerminosdePago";
            this.cmbTerminosdePago.Size = new System.Drawing.Size(331, 33);
            this.cmbTerminosdePago.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTerminosdePago.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbTerminosdePago.TabIndex = 15;
            this.cmbTerminosdePago.SelectedIndexChanged += new System.EventHandler(this.cmbTerminosdePago_SelectedIndexChanged);
            // 
            // frmProveedores_Añadir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 588);
            this.Controls.Add(this.cmbTerminosdePago);
            this.Controls.Add(this.cmbClasificacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCorreoCentral);
            this.Controls.Add(this.txtTelefonoGeneral);
            this.Controls.Add(this.txtRtn);
            this.Controls.Add(this.txtNombreComercial);
            this.Controls.Add(this.txtDireccionFiscal);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedores_Añadir";
            this.Text = "frmProveedores_Añadir";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClasificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTerminosdePago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Krypton.Toolkit.KryptonTextBox txtRazonSocial;
        private Krypton.Toolkit.KryptonTextBox txtDireccionFiscal;
        private Krypton.Toolkit.KryptonTextBox txtNombreComercial;
        private Krypton.Toolkit.KryptonTextBox txtRtn;
        private Krypton.Toolkit.KryptonTextBox txtTelefonoGeneral;
        private Krypton.Toolkit.KryptonTextBox txtCorreoCentral;
        private Krypton.Toolkit.KryptonButton btnGuardar;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private Krypton.Toolkit.KryptonComboBox cmbClasificacion;
        private Krypton.Toolkit.KryptonComboBox cmbTerminosdePago;
        private Krypton.Toolkit.KryptonButton btnSalir;
    }
}