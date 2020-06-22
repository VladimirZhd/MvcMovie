﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public Movie Movie { get; set; }
        public SelectList Genres { get; set; }
        public Genre Genre { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }

    }
}