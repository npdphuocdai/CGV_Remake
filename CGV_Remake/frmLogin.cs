﻿using DevExpress.XtraEditors;
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
        public dtoEmployee UserLogin;
        public bool flag = false;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            balEmployee balEmployee = new balEmployee();
            List<dtoEmployee> listEmployee = balEmployee.GetEmployees();
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
                    foreach(dtoEmployee i in listEmployee)
                    {
                        if(Convert.ToInt32(txtUsername.Text) == i.EmployeeID)
                        {
                            UserLogin = i;
                        }
                    }
                    XtraMessageBox.Show("Đăng nhập thành công!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}