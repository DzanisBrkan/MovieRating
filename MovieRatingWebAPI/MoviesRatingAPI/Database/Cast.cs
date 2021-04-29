using System;
using System.Collections.Generic;

#nullable disable

namespace MoviesRatingAPI.Database
{
    public partial class Cast
    {
        public Cast()
        {
            MovieCasts = new HashSet<MovieCast>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }

        public virtual ICollection<MovieCast> MovieCasts { get; set; }
    }
}
