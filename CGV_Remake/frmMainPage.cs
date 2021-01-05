using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BAL;

namespace Viewer
{
    public partial class frmMainPage : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMainPage()
        {
            InitializeComponent();
            SkinHelper.InitSkinPopupMenu(SkinsLink);
            AddPage(ucHome.Instance);
        }
        frmLogin frmLogin = new frmLogin();
        public void AddPage(UserControl userControl)
        {
            while(this.fldContainter.Controls.Count > 0)
            {
                this.fldContainter.Controls.RemoveAt(0);
            }
            this.fldContainter.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }
        private void aceTicket_Click(object sender, EventArgs e)
        {
            AddPage(ucTicket.Instance);
        }

        private void aceUsername_Click(object sender, EventArgs e)
        {
            if (frmLogin.flag == false)
            {
                this.Hide();
                frmLogin.ShowDialog();
                this.Show();
            }
            else
            {
                AddPage(ucEmployeeInformation.Instance);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(frmLogin.flag == true)
            {
                aceUsername.Text = frmLogin.UserLogin.FullName;
            }
        }
    }
}
