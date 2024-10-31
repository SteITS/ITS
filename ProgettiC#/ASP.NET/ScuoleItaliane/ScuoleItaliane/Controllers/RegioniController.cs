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
    public class RegioniController : Controller
    {
        private readonly ScuoleItalianeContext _context;

        public RegioniController(ScuoleItalianeContext context)
        {
            _context = context;
        }

        // GET: Regioni
        public async Task<IActionResult> Index()
        {
            var scuoleItalianeContext = _context.Regioni.Include(r => r.IdRipartizioneNavigation);
            return View(await scuoleItalianeContext.ToListAsync());
        }

        // GET: Regioni/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regione = await _context.Regioni
                .Include(r => r.IdRipartizioneNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (regione == null)
            {
                return NotFound();
            }

            return View(regione);
        }

        // GET: Regioni/Create
        public IActionResult Create()
        {
            ViewData["IdRipartizione"] = new SelectList(_context.RipartizioneGeografiche, "Id", "Id");
            return View();
        }

        // POST: Regioni/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Denominazione,IdRipartizione")] Regione regione)
        {
            if (ModelState.IsValid)
            {
                _context.Add(regione);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdRipartizione"] = new SelectList(_context.RipartizioneGeografiche, "Id", "Id", regione.IdRipartizione);
            return View(regione);
        }

        // GET: Regioni/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regione = await _context.Regioni.FindAsync(id);
            if (regione == null)
            {
                return NotFound();
            }
            ViewData["IdRipartizione"] = new SelectList(_context.RipartizioneGeografiche, "Id", "Id", regione.IdRipartizione);
            return View(regione);
        }

        // POST: Regioni/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Denominazione,IdRipartizione")] Regione regione)
        {
            if (id != regione.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(regione);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegioneExists(regione.Id))
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
            ViewData["IdRipartizione"] = new SelectList(_context.RipartizioneGeografiche, "Id", "Id", regione.IdRipartizione);
            return View(regione);
        }

        // GET: Regioni/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regione = await _context.Regioni
                .Include(r => r.IdRipartizioneNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (regione == null)
            {
                return NotFound();
            }

            return View(regione);
        }

        // POST: Regioni/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var regione = await _context.Regioni.FindAsync(id);
            if (regione != null)
            {
                _context.Regioni.Remove(regione);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RegioneExists(int id)
        {
            return _context.Regioni.Any(e => e.Id == id);
        }
    }
}
