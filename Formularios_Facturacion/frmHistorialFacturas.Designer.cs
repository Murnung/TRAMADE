namespace TRAMADE
{
    partial class frmHistorialFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialFacturas));
            this.dtpCalendario = new System.Windows.Forms.DateTimePicker();
            this.btnOrdenarFacturas = new Krypton.Toolkit.KryptonButton();
            this.btnCalendarioFacturas = new Krypton.Toolkit.KryptonButton();
            this.txtBuscarFactura = new Krypton.Toolkit.KryptonTextBox();
            this.btnBuscarFacturas = new Krypton.Toolkit.ButtonSpecAny();
            this.dgvHistorialFacturas = new Krypton.Toolkit.KryptonDataGridView();
            this.Numeral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNIRTNCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerFacturaHF = new Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroup5 = new Krypton.Toolkit.KryptonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup5.Panel)).BeginInit();
            this.kryptonGroup5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpCalendario
            // 
            this.dtpCalendario.Location = new System.Drawing.Point(696, 32);
            this.dtpCalendario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCalendario.Name = "dtpCalendario";
            this.dtpCalendario.Size = new System.Drawing.Size(265, 22);
            this.dtpCalendario.TabIndex = 59;
            // 
            // btnOrdenarFacturas
            // 
            this.btnOrdenarFacturas.Location = new System.Drawing.Point(651, 26);
            this.btnOrdenarFacturas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrdenarFacturas.Name = "btnOrdenarFacturas";
            this.btnOrdenarFacturas.Size = new System.Drawing.Size(37, 28);
            this.btnOrdenarFacturas.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnOrdenarFacturas.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnOrdenarFacturas.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnOrdenarFacturas.StateCommon.Border.Rounding = 10F;
            this.btnOrdenarFacturas.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnOrdenarFacturas.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnOrdenarFacturas.StateCommon.Content.ShortText.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenarFacturas.StateCommon.Content.ShortText.Image")));
            this.btnOrdenarFacturas.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnOrdenarFacturas.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnOrdenarFacturas.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnOrdenarFacturas.StatePressed.Back.Color1 = System.Drawing.Color.Sienna;
            this.btnOrdenarFacturas.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOrdenarFacturas.TabIndex = 58;
            this.btnOrdenarFacturas.TabStop = false;
            this.btnOrdenarFacturas.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnOrdenarFacturas.Values.Image = global::TRAMADE.Properties.Resources.Ordenar_pns;
            this.btnOrdenarFacturas.Values.Text = "";
            this.btnOrdenarFacturas.Click += new System.EventHandler(this.btnOrdenarFacturas_Click);
            // 
            // btnCalendarioFacturas
            // 
            this.btnCalendarioFacturas.Location = new System.Drawing.Point(585, 11);
            this.btnCalendarioFacturas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalendarioFacturas.Name = "btnCalendarioFacturas";
            this.btnCalendarioFacturas.Size = new System.Drawing.Size(56, 48);
            this.btnCalendarioFacturas.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnCalendarioFacturas.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnCalendarioFacturas.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCalendarioFacturas.StateCommon.Border.Rounding = 10F;
            this.btnCalendarioFacturas.StateCommon.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnCalendarioFacturas.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnCalendarioFacturas.StateCommon.Content.ShortText.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendarioFacturas.StateCommon.Content.ShortText.Image")));
            this.btnCalendarioFacturas.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnCalendarioFacturas.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.btnCalendarioFacturas.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnCalendarioFacturas.StatePressed.Back.Color1 = System.Drawing.Color.Sienna;
            this.btnCalendarioFacturas.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCalendarioFacturas.TabIndex = 58;
            this.btnCalendarioFacturas.TabStop = false;
            this.btnCalendarioFacturas.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCalendarioFacturas.Values.Image = global::TRAMADE.Properties.Resources.Calendario_BC_png;
            this.btnCalendarioFacturas.Values.Text = "";
            this.btnCalendarioFacturas.Click += new System.EventHandler(this.btnCalendarioFacturas_Click);
            // 
            // txtBuscarFactura
            // 
            this.txtBuscarFactura.ButtonSpecs.Add(this.btnBuscarFacturas);
            this.txtBuscarFactura.CueHint.CueHintText = "Ingrese numero de factura o ID de cliente";
            this.txtBuscarFactura.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtBuscarFactura.Location = new System.Drawing.Point(37, 26);
            this.txtBuscarFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarFactura.Name = "txtBuscarFactura";
            this.txtBuscarFactura.ShortcutsEnabled = false;
            this.txtBuscarFactura.Size = new System.Drawing.Size(540, 31);
            this.txtBuscarFactura.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.txtBuscarFactura.StateCommon.Border.Rounding = 5F;
            this.txtBuscarFactura.TabIndex = 42;
            this.txtBuscarFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarFactura.TextChanged += new System.EventHandler(this.txtBuscarFactura_TextChanged);
            this.txtBuscarFactura.Click += new System.EventHandler(this.frmHistorialFacturas_Load);
            // 
            // btnBuscarFacturas
            // 
            this.btnBuscarFacturas.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnBuscarFacturas.Image = global::TRAMADE.Properties.Resources.lupa__1_;
            this.btnBuscarFacturas.UniqueName = "1cd0ef32f05d4208949f65d35e06f9f0";
            // 
            // dgvHistorialFacturas
            // 
            this.dgvHistorialFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorialFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numeral,
            this.NumFactura,
            this.IDVendedor,
            this.DNIRTNCliente,
            this.FechaEmision});
            this.dgvHistorialFacturas.Location = new System.Drawing.Point(37, 89);
            this.dgvHistorialFacturas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHistorialFacturas.Name = "dgvHistorialFacturas";
            this.dgvHistorialFacturas.RowHeadersVisible = false;
            this.dgvHistorialFacturas.RowHeadersWidth = 51;
            this.dgvHistorialFacturas.Size = new System.Drawing.Size(925, 204);
            this.dgvHistorialFacturas.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvHistorialFacturas.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dgvHistorialFacturas.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvHistorialFacturas.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.LightGray;
            this.dgvHistorialFacturas.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)));
            this.dgvHistorialFacturas.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.dgvHistorialFacturas.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.dgvHistorialFacturas.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Transparent;
            this.dgvHistorialFacturas.StateCommon.HeaderColumn.Border.Rounding = 1F;
            this.dgvHistorialFacturas.StateCommon.HeaderColumn.Border.Width = 1;
            this.dgvHistorialFacturas.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgvHistorialFacturas.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHistorialFacturas.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvHistorialFacturas.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvHistorialFacturas.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Gray;
            this.dgvHistorialFacturas.TabIndex = 54;
            this.dgvHistorialFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialFacturas_CellContentClick);
            // 
            // Numeral
            // 
            this.Numeral.FillWeight = 63.08398F;
            this.Numeral.HeaderText = "#";
            this.Numeral.MinimumWidth = 6;
            this.Numeral.Name = "Numeral";
            // 
            // NumFactura
            // 
            this.NumFactura.HeaderText = "Numero de factura";
            this.NumFactura.MinimumWidth = 6;
            this.NumFactura.Name = "NumFactura";
            // 
            // IDVendedor
            // 
            this.IDVendedor.HeaderText = "ID vendedor";
            this.IDVendedor.MinimumWidth = 6;
            this.IDVendedor.Name = "IDVendedor";
            // 
            // DNIRTNCliente
            // 
            this.DNIRTNCliente.HeaderText = "DNI/RTN cliente";
            this.DNIRTNCliente.MinimumWidth = 6;
            this.DNIRTNCliente.Name = "DNIRTNCliente";
            // 
            // FechaEmision
            // 
            this.FechaEmision.HeaderText = "Fecha de emisión";
            this.FechaEmision.MinimumWidth = 6;
            this.FechaEmision.Name = "FechaEmision";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Historial de facturas";
            // 
            // btnVerFacturaHF
            // 
            this.btnVerFacturaHF.Location = new System.Drawing.Point(25, 354);
            this.btnVerFacturaHF.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerFacturaHF.Name = "btnVerFacturaHF";
            this.btnVerFacturaHF.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVerFacturaHF.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVerFacturaHF.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVerFacturaHF.OverrideFocus.Back.Color2 = System.Drawing.Color.Blue;
            this.btnVerFacturaHF.Size = new System.Drawing.Size(164, 41);
            this.btnVerFacturaHF.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVerFacturaHF.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVerFacturaHF.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnVerFacturaHF.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnVerFacturaHF.StateCommon.Border.Rounding = 5F;
            this.btnVerFacturaHF.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnVerFacturaHF.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnVerFacturaHF.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVerFacturaHF.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVerFacturaHF.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVerFacturaHF.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVerFacturaHF.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVerFacturaHF.StateTracking.Back.Color2 = System.Drawing.Color.Blue;
            this.btnVerFacturaHF.TabIndex = 55;
            this.btnVerFacturaHF.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnVerFacturaHF.Values.Image = global::TRAMADE.Properties.Resources.ojo_png_3_;
            this.btnVerFacturaHF.Values.Text = "Ver factura";
            this.btnVerFacturaHF.Click += new System.EventHandler(this.btnVerFacturaHF_Click);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionVisible = false;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(17, 54);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.dgvHistorialFacturas);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonGroup5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnVerFacturaHF);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnCalendarioFacturas);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtpCalendario);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtBuscarFactura);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnOrdenarFacturas);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(1021, 415);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 5F;
            this.kryptonGroupBox1.TabIndex = 60;
            // 
            // kryptonGroup5
            // 
            this.kryptonGroup5.Location = new System.Drawing.Point(25, 82);
            this.kryptonGroup5.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonGroup5.Size = new System.Drawing.Size(948, 264);
            this.kryptonGroup5.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup5.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroup5.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup5.StateCommon.Border.Width = 1;
            this.kryptonGroup5.TabIndex = 155;
            // 
            // frmHistorialFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1076, 508);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHistorialFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistorialFacturas";
            this.Load += new System.EventHandler(this.frmHistorialFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup5.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup5)).EndInit();
            this.kryptonGroup5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonTextBox txtBuscarFactura;
        private Krypton.Toolkit.ButtonSpecAny btnBuscarFacturas;
        private Krypton.Toolkit.KryptonDataGridView dgvHistorialFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numeral;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIRTNCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEmision;
        private Krypton.Toolkit.KryptonButton btnCalendarioFacturas;
        private Krypton.Toolkit.KryptonButton btnOrdenarFacturas;
        private System.Windows.Forms.DateTimePicker dtpCalendario;
        private Krypton.Toolkit.KryptonButton btnVerFacturaHF;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup5;
    }
}