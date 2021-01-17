﻿using System;
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
                // Tạo câu truy vấn có điều kiện để tìm kiếm user
                // CONVERT(NVARCHAR, DECRYPTBYPASSPHRASE(N'Team up fight on', [Password])) là câu truy vấn trong SQL để ép kiểu từ 1 kiểu bất kỳ thành dạng NVARCHAR
                // DECRYPTBYPASSPHRASE là hàm trong SQL dùng để giải mã dữ liệu được mã hóa từ 1 pass cho trước
                // 'Team up fight on' là pass để giải mã
                string sql = "SELECT * FROM [dbo].[Employee] WHERE [EmployeeID] = @Username AND CONVERT(NVARCHAR, DECRYPTBYPASSPHRASE(N'Team up fight on', [Password])) = @Password";
                // Truyền giá trị cho 2 tham số
                SqlParameter parameterUser = new SqlParameter("@Username", SqlDbType.Int);
                parameterUser.Value = username;
                SqlParameter parameterPass = new SqlParameter("@Password", SqlDbType.NVarChar);
                parameterPass.Value = password;
                // Sử dụng hàm ReadDataPars để truy xuất thông tin
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
        /// <param name="filename"> là một chuỗi chỉ đường dẫn của ảnh </param>
        /// <returns> Giá trị trả về là số lượng các dòng bị tác động bởi câu lệnh , nếu 0 là thêm mới thất bại </returns>
        public int InsertEmployee(dtoEmployee employee, string filename)
        {
            int count = 0;
            try
            {
                // Ở câu truy vấn này có sử dụng Bulk Column để mã hóa hình ảnh thành 1 vector và lưu trữ trên SQL
                string sql = "INSERT [dbo].[Employee] ([EmployeeFullName], [EmployeePotrait], [EmployeeBirthday], [EmployeeAddress], [EmployeePhoneNumber], [EmployeeEmail], [BasicSalary], [JobTilteID], [StartDay], [Password], [Gender]) SELECT @Name, BulkColumn, @Birthday, @Address, @PhoneNumber, @Email, @BasicSalary, @JobtitleID, @StartDay, ENCRYPTBYPASSPHRASE(N'Team up fight on',@Password), @Gender FROM OPENROWSET(BULK N'" + filename + "', Single_Blob) as Picture";
                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = employee.FullName;
                SqlParameter parameterBirthDay = new SqlParameter("@BirthDay", SqlDbType.DateTime);
                parameterBirthDay.Value = employee.BirthDay;
                SqlParameter parameterGender = new SqlParameter("@Gender", SqlDbType.NVarChar);
                parameterGender.Value = employee.Gender;
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
                SqlParameter parameterStartDay = new SqlParameter("@StartDay", SqlDbType.DateTime);
                parameterStartDay.Value = employee.StartDay;
                SqlParameter parameterPassword = new SqlParameter("@Password", SqlDbType.NVarChar);
                parameterPassword.Value = employee.Password;
                count = InsertUpdateDeleteData(sql, new[] { parameterName, parameterBirthDay, parameterGender, parameterAddress, parameterPhoneNumber, parameterEmail, parameterBasicSalary, parameterJobTitleID, parameterStartDay, parameterPassword});
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
                string sql = "UPDATE [dbo].[Employee] SET [EmployeeFullName] = @Name, [EmployeeBirthDay] = @BirthDay, [EmployeeAddress] = @Address, [EmployeePhoneNumber] = @PhoneNumber, [EmployeeEmail] = @Email, [BasicSalary] = @BasicSalary, [JobTitleID] = @JobTitleID, [StartDay] = @StartDay WHERE [EmployeeID] = @EmployeeID";
                SqlParameter parameterID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                parameterID.Value = employee.EmployeeID;
                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = employee.FullName;
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
                count = InsertUpdateDeleteData(sql, new[] { parameterName, parameterBirthDay, parameterAddress, parameterPhoneNumber, parameterEmail, parameterBasicSalary, parameterJobTitleID, parameterStartDay });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        public int SelfUpdateEmployee(dtoEmployee employee)
        {
            int count = 0;
            try
            {
                string sql = "UPDATE [dbo].[Employee] SET [EmployeeFullName] = @Name, [EmployeeBirthDay] = @BirthDay, [EmployeeAddress] = @Address, [EmployeePhoneNumber] = @PhoneNumber, [EmployeeEmail] = @Email, [Gender] = @Gender WHERE [EmployeeID] = @EmployeeID";
                SqlParameter parameterID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                parameterID.Value = employee.EmployeeID;
                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = employee.FullName;
                SqlParameter parameterBirthDay = new SqlParameter("@BirthDay", SqlDbType.DateTime);
                parameterBirthDay.Value = employee.BirthDay;
                SqlParameter parameterAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                parameterAddress.Value = employee.Address;
                SqlParameter parameterPhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.Char);
                parameterPhoneNumber.Value = employee.PhoneNumber;
                SqlParameter parameterEmail = new SqlParameter("@Email", SqlDbType.NVarChar);
                parameterEmail.Value = employee.Email;
                SqlParameter parameterGender = new SqlParameter("@Gender", SqlDbType.NVarChar);
                parameterGender.Value = employee.Gender;
                count = InsertUpdateDeleteData(sql, new[] { parameterName, parameterBirthDay, parameterAddress, parameterPhoneNumber, parameterEmail, parameterGender });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        public int SelfUpdateEmployeeFromView(dtoViewEmployees employee)
        {
            int count = 0;
            try
            {
                string sql = "UPDATE [dbo].[Employee] SET [EmployeeFullName] = @Name, [EmployeeBirthDay] = @BirthDay, [EmployeeAddress] = @Address, [EmployeePhoneNumber] = @PhoneNumber, [EmployeeEmail] = @Email, [Gender] = @Gender WHERE [EmployeeID] = @EmployeeID";
                SqlParameter parameterID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                parameterID.Value = employee.EmployeeID;
                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = employee.EmployeeFullName;
                SqlParameter parameterBirthDay = new SqlParameter("@BirthDay", SqlDbType.DateTime);
                parameterBirthDay.Value = employee.EmployeeBirthday;
                SqlParameter parameterAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                parameterAddress.Value = employee.EmployeeAddress;
                SqlParameter parameterPhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.Char);
                parameterPhoneNumber.Value = employee.EmployeePhoneNumber;
                SqlParameter parameterEmail = new SqlParameter("@Email", SqlDbType.NVarChar);
                parameterEmail.Value = employee.EmployeeEmail;
                SqlParameter parameterGender = new SqlParameter("@Gender", SqlDbType.NVarChar);
                parameterGender.Value = employee.Gender;
                count = InsertUpdateDeleteData(sql, new[] { parameterID, parameterName, parameterBirthDay, parameterAddress, parameterPhoneNumber, parameterEmail, parameterGender });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        public int AdminUpdateEmployeeFromView(dtoViewEmployees employee)
        {
            int count = 0;
            try
            {
                string sql = "UPDATE [dbo].[Employee] SET [EmployeeFullName] = @Name, [EmployeeBirthDay] = @BirthDay, [EmployeeAddress] = @Address, [EmployeePhoneNumber] = @PhoneNumber, [EmployeeEmail] = @Email, [Gender] = @Gender, [JobTilteID] = @JobTitleID WHERE [EmployeeID] = @EmployeeID";
                SqlParameter parameterID = new SqlParameter("@EmployeeID", SqlDbType.Int);
                parameterID.Value = employee.EmployeeID;
                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = employee.EmployeeFullName;
                SqlParameter parameterBirthDay = new SqlParameter("@BirthDay", SqlDbType.DateTime);
                parameterBirthDay.Value = employee.EmployeeBirthday;
                SqlParameter parameterAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                parameterAddress.Value = employee.EmployeeAddress;
                SqlParameter parameterPhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.Char);
                parameterPhoneNumber.Value = employee.EmployeePhoneNumber;
                SqlParameter parameterEmail = new SqlParameter("@Email", SqlDbType.NVarChar);
                parameterEmail.Value = employee.EmployeeEmail;
                SqlParameter parameterGender = new SqlParameter("@Gender", SqlDbType.NVarChar);
                parameterGender.Value = employee.Gender;
                SqlParameter parameterJobTilteID = new SqlParameter("@JobTitleID", SqlDbType.NVarChar);
                parameterJobTilteID.Value = employee.JobTitleID;
                count = InsertUpdateDeleteData(sql, new[] { parameterID, parameterName, parameterBirthDay, parameterAddress, parameterPhoneNumber, parameterEmail, parameterGender, parameterJobTilteID });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        public int UpdatePassword(int ID, string password)
        {
            int count = 0;
            try
            {
                string sql = "UPDATE [dbo].[Employee] SET [Password] = ENCRYPTBYPASSPHRASE(N'Team up fight on',@Password) WHERE [EmployeeID] = @ID";
                SqlParameter parameterID = new SqlParameter("@ID", SqlDbType.Int);
                parameterID.Value = ID;
                SqlParameter parameterPass = new SqlParameter("@Password", SqlDbType.NVarChar);
                parameterPass.Value = password;
                count = InsertUpdateDeleteData(sql, new[] { parameterID, parameterPass });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        public DataTable GetEmployees()
        {
            DataTable employees = new DataTable();
            try
            {
                string sql = "SELECT* FROM[dbo].[Employee]";
                SqlDataAdapter adapter = Adapter(sql);
                if ( adapter != null)
                {
                    adapter.Fill(employees);
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
