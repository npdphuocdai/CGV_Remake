using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class dalTicket : DatabaseServices
    {
        public List<dtoTicket> GetTickets()
        {
            List<dtoTicket> tickets = new List<dtoTicket>();
            try
            {
                string sql = "SELECT * from [dto].[Ticket]";
                SqlDataReader reader = ReadData(sql);
                while(reader.Read())
                {
                    dtoTicket ticket = new dtoTicket();
                    ticket.TicketID = Convert.ToInt32((dtoTicket)reader[0]);
                    ticket.TimeCreate = Convert.ToDateTime((dtoTicket)reader[1]);
                    ticket.TicketPrice = Convert.ToDecimal((dtoTicket)reader[2]);
                    ticket.SeatName = ((dtoTicket)reader[3]).ToString();
                    ticket.FilmID = Convert.ToInt32((dtoTicket)reader[4]);
                    ticket.SetID = Convert.ToInt32((dtoTicket)reader[5]);
                    ticket.CustomerID = Convert.ToInt32((dtoTicket)reader[6]);
                    ticket.EmployeeID = Convert.ToInt32((dtoTicket)reader[7]);
                    tickets.Add(ticket);
                }
                reader.Close();
            }
            finally
            {
                CloseConnection();
            }
            return tickets;
        }
    }
}
