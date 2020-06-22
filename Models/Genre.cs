﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Display(Name ="Genre")]
        public string GenreName { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
