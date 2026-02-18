namespace TRAMADE
{
    partial class frmAutorizar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new Krypton.Toolkit.KryptonButton();
            this.label14 = new System.Windows.Forms.Label();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAutorizar = new Krypton.Toolkit.KryptonButton();
            this.btnDenegar = new Krypton.Toolkit.KryptonButton();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "AUTORIZAR SOLICITUD DE COMPRA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 69);
            this.panel1.TabIndex = 27;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(650, 18);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnRegresar.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnRegresar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnRegresar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnRegresar.OverrideFocus.Back.Color1 = System.Drawing.Color.Goldenrod;
            this.btnRegresar.OverrideFocus.Back.Color2 = System.Drawing.Color.Gold;
            this.btnRegresar.Size = new System.Drawing.Size(106, 29);
            this.btnRegresar.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnRegresar.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnRegresar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnRegresar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnRegresar.StateCommon.Border.Rounding = 10F;
            this.btnRegresar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnRegresar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnRegresar.StateTracking.Back.Color1 = System.Drawing.Color.Goldenrod;
            this.btnRegresar.StateTracking.Back.Color2 = System.Drawing.Color.Gold;
            this.btnRegresar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnRegresar.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnRegresar.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnRegresar.StateTracking.Content.ShortText.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnRegresar.StateTracking.Content.ShortText.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnRegresar.TabIndex = 72;
            this.btnRegresar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRegresar.Values.Text = "REGRESAR";
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(11, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 42);
            this.label14.TabIndex = 21;
            this.label14.Text = "TSMS";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(35, 240);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.RowTemplate.Height = 24;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(736, 343);
            this.kryptonDataGridView1.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Solicitud de compra";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha de emisión";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha de entrega";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Importe total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Estado";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.Location = new System.Drawing.Point(31, 189);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.OverrideFocus.Back.Color2 = System.Drawing.Color.DarkSeaGreen;
            this.btnAutorizar.Size = new System.Drawing.Size(208, 29);
            this.btnAutorizar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAutorizar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAutorizar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.StateTracking.Back.Color2 = System.Drawing.Color.DarkSeaGreen;
            this.btnAutorizar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnAutorizar.TabIndex = 72;
            this.btnAutorizar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAutorizar.Values.Text = "AUTORIZAR SELECCIONES";
            // 
            // btnDenegar
            // 
            this.btnDenegar.Location = new System.Drawing.Point(258, 189);
            this.btnDenegar.Name = "btnDenegar";
            this.btnDenegar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.OverrideFocus.Back.Color2 = System.Drawing.Color.OrangeRed;
            this.btnDenegar.Size = new System.Drawing.Size(208, 29);
            this.btnDenegar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDenegar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDenegar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.StateTracking.Back.Color2 = System.Drawing.Color.OrangeRed;
            this.btnDenegar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnDenegar.TabIndex = 73;
            this.btnDenegar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDenegar.Values.Text = "DENEGAR SELECCIONES";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(35, 132);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(477, 33);
            this.kryptonTextBox1.StateCommon.Border.Rounding = 10F;
            this.kryptonTextBox1.TabIndex = 74;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.panel2.Location = new System.Drawing.Point(0, 612);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 37);
            this.panel2.TabIndex = 75;
            // 
            // frmAutorizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(793, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.btnDenegar);
            this.Controls.Add(this.btnAutorizar);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "frmAutorizar";
            this.Text = "frmAutorizar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btnRegresar;
        private System.Windows.Forms.Label label14;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private Krypton.Toolkit.KryptonButton btnAutorizar;
        private Krypton.Toolkit.KryptonButton btnDenegar;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private System.Windows.Forms.Panel panel2;
    }
}