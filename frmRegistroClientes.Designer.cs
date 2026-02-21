namespace TRAMADE
{
    partial class frmRegistroClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoCliente = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdCliente = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBox2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtContacto = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtDireccionContacto = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtDepartamento = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE NUEVO CLIENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(811, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "_________________________________________________________________________________" +
    "_____________________________________________________\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 9.5F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(731, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID de cliente*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Sans Serif Collection", 9.5F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(81, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 44);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre de cliente*";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Sans Serif Collection", 9.5F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(146, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 44);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de Registro*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Sans Serif Collection", 9.5F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(682, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 44);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de cliente*";
            // 
            // cmbTipoCliente
            // 
            this.cmbTipoCliente.DropDownWidth = 137;
            this.cmbTipoCliente.Items.AddRange(new object[] {
            "Persona natural",
            "Empresa"});
            this.cmbTipoCliente.Location = new System.Drawing.Point(518, 12);
            this.cmbTipoCliente.Name = "cmbTipoCliente";
            this.cmbTipoCliente.Size = new System.Drawing.Size(147, 31);
            this.cmbTipoCliente.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cmbTipoCliente.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbTipoCliente.StateActive.ComboBox.Border.Rounding = 5;
            this.cmbTipoCliente.StateActive.ComboBox.Border.Width = 5;
            this.cmbTipoCliente.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(234, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Datos principales del cliente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Sans Serif Collection", 9.5F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(379, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 44);
            this.label10.TabIndex = 12;
            this.label10.Text = "Contacto*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Sans Serif Collection", 9.5F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(459, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 44);
            this.label9.TabIndex = 14;
            this.label9.Text = "Dirección*";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(178, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Datos de contacto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Sans Serif Collection", 9.5F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(500, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 44);
            this.label12.TabIndex = 17;
            this.label12.Text = "Departamento*";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(160, 93);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(147, 33);
            this.txtIdCliente.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtIdCliente.StateActive.Border.ColorAngle = 8F;
            this.txtIdCliente.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtIdCliente.StateActive.Border.Rounding = 5;
            this.txtIdCliente.StateActive.Border.Width = 5;
            this.txtIdCliente.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(160, 153);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 33);
            this.txtNombre.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNombre.StateActive.Border.ColorAngle = 8F;
            this.txtNombre.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNombre.StateActive.Border.Rounding = 5;
            this.txtNombre.StateActive.Border.Width = 5;
            this.txtNombre.TabIndex = 5;
            // 
            // kryptonTextBox2
            // 
            this.kryptonTextBox2.Location = new System.Drawing.Point(505, 93);
            this.kryptonTextBox2.Name = "kryptonTextBox2";
            this.kryptonTextBox2.Size = new System.Drawing.Size(147, 33);
            this.kryptonTextBox2.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.kryptonTextBox2.StateActive.Border.ColorAngle = 8F;
            this.kryptonTextBox2.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox2.StateActive.Border.Rounding = 5;
            this.kryptonTextBox2.StateActive.Border.Width = 5;
            this.kryptonTextBox2.TabIndex = 7;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(160, 249);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(147, 33);
            this.txtContacto.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtContacto.StateActive.Border.ColorAngle = 8F;
            this.txtContacto.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtContacto.StateActive.Border.Rounding = 5;
            this.txtContacto.StateActive.Border.Width = 5;
            this.txtContacto.TabIndex = 13;
            // 
            // txtDireccionContacto
            // 
            this.txtDireccionContacto.Location = new System.Drawing.Point(160, 293);
            this.txtDireccionContacto.Name = "txtDireccionContacto";
            this.txtDireccionContacto.Size = new System.Drawing.Size(147, 33);
            this.txtDireccionContacto.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtDireccionContacto.StateActive.Border.ColorAngle = 8F;
            this.txtDireccionContacto.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDireccionContacto.StateActive.Border.Rounding = 5;
            this.txtDireccionContacto.StateActive.Border.Width = 5;
            this.txtDireccionContacto.TabIndex = 15;
            this.txtDireccionContacto.TextChanged += new System.EventHandler(this.txtDireccionContacto_TextChanged);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(160, 340);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(147, 33);
            this.txtDepartamento.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtDepartamento.StateActive.Border.ColorAngle = 8F;
            this.txtDepartamento.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDepartamento.StateActive.Border.Rounding = 5;
            this.txtDepartamento.StateActive.Border.Width = 5;
            this.txtDepartamento.TabIndex = 18;
            // 
            // frmRegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(108)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(854, 514);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbTipoCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "frmRegistroClientes";
            this.Text = "frmRegistroClientes";
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbTipoCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtIdCliente;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNombre;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtContacto;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDireccionContacto;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDepartamento;
    }
}