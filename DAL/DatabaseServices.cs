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
        /// </summary>
        public string connectionString = @"Data Source = NPD-PHUOCDAI; Initial Catalog = CGV; Integrated Security = True;";
        public SqlConnection connection;
        public SqlCommand command;
        public DatabaseServices() 
        {
            connection = new SqlConnection(connectionString);
        }
        public void OpenConnection()
        {
            if(connection != null && connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if(connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        /// <summary>
        /// Hàm đọc data từ table có đối số truyền vào
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
        /// Hàm đọc data từ table có điều kiện
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
        /// <returns></returns>
        public int InsertUpdateDeleteData(string sql, SqlParameter[] parameters)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            command.Parameters.AddRange(parameters);
            //Hàm ExecuteNonQuery sẽ trả về giá trị là số dòng bị tác động bởi câu truy vấn
            return command.ExecuteNonQuery();
        }
        //SqlDataAdapter sẽ trả về giá trị có thể fill vào một biến kiểu DataTable
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
        public int SelectReturnInt(string sql)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            //Hàm ExecuteScalar dùng để truy vấn các câu lệnh dạng Count|MAX|MIN ...
            int returnint = (int)command.ExecuteScalar();
            return returnint;
        }
    }
}
