using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoEmployee : dtoHuman
    {
        public int EmployeeID;
        public byte[] Potrait { get; set; }
        public decimal? BasicSalary { get; set; }
        public DateTime? StartDay { get; set; }
        public string Password { get; set; }
        public int JobTitleID { get; set; }
    }
}
