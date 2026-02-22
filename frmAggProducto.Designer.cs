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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAggProducto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny2 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.btnAggProducto = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton9 = new Krypton.Toolkit.KryptonButton();
            this.numeral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.kryptonButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 100);
            this.panel1.TabIndex = 0;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(729, 33);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(37, 37);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.kryptonButton1.StateCommon.Border.Rounding = 10F;
            this.kryptonButton1.TabIndex = 10;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton1.Values.Image")));
            this.kryptonButton1.Values.Text = "";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.ButtonSpecs.Add(this.buttonSpecAny1);
            this.kryptonTextBox1.ButtonSpecs.Add(this.buttonSpecAny2);
            this.kryptonTextBox1.CueHint.CueHintText = "Ingrese nombre o código del producto";
            this.kryptonTextBox1.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.kryptonTextBox1.Location = new System.Drawing.Point(216, 134);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(405, 35);
            this.kryptonTextBox1.StateCommon.Border.Rounding = 20F;
            this.kryptonTextBox1.TabIndex = 1;
            this.kryptonTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Near;
            this.buttonSpecAny1.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAny1.Image")));
            this.buttonSpecAny1.UniqueName = "1cd0ef32f05d4208949f65d35e06f9f0";
            // 
            // buttonSpecAny2
            // 
            this.buttonSpecAny2.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Far;
            this.buttonSpecAny2.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAny2.Image")));
            this.buttonSpecAny2.UniqueName = "df054032f49042d2845b22b92630c15d";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeral,
            this.Producto,
            this.Descripcion,
            this.CantidadStock,
            this.PrecioUnit,
            this.Seleccion});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(72, 187);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(654, 209);
            this.kryptonDataGridView1.TabIndex = 2;
            // 
            // btnAggProducto
            // 
            this.btnAggProducto.Location = new System.Drawing.Point(83, 365);
            this.btnAggProducto.Name = "btnAggProducto";
            this.btnAggProducto.Size = new System.Drawing.Size(123, 20);
            this.btnAggProducto.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAggProducto.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnAggProducto.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAggProducto.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAggProducto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnAggProducto.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnAggProducto.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnAggProducto.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnAggProducto.StatePressed.Back.Color1 = System.Drawing.Color.Sienna;
            this.btnAggProducto.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAggProducto.TabIndex = 20;
            this.btnAggProducto.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAggProducto.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnAggProducto.Values.Image")));
            this.btnAggProducto.Values.Text = "Agregar producto";
            // 
            // kryptonButton9
            // 
            this.kryptonButton9.Location = new System.Drawing.Point(224, 365);
            this.kryptonButton9.Name = "kryptonButton9";
            this.kryptonButton9.Size = new System.Drawing.Size(123, 20);
            this.kryptonButton9.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton9.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton9.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton9.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonButton9.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.kryptonButton9.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonButton9.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonButton9.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonButton9.StatePressed.Back.Color1 = System.Drawing.Color.Sienna;
            this.kryptonButton9.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kryptonButton9.TabIndex = 21;
            this.kryptonButton9.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton9.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonButton9.Values.Image")));
            this.kryptonButton9.Values.Text = "Eliminar producto";
            // 
            // numeral
            // 
            this.numeral.HeaderText = "#";
            this.numeral.Name = "numeral";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // CantidadStock
            // 
            this.CantidadStock.HeaderText = "Cantidad en stock";
            this.CantidadStock.Name = "CantidadStock";
            // 
            // PrecioUnit
            // 
            this.PrecioUnit.HeaderText = "Precio unitario";
            this.PrecioUnit.Name = "PrecioUnit";
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "Selección";
            this.Seleccion.Name = "Seleccion";
            // 
            // frmAggProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonButton9);
            this.Controls.Add(this.btnAggProducto);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAggProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAggProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonButton btnAggProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnit;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccion;
        private Krypton.Toolkit.KryptonButton kryptonButton9;
    }
}