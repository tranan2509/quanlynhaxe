namespace WorkShop
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.menuStripManager = new System.Windows.Forms.MenuStrip();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceCarInParkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carRentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carForRentServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarOfCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCarRentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripManager
            // 
            this.menuStripManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.carToolStripMenuItem,
            this.contractToolStripMenuItem,
            this.accountToolStripMenuItem});
            this.menuStripManager.Location = new System.Drawing.Point(0, 0);
            this.menuStripManager.Name = "menuStripManager";
            this.menuStripManager.Size = new System.Drawing.Size(962, 24);
            this.menuStripManager.TabIndex = 0;
            this.menuStripManager.Text = "menuStripManager";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem,
            this.listStaffToolStripMenuItem});
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.managerToolStripMenuItem.Text = "Manage Staff";
            this.managerToolStripMenuItem.Click += new System.EventHandler(this.managerToolStripMenuItem_Click);
            // 
            // listStaffToolStripMenuItem
            // 
            this.listStaffToolStripMenuItem.Name = "listStaffToolStripMenuItem";
            this.listStaffToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.listStaffToolStripMenuItem.Text = "List Staff";
            this.listStaffToolStripMenuItem.Click += new System.EventHandler(this.listStaffToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCustomerToolStripMenuItem,
            this.listCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // manageCustomerToolStripMenuItem
            // 
            this.manageCustomerToolStripMenuItem.Name = "manageCustomerToolStripMenuItem";
            this.manageCustomerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.manageCustomerToolStripMenuItem.Text = "Manage Customer";
            this.manageCustomerToolStripMenuItem.Click += new System.EventHandler(this.manageCustomerToolStripMenuItem_Click);
            // 
            // listCustomerToolStripMenuItem
            // 
            this.listCustomerToolStripMenuItem.Name = "listCustomerToolStripMenuItem";
            this.listCustomerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listCustomerToolStripMenuItem.Text = "List Customer";
            this.listCustomerToolStripMenuItem.Click += new System.EventHandler(this.listCustomerToolStripMenuItem_Click);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priceCarInParkingToolStripMenuItem,
            this.carRentToolStripMenuItem});
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.carToolStripMenuItem.Text = "Car";
            // 
            // priceCarInParkingToolStripMenuItem
            // 
            this.priceCarInParkingToolStripMenuItem.Name = "priceCarInParkingToolStripMenuItem";
            this.priceCarInParkingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.priceCarInParkingToolStripMenuItem.Text = "Price Car In Parking";
            this.priceCarInParkingToolStripMenuItem.Click += new System.EventHandler(this.priceCarInParkingToolStripMenuItem_Click);
            // 
            // carRentToolStripMenuItem
            // 
            this.carRentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carForRentServiceToolStripMenuItem,
            this.addCarOfCompanyToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.listCarRentToolStripMenuItem});
            this.carRentToolStripMenuItem.Name = "carRentToolStripMenuItem";
            this.carRentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carRentToolStripMenuItem.Text = "Car Rent";
            // 
            // carForRentServiceToolStripMenuItem
            // 
            this.carForRentServiceToolStripMenuItem.Name = "carForRentServiceToolStripMenuItem";
            this.carForRentServiceToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.carForRentServiceToolStripMenuItem.Text = "Car for rent service";
            this.carForRentServiceToolStripMenuItem.Click += new System.EventHandler(this.carForRentServiceToolStripMenuItem_Click);
            // 
            // addCarOfCompanyToolStripMenuItem
            // 
            this.addCarOfCompanyToolStripMenuItem.Name = "addCarOfCompanyToolStripMenuItem";
            this.addCarOfCompanyToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.addCarOfCompanyToolStripMenuItem.Text = "Add Car of Company";
            this.addCarOfCompanyToolStripMenuItem.Click += new System.EventHandler(this.addCarOfCompanyToolStripMenuItem_Click);
            // 
            // listCarRentToolStripMenuItem
            // 
            this.listCarRentToolStripMenuItem.Name = "listCarRentToolStripMenuItem";
            this.listCarRentToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.listCarRentToolStripMenuItem.Text = "List Car Rent";
            this.listCarRentToolStripMenuItem.Click += new System.EventHandler(this.listCarRentToolStripMenuItem_Click);
            // 
            // contractToolStripMenuItem
            // 
            this.contractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listContractToolStripMenuItem,
            this.revenueToolStripMenuItem});
            this.contractToolStripMenuItem.Name = "contractToolStripMenuItem";
            this.contractToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.contractToolStripMenuItem.Text = "Contract";
            // 
            // listContractToolStripMenuItem
            // 
            this.listContractToolStripMenuItem.Name = "listContractToolStripMenuItem";
            this.listContractToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listContractToolStripMenuItem.Text = "List Contract";
            this.listContractToolStripMenuItem.Click += new System.EventHandler(this.listContractToolStripMenuItem_Click);
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            this.revenueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.revenueToolStripMenuItem.Text = "Revenue";
            this.revenueToolStripMenuItem.Click += new System.EventHandler(this.revenueToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.removeToolStripMenuItem.Text = "Remove Car of Company";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 546);
            this.Controls.Add(this.menuStripManager);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripManager;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.menuStripManager.ResumeLayout(false);
            this.menuStripManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripManager;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceCarInParkingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carRentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carForRentServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarOfCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listCarRentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}