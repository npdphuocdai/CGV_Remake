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
        /// Hàm thêm mới khách hàng
        /// </summary>
        /// <param name="customer"> Đối tượng khách hàng được thêm mới </param>
        /// <returns> Giá trị trả về là số lượng các dòng bị tác động bởi câu lệnh 
        /// thường thì giá trị sẽ là 1 cho câu lệnh Insert
        /// nếu 0 là thêm mới thất bại </returns>
        public int InsertCustomer(dtoCustomer customer)
        {
            int count = 0;
            try
            {
                string sql = "INSERT [dbo].[Customer] ([CustomerFullName], [CustomerBirthday], [CustomerAddress], [CustomerPhoneNumber], [CustomerEmail], [Gender]) VALUES (@Name, @BirthDay, @Address, @PhoneNumber, @Email, @Gender)";
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
                SqlParameter parameterGender = new SqlParameter("@Gender", SqlDbType.NVarChar);
                parameterGender.Value = customer.Gender;
                count = InsertUpdateDeleteData(sql, new[] { parameterName, parameterBirthDay, parameterAddress, parameterPhoneNumber, parameterEmail, parameterGender });
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
        /// <returns> Giá trị trả về là số lượng các dòng bị tác động bởi câu lệnh 
        /// vì mã khách hàng là khóa chính, nên số lượng các dòng bị tác động thường sẽ là 1
        /// nếu 0 là cập nhập thất bại </returns>
        public int UpdateCustomerFromID(dtoCustomer customer)
        {
            int count = 0;
            try
            {
                string sql = "UPDATE [dbo].[Customer] SET [CustomerFullName] = @Name, [CustomerBirthDay] = @BirthDay, [CustomerAddress] = @Address, [CustomerPhoneNumber] = @PhoneNumber, [CustomerEmail] = @Email WHERE [CustomerID] = @CustomerID";
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
                SqlParameter parameterID = new SqlParameter("@CustomerID", SqlDbType.Int);
                parameterID.Value = customer.CustomerID;
                count = InsertUpdateDeleteData(sql, new[] { parameterName, parameterBirthDay, parameterAddress, parameterPhoneNumber, parameterEmail, parameterID });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        /// <summary>
        /// Hàm thực thi truy vấn chọn khách hàng
        /// </summary>
        /// <returns> Trả về 1 biến kiểu DataTable chứa giá trị của bảng Customer được lấy ra từ Database </returns>
        public DataTable GetCustomers()
        {
            DataTable customers = new DataTable();
            try
            {
                string sql = "SELECT * FROM [dbo].[Customer]";
                SqlDataAdapter adapter = Adapter(sql);
                // Kiểm tra xem kết quả của câu truy vấn có null hay không
                if (adapter != null)
                {
                    // Nếu không thì "Fill" bảng từ adapter vào biến kiểu DataTable
                    adapter.Fill(customers);
                }
            }
            finally
            {
                CloseConnection();
            }
            return customers;
        }
        /// <summary>
        /// Hàm truy vấn kiểm tra khách có thuộc dạng U22 không
        /// </summary>
        /// <param name="ID"> Mã khách hàng cần kiểm tra </param>
        /// <returns> Trả về true hoặc false </returns>
        public bool GetU22Customer(int ID)
        {
            bool kq = false;
            try
            {
                //Tạo câu truy vấn có điều kiện để tìm kiếm user
                string sql = "SELECT * FROM [dbo].[Customer] WHERE  (YEAR(GETDATE()) - YEAR([CustomerBirthDay])) <= 22 AND [CustomerID] = @ID";
                SqlParameter paraID = new SqlParameter("@ID", SqlDbType.Int);
                paraID.Value = ID;
                SqlDataReader reader = ReadDataPars(sql, new[] { paraID});
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
    }
}
