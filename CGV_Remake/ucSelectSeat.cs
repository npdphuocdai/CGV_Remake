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
        balEmployee employee = new balEmployee();
        balTicket ticket = new balTicket();
        balCustomer customer = new balCustomer();
        balSetDetail setDetail = new balSetDetail();
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
                txtU22.Text = "0";
            }
            else
            {
                long lg = ticket.GetTotalMoney(DanhSachChon.Count, Convert.ToInt32(txtCusID.Text));
                DateTime cusBD = new DateTime();
                cusBD = customer.GetCustomerBirthDay(Convert.ToInt32(txtCusID.Text));
                if ((DateTime.Now.Year - cusBD.Year) <= 22)
                {
                    txtU22.Text = DanhSachChon.Count.ToString();
                }
                else
                {
                    txtU22.Text = "0";
                }
                txtTotalMoney.Text = lg.ToString();
            }
        }
        public void MakeUp(SimpleButton btn)
        {
            btn.Appearance.BackColor = DXSkinColors.FillColors.Warning;
        }

        List<SimpleButton> simpleButtons = new List<SimpleButton>();
        public void AddButtons()
        {
            simpleButtons.Add(btnSeat1);
            simpleButtons.Add(btnSeat2);
            simpleButtons.Add(btnSeat3);
            simpleButtons.Add(btnSeat4);
            simpleButtons.Add(btnSeat5);
            simpleButtons.Add(btnSeat6);
            simpleButtons.Add(btnSeat7);
            simpleButtons.Add(btnSeat8);
            simpleButtons.Add(btnSeat9);
            simpleButtons.Add(btnSeat10);
            simpleButtons.Add(btnSeat11);
            simpleButtons.Add(btnSeat12);
            simpleButtons.Add(btnSeat13);
            simpleButtons.Add(btnSeat14);
            simpleButtons.Add(btnSeat15);
            simpleButtons.Add(btnSeat16);
            simpleButtons.Add(btnSeat17);
            simpleButtons.Add(btnSeat18);
            simpleButtons.Add(btnSeat19);
            simpleButtons.Add(btnSeat20);
            simpleButtons.Add(btnSeat21);
            simpleButtons.Add(btnSeat22);
            simpleButtons.Add(btnSeat23);
            simpleButtons.Add(btnSeat24);
            simpleButtons.Add(btnSeat25);
            simpleButtons.Add(btnSeat26);
            simpleButtons.Add(btnSeat27);
            simpleButtons.Add(btnSeat28);
            simpleButtons.Add(btnSeat29);
            simpleButtons.Add(btnSeat30);
            simpleButtons.Add(btnSeat31);
            simpleButtons.Add(btnSeat32);
            simpleButtons.Add(btnSeat33);
            simpleButtons.Add(btnSeat34);
            simpleButtons.Add(btnSeat35);
            simpleButtons.Add(btnSeat36);
            simpleButtons.Add(btnSeat37);
            simpleButtons.Add(btnSeat38);
            simpleButtons.Add(btnSeat39);
            simpleButtons.Add(btnSeat40);
            simpleButtons.Add(btnSeat41);
            simpleButtons.Add(btnSeat42);
            simpleButtons.Add(btnSeat43);
            simpleButtons.Add(btnSeat44);
            simpleButtons.Add(btnSeat45);
            simpleButtons.Add(btnSeat46);
            simpleButtons.Add(btnSeat47);
            simpleButtons.Add(btnSeat48);
            simpleButtons.Add(btnSeat49);
            simpleButtons.Add(btnSeat50);
            simpleButtons.Add(btnSeat51);
            simpleButtons.Add(btnSeat52);
            simpleButtons.Add(btnSeat53);
            simpleButtons.Add(btnSeat54);
            simpleButtons.Add(btnSeat55);
            simpleButtons.Add(btnSeat56);
            simpleButtons.Add(btnSeat57);
            simpleButtons.Add(btnSeat58);
            simpleButtons.Add(btnSeat59);
            simpleButtons.Add(btnSeat60);
            simpleButtons.Add(btnSeat61);
            simpleButtons.Add(btnSeat62);
            simpleButtons.Add(btnSeat63);
            simpleButtons.Add(btnSeat64);
            simpleButtons.Add(btnSeat65);
            simpleButtons.Add(btnSeat66);
            simpleButtons.Add(btnSeat67);
            simpleButtons.Add(btnSeat68);
            simpleButtons.Add(btnSeat69);
            simpleButtons.Add(btnSeat70);
            simpleButtons.Add(btnSeat71);
            simpleButtons.Add(btnSeat72);
            simpleButtons.Add(btnSeat73);
            simpleButtons.Add(btnSeat74);
            simpleButtons.Add(btnSeat75);
            simpleButtons.Add(btnSeat76);
            simpleButtons.Add(btnSeat77);
            simpleButtons.Add(btnSeat78);
            simpleButtons.Add(btnSeat79);
            simpleButtons.Add(btnSeat80);
            simpleButtons.Add(btnSeat81);
            simpleButtons.Add(btnSeat82);
            simpleButtons.Add(btnSeat83);
            simpleButtons.Add(btnSeat84);
            simpleButtons.Add(btnSeat85);
            simpleButtons.Add(btnSeat86);
            simpleButtons.Add(btnSeat87);
            simpleButtons.Add(btnSeat88);
            simpleButtons.Add(btnSeat89);
            simpleButtons.Add(btnSeat90);
            simpleButtons.Add(btnSeat91);
            simpleButtons.Add(btnSeat92);
            simpleButtons.Add(btnSeat93);
            simpleButtons.Add(btnSeat94);
            simpleButtons.Add(btnSeat95);
            simpleButtons.Add(btnSeat96);
            simpleButtons.Add(btnFS1);
            simpleButtons.Add(btnFS2);
            simpleButtons.Add(btnCPS1);
            simpleButtons.Add(btnCPS2);
            simpleButtons.Add(btnCPS3);
            simpleButtons.Add(btnCPS4);
        }
        private void ucSelectSeat_Load(object sender, EventArgs e)
        {
            AddButtons();
            foreach (var i in ticket.GetTickets())
            {
                foreach (SimpleButton j in simpleButtons)
                {
                    if (i.SeatName == j.Text && i.SetID == TicketInfo.SetID && i.FilmID == TicketInfo.FilmID)
                    {
                        MakeUp(j);
                    }
                }
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int count = 0;
            List<dtoViewTicket> tickets = new List<dtoViewTicket>();
            string employeeName = employee.GetEmployeeName(frmLogin.UserLogin.EmployeeID);
            try
            {
                if(DanhSachChon.Count == 0)
                {
                    throw new Exception("Mời chọn ghế!");
                }
                else if(txtCusID.Text == "")
                {
                    foreach (var i in DanhSachChon)
                    {
                        dtoTicket dtoTicket = new dtoTicket();
                        dtoViewTicket viewTicket = new dtoViewTicket();
                        viewTicket.TicketID = ticket.GetCountTicket() + 1;
                        viewTicket.CustomerFullName = "Guest";
                        viewTicket.EmployeeFullName = employeeName;
                        viewTicket.FilmName = TicketInfo.FilmName;
                        viewTicket.RoomID = setDetail.GetRoomID(TicketInfo.FilmID, TicketInfo.SetID);
                        viewTicket.StartTime = TicketInfo.StartTime;
                        viewTicket.TicketPrice = 75000;
                        viewTicket.SeatName = i.Text;
                        viewTicket.CreateDate = DateTime.Now;
                        viewTicket.CustomerBirthDay = Convert.ToDateTime("01/01/1900");
                        tickets.Add(viewTicket);
                        //Thêm dữ liệu để lưu trữ lên DB
                        dtoTicket.EmployeeID = frmLogin.UserLogin.EmployeeID;
                        dtoTicket.SetID = TicketInfo.SetID;
                        dtoTicket.TicketPrice = 75000;
                        dtoTicket.TimeCreate = DateTime.Now;
                        dtoTicket.SeatName = i.Text;
                        dtoTicket.FilmID = TicketInfo.FilmID;
                        count += ticket.InsertTicket(dtoTicket);
                    }
                }
                else
                {
                    foreach (var i in DanhSachChon)
                    {
                        dtoTicket dtoTicket = new dtoTicket();
                        dtoViewTicket viewTicket = new dtoViewTicket();
                        viewTicket.TicketID = ticket.GetCountTicket() + 1;
                        viewTicket.CustomerFullName = customer.GetCustomerName(Convert.ToInt32(txtCusID.Text));
                        viewTicket.EmployeeFullName = employeeName;
                        viewTicket.FilmName = TicketInfo.FilmName;
                        viewTicket.RoomID = setDetail.GetRoomID(TicketInfo.FilmID, TicketInfo.SetID);
                        viewTicket.StartTime = TicketInfo.StartTime;
                        viewTicket.TicketPrice = Convert.ToDecimal(ticket.GetPrice(Convert.ToInt32(txtCusID.Text)));
                        viewTicket.SeatName = i.Text;
                        viewTicket.CreateDate = DateTime.Now;
                        viewTicket.CustomerBirthDay = customer.GetCustomerBirthDay(Convert.ToInt32(txtCusID.Text));
                        tickets.Add(viewTicket);
                        //Thêm dữ liệu để lưu trữ lên DB
                        dtoTicket.CustomerID = Convert.ToInt32(txtCusID.Text);
                        dtoTicket.EmployeeID = frmLogin.UserLogin.EmployeeID;
                        dtoTicket.SetID = TicketInfo.SetID;
                        dtoTicket.TicketPrice = ticket.GetPrice(Convert.ToInt32(txtCusID.Text));
                        dtoTicket.TimeCreate = DateTime.Now;
                        dtoTicket.SeatName = i.Text;
                        dtoTicket.FilmID = TicketInfo.FilmID;
                        count += ticket.InsertTicket(dtoTicket);
                    }
                }
                string tb = count.ToString() + " Vé đã được mua thành công";
                XtraMessageBox.Show(tb, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (var i in ticket.GetTickets())
                {
                    foreach (SimpleButton j in simpleButtons)
                    {
                        if (i.SeatName == j.Text && i.SetID == TicketInfo.SetID && i.FilmID == TicketInfo.FilmID)
                        {
                            MakeUp(j);
                        }
                    }
                }
                while(DanhSachChon.Count > 0)
                {
                    DanhSachChon.RemoveAt(0);
                }
                foreach (var i in tickets)
                {
                    using (frmPrintTicket frm = new frmPrintTicket())
                    {
                        frm.PrintTicket(i);
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
