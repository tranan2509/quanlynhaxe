using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShop
{
    public partial class AddCarOfCompanyForm : Form
    {
        public AddCarOfCompanyForm()
        {
            InitializeComponent();
            LoadUC();
        }

        void LoadUC()
        {
            if (!pnlMain.Controls.Contains(AddCarRentUCForm.Instance))
            {
                pnlMain.Controls.Add(AddCarRentUCForm.Instance);
                AddCarRentUCForm.Instance.Dock = DockStyle.Fill;
                AddCarRentUCForm.Instance.IsExtraCompany = true;
                AddCarRentUCForm.Instance.BringToFront();
            }
            else
                AddCarRentUCForm.Instance.BringToFront();
        }
    }
}
