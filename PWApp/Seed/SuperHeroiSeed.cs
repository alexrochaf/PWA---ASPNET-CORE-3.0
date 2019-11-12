using Microsoft.EntityFrameworkCore;

namespace PWApp.Seed
{
    public static class SuperHeroiSeed
    {
        public static void PopularSuperHerois(IServiceProvider serviceProvider)
        {
            using (var context = new HeroisContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>())){
                if (contex.SuperHeroi.Any()){
                    return;
                }

                context.SuperHeroi.AddRange(
                    new SuperHeroi{
                        
                    }
                )
            }
        }
    }
}
