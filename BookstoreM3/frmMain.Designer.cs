namespace BookstoreM3
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelUpdown = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCategory = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.picuser = new System.Windows.Forms.PictureBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelCrtl = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUpdown
            // 
            this.panelUpdown.BackColor = System.Drawing.Color.White;
            this.panelUpdown.Location = new System.Drawing.Point(2, 293);
            this.panelUpdown.Name = "panelUpdown";
            this.panelUpdown.Size = new System.Drawing.Size(11, 46);
            this.panelUpdown.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(40, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "G2 BookStore";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnCategory);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblusername);
            this.panel2.Controls.Add(this.btnlogout);
            this.panel2.Controls.Add(this.panelUpdown);
            this.panel2.Controls.Add(this.picuser);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Controls.Add(this.btnInfo);
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Controls.Add(this.btnEmployee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 621);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCategory.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(12, 508);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(177, 54);
            this.btnCategory.TabIndex = 11;
            this.btnCategory.Text = "    Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BookstoreM3.Properties.Resources._14d4cb5905b6e5be78774b2a1b8f2120;
            this.pictureBox2.Location = new System.Drawing.Point(51, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(66, 252);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(45, 21);
            this.lblusername.TabIndex = 9;
            this.lblusername.Text = "User";
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(12, 562);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(177, 54);
            this.btnlogout.TabIndex = 8;
            this.btnlogout.Text = "    Log out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // picuser
            // 
            this.picuser.Image = ((System.Drawing.Image)(resources.GetObject("picuser.Image")));
            this.picuser.Location = new System.Drawing.Point(44, 126);
            this.picuser.Name = "picuser";
            this.picuser.Size = new System.Drawing.Size(111, 112);
            this.picuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picuser.TabIndex = 3;
            this.picuser.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(12, 454);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(177, 54);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "      Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInfo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(12, 399);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(177, 54);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "      Selling Product";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnProduct.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(12, 344);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(177, 54);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "       Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEmployee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(12, 290);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(177, 53);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "         Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(207, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 50);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(703, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 21);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "label3";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(519, 14);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 21);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "lblDate";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(859, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelCrtl
            // 
            this.panelCrtl.BackColor = System.Drawing.Color.CadetBlue;
            this.panelCrtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCrtl.Location = new System.Drawing.Point(207, 50);
            this.panelCrtl.Name = "panelCrtl";
            this.panelCrtl.Size = new System.Drawing.Size(899, 571);
            this.panelCrtl.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1106, 621);
            this.Controls.Add(this.panelCrtl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelUpdown;
        private System.Windows.Forms.PictureBox picuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCrtl;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCategory;
    }
}