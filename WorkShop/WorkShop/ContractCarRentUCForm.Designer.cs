namespace WorkShop
{
    partial class ContractCarRentUCForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nmCost = new System.Windows.Forms.NumericUpDown();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.picBackCar = new System.Windows.Forms.PictureBox();
            this.picFrontCar = new System.Windows.Forms.PictureBox();
            this.pnlInfoCar = new System.Windows.Forms.Panel();
            this.lbColor = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbCarForRent = new System.Windows.Forms.Label();
            this.lbLicensePlates = new System.Windows.Forms.Label();
            this.lbCarHireSubjects = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlInfoCustomer = new System.Windows.Forms.Panel();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbIdentityNumber = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.lbTodate = new System.Windows.Forms.Label();
            this.timerToDate = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCost)).BeginInit();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontCar)).BeginInit();
            this.pnlInfoCar.SuspendLayout();
            this.pnlInfoCustomer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnlImage);
            this.panel1.Controls.Add(this.pnlInfoCar);
            this.panel1.Controls.Add(this.pnlInfoCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 583);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbTotalCost);
            this.panel3.Controls.Add(this.dtpkToDate);
            this.panel3.Controls.Add(this.dtpkFromDate);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.nmCost);
            this.panel3.Location = new System.Drawing.Point(13, 499);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 81);
            this.panel3.TabIndex = 32;
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.AutoSize = true;
            this.lbTotalCost.Location = new System.Drawing.Point(431, 14);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(79, 19);
            this.lbTotalCost.TabIndex = 15;
            this.lbTotalCost.Text = "lbTotalCost";
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkToDate.Location = new System.Drawing.Point(273, 43);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(136, 26);
            this.dtpkToDate.TabIndex = 14;
            this.dtpkToDate.ValueChanged += new System.EventHandler(this.dtpkToDate_ValueChanged);
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkFromDate.Location = new System.Drawing.Point(73, 43);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(136, 26);
            this.dtpkFromDate.TabIndex = 13;
            this.dtpkFromDate.ValueChanged += new System.EventHandler(this.dtpkFromDate_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(243, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 19);
            this.label16.TabIndex = 12;
            this.label16.Text = "To:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 19);
            this.label15.TabIndex = 11;
            this.label15.Text = "From:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(343, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 19);
            this.label14.TabIndex = 10;
            this.label14.Text = "Total Cost:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(215, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 19);
            this.label13.TabIndex = 9;
            this.label13.Text = "/day";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 19);
            this.label12.TabIndex = 9;
            this.label12.Text = "Car rental Cost:";
            // 
            // nmCost
            // 
            this.nmCost.Location = new System.Drawing.Point(114, 12);
            this.nmCost.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nmCost.Name = "nmCost";
            this.nmCost.Size = new System.Drawing.Size(95, 26);
            this.nmCost.TabIndex = 0;
            this.nmCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmCost.ValueChanged += new System.EventHandler(this.nmCost_ValueChanged);
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.label11);
            this.pnlImage.Controls.Add(this.picBackCar);
            this.pnlImage.Controls.Add(this.picFrontCar);
            this.pnlImage.Location = new System.Drawing.Point(13, 315);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(555, 178);
            this.pnlImage.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Picture:";
            // 
            // picBackCar
            // 
            this.picBackCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picBackCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBackCar.Location = new System.Drawing.Point(305, 8);
            this.picBackCar.Name = "picBackCar";
            this.picBackCar.Size = new System.Drawing.Size(207, 167);
            this.picBackCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackCar.TabIndex = 1;
            this.picBackCar.TabStop = false;
            // 
            // picFrontCar
            // 
            this.picFrontCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picFrontCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFrontCar.Location = new System.Drawing.Point(92, 8);
            this.picFrontCar.Name = "picFrontCar";
            this.picFrontCar.Size = new System.Drawing.Size(207, 167);
            this.picFrontCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrontCar.TabIndex = 0;
            this.picFrontCar.TabStop = false;
            // 
            // pnlInfoCar
            // 
            this.pnlInfoCar.Controls.Add(this.lbColor);
            this.pnlInfoCar.Controls.Add(this.lbType);
            this.pnlInfoCar.Controls.Add(this.lbCarForRent);
            this.pnlInfoCar.Controls.Add(this.lbLicensePlates);
            this.pnlInfoCar.Controls.Add(this.lbCarHireSubjects);
            this.pnlInfoCar.Controls.Add(this.label10);
            this.pnlInfoCar.Controls.Add(this.label9);
            this.pnlInfoCar.Controls.Add(this.label8);
            this.pnlInfoCar.Controls.Add(this.label7);
            this.pnlInfoCar.Controls.Add(this.label6);
            this.pnlInfoCar.Location = new System.Drawing.Point(13, 225);
            this.pnlInfoCar.Name = "pnlInfoCar";
            this.pnlInfoCar.Size = new System.Drawing.Size(555, 84);
            this.pnlInfoCar.TabIndex = 30;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(489, 47);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(55, 19);
            this.lbColor.TabIndex = 13;
            this.lbColor.Text = "lbColor";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(349, 47);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(50, 19);
            this.lbType.TabIndex = 12;
            this.lbType.Text = "lbType";
            // 
            // lbCarForRent
            // 
            this.lbCarForRent.AutoSize = true;
            this.lbCarForRent.Location = new System.Drawing.Point(390, 12);
            this.lbCarForRent.Name = "lbCarForRent";
            this.lbCarForRent.Size = new System.Drawing.Size(93, 19);
            this.lbCarForRent.TabIndex = 11;
            this.lbCarForRent.Text = "lbCarForRent";
            // 
            // lbLicensePlates
            // 
            this.lbLicensePlates.AutoSize = true;
            this.lbLicensePlates.Location = new System.Drawing.Point(131, 47);
            this.lbLicensePlates.Name = "lbLicensePlates";
            this.lbLicensePlates.Size = new System.Drawing.Size(102, 19);
            this.lbLicensePlates.TabIndex = 10;
            this.lbLicensePlates.Text = "lbLicensePlates";
            // 
            // lbCarHireSubjects
            // 
            this.lbCarHireSubjects.AutoSize = true;
            this.lbCarHireSubjects.Location = new System.Drawing.Point(131, 12);
            this.lbCarHireSubjects.Name = "lbCarHireSubjects";
            this.lbCarHireSubjects.Size = new System.Drawing.Size(121, 19);
            this.lbCarHireSubjects.TabIndex = 9;
            this.lbCarHireSubjects.Text = "lbCarHireSubjects";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Color:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "License Plates:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Car for rent:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Car hire subjects:";
            // 
            // pnlInfoCustomer
            // 
            this.pnlInfoCustomer.Controls.Add(this.lbAddress);
            this.pnlInfoCustomer.Controls.Add(this.lbIdentityNumber);
            this.pnlInfoCustomer.Controls.Add(this.lbPhone);
            this.pnlInfoCustomer.Controls.Add(this.lbCustomerName);
            this.pnlInfoCustomer.Controls.Add(this.label5);
            this.pnlInfoCustomer.Controls.Add(this.label4);
            this.pnlInfoCustomer.Controls.Add(this.label3);
            this.pnlInfoCustomer.Controls.Add(this.label2);
            this.pnlInfoCustomer.Location = new System.Drawing.Point(13, 91);
            this.pnlInfoCustomer.Name = "pnlInfoCustomer";
            this.pnlInfoCustomer.Size = new System.Drawing.Size(555, 128);
            this.pnlInfoCustomer.TabIndex = 29;
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
            this.lbPhone.Location = new System.Drawing.Point(390, 13);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(177, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Contract Rent Car";
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
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 614);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 19);
            this.label17.TabIndex = 4;
            this.label17.Text = "To Date:";
            // 
            // lbTodate
            // 
            this.lbTodate.AutoSize = true;
            this.lbTodate.Location = new System.Drawing.Point(92, 614);
            this.lbTodate.Name = "lbTodate";
            this.lbTodate.Size = new System.Drawing.Size(65, 19);
            this.lbTodate.TabIndex = 16;
            this.lbTodate.Text = "lbToDate";
            // 
            // timerToDate
            // 
            this.timerToDate.Interval = 1000;
            this.timerToDate.Tick += new System.EventHandler(this.timerToDate_Tick);
            // 
            // ContractCarRentUCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTodate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContractCarRentUCForm";
            this.Size = new System.Drawing.Size(600, 650);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCost)).EndInit();
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontCar)).EndInit();
            this.pnlInfoCar.ResumeLayout(false);
            this.pnlInfoCar.PerformLayout();
            this.pnlInfoCustomer.ResumeLayout(false);
            this.pnlInfoCustomer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Panel pnlInfoCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlInfoCar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picBackCar;
        private System.Windows.Forms.PictureBox picFrontCar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmCost;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbTotalCost;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbCarForRent;
        private System.Windows.Forms.Label lbLicensePlates;
        private System.Windows.Forms.Label lbCarHireSubjects;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbIdentityNumber;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbTodate;
        private System.Windows.Forms.Timer timerToDate;
    }
}
