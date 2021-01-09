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
        balViewEmployee balViewEmployee = new balViewEmployee();
        public void BindingData()
        {
            dtoViewEmployeeBindingSource.DataSource = balViewEmployee.GetViewEmployees();
        }
    }
}
