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
    public class balSystemPrivilege
    {
        public List<dtoSystemPrivilege> GetSystemPrivileges()
        {
            dalSystemPrivilege dalSystemPrivilege = new dalSystemPrivilege();
            List<dtoSystemPrivilege> listEmp = new List<dtoSystemPrivilege>();
            DataTable SystemPrivileges = dalSystemPrivilege.GetSystemPrivileges();
            for (int i = 0; i < SystemPrivileges.Rows.Count; i++)
            {
                dtoSystemPrivilege SystemPrivilege = new dtoSystemPrivilege();
                DataRow row = SystemPrivileges.Rows[i];
                SystemPrivilege.PrivilegeID = Convert.ToInt32(row[0]);
                SystemPrivilege.PrivilegeName = row[1].ToString();                
                listEmp.Add(SystemPrivilege);
            }
            return listEmp;
        }
    }
}
