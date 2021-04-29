using AutoMapper;
using MoviesRatingAPI.Database;
using MoviesRatingAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRatingAPI.Services
{
    public class RatingService : IRatingService
    {
        private readonly MovieRatingContext _context;
        private readonly IMapper _mapper;

        public RatingService(MovieRatingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<MoviesRating.Model.Rating> Get()
        {
            var list = _context.Rating.ToList();

            return _mapper.Map<List<MoviesRating.Model.Rating>>(list);
        }
    }
}
