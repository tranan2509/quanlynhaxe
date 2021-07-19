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
    public partial class InfoCusomerParkingForm : Form
    {
        private Customer customerParking;
        public Customer CustomerParking
        {
            get { return this.customerParking; }
            set { this.customerParking = value;  LoadInfoOnForm(customerParking); }
        }

        private bool isAdmin;
        public bool IsAdmin
        {
            get { return this.isAdmin; }
            set { this.isAdmin = value; SetButton(isAdmin); }
        }
        public InfoCusomerParkingForm()
        {
            InitializeComponent();
            IsAdmin = false;
            LoadListType();
        }

        #region Methods
        void LoadListType()
        {
            List<TypeCustomer> listCustomer = TypeCustomerDAO.Instance.GetListTypeCustomer();
            cmbType.DataSource = listCustomer;
            cmbType.DisplayMember = "name";
            cmbType.ValueMember = "id";
        }

        void LoadInfoOnForm(Customer customer)
        {
            if (customer != null)
            {
                txtID.Text = customer.ID.ToString();
                txtFirstName.Text = customer.Fname;
                txtlastName.Text = customer.Lname;
                txtIDNumber.Text = customer.IdentityNumber;
                if (customer.Bdate != null)
                {
                    dtpkBDate.Value = customer.Bdate.Value;                    //
                }
                else
                {
                    dtpkBDate.Value = DateTime.Now;
                    errorProviderInfoCus.SetError(dtpkBDate, "No birth date");
                }
                txtGender.Text = customer.Gender;
                txtPhone.Text = customer.Phone;
                txtAddress.Text = customer.Address;
                cmbType.SelectedValue = customer.TypeCustomer;
                txtCode.Text = customer.QrCode;
                picImageCustomer.Image = GetImageCustomer(customer);
            }
            else
            {
                ClearData();
            }
        }

        void ClearData()
        {
            txtFirstName.Text = "";
            txtlastName.Text =  "";
            txtIDNumber.Text = "";        
            dtpkBDate.Value = DateTime.Now;
            txtGender.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            cmbType.SelectedValue = 0;
            txtCode.Text = "";
            picImageCustomer.Image = null;
        }
        Image GetImageCustomer(Customer customer)
        {
            Photo photo = PhotoDAO.Instance.GetPhotoByID(customer.IDPhoto);
            if (photo != null)
                return photo.ImagePerson;
            return null;
        }


        void SetButton(bool isAdmin)
        {
            if (isAdmin == true)
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        bool verif()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text)
                || string.IsNullOrEmpty(txtlastName.Text)
                || string.IsNullOrEmpty(txtIDNumber.Text)
                || string.IsNullOrEmpty(txtGender.Text)
                || string.IsNullOrEmpty(txtPhone.Text)
                || string.IsNullOrEmpty(txtAddress.Text)
                || string.IsNullOrEmpty(txtCode.Text)
                || picImageCustomer.Image == null)
                return true;
            return false;
        }
        #endregion

        #region Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fname = txtFirstName.Text;
            string lname = txtlastName.Text;
            string identityNumber = txtIDNumber.Text;
            DateTime bdate = dtpkBDate.Value;
            string gender = txtGender.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            int typeCustomer = (int)cmbType.SelectedValue;
            string qrCode = txtCode.Text;
            Image pic = picImageCustomer.Image;

            if (verif() == true)
            {
                MessageBox.Show("No data box must be empty!", "Insert Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DateTime.Now.Year - dtpkBDate.Value.Year < 10)
            {
                MessageBox.Show("Birth date invalid!", "Insert Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CustomerDAO.Instance.InsertCustomer(fname, lname, identityNumber, gender, bdate, address, phone, pic, typeCustomer, qrCode))
            {
                MessageBox.Show("Insert Successful!\n ID Customer is " + CustomerDAO.Instance.GetIDMax().ToString(), "Insert Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Insert Fail", "Insert Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (!Int32.TryParse(txtID.Text, out id))
            {
                errorProviderInfoCus.SetError(txtID, "Invalid");
                return;
            }
            string fname = txtFirstName.Text;
            string lname = txtlastName.Text;
            string identityNumber = txtIDNumber.Text;
            DateTime bdate = dtpkBDate.Value;
            string gender = txtGender.Text;
            string phone = txtPhone.Text;
            string address = txtAddress.Text;
            int typeCustomer = (int)cmbType.SelectedValue;
            string qrCode = txtCode.Text;
            Image pic = picImageCustomer.Image;

            if (verif() == true)
            {
                MessageBox.Show("No data box must be empty!", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DateTime.Now.Year - dtpkBDate.Value.Year < 10)
            {
                MessageBox.Show("Birth date invalid!", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Do you want to Update Customer?", "Update Customer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (CustomerDAO.Instance.UpdateCustomer(id, fname, lname, identityNumber, gender, bdate, address, phone, pic, typeCustomer, qrCode))
                {
                    MessageBox.Show("Update Successful!", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Fail", "Update Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (!Int32.TryParse(txtID.Text, out id))
            {
                errorProviderInfoCus.SetError(txtID, "Invalid");
                return;
            }
            if (MessageBox.Show("Do you want to Delete Customer?", "Delete Customer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (CustomerDAO.Instance.DeleteCustomerByID(id))
                {
                    MessageBox.Show("Delete Successful!", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Fail", "Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picImageCustomer_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picImageCustomer.Image = Image.FromFile(open.FileName);
            }
        }

        private void picFind_Click(object sender, EventArgs e)
        {
            int id;
            if (!Int32.TryParse(txtID.Text, out id))
            {
                errorProviderInfoCus.SetError(txtID, "Invalid ID");
                return;
            }
            CustomerParking = CustomerDAO.Instance.GetCustomerByID(id);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            errorProviderInfoCus.Clear();
        }
    }
}
