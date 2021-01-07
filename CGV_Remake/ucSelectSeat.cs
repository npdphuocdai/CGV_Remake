using DevExpress.LookAndFeel;
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
    public partial class ucSelectSeat : DevExpress.XtraEditors.XtraUserControl
    {
        public ucSelectSeat()
        {
            InitializeComponent();
        }
        private static ucSelectSeat _instance;
        public static ucSelectSeat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucSelectSeat();
                }
                return _instance;
            }
        }
        balTicket ticket = new balTicket();
        List<SimpleButton> DanhSachChon = new List<SimpleButton>();
        private void btnSeat1_Click(object sender, EventArgs e)
        {
            if (txtCusID.Text == "")
            {
                SimpleButton btn = sender as SimpleButton;
                if (btn.Appearance.BackColor == DXSkinColors.FillColors.Success)
                {
                    btn.Appearance.BackColor = DXSkinColors.FillColors.Question;
                    DanhSachChon.Add(btn);
                    long lg = ticket.GetTotalMoney(DanhSachChon.Count);
                    txtTotalMoney.Text = lg.ToString();
                }
                else if (btn.Appearance.BackColor == DXSkinColors.FillColors.Question)
                {
                    btn.Appearance.BackColor = DXSkinColors.FillColors.Success;
                    DanhSachChon.Remove(btn);
                    long lg = ticket.GetTotalMoney(DanhSachChon.Count);
                    txtTotalMoney.Text = lg.ToString();
                }
                else if (btn.Appearance.BackColor == DXSkinColors.FillColors.Warning)
                {
                    MessageBox.Show("Ghế đã được chọn!");
                }
            }
            else
            {
                SimpleButton btn = sender as SimpleButton;
                if (btn.Appearance.BackColor == DXSkinColors.FillColors.Success)
                {
                    btn.Appearance.BackColor = DXSkinColors.FillColors.Question;
                    DanhSachChon.Add(btn);
                    long lg = ticket.GetTotalMoney(DanhSachChon.Count, Convert.ToInt32(txtCusID.Text));
                    txtTotalMoney.Text = lg.ToString();
                }
                else if (btn.Appearance.BackColor == DXSkinColors.FillColors.Question)
                {
                    btn.Appearance.BackColor = DXSkinColors.FillColors.Success;
                    DanhSachChon.Remove(btn);
                    long lg = ticket.GetTotalMoney(DanhSachChon.Count, Convert.ToInt32(txtCusID.Text));
                    txtTotalMoney.Text = lg.ToString();
                }
                else if (btn.Appearance.BackColor == DXSkinColors.FillColors.Warning)
                {
                    MessageBox.Show("Ghế đã được chọn!");
                }
            }
        }

        private void txtCusID_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (txtCusID.Text == "")
            {
                long lg = ticket.GetTotalMoney(DanhSachChon.Count);
                txtTotalMoney.Text = lg.ToString();
            }
            else
            {
                long lg = ticket.GetTotalMoney(DanhSachChon.Count, Convert.ToInt32(txtCusID.Text));
                txtTotalMoney.Text = lg.ToString();
            }
        }
    }
}
