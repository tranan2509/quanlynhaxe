using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop.DAO;

namespace WorkShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        #region Methods

        #endregion

        #region Events

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you realy want to escape?", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picHidePassWord_Click(object sender, EventArgs e)
        {
            txtPassWord.UseSystemPasswordChar = !txtPassWord.UseSystemPasswordChar;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int userName;
            string passWord = txtPassWord.Text;
            if (!Int32.TryParse(txtUserName.Text, out userName))
            {
                errorProviderLogin.SetError(txtUserName, "Invalid UserName");
                return;
            }
            if (rdStaff.Checked == true)
            {
                if(StaffDAO.Instance.LoginAccountStaff(userName, passWord))
                {
                    ParkingLotForm parkingLotF = new ParkingLotForm();
                    parkingLotF.StaffParking = StaffDAO.Instance.GetStaffByID(userName);
                    this.Hide();
                    parkingLotF.Show(this);
                    this.Show();
                }
                else
                {
                    errorProviderLogin.SetError(txtUserName, "Username or Password incorrect");
                }
            }
            else
            {
                if (StaffDAO.Instance.LoginAccountManager(userName, passWord))
                {
                    ManagerForm managerF = new ManagerForm();
                    managerF.StaffManager = StaffDAO.Instance.GetStaffByID(userName);
                    this.Hide();
                    managerF.ShowDialog(this);
                    this.Show();
                }
                else
                {
                    errorProviderLogin.SetError(txtUserName, "Username or Password incorrect");
                }
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            errorProviderLogin.Clear();
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            errorProviderLogin.Clear();
        }
    }
}
