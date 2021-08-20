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
    public class DiscussionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DiscussionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Discussions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Discussions.ToListAsync());
        }

        public async Task<IActionResult> AddComment(Guid? id)
        {
            var discussion = await _context.Discussions.FindAsync(id);
            if (discussion != null)
            {
                var model = new AddCommentDto
                {
                    Discussion = discussion
                };
                return View(model);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AddComment(Guid? id, AddCommentDto model)
        {
            var discussion = await _context.Discussions.FindAsync(id);
            if (discussion != null)
            {
                _context.Comments.Add(model.Comment);
                discussion.Comments.Add(model.Comment);
                try
                {
                    _context.Update(discussion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiscussionExists(discussion.Id))
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
            return NotFound();
        }

        // GET: Discussions/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var discussion = await _context.Discussions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (discussion == null)
            {
                return NotFound();
            }

            return View(discussion);
        }

        // GET: Discussions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Discussions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Content,Privacy")] Discussion discussion)
        {
            if (ModelState.IsValid)
            {
                discussion.Id = Guid.NewGuid();
                _context.Add(discussion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(discussion);
        }

        // GET: Discussions/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var discussion = await _context.Discussions.FindAsync(id);
            if (discussion == null)
            {
                return NotFound();
            }
            return View(discussion);
        }

        // POST: Discussions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Content,Privacy")] Discussion discussion)
        {
            if (id != discussion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(discussion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiscussionExists(discussion.Id))
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
            return View(discussion);
        }

        // GET: Discussions/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var discussion = await _context.Discussions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (discussion == null)
            {
                return NotFound();
            }

            return View(discussion);
        }

        // POST: Discussions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var discussion = await _context.Discussions.FindAsync(id);
            _context.Discussions.Remove(discussion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiscussionExists(Guid id)
        {
            return _context.Discussions.Any(e => e.Id == id);
        }
    }
}
