#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApi_CargoWeb.Models;

namespace WebApi_CargoWeb.Controllers
{
    public class Tpuertoes1Controller : Controller
    {
        private readonly CargoContext _context;

        public Tpuertoes1Controller(CargoContext context)
        {
            _context = context;
        }

        // GET: Tpuertoes1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tpuertos.ToListAsync());
        }

        // GET: Tpuertoes1/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tpuerto = await _context.Tpuertos
                .FirstOrDefaultAsync(m => m.NCodigoPuerto == id);
            if (tpuerto == null)
            {
                return NotFound();
            }

            return View(tpuerto);
        }

        // GET: Tpuertoes1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tpuertoes1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NCodigoPuerto,NCodigoPais,CPuerto")] Tpuerto tpuerto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tpuerto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tpuerto);
        }

        // GET: Tpuertoes1/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tpuerto = await _context.Tpuertos.FindAsync(id);
            if (tpuerto == null)
            {
                return NotFound();
            }
            return View(tpuerto);
        }

        // POST: Tpuertoes1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("NCodigoPuerto,NCodigoPais,CPuerto")] Tpuerto tpuerto)
        {
            if (id != tpuerto.NCodigoPuerto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tpuerto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TpuertoExists(tpuerto.NCodigoPuerto))
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
            return View(tpuerto);
        }

        // GET: Tpuertoes1/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tpuerto = await _context.Tpuertos
                .FirstOrDefaultAsync(m => m.NCodigoPuerto == id);
            if (tpuerto == null)
            {
                return NotFound();
            }

            return View(tpuerto);
        }

        // POST: Tpuertoes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var tpuerto = await _context.Tpuertos.FindAsync(id);
            _context.Tpuertos.Remove(tpuerto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TpuertoExists(decimal id)
        {
            return _context.Tpuertos.Any(e => e.NCodigoPuerto == id);
        }
    }
}
