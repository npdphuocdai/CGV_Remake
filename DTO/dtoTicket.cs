using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoTicket
    {
        public int TicketID { get; set; }
        public DateTime? TimeCreate { get; set; }
        public decimal? TicketPrice { get; set; }
        public string SeatName { get; set; }
        public int FilmID { get; set; }
        public int SetID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
    }
}
