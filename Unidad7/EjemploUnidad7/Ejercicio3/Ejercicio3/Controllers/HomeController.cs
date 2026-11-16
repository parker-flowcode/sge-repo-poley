using Ejercicio3.Models;
using Ejercicio3.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult listadoPersonas()
        {
            return View(clsPersonaRepository.ObtenerPersonas());
        }

        public IActionResult Persona()
        {
            var personas = clsPersonaRepository.ObtenerPersonas();

            return View(personas[2]);
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
