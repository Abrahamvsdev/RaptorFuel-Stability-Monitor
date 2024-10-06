using Microsoft.AspNetCore.Mvc;
using SistemaMonitoreoCarga.Models;

namespace SistemaMonitoreoCarga.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new StarshipModel());
        }

        [HttpPost]
        public IActionResult CalcularDistribucionCarga(StarshipModel model)
        {
            model.CalcularDistribucionCarga();
            return View("Index", model);
        }
    }
}
