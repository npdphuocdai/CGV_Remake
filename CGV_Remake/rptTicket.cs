using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DTO;
using BAL;

namespace Viewer
{
    public partial class rptTicket : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTicket()
        {
            InitializeComponent();
        }
        public void InitData(dtoViewTicket ticket)
        {
            parMoviename.Value = ticket.FilmName;
            parCreator.Value = ticket.EmployeeFullName;
            parCustomer.Value = ticket.CustomerFullName;
            parCreateDate.Value = ticket.CreateDate;
            parSeatNo.Value = ticket.SeatName;
            parTicketNo.Value = ticket.TicketID;
            parStartTime.Value = ticket.StartTime;
            parRoomNo.Value = ticket.RoomID;
            if(ticket.CustomerBirthDay.Year <= 22)
            {
                parTicketType.Value = "U22";
            }
            else
            {
                parTicketType.Value = "Nomal";
            }
            parPrice.Value = ticket.TicketPrice;
        }
    }
}
