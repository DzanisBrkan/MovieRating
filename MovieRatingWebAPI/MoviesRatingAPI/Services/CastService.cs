using AutoMapper;
using MoviesRatingAPI.Database;
using MoviesRatingAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRatingAPI.Services
{
    public class CastService: ICastService
    {
        private readonly MovieRatingContext _context;
        private readonly IMapper _mapper;
        public CastService(MovieRatingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<MoviesRating.Model.Cast> Get()
        {
            var list = _context.Cast.ToList();
            return _mapper.Map<List<MoviesRating.Model.Cast>>(list);
        }
    }
}
