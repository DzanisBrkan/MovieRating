using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRatingAPI.Services.Interfaces
{
    public interface ICastService
    {
        List<MoviesRating.Model.Cast> Get();
    }
}
