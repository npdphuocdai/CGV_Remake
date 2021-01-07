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
    public partial class frmTicket : DevExpress.XtraEditors.XtraForm
    {
        public frmTicket()
        {
            InitializeComponent();
        }
        public void AddPage(UserControl userControl)
        {
            while (this.Controls.Count > 0)
            {
                this.Controls.RemoveAt(0);
            }
            this.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }

        private void frmTicket_Resize(object sender, EventArgs e)
        {
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

    }
}