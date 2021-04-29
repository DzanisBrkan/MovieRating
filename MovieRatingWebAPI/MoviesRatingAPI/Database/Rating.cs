using System;
using System.Collections.Generic;

#nullable disable

namespace MoviesRatingAPI.Database
{
    public partial class Rating
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public string Comment { get; set; }
        public int? MovieId { get; set; }
        public int? UserId { get; set; }
        public float AvgScore { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual User User { get; set; }
    }
}
