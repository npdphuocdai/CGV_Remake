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
            DataTable Customers = dalCustomer.GetCustomers();
            for (int i = 0; i < Customers.Rows.Count; i++)
            {
                dtoCustomer Customer = new dtoCustomer();
                DataRow row = Customers.Rows[i];
                Customer.CustomerID = Convert.ToInt32(row[0]);
                Customer.FullName = row[1].ToString();
                Customer.Gender = row[2].ToString();
                Customer.PhoneNumber = row[3].ToString();
                Customer.Email = row[4].ToString();
                Customer.Email = row[7].ToString();
                Customer.BirthDay = Convert.ToDateTime(row[6]);               
                Customer.Address = row[5].ToString();   
                listEmp.Add(Customer);
            }
            return listEmp;
        }
        public int UpdateFromView(dtoViewCustomer viewCustomer)
        {
            dalCustomer Customer = new dalCustomer();
            int count = Customer.SelfUpdateCustomerFromView(viewCustomer);
            return count;
        }
    }
}
