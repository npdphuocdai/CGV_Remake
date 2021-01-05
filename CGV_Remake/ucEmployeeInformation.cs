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
    public partial class ucEmployeeInformation : DevExpress.XtraEditors.XtraUserControl
    {
        public ucEmployeeInformation()
        {
            InitializeComponent();
            layPotrait.Height = Convert.ToInt32(layoutTong.Height * 0.54);
            grpInfor.Height = Convert.ToInt32(layoutTong.Height * 0.35);
            grpOthers.Height = Convert.ToInt32(layoutTong.Height * 0.35);
            grpInfor.Width = Convert.ToInt32(layoutTong.Width * 0.48);
            grpOthers.Width = Convert.ToInt32(layoutTong.Width * 0.48);
        }
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
    }
}
