using Microsoft.AspNetCore.Mvc;
using MVC_MarcVallverdu.Models;
using System.Diagnostics;

namespace MVC_MarcVallverdu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitForm(string nombre, int edad)
        {
            var nombreRecibido = nombre;
            var edadRecibida = edad;
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult VistaPersonalizada()
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
