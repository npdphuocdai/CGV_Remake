using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace BAL
{
    public class balFilm
    {
        public List<dtoFilm> GetFilms()
        {
            dalFilm dalFilm = new dalFilm();
            List<dtoFilm> listEmp = new List<dtoFilm>();
            DataTable films = dalFilm.GetFilms();
            for (int i = 0; i < films.Rows.Count; i++)
            {
                dtoFilm film = new dtoFilm();
                DataRow row = films.Rows[i];
                film.FilmID = Convert.ToInt32(row[0]);
                film.FilmName = row[1].ToString();
                film.ReleaseDate = Convert.ToDateTime(row[2]);
                film.StopDate = Convert.ToDateTime(row[3]);
                film.Duration = Convert.ToDateTime(row[4]);
                film.GenreID = Convert.ToInt32(row[5]);
                listEmp.Add(film);
            }
            return listEmp;
        }
    }
}
