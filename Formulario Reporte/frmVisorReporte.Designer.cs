namespace TRAMADE
{
    partial class frmVisorReporte
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
            this.rpvNum1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvNum1
            // 
            this.rpvNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvNum1.LocalReport.ReportEmbeddedResource = "TRAMADE.Formulario Reporte.Reportes.rptCompras.rdlc";
            this.rpvNum1.Location = new System.Drawing.Point(0, 0);
            this.rpvNum1.Name = "rpvNum1";
            this.rpvNum1.ServerReport.BearerToken = null;
            this.rpvNum1.Size = new System.Drawing.Size(800, 450);
            this.rpvNum1.TabIndex = 0;
            // 
            // frmVisorReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvNum1);
            this.Name = "frmVisorReporte";
            this.Text = "frmVisorReporte";
            this.Load += new System.EventHandler(this.frmVisorReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvNum1;
    }
}