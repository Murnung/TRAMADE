namespace TRAMADE
{
    partial class frmAdministrador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUsuarios = new Krypton.Toolkit.KryptonButton();
            this.btnBitacora = new Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(95)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.btnBitacora);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 675);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(30, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Administrador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(1, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "_______________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(1, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "_______________________";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(7, 109);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnUsuarios.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnUsuarios.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnUsuarios.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnUsuarios.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnUsuarios.Size = new System.Drawing.Size(165, 25);
            this.btnUsuarios.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnUsuarios.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnUsuarios.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.btnUsuarios.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnUsuarios.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnUsuarios.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnUsuarios.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnUsuarios.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnUsuarios.StateTracking.Content.ShortText.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuarios.StateTracking.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUsuarios.Values.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Location = new System.Drawing.Point(4, 140);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnBitacora.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnBitacora.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnBitacora.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnBitacora.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnBitacora.Size = new System.Drawing.Size(165, 25);
            this.btnBitacora.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnBitacora.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnBitacora.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.btnBitacora.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnBitacora.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnBitacora.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnBitacora.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(64)))), ((int)(((byte)(137)))));
            this.btnBitacora.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnBitacora.StateTracking.Content.ShortText.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnBitacora.StateTracking.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnBitacora.TabIndex = 4;
            this.btnBitacora.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBitacora.Values.Text = "Bitacora";
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1077, 575);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministrador";
            this.Load += new System.EventHandler(this.frmAdministrador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonButton btnUsuarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Krypton.Toolkit.KryptonButton btnBitacora;
    }
}