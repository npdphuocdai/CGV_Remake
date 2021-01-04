using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoFilm
    {       
        public int FilmID;
        public string FilmName { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? StopDate { get; set; }
        public DateTime? Duration { get; set; }
        public int GenreID { get; set; }
    }
}
