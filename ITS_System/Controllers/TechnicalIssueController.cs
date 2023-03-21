using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITS_System.Data;
using ITS_System.Models;

namespace ITS_System
{
    public class TechnicalIssueController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TechnicalIssueController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TechnicalIssue
        public async Task<IActionResult> Index()
        {
              return _context.TechnicalIssue != null ? 
                          View(await _context.TechnicalIssue.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TechnicalIssue'  is null.");
        }

        // GET: TechnicalIssue/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.TechnicalIssue == null)
            {
                return NotFound();
            }

            var technicalIssue = await _context.TechnicalIssue
                .FirstOrDefaultAsync(m => m.Id == id);
            if (technicalIssue == null)
            {
                return NotFound();
            }

            return View(technicalIssue);
        }

        // GET: TechnicalIssue/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TechnicalIssue/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Details,Timestamp")] TechnicalIssue technicalIssue)
        {
            if (ModelState.IsValid)
            {
                technicalIssue.Id = Guid.NewGuid();
                _context.Add(technicalIssue);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(technicalIssue);
        }

        // GET: TechnicalIssue/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.TechnicalIssue == null)
            {
                return NotFound();
            }

            var technicalIssue = await _context.TechnicalIssue.FindAsync(id);
            if (technicalIssue == null)
            {
                return NotFound();
            }
            return View(technicalIssue);
        }

        // POST: TechnicalIssue/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Details,Timestamp")] TechnicalIssue technicalIssue)
        {
            if (id != technicalIssue.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(technicalIssue);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TechnicalIssueExists(technicalIssue.Id))
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
            return View(technicalIssue);
        }

        // GET: TechnicalIssue/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.TechnicalIssue == null)
            {
                return NotFound();
            }

            var technicalIssue = await _context.TechnicalIssue
                .FirstOrDefaultAsync(m => m.Id == id);
            if (technicalIssue == null)
            {
                return NotFound();
            }

            return View(technicalIssue);
        }

        // POST: TechnicalIssue/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.TechnicalIssue == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TechnicalIssue'  is null.");
            }
            var technicalIssue = await _context.TechnicalIssue.FindAsync(id);
            if (technicalIssue != null)
            {
                _context.TechnicalIssue.Remove(technicalIssue);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TechnicalIssueExists(Guid id)
        {
          return (_context.TechnicalIssue?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
