namespace WorkShop
{
    partial class ListStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListStaffForm));
            this.dtgvListStaff = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipListStaff = new System.Windows.Forms.ToolTip(this.components);
            this.picSreach = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSreach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvListStaff
            // 
            this.dtgvListStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListStaff.Location = new System.Drawing.Point(12, 58);
            this.dtgvListStaff.Name = "dtgvListStaff";
            this.dtgvListStaff.Size = new System.Drawing.Size(1002, 495);
            this.dtgvListStaff.TabIndex = 1;
            this.dtgvListStaff.DoubleClick += new System.EventHandler(this.dtgvListStaff_DoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(749, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(229, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(648, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Info Search: ";
            this.toolTipListStaff.SetToolTip(this.label1, "ID, First Name, Phone, ID Number");
            // 
            // picSreach
            // 
            this.picSreach.Image = global::WorkShop.Properties.Resources.loupe_78956;
            this.picSreach.Location = new System.Drawing.Point(984, 12);
            this.picSreach.Name = "picSreach";
            this.picSreach.Size = new System.Drawing.Size(30, 30);
            this.picSreach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSreach.TabIndex = 4;
            this.picSreach.TabStop = false;
            this.picSreach.Click += new System.EventHandler(this.picSreach_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Lime;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(452, 559);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 38);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ListStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 609);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.picSreach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtgvListStaff);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListStaffForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSreach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvListStaff;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipListStaff;
        private System.Windows.Forms.PictureBox picSreach;
        private System.Windows.Forms.Button btnRefresh;
    }
}