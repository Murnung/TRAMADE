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
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.cmbTpReporte = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new Krypton.Toolkit.KryptonButton();
            this.btnDescargar = new Krypton.Toolkit.KryptonButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pnlServicios.SuspendLayout();
            this.pnlReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlServicios
            // 
            this.pnlServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(152)))));
            this.pnlServicios.Controls.Add(this.btnGenerar);
            this.pnlServicios.Controls.Add(this.cmbTpReporte);
            this.pnlServicios.Controls.Add(this.cmbSucursal);
            this.pnlServicios.Controls.Add(this.cmbHasta);
            this.pnlServicios.Controls.Add(this.cmbDesde);
            this.pnlServicios.Controls.Add(this.label6);
            this.pnlServicios.Controls.Add(this.label5);
            this.pnlServicios.Controls.Add(this.label4);
            this.pnlServicios.Controls.Add(this.label3);
            this.pnlServicios.Controls.Add(this.label1);
            this.pnlServicios.Location = new System.Drawing.Point(79, 108);
            this.pnlServicios.Name = "pnlServicios";
            this.pnlServicios.Size = new System.Drawing.Size(610, 297);
            this.pnlServicios.TabIndex = 0;
            // 
            // pnlReportes
            // 
            this.pnlReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(166)))), ((int)(((byte)(222)))));
            this.pnlReportes.Controls.Add(this.listView1);
            this.pnlReportes.Controls.Add(this.label2);
            this.pnlReportes.Location = new System.Drawing.Point(736, 108);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(500, 297);
            this.pnlReportes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicios";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sucursal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo de reporte:";
            // 
            // cmbDesde
            // 
            this.cmbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(113, 106);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(121, 21);
            this.cmbDesde.TabIndex = 5;
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(113, 175);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(121, 21);
            this.cmbHasta.TabIndex = 6;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(446, 103);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbSucursal.TabIndex = 7;
            // 
            // cmbTpReporte
            // 
            this.cmbTpReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTpReporte.FormattingEnabled = true;
            this.cmbTpReporte.Location = new System.Drawing.Point(446, 176);
            this.cmbTpReporte.Name = "cmbTpReporte";
            this.cmbTpReporte.Size = new System.Drawing.Size(121, 21);
            this.cmbTpReporte.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(732, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Formato de descarga:";
            // 
            // cmbFormato
            // 
            this.cmbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(946, 441);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(91, 21);
            this.cmbFormato.TabIndex = 9;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(235, 246);
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
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(1070, 431);
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
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(494, 218);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 549);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.cmbFormato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnlReportes);
            this.Controls.Add(this.pnlServicios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.pnlServicios.ResumeLayout(false);
            this.pnlServicios.PerformLayout();
            this.pnlReportes.ResumeLayout(false);
            this.pnlReportes.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbTpReporte;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFormato;
        private Krypton.Toolkit.KryptonButton btnGenerar;
        private Krypton.Toolkit.KryptonButton btnDescargar;
        private System.Windows.Forms.ListView listView1;
    }
}