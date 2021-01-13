using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class dtoFilms
    {       
        public int FilmID { get; set; }
        public string FilmName { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? StopDate { get; set; }
        public TimeSpan Duration { get; set; }
        public int GenreID { get; set; }
    }
}
