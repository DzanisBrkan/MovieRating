using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRating.Model
{
    public partial class MovieCast
    {
        public int Id { get; set; }
        public int CastId { get; set; }
        public int MovieId { get; set; }
    }
}
