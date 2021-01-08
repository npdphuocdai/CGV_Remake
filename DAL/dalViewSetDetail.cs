using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalViewSetDetail: DatabaseServices
    {
        /// <summary>
        /// Hàm để đổ dữ liệu vào một biến kiểu DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable GetViewSetDetails()
        {
            DataTable setDetails = new DataTable();
            try
            {
                string sql = "SELECT* FROM[dbo].[ViewSetDetail]";
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
