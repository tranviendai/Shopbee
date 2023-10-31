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
    public class ProductsController : Controller
    {
        private readonly JZenoDbContext _context;

        public ProductsController(JZenoDbContext context)
        {
            _context = context;
        }

        [Route("Manage/Products")]
        public async Task<IActionResult> Index()
        {
            var jZenoDbContext = _context.Product.Include(p => p.Category).Include(p => p.Partner).Include(p => p.productImages);
            return View(await jZenoDbContext.ToListAsync());
        }

        [Route("/Manage/Products/updateActive/{id?}")]
        public async Task<JsonResult> updateActive(string id)
        {
            var product = await _context.Product.FindAsync(id);

            if (ModelState.IsValid)
            {
                try
                {
                    if (product!.isPublish == null) product.isPublish = true;
                    else product!.isPublish = !product!.isPublish;
                    product.postDate = DateTime.Now;
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                }
                return Json(product);
            }
            return Json(product);
        }
    }
}
