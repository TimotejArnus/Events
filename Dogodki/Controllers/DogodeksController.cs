using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dogodki.Database;
using Dogodki.Models;

namespace Dogodki.Controllers
{
    public class DogodeksController : Controller
    {
        private readonly DogodekContext _context;

        public DogodeksController(DogodekContext context)
        {
            _context = context;
        }

        // GET: Dogodeks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dogodki.ToListAsync());
        }

        // GET: Dogodeks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dogodek = await _context.Dogodki
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dogodek == null)
            {
                return NotFound();
            }

            return View(dogodek);
        }

        // GET: Dogodeks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dogodeks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,DatumZacetka,DatumKonca,Naziv,Opis")] Dogodek dogodek)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dogodek);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dogodek);
        }

        // GET: Dogodeks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dogodek = await _context.Dogodki.FindAsync(id);
            if (dogodek == null)
            {
                return NotFound();
            }
            return View(dogodek);
        }

        // POST: Dogodeks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,DatumZacetka,DatumKonca,Naziv,Opis")] Dogodek dogodek)
        {
            if (id != dogodek.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dogodek);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DogodekExists(dogodek.ID))
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
            return View(dogodek);
        }

        // GET: Dogodeks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dogodek = await _context.Dogodki
                .FirstOrDefaultAsync(m => m.ID == id);
            if (dogodek == null)
            {
                return NotFound();
            }

            return View(dogodek);
        }

        // POST: Dogodeks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dogodek = await _context.Dogodki.FindAsync(id);
            _context.Dogodki.Remove(dogodek);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DogodekExists(int id)
        {
            return _context.Dogodki.Any(e => e.ID == id);
        }
    }
}
