﻿using System;
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
    public class FilmsController : Controller
    {
        private readonly PrestitiVideotecaContext _context;

        public FilmsController(PrestitiVideotecaContext context)
        {
            _context = context;
        }

        // GET: Films
        public async Task<IActionResult> Index(string genere)
        {
            var FilmVideotecaContext = _context.Films
                .IgnoreQueryFilters();

            if (!string.IsNullOrEmpty(genere))
                FilmVideotecaContext = FilmVideotecaContext.Where(x => x.Genere!.Equals(genere));
            ViewBag.Genere =_context.Films.Select(x => x.Genere).Distinct().OrderBy(f=>f).ToList();
            ViewBag.GenereSelezionato = genere;

            return View(await FilmVideotecaContext.ToListAsync());
        }

        // GET: Films/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Films
                .FirstOrDefaultAsync(m => m.Codice == id);
            if (film == null)
            {
                return NotFound();
            }
            ViewBag.Prestiti = _context.Prestiti
                .Include(x => x.MatricolaNavigation)
                .Where(x => x.IdFilm == id)
                .OrderByDescending(x => x.DataPrestito).ToList();
                
            return View(film);
        }

        // GET: Films/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codice,Titolo,Supporto,Regista,Attori,Genere")] Film film)
        {
            if (ModelState.IsValid)
            {
                _context.Add(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(film);
        }

        // GET: Films/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Films.FindAsync(id);
            if (film == null)
            {
                return NotFound();
            }
            return View(film);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Codice,Titolo,Supporto,Regista,Attori,Genere")] Film film)
        {
            if (id != film.Codice)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(film);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmExists(film.Codice))
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
            return View(film);
        }

        // GET: Films/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Films
                .FirstOrDefaultAsync(m => m.Codice == id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // POST: Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var film = await _context.Films.FindAsync(id);
            if (film != null)
            {
                _context.Films.Remove(film);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmExists(int id)
        {
            return _context.Films.Any(e => e.Codice == id);
        }
    }
}
