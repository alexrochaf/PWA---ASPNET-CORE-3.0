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

        protected override void OnModelCreating(ModelBuilder builder)
        {
               builder.Entity<SuperHeroi>().HasKey(m => m.Id);

               builder.Entity<SuperHeroi>().HasData(
                new SuperHeroi {Id = 1, Nome = "Batman", Foto = "/images/b.jpg", SuperPoder = "Grana" },
                new SuperHeroi {Id = 2, Nome = "Miranha", Foto = "/images/m.jpg", SuperPoder = "Soltar Teia" });

               base.OnModelCreating(builder);
        }
    }
}
