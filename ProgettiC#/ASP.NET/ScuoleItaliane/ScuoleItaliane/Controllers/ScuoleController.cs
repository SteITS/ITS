using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScuoleItaliane.Models;

namespace ScuoleItaliane.Controllers
{
    public class ScuoleController : Controller
    {
        private readonly ScuoleItalianeContext _context;

        public ScuoleController(ScuoleItalianeContext context)
        {
            _context = context;
        }

        // GET: Scuole
        public async Task<IActionResult> Index(string regione, string comune, string nome)
        {

            var scuoleItalianeContext = _context.Scuole.Include(s => s.IdCaratteristicaScuolaNavigation).Include(s => s.IdComuneNavigation).Include(s => s.IdIstitutoRiferimentoNavigation).Include(s => s.IdTipologiaScuolaNavigation).AsQueryable();

            if (!string.IsNullOrEmpty(regione) && !regione.Equals("tutte"))
                scuoleItalianeContext = scuoleItalianeContext.Where(x => x.IdComuneNavigation.IdProvinciaNavigation.IdRegioneNavigation.Denominazione.Equals(regione));

            if (!string.IsNullOrEmpty(comune) && !comune.Equals("tutte"))
            {
                scuoleItalianeContext = scuoleItalianeContext.Where(x => x.IdComuneNavigation.Denominazione.Equals(comune));
            }

            if (!string.IsNullOrEmpty(nome))
            {
                scuoleItalianeContext = scuoleItalianeContext.Where(x => x.Denominazione.Contains(nome));
            }

            ViewBag.RegioneSelezionata = regione;
            ViewBag.ComuneSelezionato = comune;
            ViewBag.Nome = nome;
            ViewBag.Regione = _context.Scuole.Select(x => x.IdComuneNavigation.IdProvinciaNavigation.IdRegioneNavigation.Denominazione).Distinct().OrderBy(d=>d).ToList();
            ViewBag.Comune = _context.Scuole.Select(x => x.IdComuneNavigation.Denominazione).Distinct().OrderBy(d => d).ToList();

            return View(await scuoleItalianeContext.Take(200).ToListAsync());
        }

        public async Task<IActionResult> ZonaLit()
        {
            var lista = _context.Scuole.Include(s => s.IdCaratteristicaScuolaNavigation).Include(s => s.IdComuneNavigation).Where(s => s.IdComuneNavigation.ComuneLitoraneo.Equals(true));

                return View(await lista.ToListAsync());
        }

        // GET: Scuole/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scuola = await _context.Scuole
                .Include(s => s.IdCaratteristicaScuolaNavigation)
                .Include(s => s.IdComuneNavigation)
                .Include(s => s.IdIstitutoRiferimentoNavigation)
                .Include(s => s.IdTipologiaScuolaNavigation)
                .FirstOrDefaultAsync(m => m.CodiceScuola == id);
            if (scuola == null)
            {
                return NotFound();
            }

            return View(scuola);
        }

        private bool ScuolaExists(string id)
        {
            return _context.Scuole.Any(e => e.CodiceScuola == id);
        }
    }
}
