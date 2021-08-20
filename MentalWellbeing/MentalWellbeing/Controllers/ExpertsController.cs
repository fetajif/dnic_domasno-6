using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MentalWellbeing.Data;
using MentalWellbeing.Models;

namespace MentalWellbeing.Controllers
{
    public class ExpertsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExpertsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Experts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Experts.ToListAsync());
        }

        public async Task<IActionResult> Contact(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expert = await _context.Experts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expert == null)
            {
                return NotFound();
            }

            return View(expert);
        }

        // GET: Experts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expert = await _context.Experts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expert == null)
            {
                return NotFound();
            }

            return View(expert);
        }

        // GET: Experts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Experts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Surname,Biography,ImageURL")] Expert expert)
        {
            if (ModelState.IsValid)
            {
                expert.Id = Guid.NewGuid();
                _context.Add(expert);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(expert);
        }

        // GET: Experts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expert = await _context.Experts.FindAsync(id);
            if (expert == null)
            {
                return NotFound();
            }
            return View(expert);
        }

        // POST: Experts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Surname,Biography,ImageURL")] Expert expert)
        {
            if (id != expert.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(expert);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExpertExists(expert.Id))
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
            return View(expert);
        }

        // GET: Experts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expert = await _context.Experts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (expert == null)
            {
                return NotFound();
            }

            return View(expert);
        }

        // POST: Experts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var expert = await _context.Experts.FindAsync(id);
            _context.Experts.Remove(expert);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExpertExists(Guid id)
        {
            return _context.Experts.Any(e => e.Id == id);
        }
    }
}
