namespace WorkShop
{
    partial class RentCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentCarForm));
            this.pnlRentCar = new System.Windows.Forms.Panel();
            this.cmbChoose = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlRentCar
            // 
            this.pnlRentCar.Location = new System.Drawing.Point(12, 57);
            this.pnlRentCar.Name = "pnlRentCar";
            this.pnlRentCar.Size = new System.Drawing.Size(600, 650);
            this.pnlRentCar.TabIndex = 0;
            // 
            // cmbChoose
            // 
            this.cmbChoose.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbChoose.FormattingEnabled = true;
            this.cmbChoose.Items.AddRange(new object[] {
            "Car Rental Customers",
            "Car Rental Company",
            "Return The Car"});
            this.cmbChoose.Location = new System.Drawing.Point(357, 12);
            this.cmbChoose.Name = "cmbChoose";
            this.cmbChoose.Size = new System.Drawing.Size(255, 27);
            this.cmbChoose.TabIndex = 1;
            this.cmbChoose.SelectedIndexChanged += new System.EventHandler(this.cmbChoose_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 5);
            this.panel1.TabIndex = 2;
            // 
            // RentCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbChoose);
            this.Controls.Add(this.pnlRentCar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RentCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentCarForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRentCar;
        private System.Windows.Forms.ComboBox cmbChoose;
        private System.Windows.Forms.Panel panel1;
    }
}