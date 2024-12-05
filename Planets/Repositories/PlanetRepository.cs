using Microsoft.EntityFrameworkCore;
using Planets.Data;
using Planets.Entities;
using Planets.Repositories.IRepositories;

namespace Planets.Repositories
{
    public class PlanetRepository:IPlanetRepository 
    {
        private readonly ApplicationDbContext _context;

        public PlanetRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Planet> ToList()
        {
            return _context.Planets.ToList();
        }
    }
}
