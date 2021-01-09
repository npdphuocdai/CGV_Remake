using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace BAL
{
    public class balTicket
    {
        public List<dtoTicket> GetTickets()
        {
            dalTicket dalTicket = new dalTicket();
            List<dtoTicket> listEmp = new List<dtoTicket>();
            DataTable Tickets = dalTicket.GetTickets();
            for (int i = 0; i < Tickets.Rows.Count; i++)
            {
                dtoTicket Ticket = new dtoTicket();
                DataRow row = Tickets.Rows[i];
                if (row[6] is DBNull)
                {
                    Ticket.TicketID = Convert.ToInt32(row[0]);
                    Ticket.TimeCreate = Convert.ToDateTime(row[1]);
                    Ticket.TicketPrice = Convert.ToInt32(row[2]);
                    Ticket.SeatName = row[3].ToString();
                    Ticket.FilmID = Convert.ToInt32(row[4]);
                    Ticket.SetID = Convert.ToInt32(row[5]);
                    Ticket.EmployeeID = Convert.ToInt32(row[7]);
                    listEmp.Add(Ticket);
                }
                else
                {
                    Ticket.TicketID = Convert.ToInt32(row[0]);
                    Ticket.TimeCreate = Convert.ToDateTime(row[1]);
                    Ticket.TicketPrice = Convert.ToInt32(row[2]);
                    Ticket.SeatName = row[3].ToString();
                    Ticket.FilmID = Convert.ToInt32(row[4]);
                    Ticket.SetID = Convert.ToInt32(row[5]);
                    Ticket.CustomerID = Convert.ToInt32(row[6]);
                    Ticket.EmployeeID = Convert.ToInt32(row[7]);
                    listEmp.Add(Ticket);
                }
            }
            return listEmp;
        }
        public long GetTotalMoney(int sl,int id)
        {
            dalCustomer customer = new dalCustomer();
            if (customer.GetU22Customer(id))
            {
                return 45000 * sl;
            }
            else
            {
                return 75000 * sl;
            }
        }
        public long GetPrice( int id)
        {
            dalCustomer customer = new dalCustomer();
            if (customer.GetU22Customer(id))
            {
                return 45000;
            }
            else
            {
                return 75000;
            }
        }
        public long GetTotalMoney(int sl)
        {
            return 75000 * sl;
        }
        public int GetCountTicket()
        {
            string sql = "Select * From [dbo].[Ticket]";
            dalTicket dal = new dalTicket();
            int count = 0;
            SqlDataReader reader = dal.ReadData(sql);
            while (reader.Read())
            {
                count++;
            }
            return count;
        }
        public int InsertTicket(dtoTicket ticket)
        {
            dalTicket dal = new dalTicket();
            return dal.InsertTicket(ticket);
        }
        public int InsertTicketNonCusID(dtoTicket ticket)
        {
            dalTicket dal = new dalTicket();
            return dal.InsertTicketNonCusID(ticket);
        }
    }
}
