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
                Film.Duration = Convert.ToDateTime(row[4]);
                Film.GenreID = Convert.ToInt32(row[5]);
                listEmp.Add(Film);
            }
            return listEmp;
        }
        /*public int UpdateFromView(dtoViewFilm viewFilm)
        {
            dalFilm Film = new dalFilm();
            int count = Film.SelfUpdateFilmFromView(viewFilm);
            return count;
        }*/
    }
}
