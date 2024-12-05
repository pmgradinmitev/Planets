using Planets.Entities;
using Planets.Repositories.IRepositories;
using Planets.Services.IServices;

namespace Planets.Services
{
    public class PlanetService:IPlanetService
    {
        private IPlanetRepository _repository;

        public PlanetService(IPlanetRepository repository)
        {
            _repository = repository;
        }

        public List<Planet> GetPlanetList()
        {
            return _repository.ToList();
        }
    }
}
