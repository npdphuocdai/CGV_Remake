using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalViewEmployee : DatabaseServices
    {
        public DataTable GetViewEmployees()
        {
            DataTable employees = new DataTable();
            try
            {
                string sql = "SELECT* FROM[dbo].[ViewEmployee]";
                SqlDataAdapter adapter = Adapter(sql);
                if (adapter != null)
                {
                    adapter.Fill(employees);
                }
            }
            finally
            {
                CloseConnection();
            }
            return employees;
        }
    }
}
