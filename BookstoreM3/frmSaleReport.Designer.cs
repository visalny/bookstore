namespace BookstoreM3
{
    partial class frmSaleReport
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
            this.dtpstart = new System.Windows.Forms.DateTimePicker();
            this.dtpstop = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnpreview = new System.Windows.Forms.Button();
            this.listreport = new System.Windows.Forms.ListView();
            this.btnshow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpstart
            // 
            this.dtpstart.CustomFormat = "yyyy-MM-dd";
            this.dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpstart.Location = new System.Drawing.Point(150, 82);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(207, 29);
            this.dtpstart.TabIndex = 0;
            this.dtpstart.ValueChanged += new System.EventHandler(this.dtpstart_ValueChanged);
            // 
            // dtpstop
            // 
            this.dtpstop.CustomFormat = "yyyy-MM-dd";
            this.dtpstop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpstop.Location = new System.Drawing.Point(489, 84);
            this.dtpstop.Name = "dtpstop";
            this.dtpstop.Size = new System.Drawing.Size(201, 29);
            this.dtpstop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date :";
            // 
            // btnpreview
            // 
            this.btnpreview.Location = new System.Drawing.Point(779, 498);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(92, 41);
            this.btnpreview.TabIndex = 6;
            this.btnpreview.Text = "Preview";
            this.btnpreview.UseVisualStyleBackColor = true;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // listreport
            // 
            this.listreport.FullRowSelect = true;
            this.listreport.Location = new System.Drawing.Point(16, 137);
            this.listreport.Name = "listreport";
            this.listreport.Size = new System.Drawing.Size(745, 398);
            this.listreport.TabIndex = 7;
            this.listreport.UseCompatibleStateImageBehavior = false;
            // 
            // btnshow
            // 
            this.btnshow.Image = global::BookstoreM3.Properties.Resources.tv_show_filled_32px;
            this.btnshow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnshow.Location = new System.Drawing.Point(723, 78);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(100, 41);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "Show";
            this.btnshow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // frmSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(883, 560);
            this.Controls.Add(this.listreport);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpstop);
            this.Controls.Add(this.dtpstart);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSaleReport";
            this.Text = "frmSaleReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpstart;
        private System.Windows.Forms.DateTimePicker dtpstop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.ListView listreport;
    }
}