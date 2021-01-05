using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.IO;
using System.Drawing;

namespace DAL
{
    public class dalEmployee : DatabaseServices
    {
        /// <summary>
        /// Hàm check tài khoản của user có tồn tại hay không
        /// </summary>
        /// <param name="username"> đây là tài khoản hoặc mã nhân viên </param>
        /// <param name="password"> là password </param>
        /// cả 2 đều được nhập từ text box
        /// <returns> giá trị kiểu bool biểu thị cho việc tồn tại hay không </returns>
        public bool CheckUser(int username, string password)
        {
            bool kq = false;
            try
            {
                //Tạo câu truy vấn có điều kiện để tìm kiếm user
                string sql = "SELECT * FROM [dbo].[Employee] WHERE [EmployeeID] = @Username AND CONVERT(NVARCHAR, DECRYPTBYPASSPHRASE(N'Team up fight on', [Password])) = @Password";
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
        /// <summary>
        /// Hàm thêm mới nhân viên
        /// </summary>
        /// <param name="employee"> Đối tượng nhân viên được thêm mới </param>
        /// <returns> Giá trị trả về là số lượng các dòng bị tác động bởi câu lệnh , nếu 0 là thêm mới thất bại </returns>
        public int InsertEmployee(dtoEmployee employee)
        {
            int count = 0;
            try
            {
                string sql = "INSERT [dbo].[Employee] ([EmployeeFullName], [EmployeePotrait], [EmployeeBirthday], [EmployeeAddress], [EmployeePhoneNumber], [EmployeeEmail], [BasicSalary], [JobTilteID], [StartDay]) VALUES (@Name, @Portrait, @BirthDay, @Address, @PhoneNumber, @Email, @BasicSalary, @JobTitleID, @StartDay)";
                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = employee.FullName;
                SqlParameter parameterPotrait = new SqlParameter("@Potrait", SqlDbType.Image);
                parameterPotrait.Value = employee.Potrait;
                SqlParameter parameterBirthDay = new SqlParameter("@BirthDay", SqlDbType.DateTime);
                parameterBirthDay.Value = employee.BirthDay;
                SqlParameter parameterAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                parameterAddress.Value = employee.Address;
                SqlParameter parameterPhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.NVarChar);
                parameterPhoneNumber.Value = employee.PhoneNumber;
                SqlParameter parameterEmail = new SqlParameter("@Email", SqlDbType.NVarChar);
                parameterEmail.Value = employee.Email;
                SqlParameter parameterBasicSalary = new SqlParameter("@BasicSalary", SqlDbType.Money);
                parameterBasicSalary.Value = employee.BasicSalary;
                SqlParameter parameterJobTitleID = new SqlParameter("@JobTitleID", SqlDbType.Int);
                parameterJobTitleID.Value = employee.JobTitleID;
                SqlParameter parameterStartDay = new SqlParameter("@Name", SqlDbType.DateTime);
                parameterStartDay.Value = employee.StartDay;
                count = InsertUpdateDeleteData(sql, new[] { parameterName, parameterPotrait, parameterBirthDay, parameterAddress, parameterPhoneNumber, parameterEmail, parameterBasicSalary, parameterJobTitleID, parameterStartDay });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        /// <summary>
        /// Hàm cập nhập nhân viên theo mã nhân viên
        /// </summary>
        /// <param name="employee"> Đối tượng nhân viên được cập nhập </param>
        /// <returns> Giá trị trả về là số lượng các dòng bị tác động bởi câu lệnh , nếu 0 là cập nhập thất bại </returns>
        public int UpdateEmployeeFromID(dtoEmployee employee)
        {
            int count = 0;
            try
            {
                string sql = "UPDATE [dbo].[Employee] SET [EmployeeFullName] = @Name, [EmployeePotrait] = @Portrait, [EmployeeBirthDay] = @BirthDay, [EmployeeAddress] = @Address, [EmployeePhoneNumber] = @PhoneNumber, [EmployeeEmail] = @Email, [BasicSalary] = @BasicSalary, [JobTitleID] = @JobTitleID, [StartDay] = @StartDay) WHERE [EmployeeID] = @EmployeeID";
                SqlParameter parameterID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                parameterID.Value = employee.EmployeeID;
                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = employee.FullName;
                SqlParameter parameterPotrait = new SqlParameter("@Potrait", SqlDbType.Image);
                parameterPotrait.Value = employee.Potrait;
                SqlParameter parameterBirthDay = new SqlParameter("@BirthDay", SqlDbType.DateTime);
                parameterBirthDay.Value = employee.BirthDay;
                SqlParameter parameterAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                parameterAddress.Value = employee.Address;
                SqlParameter parameterPhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.Char);
                parameterPhoneNumber.Value = employee.PhoneNumber;
                SqlParameter parameterEmail = new SqlParameter("@Email", SqlDbType.NVarChar);
                parameterEmail.Value = employee.Email;
                SqlParameter parameterBasicSalary = new SqlParameter("@BasicSalary", SqlDbType.Money);
                parameterBasicSalary.Value = employee.BasicSalary;
                SqlParameter parameterJobTitleID = new SqlParameter("@JobTitleID", SqlDbType.Int);
                parameterJobTitleID.Value = employee.JobTitleID;
                SqlParameter parameterStartDay = new SqlParameter("@Name", SqlDbType.DateTime);
                parameterStartDay.Value = employee.StartDay;
                count = InsertUpdateDeleteData(sql, new[] { parameterName, parameterPotrait, parameterBirthDay, parameterAddress, parameterPhoneNumber, parameterEmail, parameterBasicSalary, parameterJobTitleID, parameterStartDay });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        public List<dtoEmployee> GetEmployees()
        {
            List<dtoEmployee> employees = new List<dtoEmployee>();
            try
            {
                dtoEmployee employee = new dtoEmployee();
                string sql = "SELECT * FROM [dbo].[Employee]";
                SqlDataReader reader = ReadData(sql);
                while (reader.Read())
                {
                    employee.EmployeeID = Convert.ToInt32((dtoEmployee)reader[0]);
                    employee.FullName = ((dtoEmployee)reader[1]).ToString();
                    employee.Potrait = SettingImage.ImageToByteArray((Image)reader[2]);
                    employee.BirthDay = Convert.ToDateTime((dtoEmployee)reader[3]);
                    employee.Address = ((dtoEmployee)reader[4]).ToString();
                    employee.PhoneNumber = ((dtoEmployee)reader[5]).ToString();
                    employee.Email = ((dtoEmployee)reader[6]).ToString();
                    employee.BasicSalary = Convert.ToDecimal((dtoEmployee)reader[7]);
                    employee.JobTitleID = Convert.ToInt32((dtoEmployee)reader[8]);
                    employee.StartDay = Convert.ToDateTime((dtoEmployee)reader[9]);
                    employees.Add(employee);
                }
            }
            finally
            {
                CloseConnection();
            }
            return employees;
        }
    }
}
