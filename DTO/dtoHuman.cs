using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoHuman
    {
        public string FullName { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public dtoHuman()
        {
            
        }
        public dtoHuman(string fullname, DateTime birthday, string address, string phonenumber, string email)
        {
            FullName = fullname;
            BirthDay = birthday;
            Address = address;
            PhoneNumber = phonenumber;
            Email = email;
        }
    }
}
