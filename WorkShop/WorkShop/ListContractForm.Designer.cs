namespace WorkShop
{
    partial class ListContractForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picSreach = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtgvListContract = new System.Windows.Forms.DataGridView();
            this.toolTipListContract = new System.Windows.Forms.ToolTip(this.components);
            this.dtpkTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dtpkTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdTimeIn = new System.Windows.Forms.RadioButton();
            this.rdTimeOut = new System.Windows.Forms.RadioButton();
            this.picSearchTime = new System.Windows.Forms.PictureBox();
            this.rdAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picSreach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListContract)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Lime;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(452, 559);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 38);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // picSreach
            // 
            this.picSreach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSreach.Image = global::WorkShop.Properties.Resources.loupe_78956;
            this.picSreach.Location = new System.Drawing.Point(984, 12);
            this.picSreach.Name = "picSreach";
            this.picSreach.Size = new System.Drawing.Size(30, 30);
            this.picSreach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSreach.TabIndex = 14;
            this.picSreach.TabStop = false;
            this.picSreach.Click += new System.EventHandler(this.picSreach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(648, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Info Search: ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(749, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(229, 26);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dtgvListContract
            // 
            this.dtgvListContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListContract.Location = new System.Drawing.Point(12, 58);
            this.dtgvListContract.Name = "dtgvListContract";
            this.dtgvListContract.Size = new System.Drawing.Size(1002, 495);
            this.dtgvListContract.TabIndex = 11;
            // 
            // dtpkTimeStart
            // 
            this.dtpkTimeStart.CustomFormat = "dd/MM/yyyy";
            this.dtpkTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTimeStart.Location = new System.Drawing.Point(230, 4);
            this.dtpkTimeStart.Name = "dtpkTimeStart";
            this.dtpkTimeStart.Size = new System.Drawing.Size(130, 26);
            this.dtpkTimeStart.TabIndex = 16;
            // 
            // dtpkTimeEnd
            // 
            this.dtpkTimeEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpkTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkTimeEnd.Location = new System.Drawing.Point(366, 4);
            this.dtpkTimeEnd.Name = "dtpkTimeEnd";
            this.dtpkTimeEnd.Size = new System.Drawing.Size(130, 26);
            this.dtpkTimeEnd.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdAll);
            this.panel1.Controls.Add(this.dtpkTimeEnd);
            this.panel1.Controls.Add(this.rdTimeIn);
            this.panel1.Controls.Add(this.picSearchTime);
            this.panel1.Controls.Add(this.dtpkTimeStart);
            this.panel1.Controls.Add(this.rdTimeOut);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 40);
            this.panel1.TabIndex = 18;
            // 
            // rdTimeIn
            // 
            this.rdTimeIn.AutoSize = true;
            this.rdTimeIn.Location = new System.Drawing.Point(54, 8);
            this.rdTimeIn.Name = "rdTimeIn";
            this.rdTimeIn.Size = new System.Drawing.Size(72, 23);
            this.rdTimeIn.TabIndex = 0;
            this.rdTimeIn.Text = "Time In";
            this.rdTimeIn.UseVisualStyleBackColor = true;
            this.rdTimeIn.CheckedChanged += new System.EventHandler(this.rdTimeIn_CheckedChanged);
            // 
            // rdTimeOut
            // 
            this.rdTimeOut.AutoSize = true;
            this.rdTimeOut.Location = new System.Drawing.Point(132, 7);
            this.rdTimeOut.Name = "rdTimeOut";
            this.rdTimeOut.Size = new System.Drawing.Size(83, 23);
            this.rdTimeOut.TabIndex = 1;
            this.rdTimeOut.Text = "Time Out";
            this.rdTimeOut.UseVisualStyleBackColor = true;
            this.rdTimeOut.CheckedChanged += new System.EventHandler(this.rdTimeOut_CheckedChanged);
            // 
            // picSearchTime
            // 
            this.picSearchTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearchTime.Image = global::WorkShop.Properties.Resources.loupe_78956;
            this.picSearchTime.Location = new System.Drawing.Point(501, 2);
            this.picSearchTime.Name = "picSearchTime";
            this.picSearchTime.Size = new System.Drawing.Size(30, 30);
            this.picSearchTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchTime.TabIndex = 18;
            this.picSearchTime.TabStop = false;
            this.picSearchTime.Click += new System.EventHandler(this.picSearchTime_Click);
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Checked = true;
            this.rdAll.Location = new System.Drawing.Point(5, 7);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(44, 23);
            this.rdAll.TabIndex = 19;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "All";
            this.rdAll.UseVisualStyleBackColor = true;
            this.rdAll.CheckedChanged += new System.EventHandler(this.rdAll_CheckedChanged);
            // 
            // ListContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 609);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.picSreach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtgvListContract);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListContractForm";
            ((System.ComponentModel.ISupportInitialize)(this.picSreach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListContract)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox picSreach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dtgvListContract;
        private System.Windows.Forms.ToolTip toolTipListContract;
        private System.Windows.Forms.DateTimePicker dtpkTimeStart;
        private System.Windows.Forms.DateTimePicker dtpkTimeEnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.RadioButton rdTimeIn;
        private System.Windows.Forms.PictureBox picSearchTime;
        private System.Windows.Forms.RadioButton rdTimeOut;
    }
}