using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DatabaseServices
    {
        /// <summary>
        /// Tạo Connecting String để kết nối với Database
        /// Data Source: Server trên SQL Server hoặc là địa chỉ IP vật lý của server
        /// Initial Catalog: Là tên của Database
        /// Integrated Security: Xác nhận tin tưởng kết nối này
        /// </summary>
        public string connectionString = @"Data Source = NPD-PHUOCDAI\SQLEXPRESS; Initial Catalog = CGV; Integrated Security = True;"; 
        public SqlConnection connection;
        public SqlCommand command;
        /// <summary>
        /// Contructor khi khởi tạo dạng DatabaseServices sẽ được khởi tạo connection
        /// </summary>
        public DatabaseServices() 
        {
            // Khởi tạo connection với tham số đầu vào là chuỗi kết nối
            connection = new SqlConnection(connectionString);
        }
        /// <summary>
        /// Hàm kiểm tra kết nối đã được mở chưa
        /// Nếu chưa thì mở kết nối, nếu đã mở thì bỏ qua
        /// </summary>
        public void OpenConnection()
        {
            if(connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        /// <summary>
        /// Hàm đóng kết nối, tương tự hàm mở
        /// </summary>
        public void CloseConnection()
        {
            if(connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Hàm đọc data từ table không có tham số truyền vào
        /// </summary>
        /// <param name="sql"> sql là một câu truy vấn trong SQL
        /// VD: select * from ABC </param>
        /// <returns> Trả về một table </returns>
        public SqlDataReader ReadData(string sql)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        /// <summary>
        /// Hàm đọc data từ table có điều kiện( có tham số truyền vào)
        /// </summary>
        /// <param name="sql"> là một câu truy vấn trong SQL </param>
        /// <param name="parameters"> là các tham số truyền vào cho điều kiện </param>
        /// VD: select * from ABC Where parameters = XYZ
        /// <returns> Hàm trả về một bảng </returns>
        public SqlDataReader ReadDataPars(string sql, SqlParameter[] parameters)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            command.Parameters.AddRange(parameters);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        /// <summary>
        /// Hàm thêm dữ liệu vào một bảng có
        /// </summary>
        /// <param name="sql"> là chuỗi truy vấn dạng Insert Into ... values ... </param>
        /// <param name="parameters"> là các tham số truyền vào ứng với từng cột dữ liệu trong bảng </param>
        /// <returns> Trả về một biến kiểu int biểu thị cho số lượng bảng được tác động bởi câu truy vấn </returns>
        public int InsertUpdateDeleteData(string sql, SqlParameter[] parameters)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            command.Parameters.AddRange(parameters);
            // Hàm ExecuteNonQuery sẽ trả về giá trị là số dòng bị tác động bởi câu truy vấn
            return command.ExecuteNonQuery();
        }
        /// <summary>
        /// Hàm sẽ trả vè giá trị dạng DataAdapter
        /// Ta có thể dùng nó để "Fill" vào một biến dạng DataTable và có thể tạo DataBinding
        /// </summary>
        /// <param name="sql"></param>
        /// <returns> Giá trị là một bảng </returns>
        public SqlDataAdapter Adapter(string sql)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            return adapter;
        }
        /// <summary>
        /// Hàm đọc bảng dạng Adapter và có tham số
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns> Giá trị trả về là một bảng </returns>
        public SqlDataAdapter AdapterPars(string sql, SqlParameter[] parameters)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            return adapter;
        }
        /// <summary>
        /// Là kiểu hàm trả về kết quả của câu truy vấn
        /// </summary>
        /// <param name="sql"></param>
        /// <returns> Giá trị trả về là kiểu int  </returns>
        public object ScalarSelect(string sql)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            // Hàm ExecuteScalar dùng để truy vấn các câu lệnh dạng Count|MAX|MIN ...
            // Hàm trả về một giá trị là kết quả của câu truy vấn
            return command.ExecuteScalar();
        }
    }
}
