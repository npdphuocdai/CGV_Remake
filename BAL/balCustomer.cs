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
                Customer.BirthDay = Convert.ToDateTime(row[5]);               
                Customer.Address = row[6].ToString();   
                listEmp.Add(Customer);
            }
            return listEmp;
        }
        public bool CheckCustomer(int cusID)
        {
            bool kq = false;
            foreach (var i in GetCustomers())
            {
                if (i.CustomerID == cusID)
                {
                    kq = true;
                }
            }
            return kq;
        }
        public string GetCustomerName(int id)
        {
            dalCustomer dal = new dalCustomer();
            DataTable data = dal.GetCustomers();
            for(int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];
                if(Convert.ToInt32(row[0]) == id)
                {
                    return row[1].ToString();
                }
            }
            return null;
        }
        public DateTime GetCustomerBirthDay(int id)
        {
            DateTime customerBD = new DateTime();
            dalCustomer dal = new dalCustomer();
            DataTable data = dal.GetCustomers();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];
                if (Convert.ToInt32(row[0]) == id)
                {
                    customerBD = Convert.ToDateTime(row[5]);
                }
            }
            return customerBD;
        }
        public int Update(dtoCustomer dtoCustomer)
        {
            dalCustomer Customer = new dalCustomer();
            int count = Customer.UpdateCustomerFromID(dtoCustomer);
            return count;
        }
        public int Insert(dtoCustomer dtoCustomer)
        {
            dalCustomer dalCustomer = new dalCustomer();
            int count = dalCustomer.InsertCustomer(dtoCustomer);
            return count;
        }
    }
}
