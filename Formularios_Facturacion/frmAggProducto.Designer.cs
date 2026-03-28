namespace TRAMADE
{
    partial class frmAggProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonDataGridViewImageColumn1 = new Krypton.Toolkit.KryptonDataGridViewImageColumn();
            this.kryptonDataGridViewImageColumn2 = new Krypton.Toolkit.KryptonDataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductos = new Krypton.Toolkit.KryptonDataGridView();
            this.colCantidadSeleccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionarProducto = new Krypton.Toolkit.KryptonButton();
            this.btnLimpiarBuscador = new Krypton.Toolkit.KryptonButton();
            this.btnBuscadorAgg = new Krypton.Toolkit.ButtonSpecAny();
            this.txtBuscarProducto = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroup5 = new Krypton.Toolkit.KryptonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup5.Panel)).BeginInit();
            this.kryptonGroup5.Panel.SuspendLayout();
            this.kryptonGroup5.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonDataGridViewImageColumn1
            // 
            this.kryptonDataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.kryptonDataGridViewImageColumn1.FillWeight = 44.5951F;
            this.kryptonDataGridViewImageColumn1.HeaderText = "-";
            this.kryptonDataGridViewImageColumn1.Image = global::TRAMADE.Properties.Resources.resta_1_;
            this.kryptonDataGridViewImageColumn1.MinimumWidth = 6;
            this.kryptonDataGridViewImageColumn1.Name = "kryptonDataGridViewImageColumn1";
            this.kryptonDataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewImageColumn1.Width = 28;
            // 
            // kryptonDataGridViewImageColumn2
            // 
            this.kryptonDataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kryptonDataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle13;
            this.kryptonDataGridViewImageColumn2.FillWeight = 40.60914F;
            this.kryptonDataGridViewImageColumn2.HeaderText = "+";
            this.kryptonDataGridViewImageColumn2.Image = global::TRAMADE.Properties.Resources.Suma_1_;
            this.kryptonDataGridViewImageColumn2.MinimumWidth = 6;
            this.kryptonDataGridViewImageColumn2.Name = "kryptonDataGridViewImageColumn2";
            this.kryptonDataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewImageColumn2.Width = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "AGREGAR PRODUCTOS";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colProducto,
            this.colDesc,
            this.colStock,
            this.colPrecio,
            this.colCantidadSeleccionada});
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvProductos.Location = new System.Drawing.Point(4, 4);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(876, 244);
            this.dgvProductos.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvProductos.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dgvProductos.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvProductos.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.LightGray;
            this.dgvProductos.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)));
            this.dgvProductos.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.dgvProductos.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.dgvProductos.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Transparent;
            this.dgvProductos.StateCommon.HeaderColumn.Border.Rounding = 1F;
            this.dgvProductos.StateCommon.HeaderColumn.Border.Width = 1;
            this.dgvProductos.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProductos.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvProductos.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvProductos.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Gray;
            this.dgvProductos.TabIndex = 53;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellEnter);
            this.dgvProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellValueChanged);
            this.dgvProductos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProductos_DataError);
            // 
            // colCantidadSeleccionada
            // 
            this.colCantidadSeleccionada.FillWeight = 117.6891F;
            this.colCantidadSeleccionada.HeaderText = "Cantidad a agregar";
            this.colCantidadSeleccionada.MinimumWidth = 6;
            this.colCantidadSeleccionada.Name = "colCantidadSeleccionada";
            this.colCantidadSeleccionada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCantidadSeleccionada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPrecio
            // 
            this.colPrecio.FillWeight = 117.6891F;
            this.colPrecio.HeaderText = "Precio unitario";
            this.colPrecio.MinimumWidth = 6;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.FillWeight = 117.6891F;
            this.colStock.HeaderText = "Cantidad en stock";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colDesc
            // 
            this.colDesc.FillWeight = 117.6891F;
            this.colDesc.HeaderText = "Descripción";
            this.colDesc.MinimumWidth = 6;
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 164.9846F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.MinimumWidth = 6;
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.FillWeight = 78.16487F;
            this.colID.HeaderText = "#";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(47, 399);
            this.btnSeleccionarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btnSeleccionarProducto.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btnSeleccionarProducto.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btnSeleccionarProducto.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(179)))), ((int)(((byte)(121)))));
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(200, 37);
            this.btnSeleccionarProducto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btnSeleccionarProducto.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btnSeleccionarProducto.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSeleccionarProducto.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSeleccionarProducto.StateCommon.Border.Rounding = 5F;
            this.btnSeleccionarProducto.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSeleccionarProducto.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnSeleccionarProducto.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btnSeleccionarProducto.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btnSeleccionarProducto.StateNormal.Border.Color1 = System.Drawing.Color.DarkGray;
            this.btnSeleccionarProducto.StateNormal.Border.Color2 = System.Drawing.Color.DarkGray;
            this.btnSeleccionarProducto.StateNormal.Border.Rounding = 5F;
            this.btnSeleccionarProducto.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btnSeleccionarProducto.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btnSeleccionarProducto.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btnSeleccionarProducto.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(179)))), ((int)(((byte)(121)))));
            this.btnSeleccionarProducto.TabIndex = 54;
            this.btnSeleccionarProducto.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSeleccionarProducto.Values.Image = global::TRAMADE.Properties.Resources.Signo_de_suma_png_redimensionada_2;
            this.btnSeleccionarProducto.Values.Text = "Seleccionar producto";
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click);
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(693, 49);
            this.btnLimpiarBuscador.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(109, 39);
            this.btnLimpiarBuscador.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscador.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscador.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.btnLimpiarBuscador.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.btnLimpiarBuscador.StateCommon.Border.Rounding = 5F;
            this.btnLimpiarBuscador.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscador.StatePressed.Back.Color1 = System.Drawing.Color.Sienna;
            this.btnLimpiarBuscador.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpiarBuscador.TabIndex = 54;
            this.btnLimpiarBuscador.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnLimpiarBuscador.Values.Image = global::TRAMADE.Properties.Resources.Escoba_borrador_png_3_;
            this.btnLimpiarBuscador.Values.Text = "Limpiar";
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.kryptonButton2_Click_1);
            // 
            // btnBuscadorAgg
            // 
            this.btnBuscadorAgg.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnBuscadorAgg.Image = global::TRAMADE.Properties.Resources.lupa__1_;
            this.btnBuscadorAgg.UniqueName = "1cd0ef32f05d4208949f65d35e06f9f0";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.ButtonSpecs.Add(this.btnBuscadorAgg);
            this.txtBuscarProducto.CueHint.CueHintText = "Ingrese nombre o código del producto";
            this.txtBuscarProducto.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtBuscarProducto.Location = new System.Drawing.Point(133, 49);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(540, 39);
            this.txtBuscarProducto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.txtBuscarProducto.StateCommon.Border.Rounding = 20F;
            this.txtBuscarProducto.TabIndex = 23;
            this.txtBuscarProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionVisible = false;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(28, 62);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonGroup5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtBuscarProducto);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnLimpiarBuscador);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnSeleccionarProducto);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(1022, 476);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 5F;
            this.kryptonGroupBox1.TabIndex = 57;
            // 
            // kryptonGroup5
            // 
            this.kryptonGroup5.Location = new System.Drawing.Point(36, 100);
            this.kryptonGroup5.Margin = new System.Windows.Forms.Padding(4);
            // 
            // kryptonGroup5.Panel
            // 
            this.kryptonGroup5.Panel.Controls.Add(this.dgvProductos);
            this.kryptonGroup5.Size = new System.Drawing.Size(898, 291);
            this.kryptonGroup5.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup5.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroup5.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup5.StateCommon.Border.Width = 1;
            this.kryptonGroup5.TabIndex = 155;
            // 
            // frmAggProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1079, 569);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAggProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAggProducto";
            this.Load += new System.EventHandler(this.frmAggProducto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup5.Panel)).EndInit();
            this.kryptonGroup5.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup5)).EndInit();
            this.kryptonGroup5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonDataGridViewImageColumn kryptonDataGridViewImageColumn1;
        private Krypton.Toolkit.KryptonDataGridViewImageColumn kryptonDataGridViewImageColumn2;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox txtBuscarProducto;
        private Krypton.Toolkit.ButtonSpecAny btnBuscadorAgg;
        private Krypton.Toolkit.KryptonButton btnLimpiarBuscador;
        private Krypton.Toolkit.KryptonButton btnSeleccionarProducto;
        private Krypton.Toolkit.KryptonDataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadSeleccionada;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup5;
    }
}