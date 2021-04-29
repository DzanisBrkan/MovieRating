using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MoviesRating.Model;
using MoviesRating.Model.Requests;
using MoviesRatingAPI.Database;
using MoviesRatingAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRatingAPI.Services
{
    public class MovieService : IMovieService
    {
        private readonly MovieRatingContext _context;
        private readonly IMapper _mapper;


        public MovieService(MovieRatingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<MoviesRating.Model.Movie> Get()
        {

            var list = _context.Movie.ToList();

            return _mapper.Map<List<MoviesRating.Model.Movie>>(list);
        }

        public List<MoviesRating.Model.Movie> GetAllMovies()
        {
            const int Top10 = 10;

            var query = _context.Movie.AsQueryable();

            query = query.Where(x => x.Type == "Movie");

            var list = query.OrderByDescending(x => x.AvgScore).Take(Top10).ToList();


            return _mapper.Map<List<MoviesRating.Model.Movie>>(list);

        }


        public List<MoviesRating.Model.Movie> GetAllTvshows()
        {
            const int Top10 = 10;
            var query = _context.Movie.AsQueryable();

            query = query.Where(x => x.Type == "TV Show");

            var list = query.OrderByDescending(x => x.AvgScore).Take(Top10).ToList();

            return _mapper.Map<List<MoviesRating.Model.Movie>>(list);

        }


        public List<MoviesRating.Model.Movie>GetBySearch(MoviesSearchRequest search)
        {
            var query = _context.Set<Database.Movie>().AsQueryable();
            var list = query.ToList();

            if (search?.AvgScore is int)
            {
                if (search?.AvgScore.HasValue == true)
                {
                    query = query.Where(x => x.AvgScore >= search.AvgScore);
                }
                query = query.OrderBy(x => x.AvgScore);
                list = query.ToList();

            }
            else if (!string.IsNullOrWhiteSpace(search?.Title))
            {
                query = query.Where(x => x.Title.ToLower().Contains(search.Title.ToLower()) || x.Description.ToLower().Contains(search.Title.ToLower()));
                list = query.ToList();
            }
           

            return _mapper.Map<List<MoviesRating.Model.Movie>>(list);

        }
    }
}
