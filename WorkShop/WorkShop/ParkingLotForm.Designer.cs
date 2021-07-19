namespace WorkShop
{
    partial class ParkingLotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkingLotForm));
            this.cmbDeviceCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerCamQRCode = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdMonth = new System.Windows.Forms.RadioButton();
            this.rdWeek = new System.Windows.Forms.RadioButton();
            this.rdDay = new System.Windows.Forms.RadioButton();
            this.rdHour = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdBicycle = new System.Windows.Forms.RadioButton();
            this.rdMotobike = new System.Windows.Forms.RadioButton();
            this.rdCar = new System.Windows.Forms.RadioButton();
            this.timerCountTime = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbIDStaff = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkTimeNow = new System.Windows.Forms.DateTimePicker();
            this.picBackOut = new System.Windows.Forms.PictureBox();
            this.picFrontOut = new System.Windows.Forms.PictureBox();
            this.picBackIn = new System.Windows.Forms.PictureBox();
            this.picFrontIn = new System.Windows.Forms.PictureBox();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDeviceCamera
            // 
            this.cmbDeviceCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeviceCamera.FormattingEnabled = true;
            this.cmbDeviceCamera.Location = new System.Drawing.Point(140, 17);
            this.cmbDeviceCamera.Name = "cmbDeviceCamera";
            this.cmbDeviceCamera.Size = new System.Drawing.Size(180, 28);
            this.cmbDeviceCamera.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scan QR Code";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(22, 355);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(134, 26);
            this.txtCode.TabIndex = 6;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(341, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 28);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // timerCamQRCode
            // 
            this.timerCamQRCode.Enabled = true;
            this.timerCamQRCode.Tick += new System.EventHandler(this.timerCamQRCode_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdMonth);
            this.panel1.Controls.Add(this.rdWeek);
            this.panel1.Controls.Add(this.rdDay);
            this.panel1.Controls.Add(this.rdHour);
            this.panel1.Location = new System.Drawing.Point(160, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 144);
            this.panel1.TabIndex = 10;
            // 
            // rdMonth
            // 
            this.rdMonth.AutoSize = true;
            this.rdMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMonth.Location = new System.Drawing.Point(3, 78);
            this.rdMonth.Name = "rdMonth";
            this.rdMonth.Size = new System.Drawing.Size(72, 24);
            this.rdMonth.TabIndex = 5;
            this.rdMonth.Text = "Month";
            this.rdMonth.UseVisualStyleBackColor = true;
            // 
            // rdWeek
            // 
            this.rdWeek.AutoSize = true;
            this.rdWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdWeek.Location = new System.Drawing.Point(3, 52);
            this.rdWeek.Name = "rdWeek";
            this.rdWeek.Size = new System.Drawing.Size(68, 24);
            this.rdWeek.TabIndex = 2;
            this.rdWeek.Text = "Week";
            this.rdWeek.UseVisualStyleBackColor = true;
            // 
            // rdDay
            // 
            this.rdDay.AutoSize = true;
            this.rdDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDay.Location = new System.Drawing.Point(3, 26);
            this.rdDay.Name = "rdDay";
            this.rdDay.Size = new System.Drawing.Size(55, 24);
            this.rdDay.TabIndex = 1;
            this.rdDay.Text = "Day";
            this.rdDay.UseVisualStyleBackColor = true;
            // 
            // rdHour
            // 
            this.rdHour.AutoSize = true;
            this.rdHour.Checked = true;
            this.rdHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHour.Location = new System.Drawing.Point(3, 3);
            this.rdHour.Name = "rdHour";
            this.rdHour.Size = new System.Drawing.Size(62, 24);
            this.rdHour.TabIndex = 0;
            this.rdHour.TabStop = true;
            this.rdHour.Text = "Hour";
            this.rdHour.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdBicycle);
            this.panel2.Controls.Add(this.rdMotobike);
            this.panel2.Controls.Add(this.rdCar);
            this.panel2.Location = new System.Drawing.Point(20, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 99);
            this.panel2.TabIndex = 11;
            // 
            // rdBicycle
            // 
            this.rdBicycle.AutoSize = true;
            this.rdBicycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBicycle.Location = new System.Drawing.Point(3, 49);
            this.rdBicycle.Name = "rdBicycle";
            this.rdBicycle.Size = new System.Drawing.Size(76, 24);
            this.rdBicycle.TabIndex = 2;
            this.rdBicycle.Text = "Bicycle";
            this.rdBicycle.UseVisualStyleBackColor = true;
            // 
            // rdMotobike
            // 
            this.rdMotobike.AutoSize = true;
            this.rdMotobike.Checked = true;
            this.rdMotobike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMotobike.Location = new System.Drawing.Point(3, 26);
            this.rdMotobike.Name = "rdMotobike";
            this.rdMotobike.Size = new System.Drawing.Size(92, 24);
            this.rdMotobike.TabIndex = 1;
            this.rdMotobike.TabStop = true;
            this.rdMotobike.Text = "Motobike";
            this.rdMotobike.UseVisualStyleBackColor = true;
            // 
            // rdCar
            // 
            this.rdCar.AutoSize = true;
            this.rdCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCar.Location = new System.Drawing.Point(3, 3);
            this.rdCar.Name = "rdCar";
            this.rdCar.Size = new System.Drawing.Size(52, 24);
            this.rdCar.TabIndex = 0;
            this.rdCar.Text = "Car";
            this.rdCar.UseVisualStyleBackColor = true;
            // 
            // timerCountTime
            // 
            this.timerCountTime.Interval = 1000;
            this.timerCountTime.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbIDStaff);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(738, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 37);
            this.panel3.TabIndex = 14;
            // 
            // lbIDStaff
            // 
            this.lbIDStaff.AutoSize = true;
            this.lbIDStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDStaff.Location = new System.Drawing.Point(70, 8);
            this.lbIDStaff.Name = "lbIDStaff";
            this.lbIDStaff.Size = new System.Drawing.Size(18, 20);
            this.lbIDStaff.TabIndex = 17;
            this.lbIDStaff.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "StaffID:";
            // 
            // dtpkTimeNow
            // 
            this.dtpkTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkTimeNow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTimeNow.Location = new System.Drawing.Point(445, 19);
            this.dtpkTimeNow.Name = "dtpkTimeNow";
            this.dtpkTimeNow.Size = new System.Drawing.Size(232, 26);
            this.dtpkTimeNow.TabIndex = 15;
            // 
            // picBackOut
            // 
            this.picBackOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBackOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBackOut.Location = new System.Drawing.Point(597, 305);
            this.picBackOut.Name = "picBackOut";
            this.picBackOut.Size = new System.Drawing.Size(250, 250);
            this.picBackOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackOut.TabIndex = 12;
            this.picBackOut.TabStop = false;
            // 
            // picFrontOut
            // 
            this.picFrontOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFrontOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFrontOut.Location = new System.Drawing.Point(341, 305);
            this.picFrontOut.Name = "picFrontOut";
            this.picFrontOut.Size = new System.Drawing.Size(250, 250);
            this.picFrontOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrontOut.TabIndex = 11;
            this.picFrontOut.TabStop = false;
            // 
            // picBackIn
            // 
            this.picBackIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBackIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBackIn.Image = global::WorkShop.Properties.Resources.alert_attention_caution_danger_error_notification_warning_icon_123234;
            this.picBackIn.Location = new System.Drawing.Point(597, 49);
            this.picBackIn.Name = "picBackIn";
            this.picBackIn.Size = new System.Drawing.Size(250, 250);
            this.picBackIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackIn.TabIndex = 9;
            this.picBackIn.TabStop = false;
            // 
            // picFrontIn
            // 
            this.picFrontIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFrontIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFrontIn.Image = global::WorkShop.Properties.Resources.alert_attention_caution_danger_error_notification_warning_icon_123234;
            this.picFrontIn.Location = new System.Drawing.Point(341, 49);
            this.picFrontIn.Name = "picFrontIn";
            this.picFrontIn.Size = new System.Drawing.Size(250, 250);
            this.picFrontIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFrontIn.TabIndex = 8;
            this.picFrontIn.TabStop = false;
            // 
            // picQRCode
            // 
            this.picQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQRCode.Location = new System.Drawing.Point(20, 49);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(300, 300);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCode.TabIndex = 5;
            this.picQRCode.TabStop = false;
            // 
            // ParkingLotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 577);
            this.Controls.Add(this.dtpkTimeNow);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picBackOut);
            this.Controls.Add(this.picFrontOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picBackIn);
            this.Controls.Add(this.picFrontIn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.picQRCode);
            this.Controls.Add(this.cmbDeviceCamera);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(929, 616);
            this.Name = "ParkingLotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParkingLot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParkingLot_FormClosing);
            this.Load += new System.EventHandler(this.ParkingLot_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFrontIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.ComboBox cmbDeviceCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picFrontIn;
        private System.Windows.Forms.PictureBox picBackIn;
        private System.Windows.Forms.Timer timerCamQRCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdWeek;
        private System.Windows.Forms.RadioButton rdDay;
        private System.Windows.Forms.RadioButton rdHour;
        private System.Windows.Forms.PictureBox picFrontOut;
        private System.Windows.Forms.PictureBox picBackOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdBicycle;
        private System.Windows.Forms.RadioButton rdMotobike;
        private System.Windows.Forms.RadioButton rdCar;
        private System.Windows.Forms.Timer timerCountTime;
        private System.Windows.Forms.RadioButton rdMonth;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkTimeNow;
        private System.Windows.Forms.Label lbIDStaff;
    }
}