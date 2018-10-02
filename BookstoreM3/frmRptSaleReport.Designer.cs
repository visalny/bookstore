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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Vspt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsSale = new BookstoreM3.dsSale();
            this.dtSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Vspt
            // 
            this.Vspt.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsSale";
            reportDataSource1.Value = this.dtSaleBindingSource;
            this.Vspt.LocalReport.DataSources.Add(reportDataSource1);
            this.Vspt.LocalReport.ReportEmbeddedResource = "BookstoreM3.rptSale.rdlc";
            this.Vspt.Location = new System.Drawing.Point(0, 0);
            this.Vspt.Name = "Vspt";
            this.Vspt.Size = new System.Drawing.Size(660, 504);
            this.Vspt.TabIndex = 0;
            // 
            // dsSale
            // 
            this.dsSale.DataSetName = "dsSale";
            this.dsSale.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtSaleBindingSource
            // 
            this.dtSaleBindingSource.DataMember = "dtSale";
            this.dtSaleBindingSource.DataSource = this.dsSale;
            // 
            // frmRptSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 504);
            this.Controls.Add(this.Vspt);
            this.Name = "frmRptSaleReport";
            this.Text = "frmRptSaleReport";
            this.Load += new System.EventHandler(this.frmRptSaleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSaleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dtSaleBindingSource;
        private dsSale dsSale;
        public Microsoft.Reporting.WinForms.ReportViewer Vspt;
    }
}