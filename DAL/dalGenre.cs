using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    class dalGenre : DatabaseServices
    {
        /// <summary>
        /// Hàm lấy list thể loại từ database
        /// </summary>
        /// <returns> Trả về một biến kiểu list thể loại </returns>
        public List<dtoGenre> GetListGenre()
        {
            List<dtoGenre> genres = new List<dtoGenre>();
            try
            {
                string sql = "SELECT * FROM [dbo].[Genre]";
                SqlDataReader reader = ReadData(sql);
                while (reader.Read())
                {
                    dtoGenre genre = new dtoGenre();
                    genre.GenreID = Convert.ToInt32((dtoGenre)reader[0]);
                    genre.GenreName = ((dtoGenre)reader[1]).ToString();
                    genres.Add(genre);
                }
                reader.Close();
            }
            finally
            {
                CloseConnection();
            }
            return genres;
        }
        /// <summary>
        /// Hàm thêm thể loại
        /// </summary>
        /// <param name="genre"></param>
        /// <returns></returns>
        public int InsertGenre(dtoGenre genre)
        {
            int count = 0;
            try
            {
                string sql = "INSERT [dbo].[Genre] ([GenreName]) VALUES ( @Name)";
                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = genre.GenreName;
                count = InsertUpdateDeleteData(sql, new[] { parameterName });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        /// <summary>
        /// Hàm cập nhập thể loại
        /// </summary>
        /// <param name="genre"></param>
        /// <returns></returns>
        public int UpdateGenre(dtoGenre genre)
        {
            int count = 0;
            try
            {
                string sql = "UPDATE [dbo].[Genre] SET [GenreName] = @Name WHERE [GenreID] = @ID";
                SqlParameter parameterID = new SqlParameter("@Name", SqlDbType.Int);
                parameterID.Value = genre.GenreID;
                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = genre.GenreName;
                count = InsertUpdateDeleteData(sql, new[] { parameterID, parameterName });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
    }
}
