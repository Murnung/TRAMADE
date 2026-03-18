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
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnlVentas = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.pnlInventario = new System.Windows.Forms.Panel();
            this.btnInventario = new System.Windows.Forms.Button();
            this.pnlCompras = new System.Windows.Forms.Panel();
            this.btnCompras = new System.Windows.Forms.Button();
            this.pnlProveedores = new System.Windows.Forms.Panel();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.tmrTransicionLateral = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.flpBarraLateral.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            this.pnlVentas.SuspendLayout();
            this.pnlInventario.SuspendLayout();
            this.pnlCompras.SuspendLayout();
            this.pnlProveedores.SuspendLayout();
            this.pnlReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
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
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
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
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.lblBienvenidoUsuario.Size = new System.Drawing.Size(350, 38);
            this.lblBienvenidoUsuario.TabIndex = 5;
            this.lblBienvenidoUsuario.Text = "Bienvenido, [Usuario]";
            // 
            // flpBarraLateral
            // 
            this.flpBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.flpBarraLateral.Controls.Add(this.pnlDashboard);
            this.flpBarraLateral.Controls.Add(this.pnlClientes);
            this.flpBarraLateral.Controls.Add(this.pnlVentas);
            this.flpBarraLateral.Controls.Add(this.pnlInventario);
            this.flpBarraLateral.Controls.Add(this.pnlCompras);
            this.flpBarraLateral.Controls.Add(this.pnlProveedores);
            this.flpBarraLateral.Controls.Add(this.pnlReportes);
            this.flpBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpBarraLateral.Location = new System.Drawing.Point(0, 65);
            this.flpBarraLateral.Name = "flpBarraLateral";
            this.flpBarraLateral.Size = new System.Drawing.Size(245, 716);
            this.flpBarraLateral.TabIndex = 1;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.btnInicio);
            this.pnlDashboard.Location = new System.Drawing.Point(3, 3);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(245, 54);
            this.pnlDashboard.TabIndex = 3;
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Image = global::TRAMADE.Properties.Resources.Home;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(-3, -3);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(248, 63);
            this.btnInicio.TabIndex = 2;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlClientes
            // 
            this.pnlClientes.Controls.Add(this.btnClientes);
            this.pnlClientes.Location = new System.Drawing.Point(3, 63);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(245, 60);
            this.pnlClientes.TabIndex = 5;
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
            // pnlVentas
            // 
            this.pnlVentas.Controls.Add(this.btnVentas);
            this.pnlVentas.Location = new System.Drawing.Point(3, 129);
            this.pnlVentas.Name = "pnlVentas";
            this.pnlVentas.Size = new System.Drawing.Size(245, 60);
            this.pnlVentas.TabIndex = 7;
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
            // pnlInventario
            // 
            this.pnlInventario.Controls.Add(this.btnInventario);
            this.pnlInventario.Location = new System.Drawing.Point(3, 195);
            this.pnlInventario.Name = "pnlInventario";
            this.pnlInventario.Size = new System.Drawing.Size(245, 60);
            this.pnlInventario.TabIndex = 9;
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
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // pnlCompras
            // 
            this.pnlCompras.Controls.Add(this.btnCompras);
            this.pnlCompras.Location = new System.Drawing.Point(3, 261);
            this.pnlCompras.Name = "pnlCompras";
            this.pnlCompras.Size = new System.Drawing.Size(245, 60);
            this.pnlCompras.TabIndex = 11;
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
            // pnlProveedores
            // 
            this.pnlProveedores.Controls.Add(this.btnProveedores);
            this.pnlProveedores.Location = new System.Drawing.Point(3, 327);
            this.pnlProveedores.Name = "pnlProveedores";
            this.pnlProveedores.Size = new System.Drawing.Size(242, 60);
            this.pnlProveedores.TabIndex = 13;
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
            // pnlReportes
            // 
            this.pnlReportes.Controls.Add(this.button6);
            this.pnlReportes.Location = new System.Drawing.Point(3, 393);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(245, 60);
            this.pnlReportes.TabIndex = 15;
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
            // frmMenuPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1171, 781);
            this.ControlBox = false;
            this.Controls.Add(this.flpBarraLateral);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.SizeChanged += new System.EventHandler(this.frmMenuPrincipal_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.flpBarraLateral.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlClientes.ResumeLayout(false);
            this.pnlVentas.ResumeLayout(false);
            this.pnlInventario.ResumeLayout(false);
            this.pnlCompras.ResumeLayout(false);
            this.pnlProveedores.ResumeLayout(false);
            this.pnlReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBienvenidoUsuario;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.FlowLayoutPanel flpBarraLateral;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel pnlVentas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel pnlInventario;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Panel pnlCompras;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Panel pnlProveedores;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel pnlReportes;
        private Krypton.Toolkit.KryptonButton btnSalir;
        private Krypton.Toolkit.KryptonButton btnMaximizar;
        private Krypton.Toolkit.KryptonButton btnMinimizar;
        private System.Windows.Forms.Timer tmrTransicionLateral;
    }
}