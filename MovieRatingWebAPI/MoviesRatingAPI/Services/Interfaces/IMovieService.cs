using AutoMapper;
using MoviesRating.Model;
using MoviesRating.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRatingAPI.Services.Interfaces
{
    public interface IMovieService
    {
        List<Movie> Get();

        List<Movie> GetAllMovies();

        List<Movie> GetAllTvshows();

        List<Movie> GetBySearch(MoviesSearchRequest search);
    }
}
