using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JZenoApp.Data;
using JZenoApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace JZenoApp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class NewsController : Controller
    {
        private readonly JZenoDbContext _context;

        public NewsController(JZenoDbContext context)
        {
            _context = context;
        }

        // GET: Manage/News
        [Route("Manage/News")]
        public async Task<IActionResult> Index()
        {
            var jZenoDbContext = _context.NewsModel.Include(n => n.user);
            return View(await jZenoDbContext.ToListAsync());
        }

        // GET: Manage/News/Details/5
        [Route("Manage/News/Details/{id?}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.NewsModel == null)
            {
                return NotFound();
            }
            var newsModel = await _context.NewsModel
                .Include(n => n.user)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (newsModel == null)
            {
                return NotFound();
            }

            return View(newsModel);
        }

        [Route("Manage/News/Create")]
        [Authorize(Roles = "Admin,Partner")]
        public IActionResult Create()
        {
            ViewData["userId"] = new SelectList(_context.User, "Id", "Id");
            return View();
        }

        [Route("Manage/News/Create")]
        [HttpPost]
        [Authorize(Roles = "Admin,Partner")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,title,description,userId")] NewsModel newsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["userId"] = new SelectList(_context.User, "Id", "Id", newsModel.userId);
            return View(newsModel);
        }

        [Route("Manage/News/Edit/{id?}")]
        [Authorize(Roles = "Admin,Partner")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.NewsModel == null)
            {
                return NotFound();
            }

            var newsModel = await _context.NewsModel.FindAsync(id);
            if (newsModel == null)
            {
                return NotFound();
            }
            ViewData["userId"] = new SelectList(_context.User, "Id", "Id", newsModel.userId);
            return View(newsModel);
        }

        [Route("Manage/News/Edit/{id?}")]
        [HttpPost]
        [Authorize(Roles = "Admin,Partner")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Id,title,description,userId")] NewsModel newsModel)
        {
            if (id != newsModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsModelExists(newsModel.Id))
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
            ViewData["userId"] = new SelectList(_context.User, "Id", "Id", newsModel.userId);
            return View(newsModel);
        }
        [Route("Manage/News/Delete/{id?}")]
        [Authorize(Roles = "Admin,Partner")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.NewsModel == null)
            {
                return NotFound();
            }

            var newsModel = await _context.NewsModel
                .Include(n => n.user)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (newsModel == null)
            {
                return NotFound();
            }

            return View(newsModel);
        }

        [Route("Manage/News/Delete/{id?}")]
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin,Partner")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.NewsModel == null)
            {
                return Problem("Entity set 'JZenoDbContext.NewsModel'  is null.");
            }
            var newsModel = await _context.NewsModel.FindAsync(id);
            if (newsModel != null)
            {
                _context.NewsModel.Remove(newsModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsModelExists(int? id)
        {
          return (_context.NewsModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
