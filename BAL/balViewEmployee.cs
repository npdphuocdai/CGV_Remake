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
        public List<dtoViewEmployees> GetViewEmployees()
        {
            dalViewEmployee ViewEmployee = new dalViewEmployee();
            List<dtoViewEmployees> listEmp = new List<dtoViewEmployees>();
            DataTable employees = ViewEmployee.GetViewEmployees();
            for (int i = 0; i < employees.Rows.Count; i++)
            {
                dtoViewEmployees employee = new dtoViewEmployees();
                DataRow row = employees.Rows[i];
                employee.EmployeeID = Convert.ToInt32(row[0]);
                employee.Gender = row[1].ToString();
                employee.EmployeeFullName = row[2].ToString();
                employee.EmployeeBirthday = Convert.ToDateTime(row[3]);
                employee.EmployeeAddress = row[4].ToString();
                employee.JobTitleID = Convert.ToInt32(row[5]);
                employee.EmployeePhoneNumber= row[6].ToString();
                employee.EmployeeEmail = row[7].ToString();
                employee.StartDay = Convert.ToDateTime(row[8]);
                employee.JobtitleName = row[9].ToString();
                employee.BasicSalary = Convert.ToDecimal(row[10]);
                employee.CoefficientsSalary = Convert.ToInt32(row[11]);
                employee.PositionAllowance = Convert.ToDecimal(row[12]);
                employee.Major = row[13].ToString();
                employee.EmployeePotrait = (byte[])row[14];
                listEmp.Add(employee);
            }
            return listEmp;
        }
    }
}
