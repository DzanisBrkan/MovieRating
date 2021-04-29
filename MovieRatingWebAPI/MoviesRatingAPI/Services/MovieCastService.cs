using AutoMapper;
using MoviesRatingAPI.Database;
using MoviesRatingAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRatingAPI.Services
{
    public class MovieCastService : IMovieCastService
    {
        private readonly MovieRatingContext _context;
        private readonly IMapper _mapper;

        public MovieCastService(MovieRatingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<MoviesRating.Model.MovieCast> Get()
        {
            var list = _context.MovieCast.ToList();
            return _mapper.Map<List<MoviesRating.Model.MovieCast>>(list);
        }
    }
}
