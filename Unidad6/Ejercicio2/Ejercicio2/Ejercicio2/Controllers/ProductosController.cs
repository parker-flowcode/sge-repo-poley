using Microsoft.AspNetCore.Mvc;

namespace Ejercicio2.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult ListadoProductos()
        {
            return View();
        }
    }
}
