using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using day6_movie.Models;

namespace day6_movie.Data
{
    public class day6_movieContext : DbContext
    {
        public day6_movieContext (DbContextOptions<day6_movieContext> options)
            : base(options)
        {
        }

        public DbSet<day6_movie.Models.Genre> Genre { get; set; } = default!;
        public DbSet<day6_movie.Models.Movie> Movie { get; set; } = default!;
    }
}
