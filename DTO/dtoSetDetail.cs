using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class dtoSetDetail
    {
        public int FilmID { get; set; }
        public int SetID { get; set; }
        public int TotalSeats { get; set; }
        public int TotalEmptySeats { get; set; }
        public DateTime ShowingDate { get; set; }
        public int RoomID { get; set; }
    }
}
