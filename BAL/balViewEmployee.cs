using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BAL
{
    public class balViewEmployee
    {
        public List<dtoViewEmployee> GetViewEmployees()
        {
            dalViewEmployee ViewEmployee = new dalViewEmployee();
            List<dtoViewEmployee> listEmp = new List<dtoViewEmployee>();
            DataTable employees = ViewEmployee.GetViewEmployees();
            for (int i = 0; i < employees.Rows.Count; i++)
            {
                dtoViewEmployee employee = new dtoViewEmployee();
                DataRow row = employees.Rows[i];
                employee.EmployeeID = Convert.ToInt32(row[0]);
                employee.Gender = row[1].ToString();
                employee.EmployeeFullName = row[2].ToString();
                employee.EmployeeBirthday = Convert.ToDateTime(row[3]);
                employee.EmployeeAddress = row[4].ToString();
                employee.EmployeePhoneNumber= row[5].ToString();
                employee.EmployeeEmail = row[6].ToString();
                employee.StartDay = Convert.ToDateTime(row[7]);
                employee.JobtitleName = row[8].ToString();
                employee.BasicSalary = Convert.ToDecimal(row[9]);
                employee.CoefficientsSalary = Convert.ToInt32(row[10]);
                employee.PositionAllowance = Convert.ToDecimal(row[11]);
                employee.Major = row[12].ToString();
                employee.EmployeePotrait = (byte[])row[13];
                listEmp.Add(employee);
            }
            return listEmp;
        }
    }
}
