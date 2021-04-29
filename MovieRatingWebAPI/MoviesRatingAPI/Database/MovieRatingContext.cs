using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MoviesRatingAPI.Database
{
    public partial class MovieRatingContext : DbContext
    {
        public MovieRatingContext()
        {
        }

        public MovieRatingContext(DbContextOptions<MovieRatingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cast> Cast { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<MovieCast> MovieCast { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=MovieRating;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Bosnian_Latin_100_BIN");

            modelBuilder.Entity<Cast>(entity =>
            {
                entity.ToTable("Cast");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("Movie");
            });

            modelBuilder.Entity<MovieCast>(entity =>
            {
                entity.ToTable("MovieCast");

                entity.HasIndex(e => e.CastId, "IX_MovieCast_CastId");

                entity.HasIndex(e => e.MovieId, "IX_MovieCast_MovieId");

                entity.HasOne(d => d.Cast)
                    .WithMany(p => p.MovieCasts)
                    .HasForeignKey(d => d.CastId);

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.MovieCasts)
                    .HasForeignKey(d => d.MovieId);
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("Rating");

                entity.HasIndex(e => e.MovieId, "IX_Rating_MovieId");

                entity.HasIndex(e => e.UserId, "IX_Rating_UserId");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.MovieId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
