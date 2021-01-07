using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    class dalSetDetail : DatabaseServices
    {
        public DataTable GetSetDetails()
        {
            DataTable setDetails = new DataTable();
            try
            {
                string sql = "SELECT * FROM [dbo].[SetDetail]";
                SqlDataAdapter adapter = Adapter(sql);
                if (adapter != null)
                {
                    adapter.Fill(setDetails);
                }
            }
            finally
            {
                CloseConnection();
            }
            return setDetails;
        }
    }
}
