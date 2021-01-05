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
    public class balEmployee
    {
        public bool Login(int username, string password)
        {
            dalEmployee dalEmployee = new dalEmployee();
            bool kq = dalEmployee.CheckUser(username, password);
            return kq;
        }
        public List<dtoEmployee> GetEmployees()
        {
            dalEmployee dalEmployee = new dalEmployee();
            List<dtoEmployee> employees = dalEmployee.GetEmployees();
            return employees;
        }
    }
}
