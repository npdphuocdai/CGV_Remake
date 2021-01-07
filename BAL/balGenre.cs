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
    class balGenre
    {
        public List<dtoGenre> GetGenres()
        {
            dalGenre dalGenre = new dalGenre();
            List<dtoGenre> listEmp = new List<dtoGenre>();
            DataTable Genres = dalGenre.GetGenres();
            for (int i = 0; i < Genres.Rows.Count; i++)
            {
                dtoGenre Genre = new dtoGenre();
                DataRow row = Genres.Rows[i];
                Genre.GenreID = Convert.ToInt32(row[0]);
                Genre.GenreName = row[1].ToString();
                listEmp.Add(Genre);
            }
            return listEmp;
        }
    }
}
