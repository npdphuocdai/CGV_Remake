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
            DataSourceJob.DataSource = balViewEmployee.GetViewEmployees();
        }
    }
}
