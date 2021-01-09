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
        /// <summary>
        /// Dùng để gọi một UserControl và add vào Fluent Desigh
        /// </summary>
        /// <param name="userControl"></param>
        public void AddPage(UserControl userControl)
        {
            //Kiểm tra xem trong Fluent Desigh còn controls nào không
            while (fldContainter.Controls.Count > 0)
            {
                //Nếu còn thì remove hết
                fldContainter.Controls.RemoveAt(0);
            }
            //Thêm usercontrol vào Fluent Desigh
            fldContainter.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }
        /// <summary>
        /// Dùng để thêm một Control dạng "Form" vào Fluent Desigh
        /// </summary>
        /// <param name="Child"></param>
        public void CallChildForm(object Child)
        {
            //Kiểm tra xem trong Fluent Desigh còn controls nào không
            while (fldContainter.Controls.Count > 0)
            {
                //Nếu còn thì remove hết
                fldContainter.Controls.RemoveAt(0);
            }
            //Tạo một đối tượng Form và gán giá trị của Child cho nó
            Form fr = Child as Form;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            //Thêm control fr vào Fluent Desigh
            fldContainter.Controls.Add(fr);
            fldContainter.Tag = fr;
            fr.Show();
        }
        private void aceTicket_Click(object sender, EventArgs e)
        {
            frmTicket = new frmTicket();
            CallChildForm(frmTicket);
        }

        private void aceUsername_Click(object sender, EventArgs e)
        {
            //Nếu cờ đăng nhập là "false" thì khi click vào sẽ hiển thị form đăng nhập
            if (frmLogin.flag == false)
            {
                this.Hide();
                frmLogin.ShowDialog();
                this.Show();
            }
            //Nếu cờ đăng nhập là "true" thì khi click vào sẽ hiển thị bảng thông tin người dùng
            else
            {
                AddPage(ucEmployeeInformation.Instance);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Kiểm tra xem "cờ" đăng nhập đã được mở hay chưa
            //Nếu đã được mở thì Enable toàn bộ chức năng có thể dùng theo phân quyền
            if(frmLogin.flag == true)
            {
                aceDashboard.Enabled = true;
                aceTicket.Enabled = true;
                aceChangePass.Enabled = true;
                aceLogOut.Enabled = true;
                aceUsername.Text = frmLogin.UserLogin.EmployeeFullName;
            }
            //Nếu không thì sẽ disable tất cả chức năng trừ "Home" và "Log In"
            else
            {
                aceDashboard.Enabled = false;
                aceTicket.Enabled = false;
                aceChangePass.Enabled = false;
                aceLogOut.Enabled = false;
            }
        }

        private void aceButtonHome_Click(object sender, EventArgs e)
        {
                AddPage(ucHome.Instance);
        }

        private void aceLogOut_Click(object sender, EventArgs e)
        {
            //Log Out thì tắt cờ đăng nhập
            frmLogin.flag = false;
            aceUsername.Text = "Log In";
            frmLogin.UserLogin = null;
            this.Hide();
            frmLogin.ShowDialog();
            this.Show();
        }

        private void aceChangePass_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Tính năng đang được thêm vào, xin đợi thêm một thời gian!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aceDashboard_Click(object sender, EventArgs e)
        {
            AddPage(ucDashboard.Instance);
        }
    }
}
