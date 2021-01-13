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
        public List<dtoFilms> GetFilms()
        {
            dalFilm dalFilm = new dalFilm();
            List<dtoFilms> listEmp = new List<dtoFilms>();
            DataTable Films = dalFilm.GetFilms();
            for (int i = 0; i < Films.Rows.Count; i++)
            {
                dtoFilms Film = new dtoFilms();
                DataRow row = Films.Rows[i];
                Film.FilmID = Convert.ToInt32(row[0]);
                Film.FilmName = row[1].ToString();
                Film.ReleaseDate = Convert.ToDateTime(row[2]);
                Film.StopDate = Convert.ToDateTime(row[3]);
                Film.Duration = (TimeSpan)row[4];
                Film.GenreID = Convert.ToInt32(row[5]);
                listEmp.Add(Film);
            }
            return listEmp;
        }
        public int Update(dtoFilms viewFilm)
        {
            dalFilm Film = new dalFilm();
            int count = Film.UpdateFilmFromID(viewFilm);
            return count;
        }
        public int Insert(dtoFilms dtoFilms)
        {
            dalFilm film = new dalFilm();
            int count = film.InsertFilm(dtoFilms);
            return count;
        }
    }
}
