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
        public DataTable GetJobTitles()
        {
            DataTable jobTitles = new DataTable();
            try
            {
                string sql = "SELECT * FROM [dbo].[JobTitle]";
                SqlDataAdapter adapter = Adapter(sql);
                if(adapter != null)
                {
                    adapter.Fill(jobTitles);
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
