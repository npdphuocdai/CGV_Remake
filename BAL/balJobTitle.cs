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
                DataTable JobTitles = dalJobTitle.GetJobTitles();
                for (int i = 0; i < JobTitles.Rows.Count; i++)
                {
                    dtoJobTitle JobTitle = new dtoJobTitle();
                    DataRow row = JobTitles.Rows[i];
                    JobTitle.JobTitleID = Convert.ToInt32(row[0]);
                    JobTitle.JobTitleName = row[1].ToString();
                    JobTitle.Major = row[2].ToString();
                    JobTitle.PositionAllowance = Convert.ToDecimal(row[3]);
                    JobTitle.CoefficientsSalary = Convert.ToDouble(row[4]);
                    
                    listEmp.Add(JobTitle);
                }
                return listEmp;
            }
        }
}
