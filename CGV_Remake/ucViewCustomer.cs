using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DTO;

namespace Viewer
{
    public partial class ucViewCustomer : DevExpress.XtraEditors.XtraUserControl
    {
        public ucViewCustomer()
        {
            InitializeComponent();
            BindingData();
        }
        balCustomer balCustomer = new balCustomer();
        private static ucViewCustomer _instance;
        public static ucViewCustomer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucViewCustomer();
                }
                return _instance;
            }
        }
        public void BindingData()
        {
            DataSource.DataSource = balCustomer.GetCustomers();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dtoCustomer dtoCustomer = new dtoCustomer();
                dtoCustomer = dgvViewCustomer.GetFocusedRow() as dtoCustomer;
                if (dtoCustomer.FullName == "" || dtoCustomer.Gender == "" || dtoCustomer.BirthDay.ToString() == "" || dtoCustomer.PhoneNumber == "" || dtoCustomer.Address == "" || dtoCustomer.Email == "" )
                {
                    throw new Exception("Vui lòng không để trống thông tin!");
                }
                else
                {
                    int count = balCustomer.Update(dtoCustomer);
                    XtraMessageBox.Show("Cập nhập thông tin khách hàng thành công! \nSố hàng đã được cập nhập: " + count.ToString(), "Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || txtAddress.Text == "" || txtBirthDay.Text == "" || txtEmail.Text == "" || txtGender.Text == "" || txtPhoneNumber.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                }
                else
                {
                    dtoCustomer dtoCustomer = new dtoCustomer();
                    dtoCustomer.FullName = txtFullName.Text;
                    dtoCustomer.Address = txtAddress.Text;
                    dtoCustomer.BirthDay = Convert.ToDateTime(txtBirthDay.Text);
                    dtoCustomer.Email = txtEmail.Text;
                    dtoCustomer.Gender = txtGender.Text;
                    dtoCustomer.PhoneNumber = txtPhoneNumber.Text;
                    int count = balCustomer.Insert(dtoCustomer);
                    txtFullName.Text = "";
                    txtAddress.Text = "";
                    txtBirthDay.Text = "";
                    txtEmail.Text = "";
                    txtGender.Text = "";
                    txtPhoneNumber.Text = "";
                    BindingData();
                    string mess = "Thông tin khách hàng đã được thêm thành công!" + "\nSố hàng đã được thêm: " + count.ToString();
                    XtraMessageBox.Show(mess, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
