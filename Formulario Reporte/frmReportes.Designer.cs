namespace TRAMADE
{
    partial class frmReportes
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
            this.pnlServicios = new System.Windows.Forms.Panel();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.cmbTipoReporte = new System.Windows.Forms.ComboBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar = new Krypton.Toolkit.KryptonButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.lstReportes = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.btnDescargar = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new Krypton.Toolkit.KryptonButton();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlServicios.SuspendLayout();
            this.pnlReportes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlServicios
            // 
            this.pnlServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(152)))));
            this.pnlServicios.Controls.Add(this.cmbSucursal);
            this.pnlServicios.Controls.Add(this.cmbTipoReporte);
            this.pnlServicios.Controls.Add(this.dtpHasta);
            this.pnlServicios.Controls.Add(this.dtpDesde);
            this.pnlServicios.Controls.Add(this.btnGenerar);
            this.pnlServicios.Controls.Add(this.label6);
            this.pnlServicios.Controls.Add(this.label5);
            this.pnlServicios.Controls.Add(this.label4);
            this.pnlServicios.Controls.Add(this.label3);
            this.pnlServicios.Controls.Add(this.label1);
            this.pnlServicios.Location = new System.Drawing.Point(53, 142);
            this.pnlServicios.Name = "pnlServicios";
            this.pnlServicios.Size = new System.Drawing.Size(687, 297);
            this.pnlServicios.TabIndex = 0;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(470, 105);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(153, 21);
            this.cmbSucursal.TabIndex = 14;
            // 
            // cmbTipoReporte
            // 
            this.cmbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoReporte.FormattingEnabled = true;
            this.cmbTipoReporte.Location = new System.Drawing.Point(470, 175);
            this.cmbTipoReporte.Name = "cmbTipoReporte";
            this.cmbTipoReporte.Size = new System.Drawing.Size(153, 21);
            this.cmbTipoReporte.TabIndex = 13;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(110, 175);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 11;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(113, 103);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(197, 20);
            this.dtpDesde.TabIndex = 10;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(273, 234);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(87)))), ((int)(((byte)(163)))));
            this.btnGenerar.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnGenerar.OverrideDefault.Border.Rounding = 10F;
            this.btnGenerar.Size = new System.Drawing.Size(131, 35);
            this.btnGenerar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(87)))), ((int)(((byte)(163)))));
            this.btnGenerar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(87)))), ((int)(((byte)(163)))));
            this.btnGenerar.StateCommon.Border.Rounding = 10F;
            this.btnGenerar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGenerar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnGenerar.Values.Text = "Generar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo de reporte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sucursal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicios";
            // 
            // pnlReportes
            // 
            this.pnlReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(166)))), ((int)(((byte)(222)))));
            this.pnlReportes.Controls.Add(this.lstReportes);
            this.pnlReportes.Controls.Add(this.label2);
            this.pnlReportes.Location = new System.Drawing.Point(791, 142);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(500, 297);
            this.pnlReportes.TabIndex = 1;
            // 
            // lstReportes
            // 
            this.lstReportes.HideSelection = false;
            this.lstReportes.Location = new System.Drawing.Point(3, 68);
            this.lstReportes.Name = "lstReportes";
            this.lstReportes.Size = new System.Drawing.Size(494, 218);
            this.lstReportes.TabIndex = 2;
            this.lstReportes.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reportes Generados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(787, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Formato de descarga:";
            // 
            // cmbFormato
            // 
            this.cmbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(1001, 475);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(91, 21);
            this.cmbFormato.TabIndex = 9;
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(1125, 465);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(87)))), ((int)(((byte)(163)))));
            this.btnDescargar.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnDescargar.OverrideDefault.Border.Rounding = 10F;
            this.btnDescargar.Size = new System.Drawing.Size(131, 35);
            this.btnDescargar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(87)))), ((int)(((byte)(163)))));
            this.btnDescargar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(87)))), ((int)(((byte)(163)))));
            this.btnDescargar.StateCommon.Border.Rounding = 10F;
            this.btnDescargar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDescargar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.TabIndex = 10;
            this.btnDescargar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDescargar.Values.Text = "Descargar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 115);
            this.panel1.TabIndex = 11;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(1158, 44);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(39)))), ((int)(((byte)(56)))));
            this.btnRegresar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(39)))), ((int)(((byte)(56)))));
            this.btnRegresar.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegresar.OverrideDefault.Border.Rounding = 10F;
            this.btnRegresar.Size = new System.Drawing.Size(131, 35);
            this.btnRegresar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(39)))), ((int)(((byte)(56)))));
            this.btnRegresar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(39)))), ((int)(((byte)(56)))));
            this.btnRegresar.StateCommon.Border.Rounding = 10F;
            this.btnRegresar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRegresar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(200)))), ((int)(((byte)(99)))));
            this.btnRegresar.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(200)))), ((int)(((byte)(99)))));
            this.btnRegresar.StateNormal.Border.Rounding = 10F;
            this.btnRegresar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(39)))), ((int)(((byte)(56)))));
            this.btnRegresar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(39)))), ((int)(((byte)(56)))));
            this.btnRegresar.StateTracking.Border.Rounding = 10F;
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRegresar.Values.Text = "Regresar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(529, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 60);
            this.label8.TabIndex = 1;
            this.label8.Text = "Reportes ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRAMADE.Properties.Resources.TramadeIcon;
            this.pictureBox1.Location = new System.Drawing.Point(13, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1331, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.cmbFormato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnlReportes);
            this.Controls.Add(this.pnlServicios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.pnlServicios.ResumeLayout(false);
            this.pnlServicios.PerformLayout();
            this.pnlReportes.ResumeLayout(false);
            this.pnlReportes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlServicios;
        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFormato;
        private Krypton.Toolkit.KryptonButton btnGenerar;
        private Krypton.Toolkit.KryptonButton btnDescargar;
        private System.Windows.Forms.ListView lstReportes;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton btnRegresar;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.ComboBox cmbSucursal;
    }
}