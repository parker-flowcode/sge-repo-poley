using Ejercicio1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var mensaje = "";

            if(DateTime.Now.Hour < 12)
            {
                mensaje = "¡Buenos días!";
            }
            else if (DateTime.Now.Hour < 18)
            {
                mensaje = "¡Buenas tardes!";
            }
            else
            {
                mensaje = "¡Buenas noches!";
            }
            ViewData["Mensaje"] = mensaje;
            ViewBag.FechaActual = DateTime.Now.ToString("dd/MM/yyyy");
            ViewBag.HoraActual = DateTime.Now.ToString("HH:mm:ss");
            return View();
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
