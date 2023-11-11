using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCApp.Data;
using System;
using System.Linq;

namespace MVCApp.Models
{
    public static class SeedData
    {
        public static void Inicialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCAppContext(serviceProvider.GetRequiredService<DbContextOptions<MVCAppContext>>()))
            {
                //Buscar Any Movie
                if (context.Movie.Any()) 
                {
                    //Db has been seeded
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry meet Sally ",
                        RealeseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R" 
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        RealeseDate = DateTime.Parse("1983-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        RealeseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "RioBravo",
                        RealeseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "R"
                    }
                   );
                context.SaveChanges();
            }
        }

    }
}
