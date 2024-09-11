using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GamCollezioni.Models;
using Microsoft.AspNetCore.Authorization;

namespace GamCollezioni.Controllers
{
    [Authorize]
    public class OpereController : Controller
    {
        private readonly GamCollezioniContext _context;

        public OpereController(GamCollezioniContext context)
        {
            _context = context;
        }

        // GET: Opere
        /*  public async Task<IActionResult> Index(string autore, string titolo)
          {
              var lista =  _context.Opere.Take(50);
              if (!string.IsNullOrEmpty(autore) && (!string.IsNullOrEmpty(titolo)))
                  lista =  _context.Opere.Where(x=>x.Autore.Contains(autore)).Where(x=>x.Titolo.Contains(titolo));

              if (!string.IsNullOrEmpty(titolo) && string.IsNullOrEmpty(autore))
                  lista = _context.Opere.Where(x => x.Titolo.Contains(titolo));

              if (string.IsNullOrEmpty(titolo) && !string.IsNullOrEmpty(autore))
                  lista = _context.Opere.Where(x => x.Autore.Contains(autore));


              return View(await lista.ToListAsync());

          }
        */
        [AllowAnonymous]
        public async Task<IActionResult> Index(int pagina,string autore, string titolo)
        {
            var record = 75;
            if (pagina == 0)
                pagina = 1;

            var lista = _context.Opere.IgnoreQueryFilters();

            if (!string.IsNullOrEmpty(titolo))
                lista = lista.Where(x => x.Titolo.Contains(titolo));

            if (!string.IsNullOrEmpty(autore))
                lista = lista.Where(x => x.Autore.Contains(autore));

            ViewBag.Autore = autore;
            ViewBag.Titolo = titolo;
            ViewBag.Pagina = lista.Count() / record;  //numero di pagine da visualizzare 
            ViewBag.PaginaSelezionata = pagina;
            return View(await lista.Skip((pagina-1)*record).Take(record).ToListAsync());

        }

        [AllowAnonymous]
        public async Task<IActionResult> Autori()
        {
            var lista = _context.Opere.Select(x => x.Autore).Distinct().ToListAsync();

            return View(await lista);

        }

        [AllowAnonymous]
        // GET: Opere/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opera = await _context.Opere
                .FirstOrDefaultAsync(m => m.Id == id);
            if (opera == null)
            {
                return NotFound();
            }

            return View(opera);
        }

        // GET: Opere/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Opere/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Autore,Titolo,Datazione,Tecnica,Dimensioni,Immagine")] Opera opera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(opera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(opera);
        }

        // GET: Opere/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opera = await _context.Opere.FindAsync(id);
            if (opera == null)
            {
                return NotFound();
            }
            return View(opera);
        }

        // POST: Opere/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Autore,Titolo,Datazione,Tecnica,Dimensioni,Immagine")] Opera opera)
        {
            if (id != opera.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(opera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperaExists(opera.Id))
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
            return View(opera);
        }

        // GET: Opere/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opera = await _context.Opere
                .FirstOrDefaultAsync(m => m.Id == id);
            if (opera == null)
            {
                return NotFound();
            }

            return View(opera);
        }

        // POST: Opere/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var opera = await _context.Opere.FindAsync(id);
            if (opera != null)
            {
                _context.Opere.Remove(opera);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperaExists(int id)
        {
            return _context.Opere.Any(e => e.Id == id);
        }
    }
}
