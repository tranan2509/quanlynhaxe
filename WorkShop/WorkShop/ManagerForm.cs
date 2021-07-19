using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop.DTO;

namespace WorkShop
{
    public partial class ManagerForm : Form
    {
        private Staff staffManager;
        public Staff StaffManager
        {
            get { return staffManager; }
            set { staffManager = value; LoadStaff(StaffManager); }
        }
        
        public ManagerForm()
        {
            InitializeComponent();
        }

        #region Methods
        void LoadStaff(Staff staff)
        {
            accountToolStripMenuItem.Text = "Account (" + staff.Fname + ")";
        }
        #endregion

        #region Events

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffForm staffF = new StaffForm();
            staffF.ShowDialog(this);
        }

        #endregion

        private void listStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListStaffForm lStaffF = new ListStaffForm();
            lStaffF.ShowDialog();
        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoCusomerParkingForm infoCusomerF = new InfoCusomerParkingForm();
            infoCusomerF.IsAdmin = true;
            infoCusomerF.ShowDialog();
        }

        private void listCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCustomerForm lCustomerF = new ListCustomerForm();
            lCustomerF.ShowDialog();
        }

        private void priceCarInParkingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PriceCarInParkingForm priceF = new PriceCarInParkingForm();
            priceF.ShowDialog(this);
        }

        private void listContractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListContractForm listContractF = new ListContractForm();
            listContractF.ShowDialog(this);
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RevenueForm revenueF = new RevenueForm();
            revenueF.ShowDialog();
        }

        private void carForRentServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentCarForm rentCarF = new RentCarForm(StaffManager);
            rentCarF.ShowDialog(this);
        }

        private void addCarOfCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarOfCompanyForm addCarOfCompanyF = new AddCarOfCompanyForm();
            addCarOfCompanyF.ShowDialog(this);
        }

        private void listCarRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCarRentForm listCarRentF = new ListCarRentForm();
            listCarRentF.ShowDialog(this);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCarOfCompanyForm removeF = new RemoveCarOfCompanyForm();
            removeF.ShowDialog(this);
        }
    }
}
