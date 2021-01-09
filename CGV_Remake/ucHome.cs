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
    public partial class ucHome : DevExpress.XtraEditors.XtraUserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }
        private static ucHome _instance;
        public static ucHome Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucHome();
                }
                return _instance;
            }
        }
        private void ucHome_Resize(object sender, EventArgs e)
        {
            layCGV.Height = Convert.ToInt32(layHome.Height * 0.125);
            layTopLeft.Height = Convert.ToInt32(layHome.Height * 0.125);
            layTopRight.Height = Convert.ToInt32(layHome.Height * 0.125);
            layTopLeft.Width = Convert.ToInt32(layHome.Width * 0.125);
            layTopRight.Width = Convert.ToInt32(layHome.Width * 0.125);
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            layCGV.Height = Convert.ToInt32(layHome.Height * 0.125);
            layTopLeft.Height = Convert.ToInt32(layHome.Height * 0.125);
            layTopRight.Height = Convert.ToInt32(layHome.Height * 0.125);
            layTopLeft.Width = Convert.ToInt32(layHome.Width * 0.125);
            layTopRight.Width = Convert.ToInt32(layHome.Width * 0.125);
        }
    }
}
