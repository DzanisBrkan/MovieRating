using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRating.Model.Requests
{
    public class MoviesSearchRequest
    {
        public string Title { get; set; }
        public int? AvgScore { get; set; }
    }
}
