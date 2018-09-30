namespace BookstoreM3
{
    partial class frmSale
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtproID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboproName = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsubTotal = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpaidkh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpaidus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtreturnkh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtreturnus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtpaymentus = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblpayment = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtpaymentkh = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pro_ID";
            // 
            // txtproID
            // 
            this.txtproID.Location = new System.Drawing.Point(105, 67);
            this.txtproID.Name = "txtproID";
            this.txtproID.Size = new System.Drawing.Size(159, 32);
            this.txtproID.TabIndex = 1;
            this.txtproID.TextChanged += new System.EventHandler(this.txtproID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pro_Name";
            // 
            // cboproName
            // 
            this.cboproName.FormattingEnabled = true;
            this.cboproName.Location = new System.Drawing.Point(379, 67);
            this.cboproName.Name = "cboproName";
            this.cboproName.Size = new System.Drawing.Size(167, 31);
            this.cboproName.TabIndex = 4;
            this.cboproName.SelectionChangeCommitted += new System.EventHandler(this.cboproName_SelectionChangeCommitted);
            // 
            // cboCategory
            // 
            this.cboCategory.Enabled = false;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(680, 67);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(167, 31);
            this.cboCategory.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(105, 125);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(159, 32);
            this.txtprice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unit Price";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(379, 126);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(159, 32);
            this.txtqty.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(590, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 39);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(720, 124);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 35);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "sub Total";
            // 
            // txtsubTotal
            // 
            this.txtsubTotal.Location = new System.Drawing.Point(705, 211);
            this.txtsubTotal.Name = "txtsubTotal";
            this.txtsubTotal.ReadOnly = true;
            this.txtsubTotal.Size = new System.Drawing.Size(167, 32);
            this.txtsubTotal.TabIndex = 14;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(705, 249);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(167, 32);
            this.txtdiscount.TabIndex = 16;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscount_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Discount(%)";
            // 
            // txtpaidkh
            // 
            this.txtpaidkh.Location = new System.Drawing.Point(705, 360);
            this.txtpaidkh.Name = "txtpaidkh";
            this.txtpaidkh.Size = new System.Drawing.Size(167, 32);
            this.txtpaidkh.TabIndex = 18;
            this.txtpaidkh.TextChanged += new System.EventHandler(this.txtpaidkh_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(571, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Paid Khmer";
            // 
            // txtpaidus
            // 
            this.txtpaidus.Location = new System.Drawing.Point(705, 398);
            this.txtpaidus.Name = "txtpaidus";
            this.txtpaidus.Size = new System.Drawing.Size(167, 32);
            this.txtpaidus.TabIndex = 20;
            this.txtpaidus.Text = "0";
            this.txtpaidus.TextChanged += new System.EventHandler(this.txtpaidus_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(571, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Paid US($)";
            // 
            // txtreturnkh
            // 
            this.txtreturnkh.Location = new System.Drawing.Point(705, 436);
            this.txtreturnkh.Name = "txtreturnkh";
            this.txtreturnkh.ReadOnly = true;
            this.txtreturnkh.Size = new System.Drawing.Size(167, 32);
            this.txtreturnkh.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(571, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "Return Kh";
            // 
            // txtreturnus
            // 
            this.txtreturnus.Location = new System.Drawing.Point(705, 474);
            this.txtreturnus.Name = "txtreturnus";
            this.txtreturnus.ReadOnly = true;
            this.txtreturnus.Size = new System.Drawing.Size(167, 32);
            this.txtreturnus.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(571, 474);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "Return US($)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(723, 512);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 36);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtpaymentus
            // 
            this.txtpaymentus.Location = new System.Drawing.Point(705, 323);
            this.txtpaymentus.Name = "txtpaymentus";
            this.txtpaymentus.ReadOnly = true;
            this.txtpaymentus.Size = new System.Drawing.Size(167, 32);
            this.txtpaymentus.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(571, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "Payment Kh";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblpayment
            // 
            this.lblpayment.AutoSize = true;
            this.lblpayment.Location = new System.Drawing.Point(691, 178);
            this.lblpayment.Name = "lblpayment";
            this.lblpayment.Size = new System.Drawing.Size(79, 23);
            this.lblpayment.TabIndex = 29;
            this.lblpayment.Text = "payment";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(568, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 30;
            this.label14.Text = "paymentID";
            // 
            // txtpaymentkh
            // 
            this.txtpaymentkh.Location = new System.Drawing.Point(704, 286);
            this.txtpaymentkh.Name = "txtpaymentkh";
            this.txtpaymentkh.ReadOnly = true;
            this.txtpaymentkh.Size = new System.Drawing.Size(167, 32);
            this.txtpaymentkh.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(562, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 23);
            this.label13.TabIndex = 33;
            this.label13.Text = "Payment US($)";
            // 
            // dgvSale
            // 
            this.dgvSale.AllowUserToAddRows = false;
            this.dgvSale.AllowUserToDeleteRows = false;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvSale.EnableHeadersVisualStyles = false;
            this.dgvSale.Location = new System.Drawing.Point(0, 178);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.ReadOnly = true;
            this.dgvSale.RowHeadersVisible = false;
            this.dgvSale.RowTemplate.Height = 30;
            this.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSale.Size = new System.Drawing.Size(556, 328);
            this.dgvSale.TabIndex = 34;
            this.dgvSale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSale_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cateoory";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Amount";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cat_ID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(307, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(288, 40);
            this.label15.TabIndex = 35;
            this.label15.Text = "Information of Sale";
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(883, 560);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dgvSale);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtpaymentkh);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblpayment);
            this.Controls.Add(this.txtpaymentus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtreturnus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtreturnkh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtpaidus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtpaidkh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsubTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboproName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtproID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmSale";
            this.Text = "frmSale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtproID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboproName;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsubTotal;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpaidkh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpaidus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtreturnkh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtreturnus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtpaymentus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblpayment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtpaymentkh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label15;
    }
}