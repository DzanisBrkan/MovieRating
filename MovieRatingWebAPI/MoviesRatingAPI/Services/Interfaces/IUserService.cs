using MoviesRating.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRatingAPI.Services.Interfaces
{
    public interface IUserService
    {
        List<User> Get();

        public User GetUserByCredentials(string email, string password);

        //User Authenticiraj(string username, string pass);

        //User Registracija(UserInsertRequest request);
    }
}
