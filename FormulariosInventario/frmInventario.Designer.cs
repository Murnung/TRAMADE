namespace TRAMADE
{
    partial class frmInventario
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new Krypton.Toolkit.KryptonButton();
            this.btnEditar = new Krypton.Toolkit.KryptonButton();
            this.btnEliminar = new Krypton.Toolkit.KryptonButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnRegresar = new Krypton.Toolkit.KryptonButton();
            this.btnExportarInventario = new Krypton.Toolkit.KryptonButton();
            this.lblPagina = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgProducto = new System.Windows.Forms.PictureBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnSiguiente = new Krypton.Toolkit.KryptonButton();
            this.btnAtras = new Krypton.Toolkit.KryptonButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new Krypton.Toolkit.KryptonButton();
            this.btnRefrescar = new Krypton.Toolkit.KryptonButton();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.txtBuscar.Location = new System.Drawing.Point(65, 20);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(146, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.cmbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Location = new System.Drawing.Point(326, 22);
            this.cmbFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(129, 21);
            this.cmbFiltrar.TabIndex = 1;
            this.cmbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrar_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrar.Location = new System.Drawing.Point(529, 21);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(61, 20);
            this.btnRegistrar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.btnRegistrar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Values.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditar.Location = new System.Drawing.Point(608, 21);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(61, 20);
            this.btnEditar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.btnEditar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnEditar.Values.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.Location = new System.Drawing.Point(686, 21);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(61, 20);
            this.btnEliminar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEliminar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnEliminar.Values.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(870, 11);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(75, 19);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegresar.Location = new System.Drawing.Point(65, 382);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(61, 20);
            this.btnRegresar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.btnRegresar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRegresar.Values.Text = "Regresar";
            // 
            // btnExportarInventario
            // 
            this.btnExportarInventario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExportarInventario.Location = new System.Drawing.Point(616, 382);
            this.btnExportarInventario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportarInventario.Name = "btnExportarInventario";
            this.btnExportarInventario.Size = new System.Drawing.Size(131, 20);
            this.btnExportarInventario.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.btnExportarInventario.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.btnExportarInventario.TabIndex = 8;
            this.btnExportarInventario.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExportarInventario.Values.Text = "Exportar Inventario";
            this.btnExportarInventario.Click += new System.EventHandler(this.btnExportarInventario_Click);
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(824, 384);
            this.lblPagina.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(73, 13);
            this.lblPagina.TabIndex = 9;
            this.lblPagina.Text = "Página 1 de 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(18, 59);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(920, 266);
            this.dgvInventario.TabIndex = 12;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            this.dgvInventario.SelectionChanged += new System.EventHandler(this.dgvInventario_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.imgProducto);
            this.panel2.Controls.Add(this.lblNombreProducto);
            this.panel2.Location = new System.Drawing.Point(182, 341);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 84);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // imgProducto
            // 
            this.imgProducto.Image = global::TRAMADE.Properties.Resources.photo_8924441;
            this.imgProducto.Location = new System.Drawing.Point(24, 6);
            this.imgProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgProducto.Name = "imgProducto";
            this.imgProducto.Size = new System.Drawing.Size(106, 74);
            this.imgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProducto.TabIndex = 1;
            this.imgProducto.TabStop = false;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(141)))), ((int)(((byte)(144)))));
            this.lblNombreProducto.Location = new System.Drawing.Point(140, 23);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(102, 38);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Imagen \r\ndel Producto";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(895, 382);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(21, 20);
            this.btnSiguiente.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.btnSiguiente.StateCommon.Back.Color2 = System.Drawing.SystemColors.Control;
            this.btnSiguiente.TabIndex = 16;
            this.btnSiguiente.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSiguiente.Values.Image = global::TRAMADE.Properties.Resources.right_arrow_17910491;
            this.btnSiguiente.Values.Text = "";
            this.btnSiguiente.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(799, 381);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(20, 20);
            this.btnAtras.StateCommon.Back.Color1 = System.Drawing.SystemColors.Control;
            this.btnAtras.StateCommon.Back.Color2 = System.Drawing.SystemColors.Control;
            this.btnAtras.TabIndex = 17;
            this.btnAtras.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAtras.Values.Image = global::TRAMADE.Properties.Resources.left_arrow_17909673;
            this.btnAtras.Values.Text = "";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TRAMADE.Properties.Resources.calendar_55281;
            this.pictureBox3.Location = new System.Drawing.Point(810, 19);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(578, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(114)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 150);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(220, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(20, 20);
            this.btnBuscar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.btnBuscar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBuscar.Values.Image = global::TRAMADE.Properties.Resources.icons8_búsqueda_50;
            this.btnBuscar.Values.Text = "kryptonButton2";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(249, 20);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(20, 20);
            this.btnRefrescar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.btnRefrescar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(212)))));
            this.btnRefrescar.TabIndex = 19;
            this.btnRefrescar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRefrescar.Values.Image = global::TRAMADE.Properties.Resources.refresh_2805355;
            this.btnRefrescar.Values.Text = "kryptonButton2";
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(870, 30);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(86, 19);
            this.lblHora.TabIndex = 20;
            this.lblHora.Text = "Hora";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 436);
            this.ControlBox = false;
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPagina);
            this.Controls.Add(this.btnExportarInventario);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbFiltrar);
            this.Controls.Add(this.txtBuscar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private Krypton.Toolkit.KryptonButton btnRegistrar;
        private Krypton.Toolkit.KryptonButton btnEditar;
        private Krypton.Toolkit.KryptonButton btnEliminar;
        private System.Windows.Forms.Label lblFecha;
        private Krypton.Toolkit.KryptonButton btnRegresar;
        private Krypton.Toolkit.KryptonButton btnExportarInventario;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Krypton.Toolkit.KryptonButton btnSiguiente;
        private Krypton.Toolkit.KryptonButton btnAtras;
        private System.Windows.Forms.PictureBox imgProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btnBuscar;
        private Krypton.Toolkit.KryptonButton btnRefrescar;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}