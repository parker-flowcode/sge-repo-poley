using EjemploUnidad7_Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using domain;

namespace EjemploUnidad7_Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Persona persona = new Persona();
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
