using Microsoft.AspNetCore.Mvc;
using Planets.Entities;
using Planets.Models;
using Planets.Services.IServices;
using System.Diagnostics;

namespace Planets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IPlanetService _planetService;
        
        public HomeController(ILogger<HomeController> logger, IPlanetService planetService)
        {
            _logger = logger;
            _planetService = planetService;
        }

        public IActionResult Index()
        {
            List<Planet> list = _planetService.GetPlanetList();
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
