using MoviesRating.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRatingAPI.Services.Interfaces
{
    public interface IRatingService
    {
        List<Rating> Get();
    }
}
