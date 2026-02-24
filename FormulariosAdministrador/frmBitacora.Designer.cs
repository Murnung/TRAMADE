namespace TRAMADE
{
    partial class frmBitacora
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBitacora = new Krypton.Toolkit.KryptonButton();
            this.btnUsuarios = new Krypton.Toolkit.KryptonButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new Krypton.Toolkit.KryptonButton();
            this.cmbUsuario = new Krypton.Toolkit.KryptonComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(95)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnBitacora);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 677);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRAMADE.Properties.Resources.USUARIO;
            this.pictureBox1.Location = new System.Drawing.Point(3, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnBitacora
            // 
            this.btnBitacora.Location = new System.Drawing.Point(0, 140);
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
            this.btnBitacora.TabIndex = 7;
            this.btnBitacora.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBitacora.Values.Text = "Bitacora";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(3, 109);
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
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnUsuarios.Values.Text = "Usuarios";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(-3, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "_______________________";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(32, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Administrador";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.cmbUsuario);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.dtHasta);
            this.panel2.Controls.Add(this.dtDesde);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvBitacora);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(190, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 524);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtHasta
            // 
            this.dtHasta.Location = new System.Drawing.Point(155, 114);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(269, 22);
            this.dtHasta.TabIndex = 38;
            // 
            // dtDesde
            // 
            this.dtDesde.Location = new System.Drawing.Point(155, 81);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(269, 22);
            this.dtDesde.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 35;
            this.label7.Text = "Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Fecha Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Fecha Desde:";
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Location = new System.Drawing.Point(26, 142);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.RowHeadersWidth = 51;
            this.dgvBitacora.RowTemplate.Height = 24;
            this.dgvBitacora.Size = new System.Drawing.Size(864, 359);
            this.dgvBitacora.TabIndex = 32;
            this.dgvBitacora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBitacora_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 38);
            this.label1.TabIndex = 31;
            this.label1.Text = "BITÁCORA DE ACTIVIDADES";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(719, 111);
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
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBuscar.Values.Text = "BUSCAR";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.DropDownWidth = 187;
            this.cmbUsuario.Location = new System.Drawing.Point(515, 110);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(187, 26);
            this.cmbUsuario.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbUsuario.TabIndex = 40;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged_1);
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1121, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBitacora";
            this.Load += new System.EventHandler(this.frmBitacora_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonButton btnBitacora;
        private Krypton.Toolkit.KryptonButton btnUsuarios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton btnBuscar;
        private Krypton.Toolkit.KryptonComboBox cmbUsuario;
    }
}