namespace TRAMADE
{
    partial class frmAutorizar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new Krypton.Toolkit.KryptonButton();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAutorizar = new Krypton.Toolkit.KryptonButton();
            this.btnDenegar = new Krypton.Toolkit.KryptonButton();
            this.txtBuscar = new Krypton.Toolkit.KryptonTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new Krypton.Toolkit.KryptonButton();
            this.btnRefrescar = new Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "AUTORIZAR SOLICITUD DE COMPRA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 69);
            this.panel1.TabIndex = 27;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(887, 18);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnRegresar.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnRegresar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnRegresar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.btnRegresar.OverrideFocus.Back.Color1 = System.Drawing.Color.Goldenrod;
            this.btnRegresar.OverrideFocus.Back.Color2 = System.Drawing.Color.Gold;
            this.btnRegresar.Size = new System.Drawing.Size(107, 30);
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
            this.btnRegresar.TabIndex = 72;
            this.btnRegresar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRegresar.Values.Text = "REGRESAR";
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(11, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 42);
            this.label14.TabIndex = 21;
            this.label14.Text = "TSMS";
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.Location = new System.Drawing.Point(20, 206);
            this.btnAutorizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.OverrideFocus.Back.Color2 = System.Drawing.Color.DarkSeaGreen;
            this.btnAutorizar.Size = new System.Drawing.Size(208, 30);
            this.btnAutorizar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAutorizar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAutorizar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(137)))), ((int)(((byte)(19)))));
            this.btnAutorizar.StateTracking.Back.Color2 = System.Drawing.Color.DarkSeaGreen;
            this.btnAutorizar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnAutorizar.TabIndex = 72;
            this.btnAutorizar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAutorizar.Values.Text = "AUTORIZAR SELECCIONES";
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // btnDenegar
            // 
            this.btnDenegar.Location = new System.Drawing.Point(247, 206);
            this.btnDenegar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDenegar.Name = "btnDenegar";
            this.btnDenegar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.OverrideFocus.Back.Color2 = System.Drawing.Color.OrangeRed;
            this.btnDenegar.Size = new System.Drawing.Size(208, 30);
            this.btnDenegar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDenegar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDenegar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnDenegar.StateTracking.Back.Color2 = System.Drawing.Color.OrangeRed;
            this.btnDenegar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnDenegar.TabIndex = 73;
            this.btnDenegar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDenegar.Values.Text = "DENEGAR SELECCIONES";
            this.btnDenegar.Click += new System.EventHandler(this.btnDenegar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(20, 139);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(303, 33);
            this.txtBuscar.StateCommon.Border.Rounding = 10F;
            this.txtBuscar.TabIndex = 74;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.panel2.Location = new System.Drawing.Point(0, 612);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 37);
            this.panel2.TabIndex = 75;
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(20, 249);
            this.dgvCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowHeadersWidth = 51;
            this.dgvCompras.RowTemplate.Height = 24;
            this.dgvCompras.Size = new System.Drawing.Size(1003, 319);
            this.dgvCompras.TabIndex = 76;
            this.dgvCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(329, 142);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnBuscar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnBuscar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnBuscar.OverrideFocus.Back.Color2 = System.Drawing.Color.Blue;
            this.btnBuscar.OverrideFocus.Border.Rounding = 10F;
            this.btnBuscar.Size = new System.Drawing.Size(139, 31);
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
            this.btnBuscar.TabIndex = 91;
            this.btnBuscar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBuscar.Values.Text = "BUSCAR";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(474, 142);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.OverrideDefault.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.OverrideDefault.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.OverrideFocus.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.btnRefrescar.Size = new System.Drawing.Size(51, 33);
            this.btnRefrescar.StateCommon.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.StateCommon.Back.Color2 = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.StateCommon.Border.Rounding = 10F;
            this.btnRefrescar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnRefrescar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnRefrescar.StateTracking.Back.Color1 = System.Drawing.SystemColors.ButtonFace;
            this.btnRefrescar.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btnRefrescar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnRefrescar.TabIndex = 93;
            this.btnRefrescar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRefrescar.Values.Image = global::TRAMADE.Properties.Resources.refresh_2805355;
            this.btnRefrescar.Values.Text = "";
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // frmAutorizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1045, 645);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnDenegar);
            this.Controls.Add(this.btnAutorizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAutorizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAutorizar";
            this.Load += new System.EventHandler(this.frmAutorizar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonButton btnRegresar;
        private System.Windows.Forms.Label label14;
        private Krypton.Toolkit.KryptonButton btnAutorizar;
        private Krypton.Toolkit.KryptonButton btnDenegar;
        private Krypton.Toolkit.KryptonTextBox txtBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCompras;
        private Krypton.Toolkit.KryptonButton btnBuscar;
        private Krypton.Toolkit.KryptonButton btnRefrescar;
    }
}