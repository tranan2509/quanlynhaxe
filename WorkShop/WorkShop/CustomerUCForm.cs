using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkShop.DTO;
using WorkShop.DAO;

namespace WorkShop
{
    public partial class CustomerUCForm : UserControl
    {
        private static CustomerUCForm _instance;
        public static CustomerUCForm Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CustomerUCForm();
                return _instance;
            }
        }

        private Staff staffRent;
        public Staff StaffRent { get { return staffRent; } set { staffRent = value; } }

        private Customer customerRent;
        public Customer CustomerRent
        {
            get { return this.customerRent; }
            set { this.customerRent = value; LoadInfoOnForm(customerRent); }
        }
        private int typeRent;

        public int TypeRent { get { return typeRent; } set { typeRent = value; } }

        public Panel PnlRentCar { get { return pnlRentCar; } set { pnlRentCar = value; } }


        private Panel pnlRentCar;

        public CustomerUCForm()
        {
            InitializeComponent();
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
            txtlastName.Text = "";
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
            if (CustomerDAO.Instance.IsExistQrCodeOfCustomer(qrCode))
            {
                MessageBox.Show("QRCode already exist!", "Insert Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CustomerDAO.Instance.InsertCustomer(fname, lname, identityNumber, gender, bdate, address, phone, pic, typeCustomer, qrCode))
            {
                int idCus = CustomerDAO.Instance.GetIDMax();
                txtID.Text = idCus.ToString();
                MessageBox.Show("Insert Successful!\n ID Customer is " + idCus.ToString(), "Insert Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Insert Fail", "Insert Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void picFind_Click(object sender, EventArgs e)
        {
            int id;
            if (!Int32.TryParse(txtID.Text, out id))
            {
                errorProviderInfoCus.SetError(txtID, "Invalid ID");
                ClearData();
                return;
            }
            CustomerRent = CustomerDAO.Instance.GetCustomerByID(id);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            errorProviderInfoCus.Clear();
            picFind_Click(sender, new EventArgs()); 
        }

        private void picImageCustomer_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picImageCustomer.Image = Image.FromFile(open.FileName);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtID.Text, out id))
            { 
                if (!CustomerDAO.Instance.IsExistCustomerByID(id))
                {
                    MessageBox.Show("ID does not exist", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid ID", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (TypeRent == 0)
            {
                if (!PnlRentCar.Controls.Contains(ListCarRentUCForm.Instance))
                {
                    PnlRentCar.Controls.Add(ListCarRentUCForm.Instance);
                    ListCarRentUCForm.Instance.Dock = DockStyle.Fill;
                    ListCarRentUCForm.Instance.TypeRent = TypeRent;
                    ListCarRentUCForm.Instance.BringToFront();
                }
                else
                    ListCarRentUCForm.Instance.BringToFront();
                ListCarRentUCForm.Instance.PnlRentCar = PnlRentCar;
                ListCarRentUCForm.Instance.CustomerRent = CustomerRent;
                ListCarRentUCForm.Instance.StaffRent = StaffRent;
                
            }
            else if (TypeRent == 1)
            {
                if (!PnlRentCar.Controls.Contains(AddCarRentUCForm.Instance))
                {
                    PnlRentCar.Controls.Add(AddCarRentUCForm.Instance);
                    AddCarRentUCForm.Instance.PnlRentCar = PnlRentCar;
                    AddCarRentUCForm.Instance.Dock = DockStyle.Fill;
                    AddCarRentUCForm.Instance.TypeRent = TypeRent;
                    AddCarRentUCForm.Instance.BringToFront();
                }
                else
                    AddCarRentUCForm.Instance.BringToFront();
                AddCarRentUCForm.Instance.IsExtraCompany = false;
                AddCarRentUCForm.Instance.CustomerRent = CustomerRent;
                AddCarRentUCForm.Instance.StaffRent = StaffRent;
            }
            else
            {
                if (!PnlRentCar.Controls.Contains(ReturnCarRentUCForm.Instance))
                {
                    PnlRentCar.Controls.Add(ReturnCarRentUCForm.Instance);
                    ReturnCarRentUCForm.Instance.PnlRentCar = PnlRentCar;
                    ReturnCarRentUCForm.Instance.Dock = DockStyle.Fill;
                    ReturnCarRentUCForm.Instance.TypeRent = TypeRent;
                    ReturnCarRentUCForm.Instance.BringToFront();
                }
                else
                    ReturnCarRentUCForm.Instance.BringToFront();
                ReturnCarRentUCForm.Instance.StaffRent = StaffRent;
                ReturnCarRentUCForm.Instance.CustomerRent = CustomerRent;
            }
        }
    }
}
