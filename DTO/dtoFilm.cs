using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Film
    {
        public int FilmID { get; set; }
        public string FilmName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime StopDate { get; set; }

    }
}
