namespace TRAMADE
{
    partial class frmProveedores_Editar
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
            this.cmbClasificacion = new Krypton.Toolkit.KryptonComboBox();
            this.btnCancelar = new Krypton.Toolkit.KryptonButton();
            this.btnGuardar = new Krypton.Toolkit.KryptonButton();
            this.txtCorreoCentral = new Krypton.Toolkit.KryptonTextBox();
            this.txtTelefonoGeneral = new Krypton.Toolkit.KryptonTextBox();
            this.txtRtn = new Krypton.Toolkit.KryptonTextBox();
            this.txtNombreComercial = new Krypton.Toolkit.KryptonTextBox();
            this.txtDireccionFiscal = new Krypton.Toolkit.KryptonTextBox();
            this.txtRazonComercial = new Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmbClasificacion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClasificacion
            // 
            this.cmbClasificacion.CueHint.Color1 = System.Drawing.Color.Gray;
            this.cmbClasificacion.CueHint.CueHintText = "SELECCIONE LA CLASIFICACION";
            this.cmbClasificacion.CueHint.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasificacion.DropDownWidth = 331;
            this.cmbClasificacion.Items.AddRange(new object[] {
            "MADERA",
            "VARIOS"});
            this.cmbClasificacion.Location = new System.Drawing.Point(411, 389);
            this.cmbClasificacion.Name = "cmbClasificacion";
            this.cmbClasificacion.Size = new System.Drawing.Size(331, 41);
            this.cmbClasificacion.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClasificacion.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbClasificacion.TabIndex = 27;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(434, 503);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 50);
            this.btnCancelar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.btnCancelar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.btnCancelar.StateCommon.Border.Rounding = 10F;
            this.btnCancelar.StateCommon.Content.ShortText.Color1 = System.Drawing.SystemColors.Control;
            this.btnCancelar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnCancelar.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancelar.Values.Text = "CANCELAR";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(598, 503);
            this.btnGuardar.Name = "btnGuardar";
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
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnGuardar.Values.Text = "GUARDAR";
            // 
            // txtCorreoCentral
            // 
            this.txtCorreoCentral.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtCorreoCentral.CueHint.CueHintText = "CORREO CENTRAL";
            this.txtCorreoCentral.CueHint.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCentral.Location = new System.Drawing.Point(60, 467);
            this.txtCorreoCentral.Name = "txtCorreoCentral";
            this.txtCorreoCentral.Size = new System.Drawing.Size(331, 42);
            this.txtCorreoCentral.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCentral.TabIndex = 24;
            // 
            // txtTelefonoGeneral
            // 
            this.txtTelefonoGeneral.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtTelefonoGeneral.CueHint.CueHintText = "TELEFÓNO GENERAL";
            this.txtTelefonoGeneral.CueHint.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoGeneral.Location = new System.Drawing.Point(60, 388);
            this.txtTelefonoGeneral.Name = "txtTelefonoGeneral";
            this.txtTelefonoGeneral.Size = new System.Drawing.Size(331, 42);
            this.txtTelefonoGeneral.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoGeneral.TabIndex = 23;
            // 
            // txtRtn
            // 
            this.txtRtn.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtRtn.CueHint.CueHintText = "RTN";
            this.txtRtn.CueHint.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRtn.Location = new System.Drawing.Point(411, 275);
            this.txtRtn.Name = "txtRtn";
            this.txtRtn.Size = new System.Drawing.Size(331, 42);
            this.txtRtn.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRtn.TabIndex = 22;
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtNombreComercial.CueHint.CueHintText = "NOMBRE COMERCIAL";
            this.txtNombreComercial.CueHint.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComercial.Location = new System.Drawing.Point(60, 275);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(331, 42);
            this.txtNombreComercial.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComercial.TabIndex = 21;
            // 
            // txtDireccionFiscal
            // 
            this.txtDireccionFiscal.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtDireccionFiscal.CueHint.CueHintText = "DIRECCION FISCAL";
            this.txtDireccionFiscal.CueHint.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionFiscal.Location = new System.Drawing.Point(411, 189);
            this.txtDireccionFiscal.Name = "txtDireccionFiscal";
            this.txtDireccionFiscal.Size = new System.Drawing.Size(331, 42);
            this.txtDireccionFiscal.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionFiscal.TabIndex = 20;
            // 
            // txtRazonComercial
            // 
            this.txtRazonComercial.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtRazonComercial.CueHint.CueHintText = "RAZÓN SOCIAL";
            this.txtRazonComercial.CueHint.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonComercial.Location = new System.Drawing.Point(60, 189);
            this.txtRazonComercial.Name = "txtRazonComercial";
            this.txtRazonComercial.Size = new System.Drawing.Size(331, 42);
            this.txtRazonComercial.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonComercial.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 40);
            this.label4.TabIndex = 18;
            this.label4.Text = "Clasificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 40);
            this.label3.TabIndex = 17;
            this.label3.Text = "Datos de contacto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 40);
            this.label2.TabIndex = 16;
            this.label2.Text = "Información general";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 120);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar Proveedor";
            // 
            // frmProveedores_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 588);
            this.Controls.Add(this.cmbClasificacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCorreoCentral);
            this.Controls.Add(this.txtTelefonoGeneral);
            this.Controls.Add(this.txtRtn);
            this.Controls.Add(this.txtNombreComercial);
            this.Controls.Add(this.txtDireccionFiscal);
            this.Controls.Add(this.txtRazonComercial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProveedores_Editar";
            this.Text = "frmProveedores_Editar";
            ((System.ComponentModel.ISupportInitialize)(this.cmbClasificacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox cmbClasificacion;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private Krypton.Toolkit.KryptonButton btnGuardar;
        private Krypton.Toolkit.KryptonTextBox txtCorreoCentral;
        private Krypton.Toolkit.KryptonTextBox txtTelefonoGeneral;
        private Krypton.Toolkit.KryptonTextBox txtRtn;
        private Krypton.Toolkit.KryptonTextBox txtNombreComercial;
        private Krypton.Toolkit.KryptonTextBox txtDireccionFiscal;
        private Krypton.Toolkit.KryptonTextBox txtRazonComercial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}