using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PWApp.Models;
using System;
using System.Linq;

namespace PWApp.Seed
{
    public static class SuperHeroiSeed
    {
        public static void PopularSuperHerois(IServiceProvider serviceProvider)
        {
            using (var context = new HeroisContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<HeroisContext>>()))
            {

                if (context.SuperHeroi.Any()){
                    return;
                }

                context.SuperHeroi.AddRange(
                    new SuperHeroi{
                        Id = 1,
                        Nome = "Batman",
                        SuperPoder = "Grana",
                        Foto = "/images/b.jpg"
                    },
                    new SuperHeroi{
                        Id = 2,
                        Nome = "Miranha",
                        SuperPoder = "Soltar Teia",
                        Foto = "/images/m.jpg"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
