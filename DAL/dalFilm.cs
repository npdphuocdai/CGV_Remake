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
    class dalFilm : DatabaseServices
    {
        /*public List<dtoFilm> GetFilms()
        {
            List<dtoFilm> films = new List<dtoFilm>();
            try
            {
                string sql = "SELECT * FROM [dto].[Film]";
                SqlDataReader reader = ReadData(sql);
                while (reader.Read())
                {
                    dtoFilm film = new dtoFilm();
                    film.FilmID = Convert.ToInt32((dtoFilm)reader[0]);
                    film.FilmName = ((dtoFilm)reader[1]).ToString();
                    film.ReleaseDate = Convert.ToDateTime((dtoFilm)reader[2]);
                    film.StopDate = Convert.ToDateTime((dtoFilm)reader[3]);
                    film.Duration = Convert.ToDateTime((dtoFilm)reader[4]);
                    film.GenreID = Convert.ToInt32((dtoFilm)reader[5]);
                    films.Add(film);
                }
                reader.Close();
            }
            finally
            {
                CloseConnection();
            }
            return films;
        }*/
        public int InsertFilm (dtoFilm film)
        {
            int count = 0;
            try
            {
                string sql = "INSERT [dbo].[Film] ([FilmName], [ReleaseDate], [StopDate], [Duration], [GenreID]) VALUES (@Name, @ReleaseDate, @StopDate, @Duration, @GenreID)";
                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = film.FilmName;
                SqlParameter parameterReleaseDate = new SqlParameter("@ReleaseDate", SqlDbType.DateTime);
                parameterReleaseDate.Value = film.ReleaseDate;
                SqlParameter parameterStopDate = new SqlParameter("@StopDate", SqlDbType.DateTime);
                parameterStopDate.Value = film.StopDate;
                SqlParameter parameterDuration = new SqlParameter("@Duration", SqlDbType.DateTime);
                parameterDuration.Value = film.Duration;
                SqlParameter parameterGenreID = new SqlParameter("@GenreID", SqlDbType.Int);
                parameterGenreID.Value = film.GenreID;
                count = InsertUpdateDeleteData(sql, new[] { parameterName, parameterReleaseDate, parameterStopDate, parameterDuration, parameterGenreID });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }

        public int UpdateFilmFromID(dtoFilm film)
        {
            int count = 0;
            try
            {
                string sql = "UPDATE [dbo].[Film] SET [FilmName] = @Name, [ReleaseDate] = @ReleaseDate, [StopDate] = @StopDate, [Duration] = @Duration, [GenreID] = @GenreID WHERE [FilmID] = @FilmID";
                SqlParameter parameterID = new SqlParameter("@FilmID", SqlDbType.Int);
                parameterID.Value = film.FilmID;
                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = film.FilmName;
                SqlParameter parameterReleaseDate = new SqlParameter("@ReleaseDate", SqlDbType.DateTime);
                parameterReleaseDate.Value = film.ReleaseDate;
                SqlParameter parameterStopDate = new SqlParameter("@StopDate", SqlDbType.DateTime);
                parameterStopDate.Value = film.StopDate;
                SqlParameter parameterDuration = new SqlParameter("@Duration", SqlDbType.DateTime);
                parameterDuration.Value = film.Duration;
                SqlParameter parameterGenreID = new SqlParameter("@GenreID", SqlDbType.Int);
                parameterGenreID.Value = film.GenreID;
                count = InsertUpdateDeleteData(sql, new[] { parameterName, parameterReleaseDate, parameterStopDate, parameterDuration, parameterGenreID });
            }
            finally
            {
                CloseConnection();
            }
            return count;
        }
        public DataTable GetFilms()
        {
            DataTable films = new DataTable();
            try
            {
                string sql = "SELECT* FROM[dbo].[Film]";
                SqlDataAdapter adapter = Adapter(sql);
                if (adapter != null)
                {
                    adapter.Fill(films);
                }
            }
            finally
            {
                CloseConnection();
            }
            return films;
        }
    }
}
