using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JZenoApp.Data;
using JZenoApp.Models;

namespace JZenoApp.Controllers
{
    public class BillsController : Controller
    {
        private readonly JZenoDbContext _context;

        public BillsController(JZenoDbContext context)
        {
            _context = context;
        }

        // GET: Bills
        public async Task<IActionResult> Index()
        {
            var jZenoDbContext = _context.Bill.Include(b => b.User).Include(b => b.Voucher);
            return View(await jZenoDbContext.ToListAsync());
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Bill == null)
            {
                return NotFound();
            }

            var bill = await _context.Bill
                .Include(b => b.User)
                .Include(b => b.Voucher)
                .FirstOrDefaultAsync(m => m.billID == id);
            if (bill == null)
            {
                return NotFound();
            }

            return View(bill);
        }

        private bool BillExists(string id)
        {
          return (_context.Bill?.Any(e => e.billID == id)).GetValueOrDefault();
        }
    }
}
