using HotLineServices.Models;
using Microsoft.EntityFrameworkCore;

namespace HotLineServices.Data
{
    public class FishDbContext : DbContext
    {
        public FishDbContext(DbContextOptions<FishDbContext> options)
            : base(options)
        {
        }

        public DbSet<Fish> Fishes { get; set; }
    }
}
