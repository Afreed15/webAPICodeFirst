using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiMovies.Models;

namespace WebApiMovies.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext (DbContextOptions<MoviesDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiMovies.Models.Movies> Movies { get; set; }
    }
}
