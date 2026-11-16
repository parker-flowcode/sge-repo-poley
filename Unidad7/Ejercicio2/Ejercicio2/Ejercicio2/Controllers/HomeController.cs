using Ejercicio2.Models;
using Ejercicio2.Models.Data;
using Ejercicio2.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var hora = DateTime.Now.Hour;
            var saludo = hora < 12
                ? "Buenos días"
                : hora < 20
                    ? "Buenas tardes"
                    : "Buenas noches";

            ViewData["Saludo"] = saludo;
            ViewBag.Fecha = DateTime.Now.ToLongDateString();

            var persona = new clsPersona
            {
                Nombre = "Pedro",
                Apellidos = "Poley",
                Edad = 30,
                Email = "pedro.poley@ejemplo.com"
            };

            return View(persona);
        }

        public IActionResult listadoPersonas()
        {
            return View(clsPersonaRepository.ObtenerPersonas());
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
