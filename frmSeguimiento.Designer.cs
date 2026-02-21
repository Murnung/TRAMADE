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
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new Krypton.Toolkit.KryptonTextBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kgActivos = new Krypton.Toolkit.KryptonGroup();
            this.txtActivos = new Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kgRegistrados = new Krypton.Toolkit.KryptonGroup();
            this.txtRegistrados = new Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kgInactivos = new Krypton.Toolkit.KryptonGroup();
            this.txtInactivos = new Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgActivos.Panel)).BeginInit();
            this.kgActivos.Panel.SuspendLayout();
            this.kgActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgRegistrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgRegistrados.Panel)).BeginInit();
            this.kgRegistrados.Panel.SuspendLayout();
            this.kgRegistrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgInactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgInactivos.Panel)).BeginInit();
            this.kgInactivos.Panel.SuspendLayout();
            this.kgInactivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(29, 23);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kgInactivos);
            this.kryptonGroup1.Panel.Controls.Add(this.kgRegistrados);
            this.kryptonGroup1.Panel.Controls.Add(this.kgActivos);
            this.kryptonGroup1.Panel.Controls.Add(this.dateTimePicker1);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonDataGridView1);
            this.kryptonGroup1.Panel.Controls.Add(this.label1);
            this.kryptonGroup1.Panel.Controls.Add(this.txtBuscar);
            this.kryptonGroup1.Panel.Enabled = false;
            this.kryptonGroup1.Size = new System.Drawing.Size(727, 424);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(220)))), ((int)(((byte)(229)))));
            this.kryptonGroup1.StateCommon.Border.Rounding = 30F;
            this.kryptonGroup1.TabIndex = 1;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(62, 265);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.Size = new System.Drawing.Size(597, 122);
            this.kryptonDataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 10.6F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "SEGUIMIENTO DE CLIENTES";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(373, 47);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(303, 29);
            this.txtBuscar.StateActive.Border.Color1 = System.Drawing.Color.Black;
            this.txtBuscar.StateActive.Border.Color2 = System.Drawing.Color.Black;
            this.txtBuscar.StateActive.Border.Rounding = 5F;
            this.txtBuscar.StateActive.Border.Width = 3;
            this.txtBuscar.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "ID de Cliente";
            this.Column2.Name = "Column2";
            this.Column2.Width = 106;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.HeaderText = "Nombre de cliente/organización";
            this.Column3.Name = "Column3";
            this.Column3.Width = 182;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.HeaderText = "Fecha de Registro";
            this.Column4.Name = "Column4";
            this.Column4.Width = 121;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.HeaderText = "Tipo de cliente";
            this.Column5.Name = "Column5";
            this.Column5.Width = 74;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.HeaderText = "Estado";
            this.Column6.Name = "Column6";
            this.Column6.Width = 71;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(303, 22);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // kgActivos
            // 
            this.kgActivos.Location = new System.Drawing.Point(285, 113);
            // 
            // kgActivos.Panel
            // 
            this.kgActivos.Panel.Controls.Add(this.txtActivos);
            this.kgActivos.Panel.Controls.Add(this.label2);
            this.kgActivos.Size = new System.Drawing.Size(187, 120);
            this.kgActivos.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(184)))), ((int)(((byte)(80)))));
            this.kgActivos.TabIndex = 26;
            // 
            // txtActivos
            // 
            this.txtActivos.Enabled = false;
            this.txtActivos.Location = new System.Drawing.Point(37, 68);
            this.txtActivos.Name = "txtActivos";
            this.txtActivos.Size = new System.Drawing.Size(100, 23);
            this.txtActivos.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(184)))), ((int)(((byte)(80)))));
            this.txtActivos.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtActivos.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.txtActivos.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.txtActivos.TabIndex = 1;
            this.txtActivos.Text = "JUAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clientes Activos";
            // 
            // kgRegistrados
            // 
            this.kgRegistrados.Location = new System.Drawing.Point(39, 109);
            // 
            // kgRegistrados.Panel
            // 
            this.kgRegistrados.Panel.Controls.Add(this.txtRegistrados);
            this.kgRegistrados.Panel.Controls.Add(this.label3);
            this.kgRegistrados.Size = new System.Drawing.Size(210, 124);
            this.kgRegistrados.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(183)))), ((int)(((byte)(215)))));
            this.kgRegistrados.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(183)))), ((int)(((byte)(215)))));
            this.kgRegistrados.TabIndex = 27;
            // 
            // txtRegistrados
            // 
            this.txtRegistrados.Enabled = false;
            this.txtRegistrados.Location = new System.Drawing.Point(37, 68);
            this.txtRegistrados.Name = "txtRegistrados";
            this.txtRegistrados.Size = new System.Drawing.Size(100, 23);
            this.txtRegistrados.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(183)))), ((int)(((byte)(215)))));
            this.txtRegistrados.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtRegistrados.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.txtRegistrados.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.txtRegistrados.TabIndex = 1;
            this.txtRegistrados.Text = "JUAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 54);
            this.label3.TabIndex = 0;
            this.label3.Text = "Clientes Registrados";
            // 
            // kgInactivos
            // 
            this.kgInactivos.Location = new System.Drawing.Point(501, 113);
            // 
            // kgInactivos.Panel
            // 
            this.kgInactivos.Panel.Controls.Add(this.txtInactivos);
            this.kgInactivos.Panel.Controls.Add(this.label4);
            this.kgInactivos.Size = new System.Drawing.Size(187, 120);
            this.kgInactivos.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.kgInactivos.TabIndex = 28;
            // 
            // txtInactivos
            // 
            this.txtInactivos.Enabled = false;
            this.txtInactivos.Location = new System.Drawing.Point(37, 68);
            this.txtInactivos.Name = "txtInactivos";
            this.txtInactivos.Size = new System.Drawing.Size(100, 23);
            this.txtInactivos.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.txtInactivos.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.txtInactivos.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.txtInactivos.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.txtInactivos.TabIndex = 1;
            this.txtInactivos.Text = "JUAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 54);
            this.label4.TabIndex = 0;
            this.label4.Text = "Clientes Inactivos";
            // 
            // frmSeguimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonGroup1);
            this.Name = "frmSeguimiento";
            this.Text = "frmSeguimiento";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgActivos.Panel)).EndInit();
            this.kgActivos.Panel.ResumeLayout(false);
            this.kgActivos.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgActivos)).EndInit();
            this.kgActivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgRegistrados.Panel)).EndInit();
            this.kgRegistrados.Panel.ResumeLayout(false);
            this.kgRegistrados.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgRegistrados)).EndInit();
            this.kgRegistrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgInactivos.Panel)).EndInit();
            this.kgInactivos.Panel.ResumeLayout(false);
            this.kgInactivos.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgInactivos)).EndInit();
            this.kgInactivos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Krypton.Toolkit.KryptonGroup kgActivos;
        private Krypton.Toolkit.KryptonTextBox txtActivos;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonGroup kgInactivos;
        private Krypton.Toolkit.KryptonTextBox txtInactivos;
        private System.Windows.Forms.Label label4;
        private Krypton.Toolkit.KryptonGroup kgRegistrados;
        private Krypton.Toolkit.KryptonTextBox txtRegistrados;
        private System.Windows.Forms.Label label3;
    }
}