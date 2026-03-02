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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscarProducto = new Krypton.Toolkit.KryptonTextBox();
            this.btnBuscadorAgg = new Krypton.Toolkit.ButtonSpecAny();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalirAggProducto = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonGroup2 = new Krypton.Toolkit.KryptonGroup();
            this.btnLimpiarBuscador = new Krypton.Toolkit.KryptonButton();
            this.btnSeleccionarProducto = new Krypton.Toolkit.KryptonButton();
            this.kryptonGroup3 = new Krypton.Toolkit.KryptonGroup();
            this.dgvProductos = new Krypton.Toolkit.KryptonDataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadSeleccionada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonDataGridViewImageColumn1 = new Krypton.Toolkit.KryptonDataGridViewImageColumn();
            this.kryptonDataGridViewImageColumn2 = new Krypton.Toolkit.KryptonDataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).BeginInit();
            this.kryptonGroup2.Panel.SuspendLayout();
            this.kryptonGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).BeginInit();
            this.kryptonGroup3.Panel.SuspendLayout();
            this.kryptonGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.ButtonSpecs.Add(this.btnBuscadorAgg);
            this.txtBuscarProducto.CueHint.CueHintText = "Ingrese nombre o código del producto";
            this.txtBuscarProducto.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtBuscarProducto.Location = new System.Drawing.Point(225, 138);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(405, 35);
            this.txtBuscarProducto.StateCommon.Border.Rounding = 20F;
            this.txtBuscarProducto.TabIndex = 23;
            this.txtBuscarProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            // 
            // btnBuscadorAgg
            // 
            this.btnBuscadorAgg.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.btnBuscadorAgg.Image = global::TRAMADE.Properties.Resources.lupa__1_;
            this.btnBuscadorAgg.UniqueName = "1cd0ef32f05d4208949f65d35e06f9f0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.btnSalirAggProducto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(10, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 100);
            this.panel1.TabIndex = 22;
            // 
            // btnSalirAggProducto
            // 
            this.btnSalirAggProducto.Location = new System.Drawing.Point(729, 33);
            this.btnSalirAggProducto.Name = "btnSalirAggProducto";
            this.btnSalirAggProducto.Size = new System.Drawing.Size(37, 37);
            this.btnSalirAggProducto.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSalirAggProducto.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSalirAggProducto.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnSalirAggProducto.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnSalirAggProducto.StateCommon.Border.Rounding = 10F;
            this.btnSalirAggProducto.TabIndex = 10;
            this.btnSalirAggProducto.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalirAggProducto.Values.Image = global::TRAMADE.Properties.Resources.Cerrar_png;
            this.btnSalirAggProducto.Values.Text = "";
            this.btnSalirAggProducto.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Agregar productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRAMADE.Properties.Resources.Tramade_logo_png;
            this.pictureBox1.Location = new System.Drawing.Point(11, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(1, 0);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonGroup2);
            this.kryptonGroup1.Size = new System.Drawing.Size(819, 478);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroup1.StateCommon.Border.Width = 3;
            this.kryptonGroup1.TabIndex = 27;
            // 
            // kryptonGroup2
            // 
            this.kryptonGroup2.Location = new System.Drawing.Point(17, 118);
            // 
            // kryptonGroup2.Panel
            // 
            this.kryptonGroup2.Panel.Controls.Add(this.btnLimpiarBuscador);
            this.kryptonGroup2.Panel.Controls.Add(this.btnSeleccionarProducto);
            this.kryptonGroup2.Panel.Controls.Add(this.kryptonGroup3);
            this.kryptonGroup2.Size = new System.Drawing.Size(777, 338);
            this.kryptonGroup2.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonGroup2.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroup2.StateCommon.Border.Width = 3;
            this.kryptonGroup2.TabIndex = 56;
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(612, 14);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(71, 35);
            this.btnLimpiarBuscador.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscador.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscador.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscador.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscador.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnLimpiarBuscador.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnLimpiarBuscador.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscador.StatePressed.Back.Color1 = System.Drawing.Color.Sienna;
            this.btnLimpiarBuscador.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpiarBuscador.TabIndex = 54;
            this.btnLimpiarBuscador.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnLimpiarBuscador.Values.Image = global::TRAMADE.Properties.Resources.X__2___1_;
            this.btnLimpiarBuscador.Values.Text = "Limpiar";
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.kryptonButton2_Click_1);
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(27, 309);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(150, 20);
            this.btnSeleccionarProducto.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSeleccionarProducto.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSeleccionarProducto.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnSeleccionarProducto.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnSeleccionarProducto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnSeleccionarProducto.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSeleccionarProducto.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnSeleccionarProducto.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSeleccionarProducto.StatePressed.Back.Color1 = System.Drawing.Color.Sienna;
            this.btnSeleccionarProducto.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSeleccionarProducto.TabIndex = 54;
            this.btnSeleccionarProducto.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSeleccionarProducto.Values.Image = global::TRAMADE.Properties.Resources.Signo_de_suma_png_redimensionada_2;
            this.btnSeleccionarProducto.Values.Text = "Seleccionar producto";
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click);
            // 
            // kryptonGroup3
            // 
            this.kryptonGroup3.Location = new System.Drawing.Point(19, 71);
            // 
            // kryptonGroup3.Panel
            // 
            this.kryptonGroup3.Panel.Controls.Add(this.dgvProductos);
            this.kryptonGroup3.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroup3_Panel_Paint);
            this.kryptonGroup3.Size = new System.Drawing.Size(733, 232);
            this.kryptonGroup3.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonGroup3.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroup3.StateCommon.Border.Width = 3;
            this.kryptonGroup3.TabIndex = 0;
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
            this.dgvProductos.Location = new System.Drawing.Point(16, 19);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.Size = new System.Drawing.Size(694, 198);
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
            // colID
            // 
            this.colID.FillWeight = 78.16487F;
            this.colID.HeaderText = "#";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 164.9846F;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colDesc
            // 
            this.colDesc.FillWeight = 117.6891F;
            this.colDesc.HeaderText = "Descripción";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.FillWeight = 117.6891F;
            this.colStock.HeaderText = "Cantidad en stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.FillWeight = 117.6891F;
            this.colPrecio.HeaderText = "Precio unitario";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colCantidadSeleccionada
            // 
            this.colCantidadSeleccionada.FillWeight = 117.6891F;
            this.colCantidadSeleccionada.HeaderText = "Cantidad a agregar";
            this.colCantidadSeleccionada.Name = "colCantidadSeleccionada";
            this.colCantidadSeleccionada.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCantidadSeleccionada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kryptonDataGridViewImageColumn1
            // 
            this.kryptonDataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.kryptonDataGridViewImageColumn1.FillWeight = 44.5951F;
            this.kryptonDataGridViewImageColumn1.HeaderText = "-";
            this.kryptonDataGridViewImageColumn1.Image = global::TRAMADE.Properties.Resources.resta_1_;
            this.kryptonDataGridViewImageColumn1.Name = "kryptonDataGridViewImageColumn1";
            this.kryptonDataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewImageColumn1.Width = 28;
            // 
            // kryptonDataGridViewImageColumn2
            // 
            this.kryptonDataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kryptonDataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.kryptonDataGridViewImageColumn2.FillWeight = 40.60914F;
            this.kryptonDataGridViewImageColumn2.HeaderText = "+";
            this.kryptonDataGridViewImageColumn2.Image = global::TRAMADE.Properties.Resources.Suma_1_;
            this.kryptonDataGridViewImageColumn2.Name = "kryptonDataGridViewImageColumn2";
            this.kryptonDataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kryptonDataGridViewImageColumn2.Width = 25;
            // 
            // frmAggProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 479);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonGroup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAggProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAggProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).EndInit();
            this.kryptonGroup2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).EndInit();
            this.kryptonGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).EndInit();
            this.kryptonGroup3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).EndInit();
            this.kryptonGroup3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox txtBuscarProducto;
        private Krypton.Toolkit.ButtonSpecAny btnBuscadorAgg;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btnSalirAggProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonDataGridViewImageColumn kryptonDataGridViewImageColumn1;
        private Krypton.Toolkit.KryptonDataGridViewImageColumn kryptonDataGridViewImageColumn2;
        private Krypton.Toolkit.KryptonGroup kryptonGroup2;
        private Krypton.Toolkit.KryptonGroup kryptonGroup3;
        private Krypton.Toolkit.KryptonDataGridView dgvProductos;
        private Krypton.Toolkit.KryptonButton btnSeleccionarProducto;
        private Krypton.Toolkit.KryptonButton btnLimpiarBuscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadSeleccionada;
    }
}