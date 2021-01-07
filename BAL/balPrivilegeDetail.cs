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
    public class balPrivilegeDetail
    {
        public List<dtoPrivilegeDetail> GetPrivilegeDetails()
        {
            dalPrivilegeDetail dalPrivilegeDetail = new dalPrivilegeDetail();
            List<dtoPrivilegeDetail> listEmp = new List<dtoPrivilegeDetail>();
            DataTable PrivilegeDetails = dalPrivilegeDetail.GetPrivilegeDetails();
            for (int i = 0; i < PrivilegeDetails.Rows.Count; i++)
            {
                dtoPrivilegeDetail PrivilegeDetail = new dtoPrivilegeDetail();
                DataRow row = PrivilegeDetails.Rows[i];
                PrivilegeDetail.JobTitleID = Convert.ToInt32(row[0]);
                PrivilegeDetail.PrivilegeID = Convert.ToInt32(row[1]);
                PrivilegeDetail.Description = row[2].ToString();
                listEmp.Add(PrivilegeDetail);
            }
            return listEmp;
        }
    }
}
