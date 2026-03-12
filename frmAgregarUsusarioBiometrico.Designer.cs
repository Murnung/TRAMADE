namespace TRAMADE
{
    partial class frmAgregarUsusarioBiometrico
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
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbUsuarios = new Krypton.Toolkit.KryptonComboBox();
            this.picCamara = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnCapturar = new Krypton.Toolkit.KryptonButton();
            this.btnGuardar = new Krypton.Toolkit.KryptonButton();
            this.btnCerrar = new Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.kryptonLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-12, -134);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 292);
            this.panel1.TabIndex = 12;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(200, 147);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(359, 129);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateNormal.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateNormal.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.kryptonLabel1.TabIndex = 17;
            this.kryptonLabel1.Values.Text = "Agregar usurios";
           // this.kryptonLabel1.Click += new System.EventHandler(this.kryptonLabel1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(464, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 468);
            this.panel2.TabIndex = 0;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownWidth = 8;
            this.cmbUsuarios.Location = new System.Drawing.Point(564, 220);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(284, 26);
            this.cmbUsuarios.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbUsuarios.TabIndex = 14;
            // 
            // picCamara
            // 
            this.picCamara.Location = new System.Drawing.Point(30, 201);
            this.picCamara.Name = "picCamara";
            this.picCamara.Size = new System.Drawing.Size(517, 359);
            this.picCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamara.TabIndex = 13;
            this.picCamara.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRAMADE.Properties.Resources.Logo_de_la_empresa;
            this.pictureBox1.Location = new System.Drawing.Point(4, 113);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(258, 580);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(44, 16);
            this.lblEstado.TabIndex = 15;
            this.lblEstado.Text = "label1";
           // this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(561, 201);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(136, 16);
            this.lbl.TabIndex = 16;
            this.lbl.Text = "Seleccione el usuario";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(574, 265);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(90, 25);
            this.btnCapturar.TabIndex = 17;
            this.btnCapturar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCapturar.Values.Text = "CAPTURAR ";
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(574, 323);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 25);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnGuardar.Values.Text = "GUARDAR";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(574, 382);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 25);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCerrar.Values.Text = "CERRAR";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmAgregarUsusarioBiometrico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 623);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.picCamara);
            this.Controls.Add(this.panel1);
            this.Name = "frmAgregarUsusarioBiometrico";
            this.Text = "frmAgregarUsusarioBiometrico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgregarUsusarioBiometrico_FormClosing);
            this.Load += new System.EventHandler(this.frmAgregarUsusarioBiometrico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picCamara;
        private Krypton.Toolkit.KryptonComboBox cmbUsuarios;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lbl;
        private Krypton.Toolkit.KryptonButton btnCapturar;
        private Krypton.Toolkit.KryptonButton btnGuardar;
        private Krypton.Toolkit.KryptonButton btnCerrar;
    }
}