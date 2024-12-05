using Planets.Entities;
using Microsoft.EntityFrameworkCore;

namespace Planets.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Planet> Planets { get; set; }
    }
}
