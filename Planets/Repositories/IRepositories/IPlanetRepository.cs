using Planets.Entities;

namespace Planets.Repositories.IRepositories
{
    public interface IPlanetRepository
    {
        List<Planet> ToList();
    }
}
