using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VMLbaithi2324.Models;

namespace VMLbaithi2324.Controllers
{
    public class VML850PersonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VML850PersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VML850Person
        public async Task<IActionResult> Index()
        {
              return _context.VML850Person != null ? 
                          View(await _context.VML850Person.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.VML850Person'  is null.");
        }

        // GET: VML850Person/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.VML850Person == null)
            {
                return NotFound();
            }

            var vML850Person = await _context.VML850Person
                .FirstOrDefaultAsync(m => m.VML850ID == id);
            if (vML850Person == null)
            {
                return NotFound();
            }

            return View(vML850Person);
        }

        // GET: VML850Person/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VML850Person/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VML850ID,VML850Name,VML850SoThich")] VML850Person vML850Person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vML850Person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vML850Person);
        }

        // GET: VML850Person/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.VML850Person == null)
            {
                return NotFound();
            }

            var vML850Person = await _context.VML850Person.FindAsync(id);
            if (vML850Person == null)
            {
                return NotFound();
            }
            return View(vML850Person);
        }

        // POST: VML850Person/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VML850ID,VML850Name,VML850SoThich")] VML850Person vML850Person)
        {
            if (id != vML850Person.VML850ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vML850Person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VML850PersonExists(vML850Person.VML850ID))
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
            return View(vML850Person);
        }

        // GET: VML850Person/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.VML850Person == null)
            {
                return NotFound();
            }

            var vML850Person = await _context.VML850Person
                .FirstOrDefaultAsync(m => m.VML850ID == id);
            if (vML850Person == null)
            {
                return NotFound();
            }

            return View(vML850Person);
        }

        // POST: VML850Person/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.VML850Person == null)
            {
                return Problem("Entity set 'ApplicationDbContext.VML850Person'  is null.");
            }
            var vML850Person = await _context.VML850Person.FindAsync(id);
            if (vML850Person != null)
            {
                _context.VML850Person.Remove(vML850Person);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VML850PersonExists(int id)
        {
          return (_context.VML850Person?.Any(e => e.VML850ID == id)).GetValueOrDefault();
        }
    }
}
