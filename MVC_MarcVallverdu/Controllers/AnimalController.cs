using Microsoft.AspNetCore.Mvc;
using MVC_MarcVallverdu.Models;

namespace MVC_MarcVallverdu.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Mensaje = "¡Valor pasado por viewbag!";

            List<Animal> lstAnimals = new List<Animal>()
            {
                new Animal() { IdAnimal = 1, Nombre = "Gato" },
                new Animal() { IdAnimal = 2, Nombre = "Perro" },
                new Animal() { IdAnimal = 3, Nombre = "Conejo" },
                new Animal() { IdAnimal = 4, Nombre = "Hamster" }
            };

            Random rnd = new Random();

            int numeroAleatorio = rnd.Next(0, 4);
            ViewBag.Ejemplo = "El " + lstAnimals[numeroAleatorio].Nombre + " es tu animal de la suerte!";

            return View(lstAnimals);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Animal nuevoAnimal)
        {
            return View(nuevoAnimal);
        }
    }
}
