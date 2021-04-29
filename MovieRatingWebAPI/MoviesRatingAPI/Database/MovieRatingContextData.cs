using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRatingAPI.Database
{
    public partial class MovieRatingContext
    {
        //Database seeding
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            #region Dodavanje podataka u tabelu Cast
            modelBuilder.Entity<Cast>().HasData(
                new Cast()
                {
                    Id = 1,
                    FirstName = "Johnny",
                    LastName = "Depp",
                    Age = "57 years"
                },
                new Cast()
                {
                    Id = 2,
                    FirstName = "Leonardo",
                    LastName = "DiCaprio",
                    Age = "46 years"
                },
                new Cast()
                {
                    Id = 3,
                    FirstName = "Anthony ",
                    LastName = "Hopkins",
                    Age = "83 years"
                });
            #endregion

            #region Dodavanje podataka u tabelu User
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    UserId = 1,
                    FirstName = "Angelina",
                    LastName = "Jolie",
                    Email = "angelina@gmail.com",
                    Password = "test123"
                },
                new User()
                {
                    UserId = 2,
                    FirstName = "Emily",
                    LastName = "Blunt",
                    Email = "emily@gmail.com",
                    Password = "test123"
                },
                new User()
                {
                    UserId = 3,
                    FirstName = "Emilia ",
                    LastName = "Clarke",
                    Email = "emilia@gmail.com",
                    Password = "test123"
                });
            #endregion

            #region Dodavanje podataka u tabelu Movie
            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    Id = 1,
                    Title = "Inception",
                    CoverImage = "inception.jpg",
                    Description = "Action movie",
                    ReleaseDate = "22.11.2012",
                    Type = "Movie",
                    AvgScore = 3
                },
                new Movie()
                {
                    Id = 2,
                    Title = "The Shawshank Redemption",
                    CoverImage = "sr.png",
                    Description = "Triller",
                    ReleaseDate = "22.11.1994",
                    Type = "Movie",
                    AvgScore = 4

                },
                new Movie()
                {
                    Id = 3,
                    Title = "Tenet",
                    CoverImage = "tent.png",
                    Description = "Action movie",
                    ReleaseDate = "22.11.2020",
                    Type = "Movie",
                    AvgScore = 5

                },
                new Movie()
                {
                    Id = 4,
                    Title = "The Falcon and Winter Soldier",
                    CoverImage = "marvel.png",
                    Description = "Marvel Tv series about falcon and winter soldier",
                    ReleaseDate = "22.11.2021",
                    Type = "TV Show",
                    AvgScore = 5
                },
                new Movie()
                {
                    Id = 5,
                    Title = "West World",
                    CoverImage = "ww.png",
                    Description = "Tv series about robots",
                    ReleaseDate = "22.11.2018",
                    Type = "TV Show",
                    AvgScore = 4
                },
                 new Movie()
                 {
                     Id = 6,
                     Title = "Dark Knight",
                     CoverImage = "bat.png",
                     Description = "Dark Knight returns in second...",
                     ReleaseDate = "22.11.2008",
                     Type = "Movie",
                     AvgScore = 3
                 },
                 new Movie()
                 {
                     Id = 7,
                     Title = "Breaking Bad",
                     CoverImage = "bb.png",
                     Description = "Breaking Bad tv series ins...",
                     ReleaseDate = "22.11.2008",
                     Type = "TV Show",
                     AvgScore = 3
                 },
                 new Movie()
                 {
                     Id = 8,
                     Title = "Green Mile",
                     CoverImage = "gm.png",
                     Description = "Green Mile is movie in...",
                     ReleaseDate = "22.11.2008",
                     Type = "Movie",
                     AvgScore = 5
                 },
                 new Movie()
                 {
                     Id = 9,
                     Title = "Harry Potter",
                     CoverImage = "hp.png",
                     Description = "Harry Potter is movie in...",
                     ReleaseDate = "22.11.2008",
                     Type = "Movie",
                     AvgScore = 4
                 },
                  new Movie()
                  {
                      Id = 10,
                      Title = "Man of Steel",
                      CoverImage = "mos.png",
                      Description = "Man of Steel is movie in...",
                      ReleaseDate = "22.11.20012",
                      Type = "Movie",
                      AvgScore = 3
                  },
                   new Movie()
                   {
                       Id = 11,
                       Title = "Notebook",
                       CoverImage = "n.png",
                       Description = "Notebook is movie romantic movie...",
                       ReleaseDate = "22.11.20012",
                       Type = "Movie",
                       AvgScore = 3
                   },
                   new Movie()
                   {
                       Id = 12,
                       Title = "Lord of the Rings",
                       CoverImage = "ring.png",
                       Description = "Lord of the Rings movie...",
                       ReleaseDate = "22.11.2006",
                       Type = "Movie",
                       AvgScore = 4
                   },
                    new Movie()
                    {
                           Id = 13,
                           Title = "Spiderman 3",
                           CoverImage = "sp3.png",
                           Description = "Spiderman 3 is a movie...",
                           ReleaseDate = "22.11.2009",
                           Type = "Movie",
                           AvgScore = 5
                    },
                     new Movie()
                     {
                         Id = 14,
                         Title = "Venom",
                         CoverImage = "v.png",
                         Description = "Venom is a antihero wich...",
                         ReleaseDate = "22.11.20018",
                         Type = "Movie",
                         AvgScore = 3
                     });
            #endregion

            #region Dodavanje podataka u tabelu MovieCast
            modelBuilder.Entity<MovieCast>().HasData(
                new MovieCast()
                {
                    Id = 1,
                    CastId = 1,
                    MovieId = 1,
                },
                new MovieCast()
                {
                    Id = 2,
                    CastId = 2,
                    MovieId = 2
                },
                new MovieCast()
                {
                    Id = 3,
                    CastId = 3,
                    MovieId = 3
                });
            #endregion

            #region Dodavanje podataka u tabelu Rating
            modelBuilder.Entity<Rating>().HasData(
                new Rating()
                {
                    Id = 1,
                    UserId = 1,
                    MovieId = 1,
                    Score = 3,
                    Comment = "Nice movie",
                    AvgScore = 3
                },
                new Rating()
                {
                    Id = 2,
                    UserId = 2,
                    MovieId = 2,
                    Score = 4,
                    Comment = "Great movie",
                    AvgScore = 4
                },
                new Rating()
                {
                    Id = 3,
                    UserId = 3,
                    MovieId = 3,
                    Score = 5,
                    Comment = "Excellent movie",
                    AvgScore = 5
                },
                new Rating()
                {
                    Id = 4,
                    UserId = 3,
                    MovieId = 4,
                    Score = 5,
                    Comment = "Excellent series",
                    AvgScore = 5
                },
                new Rating()
                {
                    Id = 5,
                    UserId = 2,
                    MovieId = 5,
                    Score = 4,
                    Comment = "Excellent movie",
                    AvgScore = 4
                },
                  new Rating()
                  {
                      Id = 6,
                      UserId = 1,
                      MovieId = 6,
                      Score = 3,
                      Comment = "Excellent movie",
                      AvgScore = 3
                  },
                  new Rating()
                  {
                      Id = 7,
                      UserId = 2,
                      MovieId = 7,
                      Score = 3,
                      Comment = "Excellent movie",
                      AvgScore = 3
                  },
                new Rating()
                {
                    Id = 8,
                    UserId = 3,
                    MovieId = 8,
                    Score = 3,
                    Comment = "Excellent movie",
                    AvgScore = 5
                },
                new Rating()
                {
                    Id = 9,
                    UserId = 2,
                    MovieId = 9,
                    Score = 4,
                    Comment = "Excellent movie",
                    AvgScore = 4
                },
                new Rating()
                {
                    Id = 10,
                    UserId = 1,
                    MovieId = 10,
                    Score = 3,
                    Comment = "Excellent movie",
                    AvgScore = 3
                },
                 new Rating()
                 {
                     Id = 11,
                     UserId = 2,
                     MovieId = 11,
                     Score = 3,
                     Comment = "Excellent movie",
                     AvgScore = 3
                 },
                 new Rating()
                 {
                     Id = 12,
                     UserId = 3,
                     MovieId = 12,
                     Score = 4,
                     Comment = "Excellent movie",
                     AvgScore = 4
                 },
                 new Rating()
                 {
                     Id = 13,
                     UserId = 2,
                     MovieId = 13,
                     Score = 5,
                     Comment = "Excellent movie",
                     AvgScore = 5
                 },
                 new Rating()
                 {
                     Id = 14,
                     UserId = 1,
                     MovieId = 14,
                     Score = 3,
                     Comment = "Excellent movie",
                     AvgScore = 3
                 });
            #endregion
        }
    }
}
