using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidlyy.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String Name { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
        [Required]
        public String ReleaseDate { get; set; }
        [Required]
        public String DateAdded { get; set; }
        [Required]
        public int NumberInStock { get; set; }
    }
}