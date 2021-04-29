using System;
using System.Collections.Generic;

#nullable disable

namespace MoviesRatingAPI.Database
{
    public partial class MovieCast
    {
        public int Id { get; set; }
        public int CastId { get; set; }
        public int MovieId { get; set; }

        public virtual Cast Cast { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
