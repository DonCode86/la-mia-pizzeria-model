using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ILogger<PizzaController> _logger;

        public PizzaController(ILogger<PizzaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
         
            return View();
        }

        public IActionResult Details(int id)
        {
            Pizza pizzaBoscaiola = new Pizza("Boscaiola", "Funghi e salsiccia", "pizza-boscaiola.jpg", 9.00);
            Pizza pizzaCapricciosa = new Pizza("Capricciosa", "Funghi, salsiccia, uova, prosciutto crudo", "capricciosa.jfif", 12.00);
            Pizza pizzaDiavola = new Pizza("Diavola", "Salame piccante", "diavola.jfif", 8.00);

            List<Pizza> pizzaList = new List<Pizza> { pizzaBoscaiola, pizzaCapricciosa, pizzaDiavola };

            return View(pizzaList[id]);
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