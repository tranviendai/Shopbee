using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JZenoApp.Data;
using JZenoApp.Models;

namespace JZenoApp.Areas.QuanLy
{
    [Area("Manage")]
    public class PartnersController : Controller
    {
        private readonly JZenoDbContext _context;

        public PartnersController(JZenoDbContext context)
        {
            _context = context;
        }

        [Route("Manage/Partners")]
        public async Task<IActionResult> Index()
        {
              return _context.Partner != null ? 
                          View(await _context.Partner.ToListAsync()) :
                          Problem("Entity set 'JZenoDbContext.Partner'  is null.");
        }

        [Route("Manage/Partners/Details/{id?}")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Partner == null)
            {
                return NotFound();
            }

            var partner = await _context.Partner
                .FirstOrDefaultAsync(m => m.partnerId == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }
    }
}
