namespace TRAMADE
{
    partial class frmActualizar
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
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new Krypton.Toolkit.KryptonButton();
            this.btnActualizar = new Krypton.Toolkit.KryptonButton();
            this.txtbBuscar = new Krypton.Toolkit.KryptonTextBox();
            this.dtEntrega = new Krypton.Toolkit.KryptonDateTimePicker();
            this.cmbFormaPago = new Krypton.Toolkit.KryptonComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.nudCantidad = new Krypton.Toolkit.KryptonNumericUpDown();
            this.cmbProveedor = new Krypton.Toolkit.KryptonComboBox();
            this.cmbProducto = new Krypton.Toolkit.KryptonComboBox();
            this.txtTotal = new Krypton.Toolkit.KryptonTextBox();
            this.txtImpuesto = new Krypton.Toolkit.KryptonTextBox();
            this.txtSubtotal = new Krypton.Toolkit.KryptonTextBox();
            this.txtPrecio = new Krypton.Toolkit.KryptonTextBox();
            this.lstProductos = new Krypton.Toolkit.KryptonListBox();
            this.btnQuitar = new Krypton.Toolkit.KryptonButton();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAgregar = new Krypton.Toolkit.KryptonButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new Krypton.Toolkit.KryptonButton();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificarCantidad = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormaPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "ACTUALIZAR SOLICITUD DE COMPRA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(512, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 22);
            this.label9.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 22);
            this.label3.TabIndex = 71;
            this.label3.Text = "Número de compra";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(508, 475);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.OverrideDefault.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.OverrideDefault.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.OverrideFocus.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.btnLimpiar.Size = new System.Drawing.Size(107, 30);
            this.btnLimpiar.StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.StateCommon.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.StateCommon.Border.Rounding = 10F;
            this.btnLimpiar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnLimpiar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnLimpiar.StateTracking.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btnLimpiar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnLimpiar.TabIndex = 72;
            this.btnLimpiar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Values.Text = "LIMPIAR";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(621, 475);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnActualizar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnActualizar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnActualizar.OverrideFocus.Back.Color2 = System.Drawing.Color.Blue;
            this.btnActualizar.OverrideFocus.Border.Rounding = 10F;
            this.btnActualizar.Size = new System.Drawing.Size(208, 30);
            this.btnActualizar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnActualizar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnActualizar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnActualizar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnActualizar.StateCommon.Border.Rounding = 10F;
            this.btnActualizar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnActualizar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnActualizar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnActualizar.StateTracking.Back.Color2 = System.Drawing.Color.Blue;
            this.btnActualizar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnActualizar.StateTracking.Border.Rounding = 10F;
            this.btnActualizar.TabIndex = 71;
            this.btnActualizar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnActualizar.Values.Text = "ACTUALIZAR Y ENVIAR";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtbBuscar
            // 
            this.txtbBuscar.Location = new System.Drawing.Point(216, 79);
            this.txtbBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbBuscar.Name = "txtbBuscar";
            this.txtbBuscar.Size = new System.Drawing.Size(189, 27);
            this.txtbBuscar.TabIndex = 100;
            // 
            // dtEntrega
            // 
            this.dtEntrega.Location = new System.Drawing.Point(528, 129);
            this.dtEntrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtEntrega.Name = "dtEntrega";
            this.dtEntrega.Size = new System.Drawing.Size(297, 25);
            this.dtEntrega.TabIndex = 144;
            this.dtEntrega.ValueChanged += new System.EventHandler(this.dtEntrega_ValueChanged);
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.DropDownWidth = 186;
            this.cmbFormaPago.Location = new System.Drawing.Point(249, 214);
            this.cmbFormaPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(189, 26);
            this.cmbFormaPago.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbFormaPago.TabIndex = 143;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(19, 214);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 22);
            this.label17.TabIndex = 142;
            this.label17.Text = "Forma de pago";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Location = new System.Drawing.Point(180, 342);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudCantidad.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(93, 26);
            this.nudCantidad.TabIndex = 141;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownWidth = 186;
            this.cmbProveedor.Location = new System.Drawing.Point(164, 124);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(189, 26);
            this.cmbProveedor.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbProveedor.TabIndex = 140;
            this.cmbProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbProveedor_SelectedIndexChanged);
            this.cmbProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProveedor_KeyDown);
            this.cmbProveedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbProveedor_KeyUp);
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownWidth = 186;
            this.cmbProducto.Location = new System.Drawing.Point(249, 173);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(189, 26);
            this.cmbProducto.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbProducto.TabIndex = 139;
            this.cmbProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProducto_KeyDown);
            this.cmbProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbProducto_KeyUp);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(410, 398);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(93, 27);
            this.txtTotal.TabIndex = 138;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(410, 342);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(93, 27);
            this.txtImpuesto.TabIndex = 137;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(410, 282);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(93, 27);
            this.txtSubtotal.TabIndex = 136;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(180, 282);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(93, 27);
            this.txtPrecio.TabIndex = 135;
            // 
            // lstProductos
            // 
            this.lstProductos.Location = new System.Drawing.Point(513, 207);
            this.lstProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(316, 248);
            this.lstProductos.StateCommon.Border.Rounding = 10F;
            this.lstProductos.TabIndex = 132;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(722, 173);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.OverrideDefault.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnQuitar.OverrideDefault.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnQuitar.OverrideFocus.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnQuitar.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnQuitar.Size = new System.Drawing.Size(107, 30);
            this.btnQuitar.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnQuitar.StateCommon.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnQuitar.StateCommon.Border.Rounding = 10F;
            this.btnQuitar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnQuitar.StateTracking.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnQuitar.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnQuitar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnQuitar.TabIndex = 131;
            this.btnQuitar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnQuitar.Values.Text = "QUITAR";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(192, 22);
            this.label16.TabIndex = 130;
            this.label16.Text = "Seleccione el producto";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(513, 173);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OverrideDefault.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.OverrideDefault.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.OverrideFocus.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnAgregar.Size = new System.Drawing.Size(191, 30);
            this.btnAgregar.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.StateCommon.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.StateCommon.Border.Rounding = 10F;
            this.btnAgregar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnAgregar.StateTracking.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnAgregar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnAgregar.TabIndex = 129;
            this.btnAgregar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAgregar.Values.Text = "AGREGAR PRODUCTO";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(322, 398);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 22);
            this.label15.TabIndex = 128;
            this.label15.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(322, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 22);
            this.label13.TabIndex = 127;
            this.label13.Text = "Subtotal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(316, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 22);
            this.label12.TabIndex = 126;
            this.label12.Text = "Impuesto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 22);
            this.label11.TabIndex = 125;
            this.label11.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 22);
            this.label10.TabIndex = 124;
            this.label10.Text = "Precio costo";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 122;
            this.label6.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 22);
            this.label5.TabIndex = 119;
            this.label5.Text = "Fecha de entrega";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(420, 82);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnBuscar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnBuscar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnBuscar.OverrideFocus.Back.Color2 = System.Drawing.Color.Blue;
            this.btnBuscar.OverrideFocus.Border.Rounding = 10F;
            this.btnBuscar.Size = new System.Drawing.Size(93, 28);
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
            this.btnBuscar.TabIndex = 74;
            this.btnBuscar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBuscar.Values.Text = "BUSCAR";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionVisible = false;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(23, 24);
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnModificarCantidad);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnLimpiar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnBuscar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label9);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnActualizar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtbBuscar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtEntrega);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cmbFormaPago);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label17);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label6);
            this.kryptonGroupBox1.Panel.Controls.Add(this.nudCantidad);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label10);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cmbProveedor);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label11);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cmbProducto);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label12);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtTotal);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label13);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtImpuesto);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label15);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtSubtotal);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnAgregar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtPrecio);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label16);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lstProductos);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnQuitar);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(878, 556);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 10F;
            this.kryptonGroupBox1.TabIndex = 145;
            this.kryptonGroupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroupBox1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(-41, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(952, 32);
            this.label4.TabIndex = 145;
            this.label4.Text = "_________________________________________________________________________________" +
    "______________________________________________________\r\n\r\n";
            // 
            // btnModificarCantidad
            // 
            this.btnModificarCantidad.Location = new System.Drawing.Point(23, 390);
            this.btnModificarCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarCantidad.Name = "btnModificarCantidad";
            this.btnModificarCantidad.OverrideDefault.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarCantidad.OverrideDefault.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarCantidad.OverrideFocus.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarCantidad.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.btnModificarCantidad.Size = new System.Drawing.Size(250, 30);
            this.btnModificarCantidad.StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarCantidad.StateCommon.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarCantidad.StateCommon.Border.Rounding = 10F;
            this.btnModificarCantidad.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnModificarCantidad.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnModificarCantidad.StateTracking.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarCantidad.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btnModificarCantidad.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnModificarCantidad.TabIndex = 146;
            this.btnModificarCantidad.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnModificarCantidad.Values.Text = "MODIFICAR CANTIDAD";
            this.btnModificarCantidad.Click += new System.EventHandler(this.btnModificarCantidad_Click);
            // 
            // frmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(927, 604);
            this.Controls.Add(this.kryptonGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmActualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActualizar";
            this.Load += new System.EventHandler(this.frmActualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormaPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonButton btnLimpiar;
        private Krypton.Toolkit.KryptonButton btnActualizar;
        private Krypton.Toolkit.KryptonTextBox txtbBuscar;
        private Krypton.Toolkit.KryptonDateTimePicker dtEntrega;
        private Krypton.Toolkit.KryptonComboBox cmbFormaPago;
        private System.Windows.Forms.Label label17;
        private Krypton.Toolkit.KryptonNumericUpDown nudCantidad;
        private Krypton.Toolkit.KryptonComboBox cmbProveedor;
        private Krypton.Toolkit.KryptonComboBox cmbProducto;
        private Krypton.Toolkit.KryptonTextBox txtTotal;
        private Krypton.Toolkit.KryptonTextBox txtImpuesto;
        private Krypton.Toolkit.KryptonTextBox txtSubtotal;
        private Krypton.Toolkit.KryptonTextBox txtPrecio;
        private Krypton.Toolkit.KryptonListBox lstProductos;
        private Krypton.Toolkit.KryptonButton btnQuitar;
        private System.Windows.Forms.Label label16;
        private Krypton.Toolkit.KryptonButton btnAgregar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Krypton.Toolkit.KryptonButton btnBuscar;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.Label label4;
        private Krypton.Toolkit.KryptonButton btnModificarCantidad;
    }
}