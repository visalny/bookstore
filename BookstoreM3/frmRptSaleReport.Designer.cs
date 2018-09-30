namespace BookstoreM3
{
    partial class frmRptSaleReport
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
            this.Vspt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // Vspt
            // 
            this.Vspt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vspt.Location = new System.Drawing.Point(0, 0);
            this.Vspt.Name = "Vspt";
            this.Vspt.ServerReport.ReportPath = "rptSale.rdlc";
            this.Vspt.Size = new System.Drawing.Size(495, 447);
            this.Vspt.TabIndex = 0;
            // 
            // frmRptSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 447);
            this.Controls.Add(this.Vspt);
            this.Name = "frmRptSaleReport";
            this.Text = "frmRptSaleReport";
            this.Load += new System.EventHandler(this.frmRptSaleReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer Vspt;
    }
}