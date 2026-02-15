namespace TRAMADE
{
    partial class frmCompras
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new Krypton.Toolkit.KryptonButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnActualizar = new Krypton.Toolkit.KryptonButton();
            this.btnAutorizar = new Krypton.Toolkit.KryptonButton();
            this.btnSeguimiento = new Krypton.Toolkit.KryptonButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÓDULO DE COMPRAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1238, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1238, 24);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 591);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 6;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(1024, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 91);
            this.panel4.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSeguimiento);
            this.panel2.Controls.Add(this.btnAutorizar);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(187, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 105);
            this.panel2.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnRegistrar.Location = new System.Drawing.Point(42, 27);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OverrideDefault.Back.Color1 = System.Drawing.Color.Teal;
            this.btnRegistrar.OverrideDefault.Back.Color2 = System.Drawing.Color.Teal;
            this.btnRegistrar.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegistrar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRegistrar.OverrideFocus.Back.Color2 = System.Drawing.Color.Teal;
            this.btnRegistrar.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnRegistrar.Size = new System.Drawing.Size(183, 40);
            this.btnRegistrar.StateCommon.Back.Color1 = System.Drawing.Color.Teal;
            this.btnRegistrar.StateCommon.Back.Color2 = System.Drawing.Color.Teal;
            this.btnRegistrar.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnRegistrar.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnRegistrar.StateNormal.Back.Color1 = System.Drawing.Color.Teal;
            this.btnRegistrar.StateNormal.Back.Color2 = System.Drawing.Color.Teal;
            this.btnRegistrar.StatePressed.Back.Color1 = System.Drawing.Color.Teal;
            this.btnRegistrar.StatePressed.Back.Color2 = System.Drawing.Color.Teal;
            this.btnRegistrar.StateTracking.Back.Color1 = System.Drawing.Color.Teal;
            this.btnRegistrar.StateTracking.Back.Color2 = System.Drawing.Color.Teal;
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Values.Text = "REGISTRAR SOLICITUD";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(2, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1027, 11);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnActualizar
            // 
            this.btnActualizar.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnActualizar.Location = new System.Drawing.Point(262, 27);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.OverrideDefault.Back.Color1 = System.Drawing.Color.Teal;
            this.btnActualizar.OverrideDefault.Back.Color2 = System.Drawing.Color.Teal;
            this.btnActualizar.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnActualizar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnActualizar.OverrideFocus.Back.Color2 = System.Drawing.Color.Teal;
            this.btnActualizar.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnActualizar.Size = new System.Drawing.Size(211, 40);
            this.btnActualizar.StateCommon.Back.Color1 = System.Drawing.Color.Teal;
            this.btnActualizar.StateCommon.Back.Color2 = System.Drawing.Color.Teal;
            this.btnActualizar.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnActualizar.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnActualizar.StateNormal.Back.Color1 = System.Drawing.Color.Teal;
            this.btnActualizar.StateNormal.Back.Color2 = System.Drawing.Color.Teal;
            this.btnActualizar.StatePressed.Back.Color1 = System.Drawing.Color.Teal;
            this.btnActualizar.StatePressed.Back.Color2 = System.Drawing.Color.Teal;
            this.btnActualizar.StateTracking.Back.Color1 = System.Drawing.Color.Teal;
            this.btnActualizar.StateTracking.Back.Color2 = System.Drawing.Color.Teal;
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnActualizar.Values.Text = "ACTUALIZAR SOLICITUD";
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnAutorizar.Location = new System.Drawing.Point(520, 27);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.OverrideDefault.Back.Color1 = System.Drawing.Color.Teal;
            this.btnAutorizar.OverrideDefault.Back.Color2 = System.Drawing.Color.Teal;
            this.btnAutorizar.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAutorizar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAutorizar.OverrideFocus.Back.Color2 = System.Drawing.Color.Teal;
            this.btnAutorizar.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnAutorizar.Size = new System.Drawing.Size(211, 40);
            this.btnAutorizar.StateCommon.Back.Color1 = System.Drawing.Color.Teal;
            this.btnAutorizar.StateCommon.Back.Color2 = System.Drawing.Color.Teal;
            this.btnAutorizar.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAutorizar.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnAutorizar.StateNormal.Back.Color1 = System.Drawing.Color.Teal;
            this.btnAutorizar.StateNormal.Back.Color2 = System.Drawing.Color.Teal;
            this.btnAutorizar.StatePressed.Back.Color1 = System.Drawing.Color.Teal;
            this.btnAutorizar.StatePressed.Back.Color2 = System.Drawing.Color.Teal;
            this.btnAutorizar.StateTracking.Back.Color1 = System.Drawing.Color.Teal;
            this.btnAutorizar.StateTracking.Back.Color2 = System.Drawing.Color.Teal;
            this.btnAutorizar.TabIndex = 9;
            this.btnAutorizar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAutorizar.Values.Text = "AUTORIZAR SOLICITUD";
            // 
            // btnSeguimiento
            // 
            this.btnSeguimiento.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnSeguimiento.Location = new System.Drawing.Point(780, 27);
            this.btnSeguimiento.Name = "btnSeguimiento";
            this.btnSeguimiento.OverrideDefault.Back.Color1 = System.Drawing.Color.Teal;
            this.btnSeguimiento.OverrideDefault.Back.Color2 = System.Drawing.Color.Teal;
            this.btnSeguimiento.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnSeguimiento.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSeguimiento.OverrideFocus.Back.Color2 = System.Drawing.Color.Teal;
            this.btnSeguimiento.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnSeguimiento.Size = new System.Drawing.Size(211, 40);
            this.btnSeguimiento.StateCommon.Back.Color1 = System.Drawing.Color.Teal;
            this.btnSeguimiento.StateCommon.Back.Color2 = System.Drawing.Color.Teal;
            this.btnSeguimiento.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSeguimiento.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSeguimiento.StateNormal.Back.Color1 = System.Drawing.Color.Teal;
            this.btnSeguimiento.StateNormal.Back.Color2 = System.Drawing.Color.Teal;
            this.btnSeguimiento.StatePressed.Back.Color1 = System.Drawing.Color.Teal;
            this.btnSeguimiento.StatePressed.Back.Color2 = System.Drawing.Color.Teal;
            this.btnSeguimiento.StateTracking.Back.Color1 = System.Drawing.Color.Teal;
            this.btnSeguimiento.StateTracking.Back.Color2 = System.Drawing.Color.Teal;
            this.btnSeguimiento.TabIndex = 10;
            this.btnSeguimiento.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSeguimiento.Values.Text = "SEGUIMIENTO DE COMPRAS";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1238, 586);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip3);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Krypton.Toolkit.KryptonButton btnRegistrar;
        private Krypton.Toolkit.KryptonButton btnSeguimiento;
        private Krypton.Toolkit.KryptonButton btnAutorizar;
        private Krypton.Toolkit.KryptonButton btnActualizar;
    }
}