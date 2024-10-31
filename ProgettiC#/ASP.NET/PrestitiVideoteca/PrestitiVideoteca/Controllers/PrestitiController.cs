using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PrestitiVideoteca.Models;

namespace PrestitiVideoteca.Controllers
{
    public class PrestitiController : Controller
    {
        private readonly PrestitiVideotecaContext _context;

        public PrestitiController(PrestitiVideotecaContext context)
        {
            _context = context;
        }

        // GET: Prestiti
        public async Task<IActionResult> Index(string titolo, string cognome)
        {
            var lista = _context.Prestiti
                .Where(p => p.DataRestituzione == null)
                .Include(p => p.IdFilmNavigation)
                .Include(p => p.MatricolaNavigation)
                .IgnoreQueryFilters();

            if (!string.IsNullOrEmpty(cognome))
                lista = lista.Where(x => x.MatricolaNavigation.Cognome!.Contains(cognome));

            if (!string.IsNullOrEmpty(titolo))
                lista = lista.Where(x => x.IdFilmNavigation.Titolo!.Contains(titolo));

            ViewBag.Header = "Elenco prestiti attivi";
            ViewBag.titolo = titolo;
            ViewBag.cognome = cognome;

            return View(await lista.ToListAsync());
        }

        public async Task<IActionResult> ArchivioPrestiti(string titolo, string cognome)
        {
            var prestitiVideotecaContext = _context.Prestiti
                .Where(p => p.DataRestituzione != null)
                .Include(p => p.IdFilmNavigation)
                .Include(p => p.MatricolaNavigation)
                .OrderByDescending(x => x.DataPrestito)
                .IgnoreQueryFilters();

            if (!string.IsNullOrEmpty(cognome))
                prestitiVideotecaContext = prestitiVideotecaContext.Where(x => x.MatricolaNavigation.Cognome!.Contains(cognome));

            if (!string.IsNullOrEmpty(titolo))
                prestitiVideotecaContext = prestitiVideotecaContext.Where(x => x.IdFilmNavigation.Titolo!.Contains(titolo));

            ViewBag.Header = "Archivio prestiti";
            return View("Index", await prestitiVideotecaContext.ToListAsync());
        }

        public async Task<IActionResult> PrestitiScaduti(string titolo, string cognome)
        {
            var prestitiVideotecaContext = _context.Prestiti
                .Where(p => p.DataRestituzione == null && p.DataPrestito.AddDays(30)<DateTime.Now)
                .Include(p => p.IdFilmNavigation)
                .Include(p => p.MatricolaNavigation)
                .OrderByDescending(x => x.DataPrestito)
                .IgnoreQueryFilters();

            if (!string.IsNullOrEmpty(cognome))
                prestitiVideotecaContext = prestitiVideotecaContext.Where(x => x.MatricolaNavigation.Cognome!.Contains(cognome));

            if (!string.IsNullOrEmpty(titolo))
                prestitiVideotecaContext = prestitiVideotecaContext.Where(x => x.IdFilmNavigation.Titolo!.Contains(titolo));

            ViewBag.Header = "Elenco prestiti scaduti";
            return View("Index", await prestitiVideotecaContext.ToListAsync());
        }
        // GET: Prestiti/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestito = await _context.Prestiti
                .Include(p => p.IdFilmNavigation)
                .Include(p => p.MatricolaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestito == null)
            {
                return NotFound();
            }
            
            return View(prestito);
        }

        // GET: Prestiti/Create
        public IActionResult Create()
        {
            ViewData["IdFilm"] = new SelectList(_context.Films, "Codice", "Titolo");
            ViewData["Matricola"] = new SelectList(_context.Studenti, "Matricola", "Nominativo");
            return View();
        }

        // POST: Prestiti/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdFilm,Matricola,DataPrestito,DataRestituzione")] Prestito prestito)
        {
            //if (ModelState.IsValid)
            //{
            prestito.DataPrestito = DateTime.Now;
                _context.Add(prestito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            //}
            //ViewData["IdFilm"] = new SelectList(_context.Films, "Codice", "Codice", prestito.IdFilm);
            //ViewData["Matricola"] = new SelectList(_context.Studenti, "Matricola", "Matricola", prestito.Matricola);
            //return View(prestito);
        }

        // GET: Prestiti/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestito = await _context.Prestiti.FindAsync(id);
            if (prestito == null)
            {
                return NotFound();
            }
            ViewData["IdFilm"] = new SelectList(_context.Films, "Codice", "Codice", prestito.IdFilm);
            ViewData["Matricola"] = new SelectList(_context.Studenti, "Matricola", "Matricola", prestito.Matricola);
            return View(prestito);
        }

        // POST: Prestiti/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdFilm,Matricola,DataPrestito,DataRestituzione")] Prestito prestito)
        {
            if (id != prestito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prestito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestitoExists(prestito.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdFilm"] = new SelectList(_context.Films, "Codice", "Codice", prestito.IdFilm);
            ViewData["Matricola"] = new SelectList(_context.Studenti, "Matricola", "Matricola", prestito.Matricola);
            return View(prestito);
        }

        // GET: Prestiti/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestito = await _context.Prestiti
                .Include(p => p.IdFilmNavigation)
                .Include(p => p.MatricolaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestito == null)
            {
                return NotFound();
            }

            return View(prestito);
        }


        // POST: Prestiti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prestito = await _context.Prestiti.FindAsync(id);
            if (prestito != null)
            {
                _context.Prestiti.Remove(prestito);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult ClassificaFilm()
        {
            var lista = new List<ClassificaFilmViewModel>();

            var film = _context.Films.Include(p => p.Prestitos).ToList();

            foreach (var f in film)
                lista.Add(
                    new ClassificaFilmViewModel
                    {
                        Film = f,
                        NumeroPrestiti = f.Prestitos.Count
                    }
                    );

            var listaordinata = lista.Take(10).OrderByDescending(x => x.NumeroPrestiti).ToList();
            return View(listaordinata);
        }

        private bool PrestitoExists(int id)
        {
            return _context.Prestiti.Any(e => e.Id == id);
        }

        // GET: Restituzione
        public async Task<IActionResult> Restituzione(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestito = await _context.Prestiti
                .Include(p => p.IdFilmNavigation)
                .Include(p => p.MatricolaNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestito == null)
            {
                return NotFound();
            }

            return View(prestito);
        }


        // POST: Prestiti/Restituzione/5
        [HttpPost, ActionName("Restituzione")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RestituzioneConfermata(int id)
        {
            var prestito = await _context.Prestiti.FindAsync(id);
            if (prestito != null)
            {
                prestito.DataRestituzione = DateTime.Now;
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
