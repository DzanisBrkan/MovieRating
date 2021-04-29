using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesRating.Model
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverImage { get; set; }
        public string Description { get; set; }
        public string ReleaseDate { get; set; }
        public string Type { get; set; }
        public float AvgScore { get; set; }


    }
}
