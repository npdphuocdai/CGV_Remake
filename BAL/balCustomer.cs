using System;
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
    public class balCustomer
    {
        public List<dtoCustomer> GetCustomers()
        {
            dalCustomer dalCustomer = new dalCustomer();
            List<dtoCustomer> listEmp = new List<dtoCustomer>();
            DataTable customers = dalCustomer.GetCustomers();
            for (int i = 0; i < customers.Rows.Count; i++)
            {
                dtoCustomer customer = new dtoCustomer();
                DataRow row = customers.Rows[i];
                customer.CustomerID = Convert.ToInt32(row[0]);
                customer.FullName = row[1].ToString();
                customer.Gender = row[2].ToString();
                customer.BirthDay = Convert.ToDateTime(row[3]);
                customer.Address = row[5].ToString();
                customer.PhoneNumber = row[6].ToString();
                customer.Email = row[7].ToString();
                listEmp.Add(customer);
            }
            return listEmp;
        }
    }
}
