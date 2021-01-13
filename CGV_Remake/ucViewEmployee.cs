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
    public partial class ucViewEmployee : DevExpress.XtraEditors.XtraUserControl
    {
        public ucViewEmployee()
        {
            InitializeComponent();
            BindingData();
        }
        balViewEmployee balViewEmployee = new balViewEmployee();
        balEmployee balEmployee = new balEmployee();
        balJobTitle balJobTitle = new balJobTitle();
        private static ucViewEmployee _instance;
        public static ucViewEmployee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucViewEmployee();
                }
                return _instance;
            }
        }
        public void BindingData()
        {
            DataSource.DataSource = balViewEmployee.GetViewEmployees();
            DataSourceJob.DataSource = balJobTitle.GetJobTitles();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dtoViewEmployees viewEmployees = new dtoViewEmployees();
                viewEmployees = dgvViewEmployee.GetFocusedRow() as dtoViewEmployees;
                if (viewEmployees.EmployeeFullName == "" || viewEmployees.Gender == "" || viewEmployees.EmployeeBirthday.ToString() == "" || viewEmployees.EmployeePhoneNumber == "" || viewEmployees.EmployeeAddress == "" || viewEmployees.EmployeeEmail == "" || viewEmployees.BasicSalary.ToString() == "")
                {
                    throw new Exception("Vui lòng không để trống thông tin!");
                }
                else
                {
                    int count = balEmployee.AdminUpdateFromView(viewEmployees);
                    XtraMessageBox.Show("Cập nhập thông tin nhân viên thành công! \nSố hàng đã được cập nhập: " + count.ToString(), "Succesful", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ucViewEmployee_Load(object sender, EventArgs e)
        {
            BindingData();
        }
    }
}
