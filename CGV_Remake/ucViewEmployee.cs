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
        public void BindingData()
        {
            dtoViewEmployeeBindingSource.DataSource = balViewEmployee.GetViewEmployees();
        }
    }
}
