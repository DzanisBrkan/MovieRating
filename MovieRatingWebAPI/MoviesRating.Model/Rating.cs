using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRating.Model
{
    public partial class Rating
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public string Comment { get; set; }
        public int? MovieId { get; set; }
        public int? UserId { get; set; }
    }
}
