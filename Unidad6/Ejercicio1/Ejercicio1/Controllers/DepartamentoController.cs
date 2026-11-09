using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1.Controllers
{
    public class DepartamentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
