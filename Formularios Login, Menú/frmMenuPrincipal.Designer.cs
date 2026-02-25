namespace TRAMADE
{
    partial class frmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new Krypton.Toolkit.KryptonButton();
            this.btnMaximizar = new Krypton.Toolkit.KryptonButton();
            this.btnMinimizar = new Krypton.Toolkit.KryptonButton();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.lblBienvenidoUsuario = new System.Windows.Forms.Label();
            this.flpBarraLateral = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnInventario = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCompras = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.tmrTransicionLateral = new System.Windows.Forms.Timer(this.components);
            this.pnlVistaGeneral = new Krypton.Toolkit.KryptonPanel();
            this.btnProductosAgot = new Krypton.Toolkit.KryptonButton();
            this.btnComprasRealizadas = new Krypton.Toolkit.KryptonButton();
            this.btnVentasRealizadas = new Krypton.Toolkit.KryptonButton();
            this.btnTotalProductos = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.flpBarraLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlVistaGeneral)).BeginInit();
            this.pnlVistaGeneral.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnMaximizar);
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.lblBienvenidoUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1107, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(37, 38);
            this.btnSalir.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnSalir.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnSalir.StatePressed.Back.Color1 = System.Drawing.Color.Red;
            this.btnSalir.StatePressed.Back.Color2 = System.Drawing.Color.Red;
            this.btnSalir.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnSalir.StateTracking.Back.Color2 = System.Drawing.Color.Red;
            this.btnSalir.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSalir.Values.Image = global::TRAMADE.Properties.Resources.Cerrar;
            this.btnSalir.Values.Text = "";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Location = new System.Drawing.Point(1049, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(37, 38);
            this.btnMaximizar.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            this.btnMaximizar.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnMaximizar.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnMaximizar.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnMaximizar.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnMaximizar.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnMaximizar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMaximizar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMaximizar.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertPressed;
            this.btnMaximizar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMaximizar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMaximizar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnMaximizar.TabIndex = 8;
            this.btnMaximizar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnMaximizar.Values.Image = global::TRAMADE.Properties.Resources.Maximizar;
            this.btnMaximizar.Values.Text = "";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Location = new System.Drawing.Point(992, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(37, 38);
            this.btnMinimizar.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            this.btnMinimizar.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnMinimizar.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btnMinimizar.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnMinimizar.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnMinimizar.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnMinimizar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimizar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimizar.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertPressed;
            this.btnMinimizar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimizar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimizar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnMinimizar.Values.Image = global::TRAMADE.Properties.Resources.Minimizar;
            this.btnMinimizar.Values.Text = "";
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(19, 14);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(55, 36);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 6;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblBienvenidoUsuario
            // 
            this.lblBienvenidoUsuario.AutoSize = true;
            this.lblBienvenidoUsuario.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoUsuario.Location = new System.Drawing.Point(91, 18);
            this.lblBienvenidoUsuario.Name = "lblBienvenidoUsuario";
            this.lblBienvenidoUsuario.Size = new System.Drawing.Size(273, 29);
            this.lblBienvenidoUsuario.TabIndex = 5;
            this.lblBienvenidoUsuario.Text = "Bienvenido, [Usuario]";
            // 
            // flpBarraLateral
            // 
            this.flpBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.flpBarraLateral.Controls.Add(this.pictureBox1);
            this.flpBarraLateral.Controls.Add(this.panel2);
            this.flpBarraLateral.Controls.Add(this.panel3);
            this.flpBarraLateral.Controls.Add(this.panel4);
            this.flpBarraLateral.Controls.Add(this.panel5);
            this.flpBarraLateral.Controls.Add(this.panel6);
            this.flpBarraLateral.Controls.Add(this.panel7);
            this.flpBarraLateral.Controls.Add(this.panel8);
            this.flpBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpBarraLateral.Location = new System.Drawing.Point(0, 65);
            this.flpBarraLateral.Name = "flpBarraLateral";
            this.flpBarraLateral.Size = new System.Drawing.Size(245, 689);
            this.flpBarraLateral.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(45, 0, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInicio);
            this.panel2.Location = new System.Drawing.Point(3, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 60);
            this.panel2.TabIndex = 3;
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Image = global::TRAMADE.Properties.Resources.Home;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(-3, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(245, 60);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClientes);
            this.panel3.Location = new System.Drawing.Point(3, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 60);
            this.panel3.TabIndex = 5;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClientes.Image = global::TRAMADE.Properties.Resources.Clientes1;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(-3, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(245, 60);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnVentas);
            this.panel4.Location = new System.Drawing.Point(3, 282);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 60);
            this.panel4.TabIndex = 7;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVentas.Image = global::TRAMADE.Properties.Resources.Ventas;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(-3, 0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(245, 60);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnInventario);
            this.panel5.Location = new System.Drawing.Point(3, 348);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(245, 60);
            this.panel5.TabIndex = 9;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInventario.Image = global::TRAMADE.Properties.Resources.Inventario;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(-3, -1);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(245, 60);
            this.btnInventario.TabIndex = 8;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCompras);
            this.panel6.Location = new System.Drawing.Point(3, 414);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(245, 60);
            this.panel6.TabIndex = 11;
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCompras.Image = global::TRAMADE.Properties.Resources.Compras;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(-3, -6);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnCompras.Size = new System.Drawing.Size(245, 60);
            this.btnCompras.TabIndex = 10;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnProveedores);
            this.panel7.Location = new System.Drawing.Point(3, 480);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(242, 60);
            this.panel7.TabIndex = 13;
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.SystemColors.Window;
            this.btnProveedores.Image = global::TRAMADE.Properties.Resources.Proveedores;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(-3, -6);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnProveedores.Size = new System.Drawing.Size(266, 60);
            this.btnProveedores.TabIndex = 12;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button6);
            this.panel8.Location = new System.Drawing.Point(3, 546);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(245, 60);
            this.panel8.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Window;
            this.button6.Image = global::TRAMADE.Properties.Resources.Reportes;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(-3, -6);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(245, 60);
            this.button6.TabIndex = 14;
            this.button6.Text = "Reportes";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // tmrTransicionLateral
            // 
            this.tmrTransicionLateral.Enabled = true;
            this.tmrTransicionLateral.Interval = 2;
            this.tmrTransicionLateral.Tick += new System.EventHandler(this.tmrTransicionLateral_Tick);
            // 
            // pnlVistaGeneral
            // 
            this.pnlVistaGeneral.Controls.Add(this.btnProductosAgot);
            this.pnlVistaGeneral.Controls.Add(this.btnComprasRealizadas);
            this.pnlVistaGeneral.Controls.Add(this.btnVentasRealizadas);
            this.pnlVistaGeneral.Controls.Add(this.btnTotalProductos);
            this.pnlVistaGeneral.Controls.Add(this.label1);
            this.pnlVistaGeneral.Location = new System.Drawing.Point(279, 119);
            this.pnlVistaGeneral.Name = "pnlVistaGeneral";
            this.pnlVistaGeneral.Size = new System.Drawing.Size(850, 156);
            this.pnlVistaGeneral.StateCommon.Color1 = System.Drawing.Color.White;
            this.pnlVistaGeneral.StateCommon.Color2 = System.Drawing.Color.White;
            this.pnlVistaGeneral.StateNormal.Color1 = System.Drawing.Color.White;
            this.pnlVistaGeneral.StateNormal.Color2 = System.Drawing.Color.White;
            this.pnlVistaGeneral.TabIndex = 2;
            // 
            // btnProductosAgot
            // 
            this.btnProductosAgot.Location = new System.Drawing.Point(643, 45);
            this.btnProductosAgot.Name = "btnProductosAgot";
            this.btnProductosAgot.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnProductosAgot.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnProductosAgot.OverrideDefault.Back.Image = global::TRAMADE.Properties.Resources.totalproductos;
            this.btnProductosAgot.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnProductosAgot.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnProductosAgot.OverrideDefault.Border.Rounding = 10F;
            this.btnProductosAgot.Size = new System.Drawing.Size(174, 91);
            this.btnProductosAgot.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnProductosAgot.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnProductosAgot.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnProductosAgot.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnProductosAgot.StateCommon.Border.Rounding = 10F;
            this.btnProductosAgot.StateCommon.Border.Width = 2;
            this.btnProductosAgot.StateCommon.Content.ShortText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosAgot.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnProductosAgot.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnProductosAgot.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnProductosAgot.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnProductosAgot.StateNormal.Border.Rounding = 10F;
            this.btnProductosAgot.StateNormal.Border.Width = 2;
            this.btnProductosAgot.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnProductosAgot.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnProductosAgot.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnProductosAgot.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnProductosAgot.TabIndex = 4;
            this.btnProductosAgot.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnProductosAgot.Values.Image = global::TRAMADE.Properties.Resources.Productosagotados;
            this.btnProductosAgot.Values.Text = "Productos\r\nagotados";
            // 
            // btnComprasRealizadas
            // 
            this.btnComprasRealizadas.Location = new System.Drawing.Point(436, 45);
            this.btnComprasRealizadas.Name = "btnComprasRealizadas";
            this.btnComprasRealizadas.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnComprasRealizadas.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnComprasRealizadas.OverrideDefault.Back.Image = global::TRAMADE.Properties.Resources.totalproductos;
            this.btnComprasRealizadas.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnComprasRealizadas.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnComprasRealizadas.OverrideDefault.Border.Rounding = 10F;
            this.btnComprasRealizadas.Size = new System.Drawing.Size(174, 91);
            this.btnComprasRealizadas.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnComprasRealizadas.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnComprasRealizadas.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnComprasRealizadas.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnComprasRealizadas.StateCommon.Border.Rounding = 10F;
            this.btnComprasRealizadas.StateCommon.Border.Width = 2;
            this.btnComprasRealizadas.StateCommon.Content.ShortText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprasRealizadas.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnComprasRealizadas.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnComprasRealizadas.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnComprasRealizadas.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnComprasRealizadas.StateNormal.Border.Rounding = 10F;
            this.btnComprasRealizadas.StateNormal.Border.Width = 2;
            this.btnComprasRealizadas.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnComprasRealizadas.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnComprasRealizadas.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnComprasRealizadas.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnComprasRealizadas.TabIndex = 3;
            this.btnComprasRealizadas.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnComprasRealizadas.Values.Image = global::TRAMADE.Properties.Resources.comprasrealizadas;
            this.btnComprasRealizadas.Values.Text = "Compras\r\nrealizadas";
            this.btnComprasRealizadas.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // btnVentasRealizadas
            // 
            this.btnVentasRealizadas.Location = new System.Drawing.Point(229, 45);
            this.btnVentasRealizadas.Name = "btnVentasRealizadas";
            this.btnVentasRealizadas.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnVentasRealizadas.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnVentasRealizadas.OverrideDefault.Back.Image = global::TRAMADE.Properties.Resources.totalproductos;
            this.btnVentasRealizadas.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnVentasRealizadas.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnVentasRealizadas.OverrideDefault.Border.Rounding = 10F;
            this.btnVentasRealizadas.Size = new System.Drawing.Size(174, 91);
            this.btnVentasRealizadas.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnVentasRealizadas.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnVentasRealizadas.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnVentasRealizadas.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnVentasRealizadas.StateCommon.Border.Rounding = 10F;
            this.btnVentasRealizadas.StateCommon.Border.Width = 2;
            this.btnVentasRealizadas.StateCommon.Content.ShortText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasRealizadas.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnVentasRealizadas.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnVentasRealizadas.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnVentasRealizadas.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnVentasRealizadas.StateNormal.Border.Rounding = 10F;
            this.btnVentasRealizadas.StateNormal.Border.Width = 2;
            this.btnVentasRealizadas.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnVentasRealizadas.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnVentasRealizadas.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnVentasRealizadas.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnVentasRealizadas.TabIndex = 2;
            this.btnVentasRealizadas.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnVentasRealizadas.Values.Image = global::TRAMADE.Properties.Resources.ventasrealizadas;
            this.btnVentasRealizadas.Values.Text = "Ventas \r\nrealizadas";
            // 
            // btnTotalProductos
            // 
            this.btnTotalProductos.Location = new System.Drawing.Point(22, 45);
            this.btnTotalProductos.Name = "btnTotalProductos";
            this.btnTotalProductos.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnTotalProductos.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btnTotalProductos.OverrideDefault.Back.Image = global::TRAMADE.Properties.Resources.totalproductos;
            this.btnTotalProductos.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnTotalProductos.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnTotalProductos.OverrideDefault.Border.Rounding = 10F;
            this.btnTotalProductos.Size = new System.Drawing.Size(174, 91);
            this.btnTotalProductos.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnTotalProductos.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnTotalProductos.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnTotalProductos.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnTotalProductos.StateCommon.Border.Rounding = 10F;
            this.btnTotalProductos.StateCommon.Border.Width = 2;
            this.btnTotalProductos.StateCommon.Content.ShortText.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalProductos.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnTotalProductos.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btnTotalProductos.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnTotalProductos.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnTotalProductos.StateNormal.Border.Rounding = 10F;
            this.btnTotalProductos.StateNormal.Border.Width = 2;
            this.btnTotalProductos.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnTotalProductos.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnTotalProductos.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnTotalProductos.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(242)))));
            this.btnTotalProductos.TabIndex = 1;
            this.btnTotalProductos.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnTotalProductos.Values.Image = global::TRAMADE.Properties.Resources.totalproductos;
            this.btnTotalProductos.Values.Text = " Total de     \r\nproductos   ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vista General";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.label2);
            this.panel9.Controls.Add(this.pictureBox2);
            this.panel9.Location = new System.Drawing.Point(279, 300);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(226, 173);
            this.panel9.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TRAMADE.Properties.Resources.vistaClientes2;
            this.pictureBox2.Location = new System.Drawing.Point(79, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(45, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clientes";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1171, 754);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.pnlVistaGeneral);
            this.Controls.Add(this.flpBarraLateral);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.flpBarraLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlVistaGeneral)).EndInit();
            this.pnlVistaGeneral.ResumeLayout(false);
            this.pnlVistaGeneral.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBienvenidoUsuario;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.FlowLayoutPanel flpBarraLateral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel8;
        private Krypton.Toolkit.KryptonButton btnSalir;
        private Krypton.Toolkit.KryptonButton btnMaximizar;
        private Krypton.Toolkit.KryptonButton btnMinimizar;
        private System.Windows.Forms.Timer tmrTransicionLateral;
        private Krypton.Toolkit.KryptonPanel pnlVistaGeneral;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonButton btnTotalProductos;
        private Krypton.Toolkit.KryptonButton btnProductosAgot;
        private Krypton.Toolkit.KryptonButton btnComprasRealizadas;
        private Krypton.Toolkit.KryptonButton btnVentasRealizadas;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}