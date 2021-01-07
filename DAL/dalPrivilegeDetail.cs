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
    class dalPrivilegeDetail :DatabaseServices
    {
        public bool CheckPrivilege(int jobtitleid, int privilegeid)
        {
            bool kq = false;
            try
            {
                string sql = "SELECT * FROM [dbo].[PrivilegeDetail] WHERE [JobTitleID] = @JobTitleID AND [PrivilegeID] = @PrivilegeID";
                SqlParameter parameterJobTilteID = new SqlParameter("@JobTitleID", SqlDbType.Int);
                parameterJobTilteID.Value = jobtitleid;
                SqlParameter parameterPrivilegeID = new SqlParameter("@PrivilegeID", SqlDbType.Int);
                parameterPrivilegeID.Value = privilegeid;
                SqlDataReader reader = ReadDataPars(sql, new[] { parameterJobTilteID, parameterPrivilegeID });
                if (reader.Read())
                {
                    kq = true;
                }
            }
            finally
            {
                CloseConnection();
            }
            return kq;
        }

    }
}
