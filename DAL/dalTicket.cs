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
        public int InsertTicket(dtoTicket ticket)
        {
            int count = 0;
            try
            {
                string sql = "INSERT [dbo].[Ticket] ([TimeCreated], [TicketPrice], [SeatName], [FilmID], [SetID], [CustomerID], [EmployeeID]) VALUES (@TimeCreate, @Price, @SeatName, @FilmID, @SetID, @CustomerID, @EmployeeID)";
                SqlParameter parameterTimeCreate = new SqlParameter("@TimeCreate", SqlDbType.DateTime);
                parameterTimeCreate.Value = ticket.TimeCreate;
                SqlParameter parameterPrice = new SqlParameter("@Price", SqlDbType.Decimal);
                parameterPrice.Value = ticket.TicketPrice;
                SqlParameter parameterSeatName = new SqlParameter("@SeatName", SqlDbType.NVarChar);
                parameterSeatName.Value = ticket.SeatName;
                SqlParameter parameterFilmID = new SqlParameter("@FilmID", SqlDbType.Int);
                parameterFilmID.Value = ticket.FilmID;
                SqlParameter parameterSetID = new SqlParameter("@SetID", SqlDbType.Int);
                parameterSetID.Value = ticket.SetID;
                SqlParameter parameterCustomerID = new SqlParameter("@CustomerID", SqlDbType.Int);
                parameterCustomerID.Value = ticket.CustomerID;
                SqlParameter parameterEmployeeID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                parameterEmployeeID.Value = ticket.EmployeeID;
                count = InsertUpdateDeleteData(sql, new[] { parameterTimeCreate, parameterPrice, parameterSeatName, parameterFilmID, parameterSetID, parameterCustomerID, parameterEmployeeID });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        public DataTable GetTickets()
        {
            DataTable tickets = new DataTable();
            try
            {
                string sql = "SELECT * from [dbo].[Ticket]";
                SqlDataAdapter adapter = Adapter(sql);
                if(adapter != null)
                {
                    adapter.Fill(tickets);
                }                
            }
            finally
            {
                CloseConnection();
            }
            return tickets;
        }
    }
}
