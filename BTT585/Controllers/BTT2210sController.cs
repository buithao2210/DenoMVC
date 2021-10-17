using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BTT585.Models;

namespace BTT585.Controllers
{
    public class BTT2210sController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BTT2210sController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BTT2210s
        public async Task<IActionResult> Index()
        {
            return View(await _context.BTT2210.ToListAsync());
        }

        // GET: BTT2210s/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bTT2210 = await _context.BTT2210
                .FirstOrDefaultAsync(m => m.BTTId == id);
            if (bTT2210 == null)
            {
                return NotFound();
            }

            return View(bTT2210);
        }

        // GET: BTT2210s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BTT2210s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BTTId,BTTName,BTTGender")] BTT2210 bTT2210)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bTT2210);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bTT2210);
        }

        // GET: BTT2210s/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bTT2210 = await _context.BTT2210.FindAsync(id);
            if (bTT2210 == null)
            {
                return NotFound();
            }
            return View(bTT2210);
        }

        // POST: BTT2210s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BTTId,BTTName,BTTGender")] BTT2210 bTT2210)
        {
            if (id != bTT2210.BTTId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bTT2210);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BTT2210Exists(bTT2210.BTTId))
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
            return View(bTT2210);
        }

        // GET: BTT2210s/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bTT2210 = await _context.BTT2210
                .FirstOrDefaultAsync(m => m.BTTId == id);
            if (bTT2210 == null)
            {
                return NotFound();
            }

            return View(bTT2210);
        }

        // POST: BTT2210s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bTT2210 = await _context.BTT2210.FindAsync(id);
            _context.BTT2210.Remove(bTT2210);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BTT2210Exists(int id)
        {
            return _context.BTT2210.Any(e => e.BTTId == id);
        }
    }
}
