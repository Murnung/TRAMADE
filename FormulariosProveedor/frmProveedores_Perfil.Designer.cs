namespace TRAMADE.Formulario_Proveedores
{
    partial class frmProveedores_Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores_Perfil));
            this.label1 = new System.Windows.Forms.Label();
            this.lstInformacionGeneral = new Krypton.Toolkit.KryptonListBox();
            this.lstDatosdeContacto = new Krypton.Toolkit.KryptonListBox();
            this.lstClasificacion = new Krypton.Toolkit.KryptonListBox();
            this.btnEditar = new Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 50);
            this.label1.TabIndex = 22;
            this.label1.Text = "Perfil del Proveedor";
            // 
            // lstInformacionGeneral
            // 
            this.lstInformacionGeneral.Location = new System.Drawing.Point(89, 157);
            this.lstInformacionGeneral.Name = "lstInformacionGeneral";
            this.lstInformacionGeneral.Size = new System.Drawing.Size(744, 139);
            this.lstInformacionGeneral.StateCommon.Border.Rounding = 17F;
            this.lstInformacionGeneral.TabIndex = 23;
            // 
            // lstDatosdeContacto
            // 
            this.lstDatosdeContacto.Location = new System.Drawing.Point(89, 318);
            this.lstDatosdeContacto.Name = "lstDatosdeContacto";
            this.lstDatosdeContacto.Size = new System.Drawing.Size(744, 139);
            this.lstDatosdeContacto.StateCommon.Border.Rounding = 17F;
            this.lstDatosdeContacto.TabIndex = 24;
            // 
            // lstClasificacion
            // 
            this.lstClasificacion.Location = new System.Drawing.Point(89, 479);
            this.lstClasificacion.Name = "lstClasificacion";
            this.lstClasificacion.Size = new System.Drawing.Size(744, 139);
            this.lstClasificacion.StateCommon.Border.Rounding = 17F;
            this.lstClasificacion.TabIndex = 25;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(781, 642);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.btnEditar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.btnEditar.OverrideFocus.Back.Color1 = System.Drawing.Color.Silver;
            this.btnEditar.OverrideFocus.Back.Color2 = System.Drawing.Color.Silver;
            this.btnEditar.Size = new System.Drawing.Size(116, 50);
            this.btnEditar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.btnEditar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(107)))), ((int)(((byte)(111)))));
            this.btnEditar.StateCommon.Content.ShortText.Color1 = System.Drawing.SystemColors.Control;
            this.btnEditar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.btnEditar.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btnEditar.StateTracking.Border.Color1 = System.Drawing.Color.Navy;
            this.btnEditar.StateTracking.Border.Color2 = System.Drawing.Color.Navy;
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnEditar.Values.Text = "EDITAR";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Clasificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "Datos de contacto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Información general";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 65);
            this.panel1.TabIndex = 34;
            // 
            // frmProveedores_Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lstClasificacion);
            this.Controls.Add(this.lstDatosdeContacto);
            this.Controls.Add(this.lstInformacionGeneral);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedores_Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProveedores_Perfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonListBox lstInformacionGeneral;
        private Krypton.Toolkit.KryptonListBox lstDatosdeContacto;
        private Krypton.Toolkit.KryptonListBox lstClasificacion;
        private Krypton.Toolkit.KryptonButton btnEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}