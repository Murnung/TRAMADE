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
           
            this.btnRegresar = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(240, 188);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(129, 51);
            this.btnRegresar.StateCommon.Back.Color1 = System.Drawing.Color.Teal;
            this.btnRegresar.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegresar.StateDisabled.Back.Color1 = System.Drawing.Color.Teal;
            this.btnRegresar.StateDisabled.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegresar.StateNormal.Back.Color1 = System.Drawing.Color.Teal;
            this.btnRegresar.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegresar.StatePressed.Back.Color1 = System.Drawing.Color.Teal;
            this.btnRegresar.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegresar.StateTracking.Back.Color1 = System.Drawing.Color.Teal;
            this.btnRegresar.StateTracking.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnRegresar.Values.Text = "Regresar";
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(817, 459);
            this.Name = "frmRegistrar";
            this.Text = "frmRegistrar";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnRegresar;
    }
}