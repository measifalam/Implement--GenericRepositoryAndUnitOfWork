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
    internal class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieManagementDbContext context) : base(context)
        {
        }
    }
}
