using Microsoft.EntityFrameworkCore;
using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.DataAccess.Implementation
{
    public class ActorRepository:GenericRepository<Actor>,IActorRepository
    {
        public ActorRepository(MovieManagementDbContext context):base(context)
        {
            
        }

        public IEnumerable<Actor> GetActorsWithMovies()
        {
            var actorsWithMovie = _context.Actors.Include(a => a.Movies).ToList();
            return actorsWithMovie;
        }
    }
}
