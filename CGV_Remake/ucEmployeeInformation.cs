using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DTO;

namespace Viewer
{
    public partial class ucEmployeeInformation : DevExpress.XtraEditors.XtraUserControl
    {
        public ucEmployeeInformation()
        {
            InitializeComponent();
            imgInfor.Image = SettingImage.ByteArrayToImage(frmLogin.UserLogin.EmployeePotrait);
            layPotrait.Height = Convert.ToInt32(layoutTong.Height * 0.54);
            grpInfor.Height = Convert.ToInt32(layoutTong.Height * 0.35);
            grpOthers.Height = Convert.ToInt32(layoutTong.Height * 0.35);
            grpInfor.Width = Convert.ToInt32(layoutTong.Width * 0.48);
            grpOthers.Width = Convert.ToInt32(layoutTong.Width * 0.48);
        }
        public string FileName;
        private void ucEmployeeInformation_Resize(object sender, EventArgs e)
        {
            layPotrait.Height = Convert.ToInt32(layoutTong.Height * 0.54);
            grpInfor.Height = Convert.ToInt32(layoutTong.Height * 0.35);
            grpOthers.Height = Convert.ToInt32(layoutTong.Height * 0.35);
            grpInfor.Width = Convert.ToInt32(layoutTong.Width * 0.48);
            grpOthers.Width = Convert.ToInt32(layoutTong.Width * 0.48);
        }
        private static ucEmployeeInformation _instance;
        public static ucEmployeeInformation Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucEmployeeInformation();
                }
                return _instance;
            }
        }
        private void ucEmployeeInformation_Load(object sender, EventArgs e)
        {
            txtEmployeeID.Text = frmLogin.UserLogin.EmployeeID.ToString();
            txtGender.Text = frmLogin.UserLogin.Gender;
            txtFullName.Text = frmLogin.UserLogin.EmployeeFullName;
            txtBirthDay.Text = frmLogin.UserLogin.EmployeeBirthday.ToString();
            txtAddress.Text = frmLogin.UserLogin.EmployeeAddress;
            txtPhoneNumber.Text = frmLogin.UserLogin.EmployeePhoneNumber;
            txtEmail.Text = frmLogin.UserLogin.EmployeeEmail;
            txtStartDay1.Text = frmLogin.UserLogin.StartDay.ToString();
            txtJobTitle1.Text = frmLogin.UserLogin.JobtitleName.ToString();
            txtBasicSalary1.Text = frmLogin.UserLogin.BasicSalary.ToString();
            imgInfor.Image = SettingImage.ByteArrayToImage(frmLogin.UserLogin.EmployeePotrait);
            txtCoe.Text = frmLogin.UserLogin.CoefficientsSalary.ToString();
            txtPosi.Text = frmLogin.UserLogin.PositionAllowance.ToString();
            txtMajor1.Text = frmLogin.UserLogin.Major.ToString();
        }
        private void btnEditInfor_Click(object sender, EventArgs e)
        {
            frmMainPage.EmployeeTemp.EmployeeID = Convert.ToInt32(txtEmployeeID.Text);
            frmMainPage.EmployeeTemp.Gender = txtGender.Text;
            frmMainPage.EmployeeTemp.EmployeeFullName = txtFullName.Text;
            frmMainPage.EmployeeTemp.EmployeeBirthday = Convert.ToDateTime(txtBirthDay.Text);
            frmMainPage.EmployeeTemp.EmployeeAddress = txtAddress.Text;
            frmMainPage.EmployeeTemp.EmployeePhoneNumber = txtPhoneNumber.Text;
            frmMainPage.EmployeeTemp.EmployeeEmail = txtEmail.Text;
            frmMainPage.EmployeeTemp.StartDay = Convert.ToDateTime(txtStartDay1.Text);
            frmMainPage.EmployeeTemp.JobtitleName = txtJobTitle1.Text;
            frmMainPage.EmployeeTemp.BasicSalary = Convert.ToDecimal(txtBasicSalary1.Text);
            frmMainPage.EmployeeTemp.CoefficientsSalary = Convert.ToInt32(txtCoe.Text);
            frmMainPage.EmployeeTemp.PositionAllowance = Convert.ToDecimal(txtPosi.Text);
            frmMainPage.EmployeeTemp.Major = txtMajor1.Text;
            balEmployee employee = new balEmployee();
            int count = employee.UpdateFromView(frmMainPage.EmployeeTemp);
            string mess = "Thông tin nhân viên đã được update thành công!"+"\nSố hàng đã được update: " + count.ToString();
            XtraMessageBox.Show(mess, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void imgInfor_Properties_ImageLoading(object sender, DevExpress.XtraEditors.Repository.SaveLoadImageEventArgs e)
        {
            FileName = e.FileName;
        }
    }
}
