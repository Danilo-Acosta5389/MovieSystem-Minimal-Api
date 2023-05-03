using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MovieSystem_Minimal_Api.Models;

namespace MovieSystem_Minimal_Api.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<LikedGenre> LikedGenres { get; set; }
        public DbSet<PersonMovie> PersonMovies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DN1L0S-D4TR;Database=MovieSystem-Minimal-Api.Models;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
