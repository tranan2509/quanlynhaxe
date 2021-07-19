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
using WorkShop.DTO;

namespace WorkShop
{
    public partial class StaffForm : Form
    {

        private Staff staffWorkShop;
        public Staff StaffWorkShop
        {
            get { return this.staffWorkShop; }
            set { this.staffWorkShop = value; LoadInfoOnForm(staffWorkShop); }
        }

        public StaffForm()
        {
            InitializeComponent();
            LoadListSpeciality();
        }

        #region Methods
        void LoadInfoOnForm(Staff staff)
        {
            if (staff != null)
            {
                txtID.Text = staff.ID.ToString();
                txtFirstName.Text = staff.Fname;
                txtlastName.Text = staff.Lname;
                txtIDNumber.Text = staff.IdentityNumber;
                dtpkBDate.Value = staff.Bdate;
                txtGender.Text = staff.Gender;
                txtPhone.Text = staff.Phone;
                txtAddress.Text = staff.Address;
                cmbSpeciality.SelectedValue = staff.IDSpeciality;
                txtPassword.Text = staff.Pass;
                picImageStaff.Image = StaffDAO.Instance.GetPhotoByID(staff.IDPhoto).ImagePerson;
                txtSalary.Text = staff.Salary.ToString();
                txtBonus.Text = staff.Bonus.ToString();
            }
            else
            {
                ClearData();
            }
        }
        void ClearData()
        {
            txtFirstName.Text = "";
            txtlastName.Text = "";
            txtIDNumber.Text = "";
            dtpkBDate.Value = DateTime.Now;
            txtGender.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            cmbSpeciality.SelectedValue = 0;
            txtPassword.Text = "";
            picImageStaff.Image = null;
            txtSalary.Text = "";
            txtBonus.Text = "";
        }
        bool verif()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text)
                || string.IsNullOrEmpty(txtlastName.Text)
                || string.IsNullOrEmpty(txtIDNumber.Text)
                || string.IsNullOrEmpty(txtGender.Text)
                || string.IsNullOrEmpty(txtPhone.Text)
                || string.IsNullOrEmpty(txtAddress.Text)
                || string.IsNullOrEmpty(txtPassword.Text)
                || picImageStaff == null
                || string.IsNullOrEmpty(txtSalary.Text))
                return true;
            return false;
        }

        void LoadListSpeciality()
        {
            cmbSpeciality.DataSource = SpecialityDAO.Instance.GetListSpeciality();
            cmbSpeciality.DisplayMember = "content";
            cmbSpeciality.ValueMember = "id";
        }

        #endregion

        private void picImageStaff_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picImageStaff.Image = Image.FromFile(open.FileName);
            }
        }

        private void picFind_Click(object sender, EventArgs e)
        {
            int id;
            if (!Int32.TryParse(txtID.Text, out id))
            {
                errorProviderStaff.SetError(txtID, "Invalid ID");
                StaffWorkShop = null;
                return;
            }
            StaffWorkShop = StaffDAO.Instance.GetStaffByID(id);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            errorProviderStaff.Clear();
            picFind_Click(sender, new EventArgs());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtlastName.Text;
            string identityNumber = txtIDNumber.Text;
            DateTime bdate = dtpkBDate.Value;
            string gender = txtGender.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            int idSpeciality = (int)cmbSpeciality.SelectedValue;
            string passWord = txtPassword.Text;
            Image pic = picImageStaff.Image;
            double salary = Convert.ToDouble(txtSalary.Text);
            double bonus = 0;
            if (Double.TryParse(txtBonus.Text, out bonus)) { }
            if (verif() == true)
            {
                MessageBox.Show("No data box must be empty!", "Insert Staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DateTime.Now.Year - dtpkBDate.Value.Year < 10)
            {
                MessageBox.Show("Birth date invalid!", "Insert Staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (StaffDAO.Instance.InsertStaff(fname, lname, identityNumber, gender, bdate, address, phone, pic, idSpeciality, passWord, (float)salary, (float)bonus))
            {
                MessageBox.Show("Insert Successful!\n ID Staff is " + StaffDAO.Instance.GetIDMax().ToString(), "Insert Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Insert Fail", "Insert Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (!Int32.TryParse(txtID.Text, out id))
            {
                errorProviderStaff.SetError(txtID, "Invalid ID");
                return;
            }
            string fname = txtFirstName.Text;
            string lname = txtlastName.Text;
            string identityNumber = txtIDNumber.Text;
            DateTime bdate = dtpkBDate.Value;
            string gender = txtGender.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            int idSpeciality = (int)cmbSpeciality.SelectedValue;
            string passWord = txtPassword.Text;
            Image pic = picImageStaff.Image;
            double salary = Convert.ToDouble(txtSalary.Text);
            double bonus = 0;
            if (Double.TryParse(txtBonus.Text, out bonus)) { }
            if (verif() == true)
            {
                MessageBox.Show("No data box must be empty!", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DateTime.Now.Year - dtpkBDate.Value.Year < 10)
            {
                MessageBox.Show("Birth date invalid!", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Do you want to Update Staff?", "Update Staff", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (StaffDAO.Instance.UpdateStaff(id, fname, lname, identityNumber, gender, bdate, address, phone, pic, idSpeciality, passWord, (float)salary, (float)bonus))
                {
                    MessageBox.Show("Update Successful!", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Fail", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (!Int32.TryParse(txtID.Text, out id))
            {
                errorProviderStaff.SetError(txtID, "Invalid");
                return;
            }
            if (MessageBox.Show("Do you want to Delete Staff?", "Delete Staff", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (StaffDAO.Instance.DeleteStaffByID(id))
                {
                    MessageBox.Show("Delete Successful!", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Fail", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
