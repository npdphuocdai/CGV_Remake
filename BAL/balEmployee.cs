﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

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
            List<dtoEmployee> listEmp = new List<dtoEmployee>();
            DataTable employees = dalEmployee.GetEmployees();
            for(int i = 0; i < employees.Rows.Count; i++)
            {
                dtoEmployee employee = new dtoEmployee();
                DataRow row = employees.Rows[i];
                employee.EmployeeID = Convert.ToInt32(row[0]);
                employee.FullName = row[1].ToString();
                employee.Potrait = (byte[])row[2];
                employee.BirthDay = Convert.ToDateTime(row[3]);
                employee.Address = row[4].ToString();
                employee.PhoneNumber = row[5].ToString();
                employee.Email = row[6].ToString();
                employee.BasicSalary = Convert.ToDecimal(row[7]);
                employee.JobTitleID = Convert.ToInt32(row[8]);
                employee.StartDay = Convert.ToDateTime(row[9]);
                listEmp.Add(employee);
            }
            return listEmp;
        }
    }
}