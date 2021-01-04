using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class dalEmployee : DatabaseServices
    {
        dtoEmployee employee = new dtoEmployee();
        /// <summary>
        /// Hàm check tài khoản của user có tồn tại hay không
        /// </summary>
        /// <param name="username"> đây là tài khoản hoặc mã nhân viên </param>
        /// <param name="password"> là password </param>
        /// cả 2 đều được nhập từ text box
        /// <returns> giá trị kiểu bool biểu thị cho việc tồn tại hay không </returns>
        public bool CheckUser(string username, string password)
        {
            bool kq = false;
            try
            {
                //Tạo câu truy vấn có điều kiện để tìm kiếm user
                string sql = "SELECT * FROM Employee WHERE EmployeeID = @Username AND Password = @Password";
                //Truyền giá trị cho 2 tham số
                SqlParameter parameterUser = new SqlParameter("@Username", SqlDbType.Int);
                parameterUser.Value = username;
                SqlParameter parameterPass = new SqlParameter("@Password", SqlDbType.NVarChar);
                parameterPass.Value = password;
                //Sử dụng hàm ReadDataPars để truy xuất thông tin
                SqlDataReader reader = ReadDataPars(sql, new[] { parameterUser, parameterPass });
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
        public SqlDataReader SearchFromID(int employeeID)
        {
            SqlDataReader reader = null;
            try
            {
                string sql = "SELECT * FROM Employee WHERE EmployeeID = @EmployeeID";
                SqlParameter parameterID = new SqlParameter("@EmployeeID", SqlDbType.NVarChar);
                parameterID.Value = employeeID;
                reader = ReadDataPars(sql, new[] { parameterID });
            }
            finally
            {
                CloseConnection();
            }
            return reader;
        }
        public SqlDataReader SearchFromName(string employeeName)
        {
            SqlDataReader reader = null;
            try
            {
                string sql = "SELECT * FROM Employee WHERE EmployeeFullName = @EmployeeName";
                SqlParameter parameterName = new SqlParameter("@EmployeeName", SqlDbType.NVarChar);
                parameterName.Value = employeeName;
                reader = ReadDataPars(sql, new[] { parameterName });
            }
            finally
            {
                CloseConnection();
            }
            return reader;
        }
        public int InsertEmployee(string name, byte[] potrait, DateTime birthday, string address, string phonenumber, string email, decimal basicsalary, int jobtitleid, DateTime startday)
        {
            int count = 0;
            try
            {
                string sql = "INSERT [dbo].[Employee] ([EmployeeFullName], [EmployeePotrait], [EmployeeBirthday], [EmployeeAddress], [EmployeePhoneNumber], [EmployeeEmail], [BasicSalary], [JobTilteID], [StartDay]) VALUES (@Name, @Portrait, @BirthDay, @Address, @PhoneNumber, @Email, @BasicSalary, @JobTitleID, @StartDay)";
                SqlParameter parameterName = new SqlParameter("@Name",SqlDbType.NVarChar);
                parameterName.Value = name;
                SqlParameter parameterPotrait = new SqlParameter("@Potrait", SqlDbType.Image);
                parameterPotrait.Value = potrait;
                SqlParameter parameterBirthDay = new SqlParameter("@BirthDay", SqlDbType.DateTime);
                parameterBirthDay.Value = birthday;
                SqlParameter parameterAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                parameterAddress.Value = address;
                SqlParameter parameterPhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.NVarChar);
                parameterPhoneNumber.Value = phonenumber;
                SqlParameter parameterEmail = new SqlParameter("@Email", SqlDbType.NVarChar);
                parameterEmail.Value = email;
                SqlParameter parameterBasicSalary = new SqlParameter("@BasicSalary", SqlDbType.Money);
                parameterBasicSalary.Value = basicsalary;
                SqlParameter parameterJobTitleID = new SqlParameter("@JobTitleID", SqlDbType.Int);
                parameterJobTitleID.Value = jobtitleid;
                SqlParameter parameterStartDay = new SqlParameter("@Name", SqlDbType.DateTime);
                parameterStartDay.Value = startday;
                count = InsertUpdateDeleteData(sql, new[] { parameterName, parameterPotrait, parameterBirthDay, parameterAddress, parameterPhoneNumber, parameterEmail, parameterBasicSalary, parameterJobTitleID, parameterStartDay });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        public int UpdateEmployeeFromID(int id,string name, byte[] potrait, DateTime birthday, string address, string phonenumber, string email, decimal basicsalary, int jobtitleid, DateTime startday)
        {
            int count = 0;
            try
            {
                string sql = "UPDATE [dbo].[Employee] SET EmployeeFullName = @Name, EmployeePotrait = @Portrait, EmployeeBirthDay = @BirthDay, EmployeeAddress = @Address, EmployeePhoneNumber = @PhoneNumber, EmployeeEmail = @Email, BasicSalary = @BasicSalary, JobTitleID = @JobTitleID, StartDay = @StartDay) WHERE EmployeeID = @EmployeeID";
                SqlParameter parameterID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                parameterID.Value = id;
                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = name;
                SqlParameter parameterPotrait = new SqlParameter("@Potrait", SqlDbType.Image);
                parameterPotrait.Value = potrait;
                SqlParameter parameterBirthDay = new SqlParameter("@BirthDay", SqlDbType.DateTime);
                parameterBirthDay.Value = birthday;
                SqlParameter parameterAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                parameterAddress.Value = address;
                SqlParameter parameterPhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.NVarChar);
                parameterPhoneNumber.Value = phonenumber;
                SqlParameter parameterEmail = new SqlParameter("@Email", SqlDbType.NVarChar);
                parameterEmail.Value = email;
                SqlParameter parameterBasicSalary = new SqlParameter("@BasicSalary", SqlDbType.Money);
                parameterBasicSalary.Value = basicsalary;
                SqlParameter parameterJobTitleID = new SqlParameter("@JobTitleID", SqlDbType.Int);
                parameterJobTitleID.Value = jobtitleid;
                SqlParameter parameterStartDay = new SqlParameter("@Name", SqlDbType.DateTime);
                parameterStartDay.Value = startday;
                count = InsertUpdateDeleteData(sql, new[] { parameterName, parameterPotrait, parameterBirthDay, parameterAddress, parameterPhoneNumber, parameterEmail, parameterBasicSalary, parameterJobTitleID, parameterStartDay });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
    }
}
