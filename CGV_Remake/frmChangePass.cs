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
using DTO;
using BAL;

namespace Viewer
{
    public partial class frmChangePass : DevExpress.XtraEditors.XtraForm
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            balEmployee balEmployee = new balEmployee();
            List<dtoEmployee> dtoEmployees = new List<dtoEmployee>();
            try
            {
                if(txtUsername.Text != frmLogin.UserLogin.EmployeeID.ToString())
                {
                    throw new Exception("Sai thông tin đăng nhập, vui lòng nhập lại!");
                }else if (txtUsername.Text == "" || txtPass.Text == "" || txtNewPass.Text == "" || txtConfirmPass.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin tài khoản!");
                }
                else if (!balEmployee.Login(Convert.ToInt32(txtUsername.Text), txtPass.Text))
                {
                    throw new Exception("Sai thông tin đăng nhập, vui lòng nhập lại!");
                }
                else if(txtNewPass.Text != txtConfirmPass.Text)
                {
                    throw new Exception("Mật khẩu mới và xác nhận không khớp!");
                }
                else
                {
                    balEmployee.UpdatePassword(Convert.ToInt32(txtUsername.Text), txtNewPass.Text);
                    txtPass.Text = "";
                    txtConfirmPass.Text = "";
                    txtNewPass.Text = "";
                    XtraMessageBox.Show("Đổi mật khẩu thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            balEmployee balEmployee = new balEmployee();
            List<dtoEmployee> dtoEmployees = new List<dtoEmployee>();
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (txtUsername.Text != frmLogin.UserLogin.EmployeeID.ToString())
                    {
                        throw new Exception("Sai thông tin đăng nhập, vui lòng nhập lại!");
                    }
                    else if (txtUsername.Text == "" || txtPass.Text == "" || txtNewPass.Text == "" || txtConfirmPass.Text == "")
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin tài khoản!");
                    }
                    else if (!balEmployee.Login(Convert.ToInt32(txtUsername.Text), txtPass.Text))
                    {
                        throw new Exception("Sai thông tin đăng nhập, vui lòng nhập lại!");
                    }
                    else if (txtNewPass.Text != txtConfirmPass.Text)
                    {
                        throw new Exception("Mật khẩu mới và xác nhận không khớp!");
                    }
                    else
                    {
                        balEmployee.UpdatePassword(Convert.ToInt32(txtUsername.Text), txtNewPass.Text);
                        txtPass.Text = "";
                        txtConfirmPass.Text = "";
                        txtNewPass.Text = "";
                        XtraMessageBox.Show("Đổi mật khẩu thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            balEmployee balEmployee = new balEmployee();
            List<dtoEmployee> dtoEmployees = new List<dtoEmployee>();
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (txtUsername.Text != frmLogin.UserLogin.EmployeeID.ToString())
                    {
                        throw new Exception("Sai thông tin đăng nhập, vui lòng nhập lại!");
                    }
                    else if (txtUsername.Text == "" || txtPass.Text == "" || txtNewPass.Text == "" || txtConfirmPass.Text == "")
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin tài khoản!");
                    }
                    else if (!balEmployee.Login(Convert.ToInt32(txtUsername.Text), txtPass.Text))
                    {
                        throw new Exception("Sai thông tin đăng nhập, vui lòng nhập lại!");
                    }
                    else if (txtNewPass.Text != txtConfirmPass.Text)
                    {
                        throw new Exception("Mật khẩu mới và xác nhận không khớp!");
                    }
                    else
                    {
                        balEmployee.UpdatePassword(Convert.ToInt32(txtUsername.Text), txtNewPass.Text);
                        txtPass.Text = "";
                        txtConfirmPass.Text = "";
                        txtNewPass.Text = "";
                        XtraMessageBox.Show("Đổi mật khẩu thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            balEmployee balEmployee = new balEmployee();
            List<dtoEmployee> dtoEmployees = new List<dtoEmployee>();
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (txtUsername.Text != frmLogin.UserLogin.EmployeeID.ToString())
                    {
                        throw new Exception("Sai thông tin đăng nhập, vui lòng nhập lại!");
                    }
                    else if (txtUsername.Text == "" || txtPass.Text == "" || txtNewPass.Text == "" || txtConfirmPass.Text == "")
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin tài khoản!");
                    }
                    else if (!balEmployee.Login(Convert.ToInt32(txtUsername.Text), txtPass.Text))
                    {
                        throw new Exception("Sai thông tin đăng nhập, vui lòng nhập lại!");
                    }
                    else if (txtNewPass.Text != txtConfirmPass.Text)
                    {
                        throw new Exception("Mật khẩu mới và xác nhận không khớp!");
                    }
                    else
                    {
                        balEmployee.UpdatePassword(Convert.ToInt32(txtUsername.Text), txtNewPass.Text);
                        txtPass.Text = "";
                        txtConfirmPass.Text = "";
                        txtNewPass.Text = "";
                        XtraMessageBox.Show("Đổi mật khẩu thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            balEmployee balEmployee = new balEmployee();
            List<dtoEmployee> dtoEmployees = new List<dtoEmployee>();
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (txtUsername.Text != frmLogin.UserLogin.EmployeeID.ToString())
                    {
                        throw new Exception("Sai thông tin đăng nhập, vui lòng nhập lại!");
                    }
                    else if (txtUsername.Text == "" || txtPass.Text == "" || txtNewPass.Text == "" || txtConfirmPass.Text == "")
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin tài khoản!");
                    }
                    else if (!balEmployee.Login(Convert.ToInt32(txtUsername.Text), txtPass.Text))
                    {
                        throw new Exception("Sai thông tin đăng nhập, vui lòng nhập lại!");
                    }
                    else if (txtNewPass.Text != txtConfirmPass.Text)
                    {
                        throw new Exception("Mật khẩu mới và xác nhận không khớp!");
                    }
                    else
                    {
                        balEmployee.UpdatePassword(Convert.ToInt32(txtUsername.Text), txtNewPass.Text);
                        txtPass.Text = "";
                        txtConfirmPass.Text = "";
                        txtNewPass.Text = "";
                        XtraMessageBox.Show("Đổi mật khẩu thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}