using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Project DTO là project để chứa các class đại diện cho các bảng trong Database
/// </summary>
namespace DTO
{
    /// <summary>
    /// Class Human là Super Class của Employee và Customer
    /// </summary>
    public class dtoHuman
    {
        public string FullName { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        /// <summary>
        /// Contructor chuẩn
        /// </summary>
        public dtoHuman()
        {
            
        }
        /// <summary>
        /// Contructor có tham số
        /// </summary>
        /// <param name="fullname"></param>
        /// <param name="birthday"></param>
        /// <param name="address"></param>
        /// <param name="phonenumber"></param>
        /// <param name="email"></param>
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
