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
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de Proveedores";
            // 
            // btnAñadirProveedor
            // 
            this.btnAñadirProveedor.Location = new System.Drawing.Point(104, 126);
            this.btnAñadirProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadirProveedor.Name = "btnAñadirProveedor";
            this.btnAñadirProveedor.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(72)))), ((int)(((byte)(229)))));
            this.btnAñadirProveedor.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(72)))), ((int)(((byte)(229)))));
            this.btnAñadirProveedor.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAñadirProveedor.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAñadirProveedor.Size = new System.Drawing.Size(228, 50);
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
            this.txtBuscar.Location = new System.Drawing.Point(104, 226);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(547, 34);
            this.txtBuscar.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnFiltrarActivo
            // 
            this.btnFiltrarActivo.Location = new System.Drawing.Point(704, 226);
            this.btnFiltrarActivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrarActivo.Name = "btnFiltrarActivo";
            this.btnFiltrarActivo.OverrideDefault.Back.Color1 = System.Drawing.Color.Lime;
            this.btnFiltrarActivo.OverrideDefault.Back.Color2 = System.Drawing.Color.Lime;
            this.btnFiltrarActivo.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFiltrarActivo.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFiltrarActivo.Size = new System.Drawing.Size(107, 44);
            this.btnFiltrarActivo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnFiltrarActivo.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
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
            this.btnFiltrarInactivo.Location = new System.Drawing.Point(825, 226);
            this.btnFiltrarInactivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrarInactivo.Name = "btnFiltrarInactivo";
            this.btnFiltrarInactivo.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.btnFiltrarInactivo.OverrideDefault.Back.Color2 = System.Drawing.Color.Red;
            this.btnFiltrarInactivo.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFiltrarInactivo.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFiltrarInactivo.Size = new System.Drawing.Size(107, 44);
            this.btnFiltrarInactivo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnFiltrarInactivo.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
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
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(105, 296);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.RowTemplate.Height = 24;
            this.dgvProveedor.Size = new System.Drawing.Size(889, 362);
            this.dgvProveedor.TabIndex = 17;
            this.dgvProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedorCellDoubleClick);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.Location = new System.Drawing.Point(305, 717);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(17, 30);
            this.lblInstrucciones.TabIndex = 18;
            this.lblInstrucciones.Text = ".";
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 792);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.btnFiltrarActivo);
            this.Controls.Add(this.btnFiltrarInactivo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAñadirProveedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Label lblInstrucciones;
    }
}