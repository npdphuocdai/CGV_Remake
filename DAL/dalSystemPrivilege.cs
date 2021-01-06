using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class dalSystemPrivilege : DatabaseServices
    {
        public List<dtoSystemPrivilege> GetPrivileges()
        {
            List<dtoSystemPrivilege> privileges = new List<dtoSystemPrivilege>();
            try
            {
                string sql = "SELECT * FROM [dbo].[SystemPrivilege]";
                SqlDataReader reader = ReadData(sql);
                while (reader.Read())
                {
                    dtoSystemPrivilege privilege = new dtoSystemPrivilege();
                    privilege.PrivilegeID = Convert.ToInt32((dtoSystemPrivilege)reader[0]);
                    privilege.PrivilegeName = ((dtoSystemPrivilege)reader[1]).ToString();
                    privileges.Add(privilege);
                }
            }
            finally
            {
                CloseConnection();
            }
            return privileges;
        }
        public int InsertPrivilege(dtoSystemPrivilege privilege)
        {
            int count = 0;
            try
            {
                string sql = "INSERT [dbo].[SystemPrivilege] ([PrivilegeName]) VALUES (@PrivilegeName)";
                SqlParameter parameterPrivilegeName = new SqlParameter("@PrivilegeName", SqlDbType.Int);
                parameterPrivilegeName.Value = privilege.PrivilegeName;
                count = InsertUpdateDeleteData(sql, new[] { parameterPrivilegeName });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        public int UpdatePrivilege(dtoSystemPrivilege privilege)
        {
            int count = 0;
            try
            {
                string sql = "UPDATE [dbo].[SystemPrivilege] SET [PrivilegeName] = @PrivilegeName WHERE [PrivilegeID] = @PrivilegeID";
                SqlParameter parameterPrivilegeID = new SqlParameter("@PrivilegeID", SqlDbType.Int);
                parameterPrivilegeID.Value = privilege.PrivilegeID;
                SqlParameter parameterPrivilegeName = new SqlParameter("@PrivilegeName", SqlDbType.NVarChar);
                parameterPrivilegeName.Value = privilege.PrivilegeName;
                count = InsertUpdateDeleteData(sql, new[] { parameterPrivilegeID, parameterPrivilegeName });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
    }
}
