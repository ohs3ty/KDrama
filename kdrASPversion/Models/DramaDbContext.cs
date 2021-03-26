using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kdrASPversion.Models
{
    public class DramaDbContext : DbContext
    {
        public DramaDbContext(DbContextOptions<DramaDbContext> options) : base(options)
        {

        }

        public DbSet<Kdrama> Kdramas { get; set; }
        
    }
}
