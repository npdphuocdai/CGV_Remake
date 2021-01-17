using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Customer được kế thừa từ Class Human với các thuộc tính có sẵn từ Human
    /// </summary>
    public class dtoCustomer : dtoHuman
    {
        /// <summary>
        /// Thuộc tính CustomerID là khóa của bảng Customer trong Database
        /// </summary>
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
