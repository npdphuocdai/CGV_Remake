using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoCustomer : dtoHuman
    {
        public int CustomerID { get; set; }
        public dtoCustomer()
        {
            
        }
        public dtoCustomer(int customerid, string fullname, DateTime birthday, string address, string phonenumber, string email)
        {
            CustomerID = customerid;
            FullName = fullname;
            BirthDay = birthday;
            Address = address;
            PhoneNumber = phonenumber;
            Email = email;
        }
    }
}
