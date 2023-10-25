using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JZenoApp.Data;
using JZenoApp.Models;

namespace JZenoApp.Areas.QuanLy.Controllers
{
    [Area("Manage")]
    public class CategoriesController : Controller
    {
        private readonly JZenoDbContext _context;

        public CategoriesController(JZenoDbContext context)
        {
            _context = context;
        }

        [Route("Manage/Categories")]
        public async Task<IActionResult> Index()
        {
              return _context.Category != null ? 
                          View(await _context.Category.ToListAsync()) :
                          Problem("Entity set 'JZenoDbContext.Category'  is null.");
        }

    
        [Route("Manage/Categories/Create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuanLy/Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Route("Manage/Categories/Create")]
        public async Task<IActionResult> Create([Bind("Id,name,icon")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        [Route("Manage/Categories/Edit/{id?}")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Manage/Categories/Edit/{id?}")]
        public async Task<IActionResult> Edit(string id, [Bind("Id,name,icon")] Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
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
            return View(category);
        }

       
       
        private bool CategoryExists(string id)
        {
          return (_context.Category?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
