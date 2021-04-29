using AutoMapper;
using MoviesRating.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRatingAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Movie, Movie>();
            CreateMap<Database.User, User>();
            CreateMap<Database.Cast, Cast>();
            CreateMap<Database.Rating, Rating>();
            CreateMap<Database.MovieCast, MovieCast>();
        }
    }
}
