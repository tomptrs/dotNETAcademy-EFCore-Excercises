using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
  


    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public int RatingId { get; set; }
        public Rating Rating { get; set; }
    }
}
