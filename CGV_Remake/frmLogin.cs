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
using System.Data.SqlClient;

namespace Viewer
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static dtoViewEmployees UserLogin;
        public bool flag = false;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            balEmployee balEmployee = new balEmployee();
            balViewEmployee balViewEmployee = new balViewEmployee();
            List<dtoViewEmployees> listEmployee = balViewEmployee.GetViewEmployees();
            try
            {
                if (txtUsername.Text == "" || txtPass.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin đăng nhập!");
                }
                else if (!balEmployee.Login(Convert.ToInt32(txtUsername.Text), txtPass.Text))
                {
                    throw new Exception("Sai thông tin đăng nhập, vui lòng nhập lại!");
                }
                else
                {
                    flag = true;
                    foreach(dtoViewEmployees i in listEmployee)
                    {
                        if(Convert.ToInt32(txtUsername.Text) == i.EmployeeID)
                        {
                            UserLogin = i;
                        }
                    }
                    txtPass.Text = "";
                    XtraMessageBox.Show("Đăng nhập thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            balViewEmployee balViewEmployee = new balViewEmployee();
            List<dtoViewEmployees> listEmployee = balViewEmployee.GetViewEmployees();
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (txtUsername.Text == "" || txtPass.Text == "")
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin đăng nhập!");
                    }
                    else if (!balEmployee.Login(Convert.ToInt32(txtUsername.Text), txtPass.Text))
                    {
                        throw new Exception("Sai thông tin đăng nhập, vui lòng nhập lại!");
                    }
                    else
                    {
                        flag = true;
                        foreach (dtoViewEmployees i in listEmployee)
                        {
                            if (Convert.ToInt32(txtUsername.Text) == i.EmployeeID)
                            {
                                UserLogin = i;
                            }
                        }
                        txtPass.Text = "";
                        XtraMessageBox.Show("Đăng nhập thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            balViewEmployee balViewEmployee = new balViewEmployee();
            List<dtoViewEmployees> listEmployee = balViewEmployee.GetViewEmployees();
            try
            {
                if (e.KeyChar == (char)13)
                {
                    if (txtUsername.Text == "" || txtPass.Text == "")
                    {
                        throw new Exception("Vui lòng nhập đầy đủ thông tin đăng nhập!");
                    }
                    else if (!balEmployee.Login(Convert.ToInt32(txtUsername.Text), txtPass.Text))
                    {
                        throw new Exception("Sai thông tin đăng nhập, vui lòng nhập lại!");
                    }
                    else
                    {
                        flag = true;
                        foreach (dtoViewEmployees i in listEmployee)
                        {
                            if (Convert.ToInt32(txtUsername.Text) == i.EmployeeID)
                            {
                                UserLogin = i;
                            }
                        }
                        txtPass.Text = "";
                        XtraMessageBox.Show("Đăng nhập thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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