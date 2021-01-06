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
        public List<dtoFilm> GetFilms()
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
        }
    }
}
