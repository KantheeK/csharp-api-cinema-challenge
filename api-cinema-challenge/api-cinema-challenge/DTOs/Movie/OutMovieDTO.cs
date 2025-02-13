﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs.Movie
{
    public class OutMovieDTO
    {
       
        public int Id { get; set; } 
        public string Title { get; set; } 
        public string Rating { get; set; }
        public string Description { get; set; }
        public int Runtime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }


    }
}
