using System;
using System.Collections.Generic;

#nullable disable

namespace MoviesRatingAPI.Database
{
    public partial class Movie
    {
        public Movie()
        {
            MovieCasts = new HashSet<MovieCast>();
            Ratings = new HashSet<Rating>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public string Type { get; set; }
        public float AvgScore { get; set; }


        public virtual ICollection<MovieCast> MovieCasts { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
