using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp_UsingMvc.Models
{
    public class DataDbContext:DbContext
    {
        public DbSet<Registration> signUps { get; set; }
        public DbSet<MovieList> movieLists { get; set; }
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {

        }
    }
}
