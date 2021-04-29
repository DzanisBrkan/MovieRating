using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesRating.Model;
using MoviesRatingAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRatingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieCastController : ControllerBase
    {
        private readonly IMovieCastService _service;

        public MovieCastController(IMovieCastService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<MovieCast> Get()
        {
            return _service.Get();
        }
    }
}
