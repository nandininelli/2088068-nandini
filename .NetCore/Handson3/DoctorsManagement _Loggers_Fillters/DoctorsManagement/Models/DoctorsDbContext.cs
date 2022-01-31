using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace DoctorsManagement.Models
{
    public class DoctorsDbContext : DbContext
    {

        public virtual DbSet<DoctorsInfo> Doctors { get; set; }

        public DoctorsDbContext(DbContextOptions<DoctorsDbContext> options): base(options)
        {

        }
    }
}
