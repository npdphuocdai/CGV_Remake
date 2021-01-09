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

namespace Viewer
{
    public partial class ucDashboard : DevExpress.XtraEditors.XtraUserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }
        private static ucDashboard _instance;
        public static ucDashboard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucDashboard();
                }
                return _instance;
            }
        }
    }
}
