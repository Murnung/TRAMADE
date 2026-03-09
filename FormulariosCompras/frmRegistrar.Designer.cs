namespace TRAMADE
{
    partial class frmRegistrar
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
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new Krypton.Toolkit.KryptonButton();
            this.btnRegistrar = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAgregar = new Krypton.Toolkit.KryptonButton();
            this.label16 = new System.Windows.Forms.Label();
            this.btnQuitar = new Krypton.Toolkit.KryptonButton();
            this.lstProductos = new Krypton.Toolkit.KryptonListBox();
            this.txtPrecio = new Krypton.Toolkit.KryptonTextBox();
            this.txtSubtotal = new Krypton.Toolkit.KryptonTextBox();
            this.txtImpuesto = new Krypton.Toolkit.KryptonTextBox();
            this.txtTotal = new Krypton.Toolkit.KryptonTextBox();
            this.cmbProducto = new Krypton.Toolkit.KryptonComboBox();
            this.cmbProveedor = new Krypton.Toolkit.KryptonComboBox();
            this.nudCantidad = new Krypton.Toolkit.KryptonNumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbFormaPago = new Krypton.Toolkit.KryptonComboBox();
            this.dtEntrega = new Krypton.Toolkit.KryptonDateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormaPago)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(7, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 42);
            this.label14.TabIndex = 20;
            this.label14.Text = "TSMS";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 64);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(692, 22);
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
            this.btnRegresar.TabIndex = 71;
            this.btnRegresar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRegresar.Values.Text = "REGRESAR";
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_2);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Location = new System.Drawing.Point(-20, 556);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 56);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(524, 17);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.OverrideDefault.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.OverrideDefault.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.OverrideFocus.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.btnLimpiar.Size = new System.Drawing.Size(106, 29);
            this.btnLimpiar.StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.StateCommon.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.StateCommon.Border.Rounding = 10F;
            this.btnLimpiar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnLimpiar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnLimpiar.StateTracking.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btnLimpiar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnLimpiar.TabIndex = 70;
            this.btnLimpiar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnLimpiar.Values.Text = "LIMPIAR";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(638, 17);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRegistrar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRegistrar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRegistrar.OverrideFocus.Back.Color2 = System.Drawing.Color.Blue;
            this.btnRegistrar.OverrideFocus.Border.Rounding = 10F;
            this.btnRegistrar.Size = new System.Drawing.Size(175, 29);
            this.btnRegistrar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRegistrar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRegistrar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRegistrar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRegistrar.StateCommon.Border.Rounding = 10F;
            this.btnRegistrar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRegistrar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnRegistrar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRegistrar.StateTracking.Back.Color2 = System.Drawing.Color.Blue;
            this.btnRegistrar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnRegistrar.StateTracking.Border.Rounding = 10F;
            this.btnRegistrar.TabIndex = 69;
            this.btnRegistrar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Values.Text = "REGISTRAR Y ENVIAR";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "REGISTRO DE SOLICITUD DE COMPRAS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fecha de entrega";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 22);
            this.label9.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "Proveedor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 22);
            this.label10.TabIndex = 35;
            this.label10.Text = "Precio costo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 397);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 22);
            this.label11.TabIndex = 36;
            this.label11.Text = "Cantidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(290, 397);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 22);
            this.label12.TabIndex = 37;
            this.label12.Text = "Impuesto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(296, 339);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 22);
            this.label13.TabIndex = 38;
            this.label13.Text = "Subtotal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(302, 454);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 22);
            this.label15.TabIndex = 39;
            this.label15.Text = "Total";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(481, 230);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OverrideDefault.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.OverrideDefault.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.OverrideFocus.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnAgregar.Size = new System.Drawing.Size(191, 29);
            this.btnAgregar.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.StateCommon.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.StateCommon.Border.Rounding = 10F;
            this.btnAgregar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnAgregar.StateTracking.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnAgregar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnAgregar.TabIndex = 52;
            this.btnAgregar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAgregar.Values.Text = "AGREGAR PRODUCTO";
            this.btnAgregar.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(192, 22);
            this.label16.TabIndex = 54;
            this.label16.Text = "Seleccione el producto";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(680, 230);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.OverrideDefault.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnQuitar.OverrideDefault.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnQuitar.OverrideFocus.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnQuitar.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnQuitar.Size = new System.Drawing.Size(107, 29);
            this.btnQuitar.StateCommon.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnQuitar.StateCommon.Back.Color2 = System.Drawing.Color.LightSkyBlue;
            this.btnQuitar.StateCommon.Border.Rounding = 10F;
            this.btnQuitar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnQuitar.StateTracking.Back.Color1 = System.Drawing.Color.LightSkyBlue;
            this.btnQuitar.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btnQuitar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnQuitar.TabIndex = 68;
            this.btnQuitar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnQuitar.Values.Text = "QUITAR";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.Location = new System.Drawing.Point(481, 265);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(306, 245);
            this.lstProductos.StateCommon.Border.Rounding = 10F;
            this.lstProductos.TabIndex = 70;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(148, 338);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(93, 31);
            this.txtPrecio.StateCommon.Border.Rounding = 5F;
            this.txtPrecio.TabIndex = 76;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(378, 338);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(94, 31);
            this.txtSubtotal.StateCommon.Border.Rounding = 5F;
            this.txtSubtotal.TabIndex = 77;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(378, 397);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(94, 31);
            this.txtImpuesto.StateCommon.Border.Rounding = 5F;
            this.txtImpuesto.TabIndex = 78;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(378, 454);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(94, 31);
            this.txtTotal.StateCommon.Border.Rounding = 5F;
            this.txtTotal.TabIndex = 79;
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownWidth = 186;
            this.cmbProducto.Location = new System.Drawing.Point(217, 229);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(190, 30);
            this.cmbProducto.StateCommon.ComboBox.Border.Rounding = 5F;
            this.cmbProducto.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbProducto.TabIndex = 81;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            this.cmbProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbProducto_KeyUp);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownWidth = 186;
            this.cmbProveedor.Location = new System.Drawing.Point(109, 164);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(190, 30);
            this.cmbProveedor.StateCommon.ComboBox.Border.Rounding = 5F;
            this.cmbProveedor.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbProveedor.TabIndex = 82;
            this.cmbProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbProveedor_SelectedIndexChanged);
            this.cmbProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProveedor_KeyDown);
            this.cmbProveedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbProveedor_KeyUp);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Location = new System.Drawing.Point(148, 397);
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
            this.nudCantidad.Size = new System.Drawing.Size(93, 30);
            this.nudCantidad.StateCommon.Border.Rounding = 5F;
            this.nudCantidad.TabIndex = 112;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 22);
            this.label17.TabIndex = 113;
            this.label17.Text = "Forma de pago";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.DropDownWidth = 186;
            this.cmbFormaPago.Location = new System.Drawing.Point(217, 269);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(190, 30);
            this.cmbFormaPago.StateCommon.ComboBox.Border.Rounding = 5F;
            this.cmbFormaPago.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cmbFormaPago.TabIndex = 114;
            this.cmbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cmbFormaPago_SelectedIndexChanged);
            // 
            // dtEntrega
            // 
            this.dtEntrega.Location = new System.Drawing.Point(481, 165);
            this.dtEntrega.Name = "dtEntrega";
            this.dtEntrega.Size = new System.Drawing.Size(306, 29);
            this.dtEntrega.StateCommon.Border.Rounding = 5F;
            this.dtEntrega.TabIndex = 116;
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(816, 608);
            this.Controls.Add(this.dtEntrega);
            this.Controls.Add(this.cmbFormaPago);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistrar";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFormaPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private Krypton.Toolkit.KryptonButton btnAgregar;
        private System.Windows.Forms.Label label16;
        private Krypton.Toolkit.KryptonButton btnQuitar;
        private Krypton.Toolkit.KryptonButton btnRegistrar;
        private Krypton.Toolkit.KryptonButton btnLimpiar;
        private Krypton.Toolkit.KryptonListBox lstProductos;
        private Krypton.Toolkit.KryptonButton btnRegresar;
        private Krypton.Toolkit.KryptonTextBox txtPrecio;
        private Krypton.Toolkit.KryptonTextBox txtSubtotal;
        private Krypton.Toolkit.KryptonTextBox txtImpuesto;
        private Krypton.Toolkit.KryptonTextBox txtTotal;
        private Krypton.Toolkit.KryptonComboBox cmbProducto;
        private Krypton.Toolkit.KryptonComboBox cmbProveedor;
        private Krypton.Toolkit.KryptonNumericUpDown nudCantidad;
        private System.Windows.Forms.Label label17;
        private Krypton.Toolkit.KryptonComboBox cmbFormaPago;
        private Krypton.Toolkit.KryptonDateTimePicker dtEntrega;
    }
}