using AutoMapper;
using MoviesRating.Model;
using MoviesRatingAPI.Database;
using MoviesRatingAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRatingAPI.Services
{
    public class UserService : IUserService
    {
        private readonly MovieRatingContext _context;
        private readonly IMapper _mapper;

        public UserService(MovieRatingContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<MoviesRating.Model.User> Get()
        {
            var list = _context.User.ToList();

            return _mapper.Map<List<MoviesRating.Model.User>>(list);
        }

        public MoviesRating.Model.User GetUserByCredentials(string email, string password)
        {
            var query = _context.User.AsQueryable();

            if (!string.IsNullOrWhiteSpace(email))
            {
                query = query.Where(x => x.Email.ToLower().StartsWith(email.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(password))
            {
                query = query.Where(x => x.Password.ToLower().StartsWith(password.ToLower()));
            }

            var list = query.FirstOrDefault();
            return _mapper.Map<MoviesRating.Model.User>(list);
        }


    }
}
