using System;
using System.Collections.Generic;

#nullable disable

namespace MoviesRatingAPI.Database
{
    public partial class User
    {
        public User()
        {
            Ratings = new HashSet<Rating>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
