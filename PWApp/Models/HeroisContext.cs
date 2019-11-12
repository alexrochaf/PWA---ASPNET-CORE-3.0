using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PWApp.Models
{
    public class HeroisContext : DbContext
    {
        public HeroisContext(DbContextOptions<HeroisContext> options) : base(options)
        {
            
        }

        public DbSet<SuperHeroi> SuperHeroi { get; set; }
    }
}
