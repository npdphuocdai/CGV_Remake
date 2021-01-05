using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;

namespace BAL
{
    class balEmployee
    {
        public bool Login(int username, string password)
        {
            dalEmployee dalEmployee = new dalEmployee();
            bool kq = dalEmployee.CheckUser(username, password);
            return kq;
        }
        public SqlDataReader GetUserLogin(int username)
        {
            dalEmployee dalEmployee = new dalEmployee();
            return dalEmployee.SearchEmployeeFromID(username);
        }

    }
}
