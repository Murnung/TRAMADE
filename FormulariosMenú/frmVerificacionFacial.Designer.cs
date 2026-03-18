namespace TRAMADE
{
    partial class frmVerificacionFacial
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.labelBienvenida = new Krypton.Toolkit.KryptonLabel();
            this.picCamara = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnCancelar = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picCamara)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(561, 436);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(261, 22);
            this.lblEstado.TabIndex = 22;
            this.lblEstado.Text = "Mire a la camara por favor";
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.Location = new System.Drawing.Point(404, -6);
            this.labelBienvenida.Margin = new System.Windows.Forms.Padding(4);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(506, 56);
            this.labelBienvenida.StateCommon.ShortText.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenida.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelBienvenida.StateNormal.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelBienvenida.StateNormal.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelBienvenida.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelBienvenida.TabIndex = 20;
            this.labelBienvenida.Values.Text = "VERIFICACION FACIAL";
            // 
            // picCamara
            // 
            this.picCamara.Location = new System.Drawing.Point(20, 10);
            this.picCamara.Name = "picCamara";
            this.picCamara.Size = new System.Drawing.Size(522, 330);
            this.picCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamara.TabIndex = 21;
            this.picCamara.TabStop = false;
            this.picCamara.Click += new System.EventHandler(this.picCamara_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.kryptonLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 594);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(464, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 468);
            this.panel2.TabIndex = 0;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMensaje.Location = new System.Drawing.Point(561, 414);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(68, 22);
            this.lblMensaje.TabIndex = 24;
            this.lblMensaje.Text = "label1";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(580, 473);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(32)))), ((int)(((byte)(25)))));
            this.btnCancelar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(32)))), ((int)(((byte)(25)))));
            this.btnCancelar.OverrideDefault.Border.Rounding = 10F;
            this.btnCancelar.Size = new System.Drawing.Size(223, 41);
            this.btnCancelar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(32)))), ((int)(((byte)(25)))));
            this.btnCancelar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(32)))), ((int)(((byte)(25)))));
            this.btnCancelar.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnCancelar.StateCommon.Border.Rounding = 10F;
            this.btnCancelar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancelar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.btnCancelar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(32)))), ((int)(((byte)(25)))));
            this.btnCancelar.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(32)))), ((int)(((byte)(25)))));
            this.btnCancelar.StateNormal.Border.Rounding = 10F;
            this.btnCancelar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.StateTracking.Border.Rounding = 10F;
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancelar.Values.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(86, 303);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(304, 129);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateNormal.LongText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateNormal.LongText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateNormal.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.kryptonLabel1.TabIndex = 17;
            this.kryptonLabel1.Values.Text = "TRAMADE \r\n    S.A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRAMADE.Properties.Resources.Logo_de_la_empresa;
            this.pictureBox1.Location = new System.Drawing.Point(19, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.picCamara);
            this.panel3.Location = new System.Drawing.Point(404, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(562, 354);
            this.panel3.TabIndex = 26;
            // 
            // frmVerificacionFacial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.labelBienvenida);
            this.Name = "frmVerificacionFacial";
            this.Text = "frmVerficacionFacial";
            this.Load += new System.EventHandler(this.frmVerificacionFacial_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picCamara)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.PictureBox picCamara;
        private Krypton.Toolkit.KryptonLabel labelBienvenida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMensaje;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}