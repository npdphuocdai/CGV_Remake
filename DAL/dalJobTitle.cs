using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class dalJobTitle : DatabaseServices
    {
        /// <summary>
        /// Hàm lấy danh sách chức vụ
        /// </summary>
        /// <returns></returns>
        public List<dtoJobTitle> GetJobTitles()
        {
            List<dtoJobTitle> jobTitles = new List<dtoJobTitle>();
            try
            {
                string sql = "SELECT * FROM [dbo].[JobTitle]";
                SqlDataReader reader = ReadData(sql);
                while (reader.Read())
                {
                    dtoJobTitle jobTitle = new dtoJobTitle();
                    jobTitle.JobTitleID = Convert.ToInt32((dtoJobTitle)reader[0]);
                    jobTitle.JobTitleName = ((dtoJobTitle)reader[1]).ToString();
                    jobTitle.Major = ((dtoJobTitle)reader[2]).ToString();
                    jobTitle.PositionAllowance = Convert.ToDecimal((dtoJobTitle)reader[3]);
                    jobTitle.CoefficientsSalary = Convert.ToDouble((dtoJobTitle)reader[4]);
                    jobTitles.Add(jobTitle);
                }
            }
            finally
            {
                CloseConnection();
            }
            return jobTitles;
        }
        /// <summary>
        /// Thêm chức vụ mới
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public int InsertJobTitle(dtoJobTitle title)
        {
            int count = 0;
            try
            {
                string sql = "INSERT [dbo].[JobTitle] ([JobTitleName], [Major], [PositionAllowance], [CoefficientsSalary]) VALUES ( @JobTitleName, @Major, @PositionAllowance, @CoefficientsSalary)";
                SqlParameter parameterJobTitleName = new SqlParameter("@JobTitleName", SqlDbType.NVarChar);
                parameterJobTitleName.Value = title.JobTitleName;
                SqlParameter parameterMajor = new SqlParameter("@Major", SqlDbType.NVarChar);
                parameterMajor.Value = title.Major;
                SqlParameter parameterPositionAllowance = new SqlParameter("@PositionAllowance", SqlDbType.Money);
                parameterPositionAllowance.Value = title.PositionAllowance;
                SqlParameter parameterCoefficientsSalary = new SqlParameter("@CoefficientsSalary", SqlDbType.Float);
                parameterCoefficientsSalary.Value = title.CoefficientsSalary;
                count = InsertUpdateDeleteData(sql, new[] { parameterJobTitleName, parameterMajor, parameterPositionAllowance, parameterCoefficientsSalary });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        /// <summary>
        /// Cập nhập lại chức vụ
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public int UpdateJobTitle(dtoJobTitle title)
        {
            int count = 0;
            try
            {
                string sql = "UPDATE [dbo].[JobTitle] SET [JobTitleName] = @JobTitleName, [Major] = @Major, [PositionAllowance] = @PositionAllowance, [CoefficientsSalary] = @CoefficientsSalary WHERE [JobTitleID] = @JobTitleID";
                SqlParameter parameterJobTitleID = new SqlParameter("@JobTitleID", SqlDbType.Int);
                parameterJobTitleID.Value = title.JobTitleID;
                SqlParameter parameterJobTitleName = new SqlParameter("@JobTitleName", SqlDbType.NVarChar);
                parameterJobTitleName.Value = title.JobTitleName;
                SqlParameter parameterMajor = new SqlParameter("@Major", SqlDbType.NVarChar);
                parameterMajor.Value = title.Major;
                SqlParameter parameterPositionAllowance = new SqlParameter("@PositionAllowance", SqlDbType.Money);
                parameterPositionAllowance.Value = title.PositionAllowance;
                SqlParameter parameterCoefficientsSalary = new SqlParameter("@CoefficientsSalary", SqlDbType.Float);
                parameterCoefficientsSalary.Value = title.CoefficientsSalary;
                count = InsertUpdateDeleteData(sql, new[] { parameterJobTitleName, parameterMajor, parameterPositionAllowance, parameterCoefficientsSalary });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
    }
}
