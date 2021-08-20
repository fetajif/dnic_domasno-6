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
    public class ArticlesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArticlesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("/Articles/IndexTopic/{topic}")]
        public async Task<IActionResult> IndexTopic(MentalHealthTopic topic)
        {
            var articlesInTopic = await _context.Articles.Where(z => z.Topic == topic).ToListAsync();
            return View(articlesInTopic);
        }

        // GET: Articles
        public async Task<IActionResult> Index()
        {
            var articlesInTopic = new ArticlesFilteredByTopicDto
            {
                Articles = await _context.Articles.ToListAsync(),
                Topic = MentalHealthTopic.Stress
            };
            return View(articlesInTopic);
        }

        //POST: Articles Filtered By Topic
        [HttpPost]
        public async Task<IActionResult> Index(ArticlesFilteredByTopicDto model)
        {
            var articlesFilteredByTopic = new ArticlesFilteredByTopicDto
            {
                Articles = await _context.Articles.Where(z => z.Topic == model.Topic).ToListAsync(),
                Topic = model.Topic
            };
            return View(articlesFilteredByTopic);
        }

        // GET: Articles/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // GET: Articles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Content,ImageURL,Topic")] Article article)
        {
            if (ModelState.IsValid)
            {
                article.Id = Guid.NewGuid();
                _context.Add(article);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(article);
        }

        // GET: Articles/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.FindAsync(id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Content,ImageURL,Topic")] Article article)
        {
            if (id != article.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.Id))
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
            return View(article);
        }

        // GET: Articles/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var article = await _context.Articles.FindAsync(id);
            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(Guid id)
        {
            return _context.Articles.Any(e => e.Id == id);
        }
    }
}
