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
        public dtoEmployee()
        {
            
        }
        public dtoEmployee(string fullname, DateTime birthday, string address, string phonenumber, string email, int employeeid, byte[] potrait, decimal basicsalary, DateTime starday, string password, int jobtilteid)
        {
            FullName = fullname;
            BirthDay = birthday;
            Address = address;
            PhoneNumber = phonenumber;
            Email = email;
            EmployeeID = employeeid;
            Potrait = potrait;
            BasicSalary = basicsalary;
            StartDay = starday;
            JobTitleID = jobtilteid;
        }
    }
}
