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
using DevExpress.XtraEditors;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
        frmTicket frmTicket = new frmTicket();
        public static dtoViewEmployee EmployeeTemp = new dtoViewEmployee();
        frmLogin frmLogin = new frmLogin();
        public void AddPage(UserControl userControl)
        {
            while(fldContainter.Controls.Count > 0)
            {
                fldContainter.Controls.RemoveAt(0);
            }
            fldContainter.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }
        public void CallChildForm(object Child)
        {
            while (fldContainter.Controls.Count > 0)
            {
                fldContainter.Controls.RemoveAt(0);
            }
            Form fr = Child as Form;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            fldContainter.Controls.Add(fr);
            fldContainter.Tag = fr;
            fr.Show();
        }
        private void aceTicket_Click(object sender, EventArgs e)
        {
            CallChildForm(frmTicket);
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
                aceLogOut.Enabled = true;
                aceUsername.Text = frmLogin.UserLogin.EmployeeFullName;
            }
            else
            {
                aceLogOut.Enabled = false;
            }
        }

        private void aceButtonHome_Click(object sender, EventArgs e)
        {
                AddPage(ucHome.Instance);
        }

        private void aceLogOut_Click(object sender, EventArgs e)
        {
            if(frmLogin.flag == true)
            {
                frmLogin.flag = false;
                aceUsername.Text = "Log In";
                frmLogin.UserLogin = null;
                this.Hide();
                frmLogin.ShowDialog();
                this.Show();
            }
        }
    }
}
