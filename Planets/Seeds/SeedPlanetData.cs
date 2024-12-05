using Planets.Data;
using Planets.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecomst.Seeds
{
    public class SeedPlanetData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Planets.Any())
                {
                    return;   // DB has been seeded
                }
                context.Planets.AddRange(
                    new Planet {
                        Name = "Mercury",
                        DiameterInKm = 4880,
                        DistanceFromSunInAu = 0.39,
                        NumberOfMoons = 0,
                        Notes = "Smallest planet, no moons, extreme temperatures.",
                    },
                    new Planet
                    {
                        Name = "Venus",
                        DiameterInKm = 12104,
                        DistanceFromSunInAu = 0.72,
                        NumberOfMoons = 0,
                        Notes = "Similar size to Earth, thick toxic atmosphere.",
                    },
                    new Planet
                    {
                        Name = "Earth",
                        DiameterInKm = 12742,
                        DistanceFromSunInAu = 1,
                        NumberOfMoons = 1,
                        Notes = "Only known planet with life.",
                    },
                    new Planet
                    {
                        Name = "Mars",
                        DiameterInKm = 6779,
                        DistanceFromSunInAu = 1.52,
                        NumberOfMoons = 2,
                        Notes = "Known for its red surface and potential for past life.",
                    },
                    new Planet
                    {
                        Name = "Jupiter",
                        DiameterInKm = 139820,
                        DistanceFromSunInAu = 5.20,
                        NumberOfMoons = 80,
                        Notes = "Largest planet, famous for the Great Red Spot.",
                    },
                    new Planet
                    {
                        Name = "Saturn",
                        DiameterInKm = 116460,
                        DistanceFromSunInAu = 9.58,
                        NumberOfMoons = 80,
                        Notes = "Known for its stunning ring system.",
                    },
                    new Planet
                    {
                        Name = "Uranus",
                        DiameterInKm = 50724,
                        DistanceFromSunInAu = 19.18,
                        NumberOfMoons = 27,
                        Notes = "Rotates on its side, blue-green due to methane.",
                    }, new Planet
                    {
                        Name = "Neptune",
                        DiameterInKm = 49244,
                        DistanceFromSunInAu = 30.07,
                        NumberOfMoons = 14,
                        Notes = "Strong winds and storms, deep blue color.",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
