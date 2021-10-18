using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Page.Models;

namespace Page.Controllers
{
    public class AddsController : Controller
    {
        private readonly MvcMovieContext _context;

        public AddsController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Adds
        public async Task<IActionResult> Index()
        {
            return View(await _context.Add.ToListAsync());
        }

        // GET: Adds/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @add = await _context.Add
                .FirstOrDefaultAsync(m => m.AddId == id);
            if (@add == null)
            {
                return NotFound();
            }

            return View(@add);
        }

        // GET: Adds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Adds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AddId,AddName")] Add @add)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@add);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@add);
        }

        // GET: Adds/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @add = await _context.Add.FindAsync(id);
            if (@add == null)
            {
                return NotFound();
            }
            return View(@add);
        }

        // POST: Adds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AddId,AddName")] Add @add)
        {
            if (id != @add.AddId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@add);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddExists(@add.AddId))
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
            return View(@add);
        }

        // GET: Adds/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @add = await _context.Add
                .FirstOrDefaultAsync(m => m.AddId == id);
            if (@add == null)
            {
                return NotFound();
            }

            return View(@add);
        }

        // POST: Adds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @add = await _context.Add.FindAsync(id);
            _context.Add.Remove(@add);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddExists(int id)
        {
            return _context.Add.Any(e => e.AddId == id);
        }
    }
}
