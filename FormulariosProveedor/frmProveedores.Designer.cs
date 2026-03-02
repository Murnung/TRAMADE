namespace TRAMADE
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadirProveedor = new Krypton.Toolkit.KryptonButton();
            this.txtBuscar = new Krypton.Toolkit.KryptonTextBox();
            this.btnFiltrarActivo = new Krypton.Toolkit.KryptonButton();
            this.btnFiltrarInactivo = new Krypton.Toolkit.KryptonButton();
            this.dgvProveedores = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de Proveedores";
            // 
            // btnAñadirProveedor
            // 
            this.btnAñadirProveedor.Location = new System.Drawing.Point(18, 99);
            this.btnAñadirProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAñadirProveedor.Name = "btnAñadirProveedor";
            this.btnAñadirProveedor.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(72)))), ((int)(((byte)(229)))));
            this.btnAñadirProveedor.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(72)))), ((int)(((byte)(229)))));
            this.btnAñadirProveedor.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAñadirProveedor.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAñadirProveedor.Size = new System.Drawing.Size(171, 41);
            this.btnAñadirProveedor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(72)))), ((int)(((byte)(229)))));
            this.btnAñadirProveedor.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(72)))), ((int)(((byte)(229)))));
            this.btnAñadirProveedor.StateCommon.Border.Rounding = 10F;
            this.btnAñadirProveedor.StateCommon.Content.ShortText.Color1 = System.Drawing.SystemColors.Control;
            this.btnAñadirProveedor.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirProveedor.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAñadirProveedor.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAñadirProveedor.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnAñadirProveedor.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnAñadirProveedor.TabIndex = 13;
            this.btnAñadirProveedor.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAñadirProveedor.Values.Text = "Añadir Proveedor";
            this.btnAñadirProveedor.Click += new System.EventHandler(this.btnAñadirProveedor_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.CueHint.Color1 = System.Drawing.Color.Gray;
            this.txtBuscar.CueHint.CueHintText = "        Buscar por Razón Social, Nombre Comercial o RTN";
            this.txtBuscar.CueHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(18, 180);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(410, 28);
            this.txtBuscar.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnFiltrarActivo
            // 
            this.btnFiltrarActivo.Location = new System.Drawing.Point(468, 180);
            this.btnFiltrarActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrarActivo.Name = "btnFiltrarActivo";
            this.btnFiltrarActivo.OverrideDefault.Back.Color1 = System.Drawing.Color.Lime;
            this.btnFiltrarActivo.OverrideDefault.Back.Color2 = System.Drawing.Color.Lime;
            this.btnFiltrarActivo.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFiltrarActivo.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFiltrarActivo.Size = new System.Drawing.Size(80, 36);
            this.btnFiltrarActivo.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.btnFiltrarActivo.StateCommon.Back.Color2 = System.Drawing.Color.Lime;
            this.btnFiltrarActivo.StateCommon.Border.Rounding = 10F;
            this.btnFiltrarActivo.StateCommon.Content.ShortText.Color1 = System.Drawing.SystemColors.Control;
            this.btnFiltrarActivo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarActivo.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFiltrarActivo.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFiltrarActivo.StateTracking.Border.Color1 = System.Drawing.Color.Green;
            this.btnFiltrarActivo.StateTracking.Border.Color2 = System.Drawing.Color.Green;
            this.btnFiltrarActivo.TabIndex = 16;
            this.btnFiltrarActivo.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnFiltrarActivo.Values.Text = "Activo";
            this.btnFiltrarActivo.Click += new System.EventHandler(this.btnFiltrarActivo_Click);
            // 
            // btnFiltrarInactivo
            // 
            this.btnFiltrarInactivo.Location = new System.Drawing.Point(559, 180);
            this.btnFiltrarInactivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrarInactivo.Name = "btnFiltrarInactivo";
            this.btnFiltrarInactivo.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.btnFiltrarInactivo.OverrideDefault.Back.Color2 = System.Drawing.Color.Red;
            this.btnFiltrarInactivo.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFiltrarInactivo.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFiltrarInactivo.Size = new System.Drawing.Size(80, 36);
            this.btnFiltrarInactivo.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.btnFiltrarInactivo.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            this.btnFiltrarInactivo.StateCommon.Border.Rounding = 10F;
            this.btnFiltrarInactivo.StateCommon.Content.ShortText.Color1 = System.Drawing.SystemColors.Control;
            this.btnFiltrarInactivo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarInactivo.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFiltrarInactivo.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFiltrarInactivo.StateTracking.Border.Color1 = System.Drawing.Color.Maroon;
            this.btnFiltrarInactivo.StateTracking.Border.Color2 = System.Drawing.Color.Maroon;
            this.btnFiltrarInactivo.TabIndex = 15;
            this.btnFiltrarInactivo.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnFiltrarInactivo.Values.Text = "Inactivo";
            this.btnFiltrarInactivo.Click += new System.EventHandler(this.btnFiltrarInactivo_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Sheet;
            this.dgvProveedores.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgvProveedores.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvProveedores.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvProveedores.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            this.dgvProveedores.HideOuterBorders = true;
            this.dgvProveedores.Location = new System.Drawing.Point(18, 240);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.RowTemplate.Height = 24;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(620, 310);
            this.dgvProveedores.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvProveedores.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet;
            this.dgvProveedores.StateCommon.DataCell.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.dgvProveedores.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dgvProveedores.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProveedores.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.dgvProveedores.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.dgvProveedores.StateCommon.HeaderColumn.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.dgvProveedores.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgvProveedores.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProveedores.TabIndex = 20;
            this.dgvProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellDoubleClick);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 581);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.btnFiltrarActivo);
            this.Controls.Add(this.btnFiltrarInactivo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAñadirProveedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private System.Windows.Forms.Timer tmrTransicionLateral;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonButton btnAñadirProveedor;
        private Krypton.Toolkit.KryptonTextBox txtBuscar;
        private Krypton.Toolkit.KryptonButton btnFiltrarActivo;
        private Krypton.Toolkit.KryptonButton btnFiltrarInactivo;
        private Krypton.Toolkit.KryptonDataGridView dgvProveedores;
    }
}