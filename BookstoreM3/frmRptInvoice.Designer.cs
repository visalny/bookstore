namespace BookstoreM3
{
    partial class frmRptInvoice
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Vinv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsInvoice = new BookstoreM3.dsInvoice();
            this.dtInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Vinv
            // 
            this.Vinv.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsInvoice";
            reportDataSource1.Value = this.dtInvoiceBindingSource;
            this.Vinv.LocalReport.DataSources.Add(reportDataSource1);
            this.Vinv.LocalReport.ReportEmbeddedResource = "BookstoreM3.rptInvoice.rdlc";
            this.Vinv.Location = new System.Drawing.Point(0, 0);
            this.Vinv.Name = "Vinv";
            this.Vinv.Size = new System.Drawing.Size(472, 475);
            this.Vinv.TabIndex = 0;
            // 
            // dsInvoice
            // 
            this.dsInvoice.DataSetName = "dsInvoice";
            this.dsInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtInvoiceBindingSource
            // 
            this.dtInvoiceBindingSource.DataMember = "dtInvoice";
            this.dtInvoiceBindingSource.DataSource = this.dsInvoice;
            // 
            // frmRptInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 475);
            this.Controls.Add(this.Vinv);
            this.Name = "frmRptInvoice";
            this.Text = "frmRptInvoice";
            this.Load += new System.EventHandler(this.frmRptInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dtInvoiceBindingSource;
        private dsInvoice dsInvoice;
        public Microsoft.Reporting.WinForms.ReportViewer Vinv;
    }
}