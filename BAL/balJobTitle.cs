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
    public class balJobTitle
    {
        public List<dtoJobTitle> GetJobTitles()
        {
            dalJobTitle dalJobTitle = new dalJobTitle();
            List<dtoJobTitle> listEmp = new List<dtoJobTitle>();
            DataTable jobtitles = dalJobTitle.GetJobTitle();
            for (int i = 0; i < jobtitles.Rows.Count; i++)
            {
                dtoJobTitle jobtitle = new dtoJobTitle();
                DataRow row = jobtitles.Rows[i];
                jobtitle.JobTitleID = Convert.ToInt32(row[0]);
                jobtitle.JobTitleName = row[1].ToString();
                jobtitle.Major = row[2].ToString();
                jobtitle.PositionAllowance = Convert.ToDecimal(row[3]);
                jobtitle.CoefficientsSalary = Convert.ToDouble(row[4]);                
                listEmp.Add(jobtitle);
            }
            return listEmp;
        }
    }
}
