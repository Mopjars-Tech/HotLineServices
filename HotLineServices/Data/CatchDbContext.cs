using Microsoft.EntityFrameworkCore;

namespace HotLineServices.Data
{
    public class CatchDbContext : DbContext
    {
        public CatchDbContext(DbContextOptions<CatchDbContext> options)
            : base(options)
        {
        }
    }
}
