namespace TRAMADE
{
    partial class frmSeguimiento
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscar = new Krypton.Toolkit.KryptonTextBox();
            this.dtDesde = new Krypton.Toolkit.KryptonDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.lblSolicitudesRegistradas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonGroupBox3 = new Krypton.Toolkit.KryptonGroupBox();
            this.lblTiempoPromedio = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new Krypton.Toolkit.KryptonButton();
            this.dtHasta = new Krypton.Toolkit.KryptonDateTimePicker();
            this.btnRefrescar = new Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox4 = new Krypton.Toolkit.KryptonGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4.Panel)).BeginInit();
            this.kryptonGroupBox4.Panel.SuspendLayout();
            this.kryptonGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 32);
            this.label2.TabIndex = 77;
            this.label2.Text = "SEGUIMIENTO DE SOLICITUD DE COMPRAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "PERÍODO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "COMPRA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(440, 261);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(283, 33);
            this.txtBuscar.StateCommon.Border.Rounding = 10F;
            this.txtBuscar.TabIndex = 81;
            // 
            // dtDesde
            // 
            this.dtDesde.Location = new System.Drawing.Point(40, 224);
            this.dtDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(277, 29);
            this.dtDesde.StateCommon.Border.Rounding = 5F;
            this.dtDesde.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(183)))), ((int)(((byte)(215)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Solicitudes registradas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(149)))), ((int)(((byte)(80)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valor total pendiente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(61)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tiempo de respuesta promedio";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(38, 300);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.RowHeadersVisible = false;
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.RowTemplate.Height = 24;
            this.dgvCompras.Size = new System.Drawing.Size(1198, 354);
            this.dgvCompras.TabIndex = 85;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.CaptionVisible = false;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(68, 72);
            this.kryptonGroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.lblSolicitudesRegistradas);
            this.kryptonGroupBox2.Panel.Controls.Add(this.pictureBox1);
            this.kryptonGroupBox2.Panel.Controls.Add(this.label4);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(325, 110);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(183)))), ((int)(((byte)(215)))));
            this.kryptonGroupBox2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(183)))), ((int)(((byte)(215)))));
            this.kryptonGroupBox2.StateCommon.Border.Rounding = 10F;
            this.kryptonGroupBox2.TabIndex = 87;
            // 
            // lblSolicitudesRegistradas
            // 
            this.lblSolicitudesRegistradas.AutoSize = true;
            this.lblSolicitudesRegistradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(183)))), ((int)(((byte)(215)))));
            this.lblSolicitudesRegistradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitudesRegistradas.Location = new System.Drawing.Point(114, 68);
            this.lblSolicitudesRegistradas.Name = "lblSolicitudesRegistradas";
            this.lblSolicitudesRegistradas.Size = new System.Drawing.Size(52, 18);
            this.lblSolicitudesRegistradas.TabIndex = 91;
            this.lblSolicitudesRegistradas.Text = "label7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(183)))), ((int)(((byte)(215)))));
            this.pictureBox1.Image = global::TRAMADE.Properties.Resources.Compras;
            this.pictureBox1.Location = new System.Drawing.Point(35, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionVisible = false;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(457, 72);
            this.kryptonGroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblValorTotal);
            this.kryptonGroupBox1.Panel.Controls.Add(this.pictureBox2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label5);
            this.kryptonGroupBox1.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroupBox1_Panel_Paint);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(331, 110);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(149)))), ((int)(((byte)(80)))));
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(149)))), ((int)(((byte)(80)))));
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 10F;
            this.kryptonGroupBox1.TabIndex = 88;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(149)))), ((int)(((byte)(80)))));
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(117, 68);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(52, 18);
            this.lblValorTotal.TabIndex = 92;
            this.lblValorTotal.Text = "label7";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(149)))), ((int)(((byte)(80)))));
            this.pictureBox2.Image = global::TRAMADE.Properties.Resources.DINERO;
            this.pictureBox2.Location = new System.Drawing.Point(37, 28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 90;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.CaptionVisible = false;
            this.kryptonGroupBox3.Location = new System.Drawing.Point(858, 72);
            this.kryptonGroupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.lblTiempoPromedio);
            this.kryptonGroupBox3.Panel.Controls.Add(this.pictureBox3);
            this.kryptonGroupBox3.Panel.Controls.Add(this.label6);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(341, 110);
            this.kryptonGroupBox3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(61)))));
            this.kryptonGroupBox3.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(61)))));
            this.kryptonGroupBox3.StateCommon.Border.Rounding = 10F;
            this.kryptonGroupBox3.TabIndex = 89;
            // 
            // lblTiempoPromedio
            // 
            this.lblTiempoPromedio.AutoSize = true;
            this.lblTiempoPromedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(61)))));
            this.lblTiempoPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoPromedio.Location = new System.Drawing.Point(116, 68);
            this.lblTiempoPromedio.Name = "lblTiempoPromedio";
            this.lblTiempoPromedio.Size = new System.Drawing.Size(52, 18);
            this.lblTiempoPromedio.TabIndex = 93;
            this.lblTiempoPromedio.Text = "label7";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(122)))), ((int)(((byte)(61)))));
            this.pictureBox3.Image = global::TRAMADE.Properties.Resources.TIEMPO;
            this.pictureBox3.Location = new System.Drawing.Point(3, 28);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 90;
            this.pictureBox3.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(744, 261);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnBuscar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnBuscar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnBuscar.OverrideFocus.Back.Color2 = System.Drawing.Color.Blue;
            this.btnBuscar.OverrideFocus.Border.Rounding = 10F;
            this.btnBuscar.Size = new System.Drawing.Size(139, 34);
            this.btnBuscar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnBuscar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnBuscar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnBuscar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnBuscar.StateCommon.Border.Rounding = 10F;
            this.btnBuscar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBuscar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnBuscar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnBuscar.StateTracking.Back.Color2 = System.Drawing.Color.Blue;
            this.btnBuscar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnBuscar.StateTracking.Border.Rounding = 10F;
            this.btnBuscar.TabIndex = 90;
            this.btnBuscar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBuscar.Values.Text = "BUSCAR";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtHasta
            // 
            this.dtHasta.Location = new System.Drawing.Point(40, 265);
            this.dtHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(277, 29);
            this.dtHasta.StateCommon.Border.Rounding = 5F;
            this.dtHasta.TabIndex = 91;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(889, 261);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.OverrideDefault.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.OverrideDefault.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.OverrideFocus.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.btnRefrescar.Size = new System.Drawing.Size(51, 33);
            this.btnRefrescar.StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.StateCommon.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.StateCommon.Border.Rounding = 10F;
            this.btnRefrescar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnRefrescar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnRefrescar.StateTracking.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btnRefrescar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnRefrescar.TabIndex = 92;
            this.btnRefrescar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRefrescar.Values.Image = global::TRAMADE.Properties.Resources.refresh_2805355;
            this.btnRefrescar.Values.Text = "";
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // kryptonGroupBox4
            // 
            this.kryptonGroupBox4.CaptionVisible = false;
            this.kryptonGroupBox4.Location = new System.Drawing.Point(28, 32);
            // 
            // kryptonGroupBox4.Panel
            // 
            this.kryptonGroupBox4.Panel.Controls.Add(this.kryptonGroupBox2);
            this.kryptonGroupBox4.Panel.Controls.Add(this.btnRefrescar);
            this.kryptonGroupBox4.Panel.Controls.Add(this.label2);
            this.kryptonGroupBox4.Panel.Controls.Add(this.dtHasta);
            this.kryptonGroupBox4.Panel.Controls.Add(this.label1);
            this.kryptonGroupBox4.Panel.Controls.Add(this.btnBuscar);
            this.kryptonGroupBox4.Panel.Controls.Add(this.label3);
            this.kryptonGroupBox4.Panel.Controls.Add(this.kryptonGroupBox3);
            this.kryptonGroupBox4.Panel.Controls.Add(this.txtBuscar);
            this.kryptonGroupBox4.Panel.Controls.Add(this.kryptonGroupBox1);
            this.kryptonGroupBox4.Panel.Controls.Add(this.dtDesde);
            this.kryptonGroupBox4.Panel.Controls.Add(this.dgvCompras);
            this.kryptonGroupBox4.Size = new System.Drawing.Size(1271, 676);
            this.kryptonGroupBox4.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.kryptonGroupBox4.StateCommon.Border.Rounding = 10F;
            this.kryptonGroupBox4.TabIndex = 93;
            // 
            // frmSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1338, 736);
            this.Controls.Add(this.kryptonGroupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSeguimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSeguimiento";
            this.Load += new System.EventHandler(this.frmSeguimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            this.kryptonGroupBox3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4.Panel)).EndInit();
            this.kryptonGroupBox4.Panel.ResumeLayout(false);
            this.kryptonGroupBox4.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4)).EndInit();
            this.kryptonGroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonTextBox txtBuscar;
        private Krypton.Toolkit.KryptonDateTimePicker dtDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCompras;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Krypton.Toolkit.KryptonButton btnBuscar;
        private Krypton.Toolkit.KryptonDateTimePicker dtHasta;
        private System.Windows.Forms.Label lblSolicitudesRegistradas;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblTiempoPromedio;
        private Krypton.Toolkit.KryptonButton btnRefrescar;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox4;
    }
}