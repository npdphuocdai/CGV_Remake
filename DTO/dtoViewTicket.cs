using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoViewTicket
    {
        public int TicketID { get; set; }
        public string EmployeeFullName { get; set; }
        public string CustomerFullName { get; set; }
        public string FilmName { get; set; }
        public int RoomID { get; set; }
        public string StartTime { get; set; }
        public decimal TicketPrice { get; set; }
        public string SeatName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime CustomerBirthDay { get; set; }
    }
}
