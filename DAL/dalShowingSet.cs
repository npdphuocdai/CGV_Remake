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
    class dalShowingSet : DatabaseServices
    {
        /// <summary>
        /// Hàm lấy list dữ liệu dạng ShowingSet từ Database
        /// </summary>
        /// <returns></returns>
        public DataTable GetShowingSets()
        {
            DataTable showingSets = new DataTable();
            try
            {
                string sql = "SELECT * FROM [dbo].[ShowingSet]";
                SqlDataAdapter adapter = Adapter(sql);
                if (adapter != null)
                {
                    adapter.Fill(showingSets);
                }
            }
            finally
            {
                CloseConnection();
            }
            return showingSets;
        }
        /// <summary>
        /// Hàm thêm xuất chiếu
        /// </summary>
        /// <param name="set"></param>
        /// <returns></returns>
        public int InsertShowingSet(dtoShowingSet set)
        {
            int count = 0;
            try
            {
                string sql = "INSERT [dbo].[ShowingSet] ([StartTime], [EndTime]) VALUES ( @StartTime, @EndTime)";
                SqlParameter parameterStartTime = new SqlParameter("@StartTime", SqlDbType.DateTime);
                parameterStartTime.Value = set.StartTime;
                SqlParameter parameterEndTime = new SqlParameter("@EndTime", SqlDbType.DateTime);
                parameterEndTime.Value = set.EndTime;
                count = InsertUpdateDeleteData(sql, new[] { parameterStartTime, parameterEndTime });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        /// <summary>
        /// Hàm cập nhập xuất chiếu
        /// </summary>
        /// <param name="set"></param>
        /// <returns></returns>
        public int UpdateShowingSet(dtoShowingSet set)
        {
            int count = 0;
            try
            {
                string sql = "UPDATE [dbo].[ShowingSet] SET [StartTime] = @StartTime, [EndTime] = @EndTime";
                SqlParameter parameterStartTime = new SqlParameter("@StartTime", SqlDbType.DateTime);
                parameterStartTime.Value = set.StartTime;
                SqlParameter parameterEndTime = new SqlParameter("@EndTime", SqlDbType.DateTime);
                parameterEndTime.Value = set.EndTime;
                count = InsertUpdateDeleteData(sql, new[] { parameterStartTime, parameterEndTime });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
    }
}
