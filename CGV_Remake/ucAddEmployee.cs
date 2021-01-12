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
    public partial class ucAddEmployee : DevExpress.XtraEditors.XtraUserControl
    {
        public ucAddEmployee()
        {
            InitializeComponent();
            layPotrait.Height = Convert.ToInt32(layoutTong.Height * 0.54);
            grpInfor.Height = Convert.ToInt32(layoutTong.Height * 0.35);
            grpOthers.Height = Convert.ToInt32(layoutTong.Height * 0.35);
            grpInfor.Width = Convert.ToInt32(layoutTong.Width * 0.48);
            grpOthers.Width = Convert.ToInt32(layoutTong.Width * 0.48);
        }
        balEmployee employee = new balEmployee();
        private string fileName;
        private static ucAddEmployee _instance;
        public static ucAddEmployee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucAddEmployee();
                }
                return _instance;
            }
        }
        private void imgInfor_Properties_ImageLoading(object sender, DevExpress.XtraEditors.Repository.SaveLoadImageEventArgs e)
        {
            fileName = e.FileName;
        }
        private void ucAddEmployee_Resize(object sender, EventArgs e)
        {
            layPotrait.Height = Convert.ToInt32(layoutTong.Height * 0.54);
            grpInfor.Height = Convert.ToInt32(layoutTong.Height * 0.35);
            grpOthers.Height = Convert.ToInt32(layoutTong.Height * 0.35);
            grpInfor.Width = Convert.ToInt32(layoutTong.Width * 0.48);
            grpOthers.Width = Convert.ToInt32(layoutTong.Width * 0.48);
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || txtAddress.Text == "" || txtBasicSalary.Text == "" || txtBirthDay.Text == "" || txtEmail.Text == "" || txtGender.Text == "" || txtJobTitle.Text == "" || txtPass.Text == "" || txtPhoneNumber.Text == "")
                {
                    throw new Exception("Vui lòng không để trống thông tin!");
                }
                dtoEmployee dtoEmployee = new dtoEmployee();
                dtoEmployee.FullName = txtFullName.Text;
                dtoEmployee.Address = txtAddress.Text;
                dtoEmployee.BasicSalary = Convert.ToDecimal(txtBasicSalary.Text);
                dtoEmployee.BirthDay = Convert.ToDateTime(txtBirthDay.Text);
                dtoEmployee.Email = txtEmail.Text;
                dtoEmployee.Gender = txtGender.Text;
                dtoEmployee.JobTitleID = Convert.ToInt32(txtJobTitle.Text);
                dtoEmployee.Password = txtPass.Text;
                dtoEmployee.PhoneNumber = txtPhoneNumber.Text;
                dtoEmployee.StartDay = DateTime.Now;
                balEmployee employee = new balEmployee();
                int count = employee.InsertEmployee(dtoEmployee, fileName);
                txtFullName.Text = "";
                txtAddress.Text = "";
                txtGender.Text = "";
                txtJobTitle.Text = "";
                txtPass.Text = "";
                txtPhoneNumber.Text = "";
                txtBirthDay.Text = "";
                txtBasicSalary.Text = "";
                string mess = "Thông tin nhân viên đã được thêm thành công!" + "\nSố hàng đã được thêm: " + count.ToString();
                XtraMessageBox.Show(mess, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void imgInfor_Properties_ImageSaving(object sender, DevExpress.XtraEditors.Repository.SaveLoadImageEventArgs e)
        {
            fileName = e.FileName;
        }
    }
}
