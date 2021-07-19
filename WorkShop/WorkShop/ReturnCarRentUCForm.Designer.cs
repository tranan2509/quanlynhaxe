namespace WorkShop
{
    partial class ReturnCarRentUCForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlInfoCustomer = new System.Windows.Forms.Panel();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbIdentityNumber = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbQRCode = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbStaffSigned = new System.Windows.Forms.Label();
            this.lbTodate = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvCarRent = new System.Windows.Forms.DataGridView();
            this.timerToDate = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlInfoCustomer.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarRent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbTodate);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lbStaffSigned);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pnlInfoCustomer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 584);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Controls.Add(this.btnFinish);
            this.panel2.Location = new System.Drawing.Point(325, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 49);
            this.panel2.TabIndex = 2;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Location = new System.Drawing.Point(5, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(124, 40);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Yellow;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Location = new System.Drawing.Point(135, 3);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(124, 40);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(186, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Return The Car";
            // 
            // pnlInfoCustomer
            // 
            this.pnlInfoCustomer.Controls.Add(this.lbQRCode);
            this.pnlInfoCustomer.Controls.Add(this.label6);
            this.pnlInfoCustomer.Controls.Add(this.lbAddress);
            this.pnlInfoCustomer.Controls.Add(this.lbIdentityNumber);
            this.pnlInfoCustomer.Controls.Add(this.lbPhone);
            this.pnlInfoCustomer.Controls.Add(this.lbCustomerName);
            this.pnlInfoCustomer.Controls.Add(this.label5);
            this.pnlInfoCustomer.Controls.Add(this.label4);
            this.pnlInfoCustomer.Controls.Add(this.label3);
            this.pnlInfoCustomer.Controls.Add(this.label1);
            this.pnlInfoCustomer.Location = new System.Drawing.Point(12, 105);
            this.pnlInfoCustomer.Name = "pnlInfoCustomer";
            this.pnlInfoCustomer.Size = new System.Drawing.Size(555, 128);
            this.pnlInfoCustomer.TabIndex = 30;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(131, 100);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(71, 19);
            this.lbAddress.TabIndex = 7;
            this.lbAddress.Text = "lbAddress";
            // 
            // lbIdentityNumber
            // 
            this.lbIdentityNumber.AutoSize = true;
            this.lbIdentityNumber.Location = new System.Drawing.Point(131, 58);
            this.lbIdentityNumber.Name = "lbIdentityNumber";
            this.lbIdentityNumber.Size = new System.Drawing.Size(115, 19);
            this.lbIdentityNumber.TabIndex = 6;
            this.lbIdentityNumber.Text = "lbIdentityNumber";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(412, 13);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(58, 19);
            this.lbPhone.TabIndex = 5;
            this.lbPhone.Text = "lbPhone";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(131, 13);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(116, 19);
            this.lbCustomerName.TabIndex = 4;
            this.lbCustomerName.Text = "lbCustomerName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Identity Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "QR Code:";
            // 
            // lbQRCode
            // 
            this.lbQRCode.AutoSize = true;
            this.lbQRCode.Location = new System.Drawing.Point(412, 58);
            this.lbQRCode.Name = "lbQRCode";
            this.lbQRCode.Size = new System.Drawing.Size(76, 19);
            this.lbQRCode.TabIndex = 9;
            this.lbQRCode.Text = "lbQRCode";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(402, 507);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 19);
            this.label13.TabIndex = 10;
            this.label13.Text = "Staff Signed";
            // 
            // lbStaffSigned
            // 
            this.lbStaffSigned.AutoSize = true;
            this.lbStaffSigned.Location = new System.Drawing.Point(402, 537);
            this.lbStaffSigned.Name = "lbStaffSigned";
            this.lbStaffSigned.Size = new System.Drawing.Size(89, 19);
            this.lbStaffSigned.TabIndex = 33;
            this.lbStaffSigned.Text = "lbStaffSigned";
            // 
            // lbTodate
            // 
            this.lbTodate.AutoSize = true;
            this.lbTodate.Location = new System.Drawing.Point(72, 537);
            this.lbTodate.Name = "lbTodate";
            this.lbTodate.Size = new System.Drawing.Size(65, 19);
            this.lbTodate.TabIndex = 35;
            this.lbTodate.Text = "lbToDate";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 537);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 19);
            this.label17.TabIndex = 34;
            this.label17.Text = "To Date:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvCarRent);
            this.panel3.Location = new System.Drawing.Point(12, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 252);
            this.panel3.TabIndex = 36;
            // 
            // dtgvCarRent
            // 
            this.dtgvCarRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCarRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCarRent.Location = new System.Drawing.Point(4, 3);
            this.dtgvCarRent.Name = "dtgvCarRent";
            this.dtgvCarRent.Size = new System.Drawing.Size(548, 246);
            this.dtgvCarRent.TabIndex = 0;
            this.dtgvCarRent.DoubleClick += new System.EventHandler(this.dtgvCarRent_DoubleClick);
            // 
            // timerToDate
            // 
            this.timerToDate.Interval = 1000;
            this.timerToDate.Tick += new System.EventHandler(this.timerToDate_Tick);
            // 
            // ReturnCarRentUCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReturnCarRentUCForm";
            this.Size = new System.Drawing.Size(600, 650);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlInfoCustomer.ResumeLayout(false);
            this.pnlInfoCustomer.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarRent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlInfoCustomer;
        private System.Windows.Forms.Label lbQRCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbIdentityNumber;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStaffSigned;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTodate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvCarRent;
        private System.Windows.Forms.Timer timerToDate;
    }
}
