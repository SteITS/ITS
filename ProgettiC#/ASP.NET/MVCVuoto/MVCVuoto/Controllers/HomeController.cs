using Microsoft.AspNetCore.Mvc;
using MVCVuoto.Models;
using System.Diagnostics;

namespace MVCVuoto.Controllers
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

        public IActionResult ChiSiamo()
        {
            ViewBag.Messaggio = "Benvenuto nella mia prima applicazione ASP.NET MVC";
            
            return View();
        }
        //get: creo vista contatti
        public IActionResult Contatto()
        {
            var contatto = new ContattoViewModel();
            return View(contatto);
        }
        //post: recupero dati da vista contatto
        public IActionResult ContattoRecupero(ContattoViewModel contatto)
        {
            if (contatto == null)
                return BadRequest();

            ViewBag.Risultato = contatto.ToString();
            return View(contatto);
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
