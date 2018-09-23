namespace BookstoreM3
{
    partial class frmEmployee
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.picEmp = new System.Windows.Forms.PictureBox();
            this.dtpdob = new System.Windows.Forms.DateTimePicker();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(257, 442);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 34);
            this.btnupdate.TabIndex = 37;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(145, 442);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 34);
            this.btndelete.TabIndex = 36;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(45, 442);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 34);
            this.btnadd.TabIndex = 35;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // picEmp
            // 
            this.picEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picEmp.Location = new System.Drawing.Point(45, 23);
            this.picEmp.Name = "picEmp";
            this.picEmp.Size = new System.Drawing.Size(134, 156);
            this.picEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmp.TabIndex = 34;
            this.picEmp.TabStop = false;
            // 
            // dtpdob
            // 
            this.dtpdob.CustomFormat = "dd/MM/yyyy";
            this.dtpdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdob.Location = new System.Drawing.Point(118, 333);
            this.dtpdob.Name = "dtpdob";
            this.dtpdob.Size = new System.Drawing.Size(214, 29);
            this.dtpdob.TabIndex = 33;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(243, 304);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(81, 25);
            this.rdFemale.TabIndex = 32;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(128, 304);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(64, 25);
            this.rdMale.TabIndex = 31;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // dgvEmp
            // 
            this.dgvEmp.AllowUserToAddRows = false;
            this.dgvEmp.AllowUserToDeleteRows = false;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Location = new System.Drawing.Point(360, 59);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.ReadOnly = true;
            this.dgvEmp.RowTemplate.Height = 80;
            this.dgvEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmp.Size = new System.Drawing.Size(533, 359);
            this.dgvEmp.TabIndex = 30;
            this.dgvEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellClick_1);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(118, 397);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(214, 29);
            this.txtpassword.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(118, 365);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(214, 29);
            this.txtusername.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Gender";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(118, 269);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(214, 29);
            this.txtname.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Name";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(118, 237);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(214, 29);
            this.txtid.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 521);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.picEmp);
            this.Controls.Add(this.dtpdob);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.picEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.PictureBox picEmp;
        private System.Windows.Forms.DateTimePicker dtpdob;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
    }
}