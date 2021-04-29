using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesRating.Model;
using MoviesRating.Model.Requests;
using MoviesRatingAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRatingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _service;
        public MovieController(IMovieService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Movie> Get()
        {
            return _service.Get();
        }

        [HttpGet]
        [Route("getmovies")]
        public List<Movie> GetAllMovies()
        {
            return _service.GetAllMovies();
        }

        [HttpGet]
        [Route("getshows")]
        public List<Movie> GetAllTvshows()
        {
            return _service.GetAllTvshows();
        }

        [HttpPost]
        [Route("search")]
        public List<Movie> GetBySearch([FromQuery]MoviesSearchRequest search)
        {
            return _service.GetBySearch(search);
        }

    }
}
