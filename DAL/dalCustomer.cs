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
    public class dalCustomer : DatabaseServices
    {
        /// <summary>
        /// Hàm tìm kiếm khách hàng theo mã khách hàng
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public SqlDataReader SearchCustomerFromID(int customerID)
        {
            SqlDataReader reader = null;
            try
            {
                string sql = "SELECT * FROM Customer WHERE CustomerID = @CustomerID";
                SqlParameter parameterID = new SqlParameter("@CustomerID", SqlDbType.NVarChar);
                parameterID.Value = customerID;
                reader = ReadDataPars(sql, new[] { parameterID });
            }
            finally
            {
                CloseConnection();
            }
            return reader;
        }
        /// <summary>
        /// Hàm tìm kiếm khách hàng theo tên khách hàng 
        /// </summary>
        /// <param name="customerName"></param>
        /// <returns></returns>
        public SqlDataReader SearchCustomerFromName(string customerName)
        {
            SqlDataReader reader = null;
            try
            {
                string sql = "SELECT * FROM Customer WHERE CustomerFullName = @CustomerName";
                SqlParameter parameterName = new SqlParameter("@CustomerName", SqlDbType.NVarChar);
                parameterName.Value = customerName;
                reader = ReadDataPars(sql, new[] { parameterName });
            }
            finally
            {
                CloseConnection();
            }
            return reader;
        }
        /// <summary>
        /// Hàm thêm mới khách hàng
        /// </summary>
        /// <param name="customer"> Đối tượng khách hàng được thêm mới </param>
        /// <returns> Giá trị trả về là số lượng các dòng bị tác động bởi câu lệnh , nếu 0 là thêm mới thất bại </returns>
        public int InsertCustomer(dtoCustomer customer)
        {
            int count = 0;
            try
            {
                string sql = "INSERT [dbo].[Customer] ([CustomerFullName], [CustomerBirthday], [CustomerAddress], [CustomerPhoneNumber], [CustomerEmail]) VALUES (@Name, @BirthDay, @Address, @PhoneNumber, @Email)";
                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = customer.FullName;
                SqlParameter parameterBirthDay = new SqlParameter("@BirthDay", SqlDbType.DateTime);
                parameterBirthDay.Value = customer.BirthDay;
                SqlParameter parameterAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                parameterAddress.Value = customer.Address;
                SqlParameter parameterPhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.Char);
                parameterPhoneNumber.Value = customer.PhoneNumber;
                SqlParameter parameterEmail = new SqlParameter("@Email", SqlDbType.NVarChar);
                parameterEmail.Value = customer.Email;
                count = InsertUpdateDeleteData(sql, new[] { parameterName, parameterBirthDay, parameterAddress, parameterPhoneNumber, parameterEmail });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        /// <summary>
        /// Hàm cập nhập khách hàng theo mã khách hàng
        /// </summary>
        /// <param name="customer"> đối tượng khách hàng được cập nhập </param>
        /// <returns> Giá trị trả về là số lượng các dòng bị tác động bởi câu lệnh , nếu 0 là cập nhập thất bại </returns>
        public int UpdateEmployeeFromID(dtoCustomer customer)
        {
            int count = 0;
            try
            {
                string sql = "UPDATE [dbo].[Customer] SET [CustomerFullName] = @Name, [CustomerBirthDay] = @BirthDay, [CustomerAddress] = @Address, [CustomerPhoneNumber] = @PhoneNumber, [CustomerEmail] = @Email) WHERE [CustomerID] = @CustomerID";
                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = customer.FullName;
                SqlParameter parameterBirthDay = new SqlParameter("@BirthDay", SqlDbType.DateTime);
                parameterBirthDay.Value = customer.BirthDay;
                SqlParameter parameterAddress = new SqlParameter("@Address", SqlDbType.NVarChar);
                parameterAddress.Value = customer.Address;
                SqlParameter parameterPhoneNumber = new SqlParameter("@PhoneNumber", SqlDbType.NVarChar);
                parameterPhoneNumber.Value = customer.PhoneNumber;
                SqlParameter parameterEmail = new SqlParameter("@Email", SqlDbType.NVarChar);
                parameterEmail.Value = customer.Email;
                count = InsertUpdateDeleteData(sql, new[] { parameterName, parameterBirthDay, parameterAddress, parameterPhoneNumber, parameterEmail });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
    }
}
