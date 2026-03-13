namespace TRAMADE
{
    partial class frmCompras
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.chtProveedores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtComprasPendientes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chtProductosMasComprados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvComprasRecientes = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSeguimiento = new Krypton.Toolkit.KryptonButton();
            this.btnAutorizar = new Krypton.Toolkit.KryptonButton();
            this.btnActualizar = new Krypton.Toolkit.KryptonButton();
            this.btnRegistrar = new Krypton.Toolkit.KryptonButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtComprasPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtProductosMasComprados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasRecientes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chtProveedores
            // 
            chartArea1.Name = "ChartArea1";
            this.chtProveedores.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtProveedores.Legends.Add(legend1);
            this.chtProveedores.Location = new System.Drawing.Point(373, 175);
            this.chtProveedores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chtProveedores.Name = "chtProveedores";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtProveedores.Series.Add(series1);
            this.chtProveedores.Size = new System.Drawing.Size(292, 219);
            this.chtProveedores.TabIndex = 18;
            // 
            // chtComprasPendientes
            // 
            chartArea2.Name = "ChartArea1";
            this.chtComprasPendientes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtComprasPendientes.Legends.Add(legend2);
            this.chtComprasPendientes.Location = new System.Drawing.Point(675, 175);
            this.chtComprasPendientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chtComprasPendientes.Name = "chtComprasPendientes";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtComprasPendientes.Series.Add(series2);
            this.chtComprasPendientes.Size = new System.Drawing.Size(274, 219);
            this.chtComprasPendientes.TabIndex = 17;
            this.chtComprasPendientes.Text = "chart2";
            // 
            // chtProductosMasComprados
            // 
            chartArea3.Name = "ChartArea1";
            this.chtProductosMasComprados.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtProductosMasComprados.Legends.Add(legend3);
            this.chtProductosMasComprados.Location = new System.Drawing.Point(56, 175);
            this.chtProductosMasComprados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chtProductosMasComprados.Name = "chtProductosMasComprados";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chtProductosMasComprados.Series.Add(series3);
            this.chtProductosMasComprados.Size = new System.Drawing.Size(302, 219);
            this.chtProductosMasComprados.TabIndex = 16;
            this.chtProductosMasComprados.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 410);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "COMPRAS RECIENTES";
            // 
            // dgvComprasRecientes
            // 
            this.dgvComprasRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasRecientes.Location = new System.Drawing.Point(54, 442);
            this.dgvComprasRecientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvComprasRecientes.Name = "dgvComprasRecientes";
            this.dgvComprasRecientes.RowHeadersVisible = false;
            this.dgvComprasRecientes.RowHeadersWidth = 51;
            this.dgvComprasRecientes.RowTemplate.Height = 24;
            this.dgvComprasRecientes.Size = new System.Drawing.Size(593, 245);
            this.dgvComprasRecientes.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSeguimiento);
            this.panel2.Controls.Add(this.btnAutorizar);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(56, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 85);
            this.panel2.TabIndex = 13;
            // 
            // btnSeguimiento
            // 
            this.btnSeguimiento.Location = new System.Drawing.Point(655, 22);
            this.btnSeguimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeguimiento.Name = "btnSeguimiento";
            this.btnSeguimiento.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(92)))));
            this.btnSeguimiento.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(92)))));
            this.btnSeguimiento.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(92)))));
            this.btnSeguimiento.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSeguimiento.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnSeguimiento.Size = new System.Drawing.Size(231, 42);
            this.btnSeguimiento.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(92)))));
            this.btnSeguimiento.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(92)))));
            this.btnSeguimiento.StateCommon.Border.Rounding = 10F;
            this.btnSeguimiento.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSeguimiento.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguimiento.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(92)))));
            this.btnSeguimiento.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSeguimiento.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnSeguimiento.StateTracking.Border.Rounding = 10F;
            this.btnSeguimiento.TabIndex = 10;
            this.btnSeguimiento.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSeguimiento.Values.ImageStates.ImageCheckedNormal = null;
            this.btnSeguimiento.Values.ImageStates.ImageCheckedPressed = null;
            this.btnSeguimiento.Values.ImageStates.ImageCheckedTracking = null;
            this.btnSeguimiento.Values.ImageStates.ImageNormal = global::TRAMADE.Properties.Resources.SEGUIMIENTO;
            this.btnSeguimiento.Values.ImageStates.ImagePressed = global::TRAMADE.Properties.Resources.SEGUIMIENTO;
            this.btnSeguimiento.Values.ImageStates.ImageTracking = global::TRAMADE.Properties.Resources.SEGUIMIENTO;
            this.btnSeguimiento.Values.Text = "SEGUIMIENTO DE COMPRA";
            this.btnSeguimiento.Click += new System.EventHandler(this.btnSeguimiento_Click_1);
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.Location = new System.Drawing.Point(440, 22);
            this.btnAutorizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.OverrideDefault.Back.Color1 = System.Drawing.Color.Teal;
            this.btnAutorizar.OverrideDefault.Back.Color2 = System.Drawing.Color.Teal;
            this.btnAutorizar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAutorizar.OverrideFocus.Back.Color2 = System.Drawing.Color.Teal;
            this.btnAutorizar.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnAutorizar.Size = new System.Drawing.Size(211, 42);
            this.btnAutorizar.StateCommon.Back.Color1 = System.Drawing.Color.Teal;
            this.btnAutorizar.StateCommon.Back.Color2 = System.Drawing.Color.Teal;
            this.btnAutorizar.StateCommon.Border.Rounding = 10F;
            this.btnAutorizar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnAutorizar.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAutorizar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutorizar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAutorizar.StateTracking.Back.Color2 = System.Drawing.Color.Teal;
            this.btnAutorizar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnAutorizar.StateTracking.Border.Rounding = 10F;
            this.btnAutorizar.TabIndex = 9;
            this.btnAutorizar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAutorizar.Values.ImageStates.ImageCheckedNormal = null;
            this.btnAutorizar.Values.ImageStates.ImageCheckedPressed = null;
            this.btnAutorizar.Values.ImageStates.ImageCheckedTracking = null;
            this.btnAutorizar.Values.ImageStates.ImageNormal = global::TRAMADE.Properties.Resources.GES;
            this.btnAutorizar.Values.ImageStates.ImagePressed = global::TRAMADE.Properties.Resources.GES;
            this.btnAutorizar.Values.ImageStates.ImageTracking = global::TRAMADE.Properties.Resources.GES;
            this.btnAutorizar.Values.Text = "AUTORIZAR SOLICITUD";
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(224, 22);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnActualizar.Size = new System.Drawing.Size(203, 42);
            this.btnActualizar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.StateCommon.Border.Rounding = 10F;
            this.btnActualizar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnActualizar.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnActualizar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            this.btnActualizar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnActualizar.StateTracking.Border.Rounding = 10F;
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnActualizar.Values.ImageStates.ImageCheckedNormal = null;
            this.btnActualizar.Values.ImageStates.ImageCheckedPressed = null;
            this.btnActualizar.Values.ImageStates.ImageCheckedTracking = null;
            this.btnActualizar.Values.ImageStates.ImageNormal = global::TRAMADE.Properties.Resources.ACTUALIZAR;
            this.btnActualizar.Values.ImageStates.ImagePressed = global::TRAMADE.Properties.Resources.ACTUALIZAR;
            this.btnActualizar.Values.ImageStates.ImageTracking = global::TRAMADE.Properties.Resources.ACTUALIZAR;
            this.btnActualizar.Values.Text = "ACTUALIZAR SOLICITUD ";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnRegistrar.Location = new System.Drawing.Point(2, 22);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegistrar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRegistrar.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnRegistrar.Size = new System.Drawing.Size(209, 42);
            this.btnRegistrar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.BottomRight;
            this.btnRegistrar.StateCommon.Border.Rounding = 10F;
            this.btnRegistrar.StateCommon.Content.Image.ImageColorMap = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.StateCommon.Content.Image.ImageColorTo = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnRegistrar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnRegistrar.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnRegistrar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.StatePressed.Back.Color2 = System.Drawing.Color.DarkOrange;
            this.btnRegistrar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRegistrar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnRegistrar.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Values.ImageStates.ImageCheckedNormal = null;
            this.btnRegistrar.Values.ImageStates.ImageCheckedPressed = null;
            this.btnRegistrar.Values.ImageStates.ImageCheckedTracking = null;
            this.btnRegistrar.Values.ImageStates.ImageNormal = global::TRAMADE.Properties.Resources.MAS1;
            this.btnRegistrar.Values.ImageStates.ImagePressed = global::TRAMADE.Properties.Resources.MAS1;
            this.btnRegistrar.Values.ImageStates.ImageTracking = global::TRAMADE.Properties.Resources.MAS1;
            this.btnRegistrar.Values.Text = "REGISTRAR SOLICITUD";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_3);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(890, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 76);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(2, 76);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 8);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "MÓDULO DE COMPRAS";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1024, 726);
            this.ControlBox = false;
            this.Controls.Add(this.chtProveedores);
            this.Controls.Add(this.chtComprasPendientes);
            this.Controls.Add(this.chtProductosMasComprados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvComprasRecientes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtComprasPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtProductosMasComprados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasRecientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtProveedores;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtComprasPendientes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtProductosMasComprados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvComprasRecientes;
        private System.Windows.Forms.Panel panel2;
        private Krypton.Toolkit.KryptonButton btnSeguimiento;
        private Krypton.Toolkit.KryptonButton btnAutorizar;
        private Krypton.Toolkit.KryptonButton btnActualizar;
        private Krypton.Toolkit.KryptonButton btnRegistrar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}