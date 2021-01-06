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
    public class balGenre
    {
        public List<dtoGenre> GetGenres()
        {
            dalGenre dalGenre = new dalGenre();
            List<dtoGenre> listEmp = new List<dtoGenre>();
            DataTable genres = dalGenre.GetGenres();
            for (int i = 0; i < genres.Rows.Count; i++)
            {
                dtoGenre genre = new dtoGenre();
                DataRow row = genres.Rows[i];
                genre.GenreID = Convert.ToInt32(row[0]);
                genre.GenreName = row[1].ToString();
                
                listEmp.Add(genre);
            }
            return listEmp;
        }
    }
}
