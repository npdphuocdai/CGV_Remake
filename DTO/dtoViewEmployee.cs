using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoViewEmployee
    {
        public int EmployeeID { get; set; }
        public byte[] EmployeePotrait { get; set; }
        public decimal? BasicSalary { get; set; }
        public DateTime? StartDay { get; set; }
        public string EmployeeFullName { get; set; }
        public string Gender { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeEmail { get; set; }
        public DateTime? EmployeeBirthday { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string JobtitleName { get; set; }
        public float CoefficientsSalary { get; set; }
        public decimal? PositionAllowance { get; set; }
        public string Major { get; set; }
        public int JobTitleID { get; set; }
    }
}
