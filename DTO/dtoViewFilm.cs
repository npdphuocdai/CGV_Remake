﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class dtoViewFilm
    {
        public int FilmID { get; set; }
        public string FilmName { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? StopDate { get; set; }
        public DateTime? Duration { get; set; }
        public string GenreName { get; set; }
    }
}