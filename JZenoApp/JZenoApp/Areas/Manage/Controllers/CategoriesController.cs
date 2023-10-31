using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JZenoApp.Data;
using JZenoApp.Models;
using Microsoft.AspNetCore.Hosting;
using PayPal.Api;

namespace JZenoApp.Areas.QuanLy.Controllers
{
    [Area("Manage")]
    public class CategoriesController : Controller
    {
        private readonly JZenoDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CategoriesController(JZenoDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
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

        [HttpPost]
        [Route("Manage/Categories/Create")]
        public async Task<IActionResult> Create([Bind("Id,name,icon,file")] Category category)
        {
            if (ModelState.IsValid)
            {
                UploadFile(category.file!);
                category.icon = UploadFile(category.file!);
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        private string UploadFile(IFormFile file)
        {
            string? fileName = null;
            if (file != null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images/logo");
                fileName = Guid.NewGuid().ToString() + "-" + file.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            return fileName!;
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
        public async Task<IActionResult> Edit(string id, [Bind("Id,name,icon,file")] Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (category.icon != null)
                {
                    if (category.file == null)
                    {
                        DeleteFile(category.icon!);
                        UploadFile(category.file!);
                        category.icon = UploadFile(category.file!);
                    }
                }
                else
                {
                    UploadFile(category.file!);
                    category.icon = UploadFile(category.file!);
                }
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

        private void DeleteFile(string file)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", file);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }

        private bool CategoryExists(string id)
        {
          return (_context.Category?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
