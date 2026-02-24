namespace TRAMADE.FormulariosAdministrador
{
    partial class frmEditar
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
            this.cmbRol = new Krypton.Toolkit.KryptonComboBox();
            this.btnLimpiar = new Krypton.Toolkit.KryptonButton();
            this.btnConfirmar = new Krypton.Toolkit.KryptonButton();
            this.cmbSucursal = new Krypton.Toolkit.KryptonComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContrasena = new Krypton.Toolkit.KryptonTextBox();
            this.txtBuscar = new Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new Krypton.Toolkit.KryptonButton();
            this.btnCancelar = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new Krypton.Toolkit.KryptonTextBox();
            this.txtCorreo = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.DropDownWidth = 243;
            this.cmbRol.Location = new System.Drawing.Point(163, 287);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(247, 30);
            this.cmbRol.StateCommon.ComboBox.Border.Rounding = 5F;
            this.cmbRol.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbRol.TabIndex = 37;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(333, 404);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.OverrideDefault.Back.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiar.OverrideDefault.Back.Color2 = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiar.OverrideFocus.Back.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiar.OverrideFocus.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Size = new System.Drawing.Size(113, 34);
            this.btnLimpiar.StateCommon.Back.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiar.StateCommon.Back.Color2 = System.Drawing.SystemColors.ButtonShadow;
            this.btnLimpiar.StateCommon.Border.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiar.StateCommon.Border.Color2 = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiar.StateCommon.Border.Rounding = 10F;
            this.btnLimpiar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnLimpiar.StateTracking.Back.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiar.StateTracking.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnLimpiar.StateTracking.Content.ShortText.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.StateTracking.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.TabIndex = 36;
            this.btnLimpiar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Values.Text = "LIMPIAR";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(20, 404);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnConfirmar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnConfirmar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnConfirmar.OverrideFocus.Back.Color2 = System.Drawing.Color.LightBlue;
            this.btnConfirmar.Size = new System.Drawing.Size(188, 34);
            this.btnConfirmar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnConfirmar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnConfirmar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnConfirmar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnConfirmar.StateCommon.Border.Rounding = 10F;
            this.btnConfirmar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnConfirmar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnConfirmar.StateTracking.Back.Color2 = System.Drawing.Color.LightBlue;
            this.btnConfirmar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnConfirmar.StateTracking.Content.ShortText.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmar.StateTracking.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmar.TabIndex = 35;
            this.btnConfirmar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnConfirmar.Values.Text = "CONFIRMAR CAMBIOS";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.DropDownWidth = 243;
            this.cmbSucursal.Location = new System.Drawing.Point(163, 337);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(247, 30);
            this.cmbSucursal.StateCommon.ComboBox.Border.Rounding = 5F;
            this.cmbSucursal.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbSucursal.TabIndex = 34;
            this.cmbSucursal.SelectedIndexChanged += new System.EventHandler(this.cmbSucursal_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 32);
            this.label7.TabIndex = 33;
            this.label7.Text = "EDITAR USUARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Sucursal:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(163, 243);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(247, 31);
            this.txtContrasena.StateCommon.Border.Rounding = 5F;
            this.txtContrasena.TabIndex = 31;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(163, 91);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(247, 31);
            this.txtBuscar.StateCommon.Border.Rounding = 5F;
            this.txtBuscar.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre/Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Rol:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(416, 91);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnBuscar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnBuscar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnBuscar.OverrideFocus.Back.Color2 = System.Drawing.Color.LightBlue;
            this.btnBuscar.Size = new System.Drawing.Size(103, 25);
            this.btnBuscar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnBuscar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnBuscar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnBuscar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnBuscar.StateCommon.Border.Rounding = 10F;
            this.btnBuscar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnBuscar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnBuscar.StateTracking.Back.Color2 = System.Drawing.Color.LightBlue;
            this.btnBuscar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnBuscar.StateTracking.Content.ShortText.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.StateTracking.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBuscar.Values.Text = "BUSCAR";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(214, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnCancelar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnCancelar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnCancelar.OverrideFocus.Back.Color2 = System.Drawing.Color.OrangeRed;
            this.btnCancelar.Size = new System.Drawing.Size(113, 34);
            this.btnCancelar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnCancelar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnCancelar.StateCommon.Border.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancelar.StateCommon.Border.Color2 = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancelar.StateCommon.Border.Rounding = 10F;
            this.btnCancelar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnCancelar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnCancelar.StateTracking.Back.Color2 = System.Drawing.Color.OrangeRed;
            this.btnCancelar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnCancelar.StateTracking.Content.ShortText.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.StateTracking.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancelar.Values.Text = "CANCELAR";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Correo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 147);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 31);
            this.txtNombre.StateCommon.Border.Rounding = 5F;
            this.txtNombre.TabIndex = 44;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(163, 193);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(247, 31);
            this.txtCorreo.StateCommon.Border.Rounding = 5F;
            this.txtCorreo.TabIndex = 45;
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 467);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditar";
            this.Load += new System.EventHandler(this.frmEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox cmbRol;
        private Krypton.Toolkit.KryptonButton btnLimpiar;
        private Krypton.Toolkit.KryptonButton btnConfirmar;
        private Krypton.Toolkit.KryptonComboBox cmbSucursal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Krypton.Toolkit.KryptonTextBox txtContrasena;
        private Krypton.Toolkit.KryptonTextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Krypton.Toolkit.KryptonButton btnBuscar;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonTextBox txtNombre;
        private Krypton.Toolkit.KryptonTextBox txtCorreo;
    }
}