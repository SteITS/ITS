using Microsoft.AspNetCore.Mvc;
using MVCVuoto.Models;

namespace MVCVuoto.Controllers
{
    public class ProdottiController : Controller
    {
        public IActionResult Index()
        {
            var prodotto = new Prodotto { codice = 1, nome = "Prodotto 1", data = DateTime.Parse("12/05/2024"), prezzo = 10.50 };

            return View(prodotto);
        }
    }
}
