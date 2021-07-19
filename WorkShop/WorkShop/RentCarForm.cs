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
    public partial class RentCarForm : Form
    {
        private Staff staffRent;

        public Staff StaffRent { get { return staffRent; } set { staffRent = value; } }

        public RentCarForm(Staff staff)
        {
            InitializeComponent();
            StaffRent = staff;
            LoadCombobox(cmbChoose);
            FormLoad();
        }

        void LoadCombobox(ComboBox combo)
        {
            combo.SelectedIndex = 0;
        }

        void FormLoad()
        {
            if (!pnlRentCar.Controls.Contains(CustomerUCForm.Instance))
            {
                pnlRentCar.Controls.Add(CustomerUCForm.Instance);
                CustomerUCForm.Instance.PnlRentCar = pnlRentCar;
                CustomerUCForm.Instance.Dock = DockStyle.Fill;
                CustomerUCForm.Instance.BringToFront();
            }
            else
                CustomerUCForm.Instance.BringToFront();
            CustomerUCForm.Instance.TypeRent = cmbChoose.SelectedIndex;
            CustomerUCForm.Instance.StaffRent = StaffRent;
        }

        private void cmbChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerUCForm.Instance.TypeRent = cmbChoose.SelectedIndex;
        }
    }
}
