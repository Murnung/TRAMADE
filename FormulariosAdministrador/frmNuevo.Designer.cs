namespace TRAMADE
{
    partial class frmNuevo
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
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new Krypton.Toolkit.KryptonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new Krypton.Toolkit.KryptonTextBox();
            this.txtCorreo = new Krypton.Toolkit.KryptonTextBox();
            this.txtContraseña = new Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSucursal = new Krypton.Toolkit.KryptonComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new Krypton.Toolkit.KryptonButton();
            this.cmbRol = new Krypton.Toolkit.KryptonComboBox();
            this.btnSalir = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRol)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(396, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "AGREGAR NUEVO USUARIO";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(18, 411);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnAgregar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnAgregar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnAgregar.OverrideFocus.Back.Color2 = System.Drawing.Color.LightBlue;
            this.btnAgregar.Size = new System.Drawing.Size(219, 34);
            this.btnAgregar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnAgregar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(198)))), ((int)(((byte)(224)))));
            this.btnAgregar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnAgregar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnAgregar.StateCommon.Border.Rounding = 10F;
            this.btnAgregar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnAgregar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnAgregar.StateTracking.Back.Color2 = System.Drawing.Color.LightBlue;
            this.btnAgregar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnAgregar.StateTracking.Content.ShortText.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.StateTracking.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAgregar.Values.Text = "AGREGAR NUEVO USUARIO";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(199, 86);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 31);
            this.txtNombre.StateCommon.Border.Rounding = 5F;
            this.txtNombre.TabIndex = 7;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(199, 157);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(247, 31);
            this.txtCorreo.StateCommon.Border.Rounding = 5F;
            this.txtCorreo.TabIndex = 8;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(199, 211);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(247, 31);
            this.txtContraseña.StateCommon.Border.Rounding = 5F;
            this.txtContraseña.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sucursal:";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.DropDownWidth = 243;
            this.cmbSucursal.Location = new System.Drawing.Point(199, 330);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(247, 30);
            this.cmbSucursal.StateCommon.ComboBox.Border.Rounding = 5F;
            this.cmbSucursal.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbSucursal.TabIndex = 15;
            this.cmbSucursal.SelectedIndexChanged += new System.EventHandler(this.cmbSucursal_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo electrónico:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(243, 411);
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
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Values.Text = "LIMPIAR";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.DropDownWidth = 243;
            this.cmbRol.Location = new System.Drawing.Point(199, 268);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(247, 30);
            this.cmbRol.StateCommon.ComboBox.Border.Rounding = 5F;
            this.cmbRol.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbRol.TabIndex = 24;
            this.cmbRol.DropDownStyleChanged += new System.EventHandler(this.frmNuevo_Load);
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(362, 411);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.OverrideDefault.Back.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.OverrideDefault.Back.Color2 = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.OverrideFocus.Back.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.OverrideFocus.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Size = new System.Drawing.Size(113, 34);
            this.btnSalir.StateCommon.Back.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.StateCommon.Back.Color2 = System.Drawing.SystemColors.ButtonShadow;
            this.btnSalir.StateCommon.Border.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.StateCommon.Border.Color2 = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.StateCommon.Border.Rounding = 10F;
            this.btnSalir.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSalir.StateTracking.Back.Color1 = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalir.StateTracking.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnSalir.StateTracking.Content.ShortText.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.StateTracking.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalir.Values.Text = "SALIR";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(498, 457);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevo";
            this.Load += new System.EventHandler(this.frmNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private Krypton.Toolkit.KryptonButton btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonTextBox txtNombre;
        private Krypton.Toolkit.KryptonTextBox txtCorreo;
        private Krypton.Toolkit.KryptonTextBox txtContraseña;
        private System.Windows.Forms.Label label6;
        private Krypton.Toolkit.KryptonComboBox cmbSucursal;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonButton btnLimpiar;
        private Krypton.Toolkit.KryptonComboBox cmbRol;
        private Krypton.Toolkit.KryptonButton btnSalir;
    }
}