namespace WorkShop
{
    partial class ListCarRentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCarRentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvCarRent = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSelectListType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarRent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvCarRent);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 551);
            this.panel1.TabIndex = 0;
            // 
            // dtgvCarRent
            // 
            this.dtgvCarRent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCarRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCarRent.Location = new System.Drawing.Point(3, 3);
            this.dtgvCarRent.Name = "dtgvCarRent";
            this.dtgvCarRent.Size = new System.Drawing.Size(1063, 545);
            this.dtgvCarRent.TabIndex = 0;
            this.dtgvCarRent.DoubleClick += new System.EventHandler(this.dtgvCarRent_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Location = new System.Drawing.Point(3, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 5);
            this.panel2.TabIndex = 3;
            // 
            // cmbSelectListType
            // 
            this.cmbSelectListType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSelectListType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSelectListType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSelectListType.FormattingEnabled = true;
            this.cmbSelectListType.Items.AddRange(new object[] {
            "List of vehicles under management",
            "List of car companies",
            "Vehicle listings can be rented",
            "List of vehicles being rented",
            "List of rented cars"});
            this.cmbSelectListType.Location = new System.Drawing.Point(719, 12);
            this.cmbSelectListType.Name = "cmbSelectListType";
            this.cmbSelectListType.Size = new System.Drawing.Size(362, 27);
            this.cmbSelectListType.TabIndex = 4;
            this.cmbSelectListType.SelectedIndexChanged += new System.EventHandler(this.cmbSelectListType_SelectedIndexChanged);
            // 
            // ListCarRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 633);
            this.Controls.Add(this.cmbSelectListType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListCarRentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListCarRentForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCarRent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbSelectListType;
        private System.Windows.Forms.DataGridView dtgvCarRent;
    }
}