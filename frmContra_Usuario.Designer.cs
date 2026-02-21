namespace TRAMADE
{
    partial class frmContra_Usuario
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
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new Krypton.Toolkit.KryptonTextBox();
            this.txtContra = new Krypton.Toolkit.KryptonTextBox();
            this.btnCancelar = new Krypton.Toolkit.KryptonButton();
            this.btnAceptar = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Enabled = false;
            this.kryptonTextBox1.Location = new System.Drawing.Point(-16, 12);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(822, 91);
            this.kryptonTextBox1.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.kryptonTextBox1.StateActive.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonTextBox1.StateActive.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonTextBox1.StateActive.Border.Rounding = 10F;
            this.kryptonTextBox1.StateActive.Border.Width = 4;
            this.kryptonTextBox1.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox1.StateActive.Content.Font = new System.Drawing.Font("Sans Serif Collection", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.TabIndex = 23;
            this.kryptonTextBox1.Text = "¡Advertencia!";
            this.kryptonTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(47, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 75);
            this.label1.TabIndex = 24;
            this.label1.Text = "Esta sección está restringida. Solo los usuarios con el rol de gerente \r\npueden a" +
    "utorizar o denegar los datos del registro de clientes.\r\nSe requiere autenticació" +
    "n de credenciales para acceder.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(75, 247);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(302, 36);
            this.txtUsuario.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.TabIndex = 25;
            this.txtUsuario.Text = "Ingrese su usuario";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(75, 309);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(302, 36);
            this.txtContra.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.TabIndex = 26;
            this.txtContra.Text = "Ingrese su contraseña";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(435, 384);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(153, 32);
            this.btnCancelar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnCancelar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(28)))), ((int)(((byte)(62)))));
            this.btnCancelar.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCancelar.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnCancelar.StateCommon.Border.Rounding = 25F;
            this.btnCancelar.StateCommon.Border.Width = 1;
            this.btnCancelar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancelar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancelar.Values.Text = "Cancelar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(606, 384);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(153, 32);
            this.btnAceptar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnAceptar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(44)))), ((int)(((byte)(131)))));
            this.btnAceptar.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnAceptar.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnAceptar.StateCommon.Border.Rounding = 25F;
            this.btnAceptar.StateCommon.Border.Width = 1;
            this.btnAceptar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAceptar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAceptar.TabIndex = 28;
            this.btnAceptar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAceptar.Values.Text = "Aceptar";
            // 
            // frmContra_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kryptonTextBox1);
            this.Name = "frmContra_Usuario";
            this.Text = "frmContra_Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox txtUsuario;
        private Krypton.Toolkit.KryptonTextBox txtContra;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private Krypton.Toolkit.KryptonButton btnAceptar;
    }
}