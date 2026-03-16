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
            this.btnSeguimiento = new Krypton.Toolkit.KryptonButton();
            this.btnAutorizar = new Krypton.Toolkit.KryptonButton();
            this.btnActualizar = new Krypton.Toolkit.KryptonButton();
            this.btnRegistrar = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefrescar = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.chtProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtComprasPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtProductosMasComprados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasRecientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 6;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chtProveedores
            // 
            chartArea1.Name = "ChartArea1";
            this.chtProveedores.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtProveedores.Legends.Add(legend1);
            this.chtProveedores.Location = new System.Drawing.Point(446, 212);
            this.chtProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chtProveedores.Name = "chtProveedores";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtProveedores.Series.Add(series1);
            this.chtProveedores.Size = new System.Drawing.Size(389, 270);
            this.chtProveedores.TabIndex = 18;
            // 
            // chtComprasPendientes
            // 
            chartArea2.Name = "ChartArea1";
            this.chtComprasPendientes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtComprasPendientes.Legends.Add(legend2);
            this.chtComprasPendientes.Location = new System.Drawing.Point(860, 212);
            this.chtComprasPendientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chtComprasPendientes.Name = "chtComprasPendientes";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chtComprasPendientes.Series.Add(series2);
            this.chtComprasPendientes.Size = new System.Drawing.Size(365, 270);
            this.chtComprasPendientes.TabIndex = 17;
            this.chtComprasPendientes.Text = "chart2";
            // 
            // chtProductosMasComprados
            // 
            chartArea3.Name = "ChartArea1";
            this.chtProductosMasComprados.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chtProductosMasComprados.Legends.Add(legend3);
            this.chtProductosMasComprados.Location = new System.Drawing.Point(15, 212);
            this.chtProductosMasComprados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chtProductosMasComprados.Name = "chtProductosMasComprados";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chtProductosMasComprados.Series.Add(series3);
            this.chtProductosMasComprados.Size = new System.Drawing.Size(403, 270);
            this.chtProductosMasComprados.TabIndex = 16;
            this.chtProductosMasComprados.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "COMPRAS RECIENTES";
            // 
            // dgvComprasRecientes
            // 
            this.dgvComprasRecientes.AllowUserToAddRows = false;
            this.dgvComprasRecientes.AllowUserToDeleteRows = false;
            this.dgvComprasRecientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvComprasRecientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComprasRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprasRecientes.Location = new System.Drawing.Point(361, 570);
            this.dgvComprasRecientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvComprasRecientes.Name = "dgvComprasRecientes";
            this.dgvComprasRecientes.RowHeadersVisible = false;
            this.dgvComprasRecientes.RowHeadersWidth = 51;
            this.dgvComprasRecientes.RowTemplate.Height = 24;
            this.dgvComprasRecientes.Size = new System.Drawing.Size(864, 302);
            this.dgvComprasRecientes.TabIndex = 14;
            // 
            // btnSeguimiento
            // 
            this.btnSeguimiento.Location = new System.Drawing.Point(938, 115);
            this.btnSeguimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeguimiento.Name = "btnSeguimiento";
            this.btnSeguimiento.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(92)))));
            this.btnSeguimiento.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(92)))));
            this.btnSeguimiento.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(92)))));
            this.btnSeguimiento.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(167)))), ((int)(((byte)(118)))));
            this.btnSeguimiento.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnSeguimiento.Size = new System.Drawing.Size(287, 75);
            this.btnSeguimiento.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(92)))));
            this.btnSeguimiento.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(92)))));
            this.btnSeguimiento.StateCommon.Border.Rounding = 10F;
            this.btnSeguimiento.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSeguimiento.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguimiento.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(130)))), ((int)(((byte)(92)))));
            this.btnSeguimiento.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(167)))), ((int)(((byte)(118)))));
            this.btnSeguimiento.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnSeguimiento.StateTracking.Border.Rounding = 10F;
            this.btnSeguimiento.TabIndex = 10;
            this.btnSeguimiento.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSeguimiento.Values.ImageStates.ImageCheckedNormal = null;
            this.btnSeguimiento.Values.ImageStates.ImageCheckedPressed = null;
            this.btnSeguimiento.Values.ImageStates.ImageCheckedTracking = null;
            this.btnSeguimiento.Values.ImageStates.ImageDisabled = global::TRAMADE.Properties.Resources.seguimiento1;
            this.btnSeguimiento.Values.ImageStates.ImageNormal = global::TRAMADE.Properties.Resources.seguimiento1;
            this.btnSeguimiento.Values.ImageStates.ImagePressed = global::TRAMADE.Properties.Resources.seguimiento1;
            this.btnSeguimiento.Values.ImageStates.ImageTracking = global::TRAMADE.Properties.Resources.seguimiento1;
            this.btnSeguimiento.Values.Text = "SEGUIMIENTO DE COMPRA";
            this.btnSeguimiento.Click += new System.EventHandler(this.btnSeguimiento_Click_1);
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.Location = new System.Drawing.Point(635, 115);
            this.btnAutorizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnAutorizar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnAutorizar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnAutorizar.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(179)))), ((int)(((byte)(121)))));
            this.btnAutorizar.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnAutorizar.Size = new System.Drawing.Size(287, 75);
            this.btnAutorizar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnAutorizar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnAutorizar.StateCommon.Border.Rounding = 10F;
            this.btnAutorizar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAutorizar.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnAutorizar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutorizar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(140)))), ((int)(((byte)(92)))));
            this.btnAutorizar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(179)))), ((int)(((byte)(121)))));
            this.btnAutorizar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnAutorizar.StateTracking.Border.Rounding = 10F;
            this.btnAutorizar.TabIndex = 9;
            this.btnAutorizar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAutorizar.Values.ImageStates.ImageCheckedNormal = null;
            this.btnAutorizar.Values.ImageStates.ImageCheckedPressed = null;
            this.btnAutorizar.Values.ImageStates.ImageCheckedTracking = null;
            this.btnAutorizar.Values.ImageStates.ImageDisabled = global::TRAMADE.Properties.Resources.autorizar;
            this.btnAutorizar.Values.ImageStates.ImageNormal = global::TRAMADE.Properties.Resources.autorizar;
            this.btnAutorizar.Values.ImageStates.ImagePressed = global::TRAMADE.Properties.Resources.autorizar;
            this.btnAutorizar.Values.ImageStates.ImageTracking = global::TRAMADE.Properties.Resources.autorizar;
            this.btnAutorizar.Values.Text = "AUTORIZAR SOLICITUD";
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(329, 115);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(120)))), ((int)(((byte)(134)))));
            this.btnActualizar.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnActualizar.Size = new System.Drawing.Size(287, 75);
            this.btnActualizar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.StateCommon.Border.Rounding = 10F;
            this.btnActualizar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnActualizar.StateCommon.Content.ShortText.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnActualizar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight;
            this.btnActualizar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.btnActualizar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(120)))), ((int)(((byte)(134)))));
            this.btnActualizar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertCheckedTracking;
            this.btnActualizar.StateTracking.Border.Rounding = 10F;
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnActualizar.Values.ImageStates.ImageCheckedNormal = null;
            this.btnActualizar.Values.ImageStates.ImageCheckedPressed = null;
            this.btnActualizar.Values.ImageStates.ImageCheckedTracking = null;
            this.btnActualizar.Values.ImageStates.ImageDisabled = global::TRAMADE.Properties.Resources.image_actualizar__1_;
            this.btnActualizar.Values.ImageStates.ImageNormal = global::TRAMADE.Properties.Resources.image_actualizar__1_;
            this.btnActualizar.Values.ImageStates.ImagePressed = global::TRAMADE.Properties.Resources.image_actualizar__1_;
            this.btnActualizar.Values.ImageStates.ImageTracking = global::TRAMADE.Properties.Resources.image_actualizar__1_;
            this.btnActualizar.Values.Text = "ACTUALIZAR SOLICITUD ";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.btnRegistrar.Location = new System.Drawing.Point(16, 115);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.OverrideDefault.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegistrar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(74)))));
            this.btnRegistrar.OverrideFocus.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.ExpertTracking;
            this.btnRegistrar.Size = new System.Drawing.Size(287, 75);
            this.btnRegistrar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.BottomRight;
            this.btnRegistrar.StateCommon.Border.Rounding = 10F;
            this.btnRegistrar.StateCommon.Content.Image.ImageColorMap = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.StateCommon.Content.Image.ImageColorTo = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrar.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRegistrar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnRegistrar.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnRegistrar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(74)))));
            this.btnRegistrar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.btnRegistrar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(93)))), ((int)(((byte)(74)))));
            this.btnRegistrar.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRegistrar.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Values.Text = "REGISTRAR SOLICITUD";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_3);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "MÓDULO DE COMPRAS";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(89, 633);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRefrescar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRefrescar.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(74)))), ((int)(((byte)(214)))));
            this.btnRefrescar.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(74)))), ((int)(((byte)(214)))));
            this.btnRefrescar.Size = new System.Drawing.Size(173, 39);
            this.btnRefrescar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRefrescar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRefrescar.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnRefrescar.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnRefrescar.StateCommon.Border.Rounding = 25F;
            this.btnRefrescar.StateCommon.Border.Width = 1;
            this.btnRefrescar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnRefrescar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnRefrescar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRefrescar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRefrescar.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRefrescar.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRefrescar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnRefrescar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(74)))), ((int)(((byte)(214)))));
            this.btnRefrescar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(74)))), ((int)(((byte)(214)))));
            this.btnRefrescar.TabIndex = 46;
            this.btnRefrescar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRefrescar.Values.Text = "REFRESCAR";
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1329, 894);
            this.ControlBox = false;
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnSeguimiento);
            this.Controls.Add(this.chtProveedores);
            this.Controls.Add(this.btnAutorizar);
            this.Controls.Add(this.chtComprasPendientes);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.chtProductosMasComprados);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvComprasRecientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtComprasPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtProductosMasComprados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasRecientes)).EndInit();
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
        private Krypton.Toolkit.KryptonButton btnSeguimiento;
        private Krypton.Toolkit.KryptonButton btnAutorizar;
        private Krypton.Toolkit.KryptonButton btnActualizar;
        private Krypton.Toolkit.KryptonButton btnRegistrar;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonButton btnRefrescar;
    }
}