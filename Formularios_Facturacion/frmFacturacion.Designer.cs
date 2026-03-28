namespace TRAMADE
{
    partial class frmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            this.btnNuevo = new Krypton.Toolkit.KryptonButton();
            this.btnEmitirFactura = new Krypton.Toolkit.KryptonButton();
            this.btnVistaPrevia = new Krypton.Toolkit.KryptonButton();
            this.btnLimpiar = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel16 = new Krypton.Toolkit.KryptonLabel();
            this.lblTotal = new Krypton.Toolkit.KryptonLabel();
            this.lblImpuesto = new Krypton.Toolkit.KryptonLabel();
            this.lblSubtotal = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel14 = new Krypton.Toolkit.KryptonLabel();
            this.rbCredito = new Krypton.Toolkit.KryptonRadioButton();
            this.rbContado = new Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            this.btnEliminarProducto = new Krypton.Toolkit.KryptonButton();
            this.btnAggProducto = new Krypton.Toolkit.KryptonButton();
            this.dgvDetalleFactura = new Krypton.Toolkit.KryptonDataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonGroup2 = new Krypton.Toolkit.KryptonGroup();
            this.txtNombreVendedor = new Krypton.Toolkit.KryptonTextBox();
            this.btnIDVendedor = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.txtIDVendedor = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonGroup1 = new Krypton.Toolkit.KryptonGroup();
            this.txtNombreCliente = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.btnDNICliente = new Krypton.Toolkit.KryptonButton();
            this.txtDireccionCliente = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.txtDNICliente = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.dtpVencimiento = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpEmision = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.lblNumeroFactura = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.btnVerFacturas = new Krypton.Toolkit.KryptonButton();
            this.kryptonGroup3 = new Krypton.Toolkit.KryptonGroup();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroup5 = new Krypton.Toolkit.KryptonGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).BeginInit();
            this.kryptonGroup2.Panel.SuspendLayout();
            this.kryptonGroup2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).BeginInit();
            this.kryptonGroup3.Panel.SuspendLayout();
            this.kryptonGroup3.SuspendLayout();
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
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(236, 627);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 31);
            this.btnNuevo.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNuevo.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNuevo.StateCommon.Border.Rounding = 10F;
            this.btnNuevo.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNuevo.StatePressed.Back.Color1 = System.Drawing.Color.Sienna;
            this.btnNuevo.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNuevo.TabIndex = 65;
            this.btnNuevo.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnNuevo.Values.Image = global::TRAMADE.Properties.Resources.Signo_de_nuevo_png_1_;
            this.btnNuevo.Values.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEmitirFactura
            // 
            this.btnEmitirFactura.Location = new System.Drawing.Point(636, 627);
            this.btnEmitirFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmitirFactura.Name = "btnEmitirFactura";
            this.btnEmitirFactura.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnEmitirFactura.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnEmitirFactura.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnEmitirFactura.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(179)))), ((int)(((byte)(121)))));
            this.btnEmitirFactura.Size = new System.Drawing.Size(153, 31);
            this.btnEmitirFactura.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnEmitirFactura.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnEmitirFactura.StateCommon.Border.Rounding = 10F;
            this.btnEmitirFactura.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEmitirFactura.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEmitirFactura.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnEmitirFactura.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnEmitirFactura.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnEmitirFactura.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnEmitirFactura.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnEmitirFactura.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(179)))), ((int)(((byte)(121)))));
            this.btnEmitirFactura.TabIndex = 64;
            this.btnEmitirFactura.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnEmitirFactura.Values.Image = global::TRAMADE.Properties.Resources.Check_png_3_;
            this.btnEmitirFactura.Values.Text = "Emitir factura";
            this.btnEmitirFactura.Click += new System.EventHandler(this.kryptonButton13_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Location = new System.Drawing.Point(497, 627);
            this.btnVistaPrevia.Margin = new System.Windows.Forms.Padding(4);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(131, 31);
            this.btnVistaPrevia.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVistaPrevia.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVistaPrevia.StateCommon.Border.Rounding = 10F;
            this.btnVistaPrevia.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnVistaPrevia.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnVistaPrevia.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVistaPrevia.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVistaPrevia.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVistaPrevia.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVistaPrevia.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnVistaPrevia.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(74)))), ((int)(((byte)(214)))));
            this.btnVistaPrevia.TabIndex = 63;
            this.btnVistaPrevia.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnVistaPrevia.Values.Image = global::TRAMADE.Properties.Resources.ojo_png_3_;
            this.btnVistaPrevia.Values.Text = "Vista previa";
            this.btnVistaPrevia.Click += new System.EventHandler(this.kryptonButton12_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(364, 627);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 31);
            this.btnLimpiar.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpiar.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnLimpiar.StateCommon.Border.Rounding = 10F;
            this.btnLimpiar.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnLimpiar.StatePressed.Back.Color1 = System.Drawing.Color.Sienna;
            this.btnLimpiar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpiar.TabIndex = 62;
            this.btnLimpiar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Values.Image = global::TRAMADE.Properties.Resources.Escoba_borrador_png_3_;
            this.btnLimpiar.Values.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Location = new System.Drawing.Point(5, 76);
            this.kryptonLabel16.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(120, 31);
            this.kryptonLabel16.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel16.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel16.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel16.TabIndex = 61;
            this.kryptonLabel16.Values.Text = "Total a pagar:";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(138, 76);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 31);
            this.lblTotal.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblTotal.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.lblTotal.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.TabIndex = 60;
            this.lblTotal.Values.Text = "L. 0.00";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.Location = new System.Drawing.Point(133, 43);
            this.lblImpuesto.Margin = new System.Windows.Forms.Padding(4);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(60, 25);
            this.lblImpuesto.TabIndex = 59;
            this.lblImpuesto.Values.Text = "L. 0.00";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Location = new System.Drawing.Point(131, 4);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(120, 31);
            this.lblSubtotal.TabIndex = 58;
            this.lblSubtotal.Values.Text = "L. 0.00";
            // 
            // kryptonLabel15
            // 
            this.kryptonLabel15.Location = new System.Drawing.Point(4, 36);
            this.kryptonLabel15.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel15.Name = "kryptonLabel15";
            this.kryptonLabel15.Size = new System.Drawing.Size(121, 31);
            this.kryptonLabel15.TabIndex = 57;
            this.kryptonLabel15.Values.Text = "Impuesto 15%:";
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Location = new System.Drawing.Point(-3, 4);
            this.kryptonLabel14.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(120, 31);
            this.kryptonLabel14.TabIndex = 56;
            this.kryptonLabel14.Values.Text = "Subtotal:";
            // 
            // rbCredito
            // 
            this.rbCredito.Location = new System.Drawing.Point(154, 540);
            this.rbCredito.Margin = new System.Windows.Forms.Padding(4);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(84, 25);
            this.rbCredito.TabIndex = 55;
            this.rbCredito.Values.Text = "Crédito";
            // 
            // rbContado
            // 
            this.rbContado.Location = new System.Drawing.Point(37, 534);
            this.rbContado.Margin = new System.Windows.Forms.Padding(4);
            this.rbContado.Name = "rbContado";
            this.rbContado.Size = new System.Drawing.Size(120, 31);
            this.rbContado.TabIndex = 54;
            this.rbContado.Values.Text = "Contado";
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(31, 501);
            this.kryptonLabel13.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(252, 31);
            this.kryptonLabel13.TabIndex = 53;
            this.kryptonLabel13.Values.Text = "( ! ) Seleccione la forma de pago:";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(837, 170);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(188, 34);
            this.btnEliminarProducto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnEliminarProducto.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnEliminarProducto.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnEliminarProducto.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnEliminarProducto.StateCommon.Border.Rounding = 5F;
            this.btnEliminarProducto.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnEliminarProducto.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnEliminarProducto.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnEliminarProducto.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnEliminarProducto.StateNormal.Border.Rounding = 5F;
            this.btnEliminarProducto.StatePressed.Back.Color1 = System.Drawing.Color.Sienna;
            this.btnEliminarProducto.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEliminarProducto.TabIndex = 52;
            this.btnEliminarProducto.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnEliminarProducto.Values.Image = global::TRAMADE.Properties.Resources.X__2___1_;
            this.btnEliminarProducto.Values.Text = "Eliminar producto";
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnAggProducto
            // 
            this.btnAggProducto.Location = new System.Drawing.Point(12, 170);
            this.btnAggProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAggProducto.Name = "btnAggProducto";
            this.btnAggProducto.Size = new System.Drawing.Size(190, 34);
            this.btnAggProducto.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btnAggProducto.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btnAggProducto.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAggProducto.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAggProducto.StateCommon.Border.Rounding = 5F;
            this.btnAggProducto.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnAggProducto.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnAggProducto.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btnAggProducto.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(170)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btnAggProducto.StatePressed.Back.Color1 = System.Drawing.Color.Sienna;
            this.btnAggProducto.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAggProducto.TabIndex = 51;
            this.btnAggProducto.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAggProducto.Values.Image = global::TRAMADE.Properties.Resources.Signo_de_suma_png_redimensionada_2;
            this.btnAggProducto.Values.Text = "Agregar producto";
            this.btnAggProducto.Click += new System.EventHandler(this.btnAggProducto_Click);
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.Producto,
            this.Descripción,
            this.Cantidad,
            this.Precio_unitario,
            this.Subtotal});
            this.dgvDetalleFactura.Location = new System.Drawing.Point(6, 4);
            this.dgvDetalleFactura.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.RowHeadersVisible = false;
            this.dgvDetalleFactura.RowHeadersWidth = 51;
            this.dgvDetalleFactura.Size = new System.Drawing.Size(1019, 167);
            this.dgvDetalleFactura.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvDetalleFactura.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dgvDetalleFactura.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvDetalleFactura.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.LightGray;
            this.dgvDetalleFactura.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)));
            this.dgvDetalleFactura.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.dgvDetalleFactura.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.dgvDetalleFactura.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Transparent;
            this.dgvDetalleFactura.StateCommon.HeaderColumn.Border.Rounding = 1F;
            this.dgvDetalleFactura.StateCommon.HeaderColumn.Border.Width = 1;
            this.dgvDetalleFactura.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalleFactura.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvDetalleFactura.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.dgvDetalleFactura.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Gray;
            this.dgvDetalleFactura.TabIndex = 50;
            this.dgvDetalleFactura.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleFactura_CellValueChanged);
            // 
            // colID
            // 
            this.colID.HeaderText = "Column1";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio_unitario
            // 
            this.Precio_unitario.HeaderText = "Precio unitario";
            this.Precio_unitario.MinimumWidth = 6;
            this.Precio_unitario.Name = "Precio_unitario";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(413, 5);
            this.kryptonLabel9.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(228, 64);
            this.kryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonLabel9.StateCommon.ShortText.Color2 = System.Drawing.Color.DarkGray;
            this.kryptonLabel9.TabIndex = 49;
            this.kryptonLabel9.Values.Text = "Los espacios con \"( ! )\" deben\r\ncontener información \r\nde manera obligatoria";
            // 
            // kryptonGroup2
            // 
            this.kryptonGroup2.Location = new System.Drawing.Point(514, 124);
            this.kryptonGroup2.Margin = new System.Windows.Forms.Padding(4);
            // 
            // kryptonGroup2.Panel
            // 
            this.kryptonGroup2.Panel.Controls.Add(this.txtNombreVendedor);
            this.kryptonGroup2.Panel.Controls.Add(this.btnIDVendedor);
            this.kryptonGroup2.Panel.Controls.Add(this.kryptonLabel10);
            this.kryptonGroup2.Panel.Controls.Add(this.txtIDVendedor);
            this.kryptonGroup2.Panel.Controls.Add(this.kryptonLabel11);
            this.kryptonGroup2.Size = new System.Drawing.Size(536, 97);
            this.kryptonGroup2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(236)))));
            this.kryptonGroup2.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroup2.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup2.TabIndex = 48;
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.CueHint.CueHintText = "Nombre de vendedor";
            this.txtNombreVendedor.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtNombreVendedor.Location = new System.Drawing.Point(143, 42);
            this.txtNombreVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.ReadOnly = true;
            this.txtNombreVendedor.Size = new System.Drawing.Size(309, 31);
            this.txtNombreVendedor.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.txtNombreVendedor.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.txtNombreVendedor.StateCommon.Border.Rounding = 5F;
            this.txtNombreVendedor.TabIndex = 17;
            this.txtNombreVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIDVendedor
            // 
            this.btnIDVendedor.Location = new System.Drawing.Point(460, 7);
            this.btnIDVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnIDVendedor.Name = "btnIDVendedor";
            this.btnIDVendedor.Size = new System.Drawing.Size(29, 25);
            this.btnIDVendedor.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnIDVendedor.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnIDVendedor.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnIDVendedor.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnIDVendedor.StatePressed.Back.Color1 = System.Drawing.Color.Sienna;
            this.btnIDVendedor.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIDVendedor.TabIndex = 18;
            this.btnIDVendedor.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnIDVendedor.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnIDVendedor.Values.Image")));
            this.btnIDVendedor.Values.Text = "kryptonButton8";
            this.btnIDVendedor.Click += new System.EventHandler(this.btnIDVendedor_Click);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(4, 46);
            this.kryptonLabel10.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(120, 31);
            this.kryptonLabel10.TabIndex = 16;
            this.kryptonLabel10.Values.Text = "Nombre:";
            // 
            // txtIDVendedor
            // 
            this.txtIDVendedor.CueHint.CueHintText = "ID de vendedor";
            this.txtIDVendedor.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtIDVendedor.Location = new System.Drawing.Point(143, 7);
            this.txtIDVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDVendedor.Name = "txtIDVendedor";
            this.txtIDVendedor.ReadOnly = true;
            this.txtIDVendedor.Size = new System.Drawing.Size(309, 31);
            this.txtIDVendedor.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.txtIDVendedor.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.txtIDVendedor.StateCommon.Border.Rounding = 5F;
            this.txtIDVendedor.TabIndex = 1;
            this.txtIDVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(4, 7);
            this.kryptonLabel11.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(160, 31);
            this.kryptonLabel11.TabIndex = 0;
            this.kryptonLabel11.Values.Text = "ID de vendedor:";
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(468, 86);
            this.kryptonLabel12.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(160, 31);
            this.kryptonLabel12.TabIndex = 47;
            this.kryptonLabel12.Values.Text = "Datos del vendedor:";
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Location = new System.Drawing.Point(18, 124);
            this.kryptonGroup1.Margin = new System.Windows.Forms.Padding(4);
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.txtNombreCliente);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonGroup1.Panel.Controls.Add(this.btnDNICliente);
            this.kryptonGroup1.Panel.Controls.Add(this.txtDireccionCliente);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel8);
            this.kryptonGroup1.Panel.Controls.Add(this.txtDNICliente);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonLabel7);
            this.kryptonGroup1.Size = new System.Drawing.Size(458, 135);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(236)))));
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroup1.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup1.TabIndex = 46;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.CueHint.CueHintText = "( ! ) Nombre del cliente";
            this.txtNombreCliente.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtNombreCliente.Location = new System.Drawing.Point(83, 42);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(307, 31);
            this.txtNombreCliente.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.txtNombreCliente.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.txtNombreCliente.StateCommon.Border.Rounding = 5F;
            this.txtNombreCliente.TabIndex = 0;
            this.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(4, 42);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(120, 31);
            this.kryptonLabel6.TabIndex = 0;
            this.kryptonLabel6.Values.Text = "Cliente:";
            // 
            // btnDNICliente
            // 
            this.btnDNICliente.Location = new System.Drawing.Point(398, 7);
            this.btnDNICliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnDNICliente.Name = "btnDNICliente";
            this.btnDNICliente.Size = new System.Drawing.Size(29, 25);
            this.btnDNICliente.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnDNICliente.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnDNICliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.btnDNICliente.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnDNICliente.StatePressed.Back.Color1 = System.Drawing.Color.Sienna;
            this.btnDNICliente.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDNICliente.TabIndex = 18;
            this.btnDNICliente.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDNICliente.Values.Image = global::TRAMADE.Properties.Resources.Editar;
            this.btnDNICliente.Values.Text = "kryptonButton5";
            this.btnDNICliente.Click += new System.EventHandler(this.btnDNICliente_Click);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.CueHint.CueHintText = "( ! ) Dirección del cliente";
            this.txtDireccionCliente.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtDireccionCliente.Location = new System.Drawing.Point(83, 84);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(307, 31);
            this.txtDireccionCliente.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.txtDireccionCliente.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.txtDireccionCliente.StateCommon.Border.Rounding = 5F;
            this.txtDireccionCliente.TabIndex = 17;
            this.txtDireccionCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(4, 84);
            this.kryptonLabel8.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(120, 31);
            this.kryptonLabel8.TabIndex = 16;
            this.kryptonLabel8.Values.Text = "Dirección:";
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.CueHint.CueHintText = "DNI/RTN del cliente";
            this.txtDNICliente.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtDNICliente.Location = new System.Drawing.Point(83, 4);
            this.txtDNICliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(307, 31);
            this.txtDNICliente.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.txtDNICliente.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.txtDNICliente.StateCommon.Border.Rounding = 5F;
            this.txtDNICliente.TabIndex = 17;
            this.txtDNICliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDNICliente.TextChanged += new System.EventHandler(this.txtDNICliente_TextChanged);
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(4, 4);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(120, 31);
            this.kryptonLabel7.TabIndex = 16;
            this.kryptonLabel7.Values.Text = "DNI/RTN:";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(24, 85);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(139, 31);
            this.kryptonLabel5.TabIndex = 45;
            this.kryptonLabel5.Values.Text = "Datos del cliente:";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CalendarTodayDate = new System.DateTime(2026, 2, 21, 0, 0, 0, 0);
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(913, 45);
            this.dtpVencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(123, 29);
            this.dtpVencimiento.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(236)))));
            this.dtpVencimiento.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.dtpVencimiento.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.dtpVencimiento.StateCommon.Border.Rounding = 5F;
            this.dtpVencimiento.TabIndex = 44;
            // 
            // dtpEmision
            // 
            this.dtpEmision.CalendarTodayDate = new System.DateTime(2026, 2, 21, 0, 0, 0, 0);
            this.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmision.Location = new System.Drawing.Point(681, 45);
            this.dtpEmision.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(123, 29);
            this.dtpEmision.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(236)))));
            this.dtpEmision.StateCommon.Border.Color1 = System.Drawing.Color.DarkGray;
            this.dtpEmision.StateCommon.Border.Color2 = System.Drawing.Color.DarkGray;
            this.dtpEmision.StateCommon.Border.Rounding = 5F;
            this.dtpEmision.TabIndex = 43;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(873, 10);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(204, 31);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel4.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel4.TabIndex = 42;
            this.kryptonLabel4.Values.Text = "( ! ) Fecha de vencimiento:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(655, 10);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(172, 31);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel3.TabIndex = 41;
            this.kryptonLabel3.Values.Text = "( ! ) Fecha de emisión:";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.Location = new System.Drawing.Point(154, 10);
            this.lblNumeroFactura.Margin = new System.Windows.Forms.Padding(4);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(217, 36);
            this.lblNumeroFactura.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblNumeroFactura.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.lblNumeroFactura.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.TabIndex = 40;
            this.lblNumeroFactura.Values.Text = "INV/2026/0001";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(8, 10);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(155, 31);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonLabel1.TabIndex = 39;
            this.kryptonLabel1.Values.Text = "Número de factura:";
            // 
            // btnVerFacturas
            // 
            this.btnVerFacturas.Location = new System.Drawing.Point(895, 4);
            this.btnVerFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerFacturas.Name = "btnVerFacturas";
            this.btnVerFacturas.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnVerFacturas.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnVerFacturas.Size = new System.Drawing.Size(265, 42);
            this.btnVerFacturas.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnVerFacturas.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnVerFacturas.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnVerFacturas.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnVerFacturas.StateCommon.Border.Rounding = 10F;
            this.btnVerFacturas.StateCommon.Border.Width = 2;
            this.btnVerFacturas.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnVerFacturas.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnVerFacturas.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerFacturas.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnVerFacturas.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnVerFacturas.StatePressed.Back.Color1 = System.Drawing.Color.Sienna;
            this.btnVerFacturas.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVerFacturas.TabIndex = 7;
            this.btnVerFacturas.TabStop = false;
            this.btnVerFacturas.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnVerFacturas.Values.Text = "Ver facturas emitidas";
            this.btnVerFacturas.Values.UACShieldIconSize = Krypton.Toolkit.IconSize.Medium;
            this.btnVerFacturas.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonGroup3
            // 
            this.kryptonGroup3.Location = new System.Drawing.Point(16, 54);
            this.kryptonGroup3.Margin = new System.Windows.Forms.Padding(4);
            // 
            // kryptonGroup3.Panel
            // 
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonGroupBox1);
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonGroup5);
            this.kryptonGroup3.Panel.Controls.Add(this.rbCredito);
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonGroup2);
            this.kryptonGroup3.Panel.Controls.Add(this.rbContado);
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonLabel13);
            this.kryptonGroup3.Panel.Controls.Add(this.btnEmitirFactura);
            this.kryptonGroup3.Panel.Controls.Add(this.btnNuevo);
            this.kryptonGroup3.Panel.Controls.Add(this.btnLimpiar);
            this.kryptonGroup3.Panel.Controls.Add(this.btnVistaPrevia);
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroup3.Panel.Controls.Add(this.lblNumeroFactura);
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonLabel9);
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroup3.Panel.Controls.Add(this.dtpEmision);
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroup3.Panel.Controls.Add(this.dtpVencimiento);
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonLabel12);
            this.kryptonGroup3.Panel.Controls.Add(this.kryptonGroup1);
            this.kryptonGroup3.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroup3_Panel_Paint);
            this.kryptonGroup3.Size = new System.Drawing.Size(1148, 706);
            this.kryptonGroup3.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup3.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroup3.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup3.TabIndex = 66;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionVisible = false;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(816, 501);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblImpuesto);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblTotal);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel15);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblSubtotal);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel16);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel14);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(245, 125);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(236)))));
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 5F;
            this.kryptonGroupBox1.TabIndex = 66;
            // 
            // kryptonGroup5
            // 
            this.kryptonGroup5.Location = new System.Drawing.Point(18, 267);
            this.kryptonGroup5.Margin = new System.Windows.Forms.Padding(4);
            // 
            // kryptonGroup5.Panel
            // 
            this.kryptonGroup5.Panel.Controls.Add(this.dgvDetalleFactura);
            this.kryptonGroup5.Panel.Controls.Add(this.btnEliminarProducto);
            this.kryptonGroup5.Panel.Controls.Add(this.btnAggProducto);
            this.kryptonGroup5.Size = new System.Drawing.Size(1043, 224);
            this.kryptonGroup5.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroup5.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroup5.StateCommon.Border.Rounding = 20F;
            this.kryptonGroup5.StateCommon.Border.Width = 1;
            this.kryptonGroup5.TabIndex = 0;
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 773);
            this.ControlBox = false;
            this.Controls.Add(this.btnVerFacturas);
            this.Controls.Add(this.kryptonGroup3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2.Panel)).EndInit();
            this.kryptonGroup2.Panel.ResumeLayout(false);
            this.kryptonGroup2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup2)).EndInit();
            this.kryptonGroup2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3.Panel)).EndInit();
            this.kryptonGroup3.Panel.ResumeLayout(false);
            this.kryptonGroup3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup3)).EndInit();
            this.kryptonGroup3.ResumeLayout(false);
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

        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnNuevo;
        private Krypton.Toolkit.KryptonButton btnEmitirFactura;
        private Krypton.Toolkit.KryptonButton btnVistaPrevia;
        private Krypton.Toolkit.KryptonButton btnLimpiar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private Krypton.Toolkit.KryptonLabel lblTotal;
        private Krypton.Toolkit.KryptonLabel lblImpuesto;
        private Krypton.Toolkit.KryptonLabel lblSubtotal;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Krypton.Toolkit.KryptonRadioButton rbCredito;
        private Krypton.Toolkit.KryptonRadioButton rbContado;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonButton btnEliminarProducto;
        private Krypton.Toolkit.KryptonButton btnAggProducto;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonGroup kryptonGroup2;
        private Krypton.Toolkit.KryptonButton btnIDVendedor;
        private Krypton.Toolkit.KryptonTextBox txtNombreVendedor;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonTextBox txtIDVendedor;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private Krypton.Toolkit.KryptonButton btnDNICliente;
        private Krypton.Toolkit.KryptonTextBox txtDireccionCliente;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonTextBox txtDNICliente;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonTextBox txtNombreCliente;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonDateTimePicker dtpVencimiento;
        private Krypton.Toolkit.KryptonDateTimePicker dtpEmision;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblNumeroFactura;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnVerFacturas;
        private Krypton.Toolkit.KryptonGroup kryptonGroup3;
        private Krypton.Toolkit.KryptonGroup kryptonGroup5;
        public Krypton.Toolkit.KryptonDataGridView dgvDetalleFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
    }
}