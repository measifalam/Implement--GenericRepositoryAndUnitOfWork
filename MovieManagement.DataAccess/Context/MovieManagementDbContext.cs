using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.Context
{
    public class MovieManagementDbContext:DbContext
    {
        public MovieManagementDbContext(DbContextOptions<MovieManagementDbContext> options):base(options)
        {
            
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Biography> Biographies { get; set;}

        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id=1,FirstName="Shah Rukh", LastName="Khan"},
                new Actor { Id = 2, FirstName = "Salman", LastName = "Khan" },
                new Actor { Id = 3, FirstName = "Aamir", LastName = "Khan" }
                );
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "DDLJ", Description = "lorem ipsun",ActorId=1 },
                new Movie { Id = 2, Name = "KBKJ", Description = "lorem ipsun", ActorId = 2 },
               new Movie { Id = 3, Name = "Ishq", Description = "lorem ipsun", ActorId = 1 }
                );

        }
    }
}
