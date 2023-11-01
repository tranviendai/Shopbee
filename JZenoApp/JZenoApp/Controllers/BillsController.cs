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

namespace JZenoApp.Controllers
{
    public class BillsController : Controller
    {
        private readonly JZenoDbContext _context;

        public BillsController(JZenoDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            var jZenoDbContext = _context.Bill.Include(b => b.User).Include(b => b.Voucher).Include(e=>e.detailsOrders).ThenInclude(e=>e.Product);
            return View(await jZenoDbContext.ToListAsync());
        }
        
        public IActionResult List(string? searchName)
        {
            ViewData["searchPhone"] = searchName;
            var bill = from m in _context.Bill
                       select m;
            return View(bill.Include(b => b.User).Include(b => b.Voucher).Where(e => e.note!.Contains(searchName!)).ToList());
        }
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Bill == null)
            {
                return NotFound();
            }

            var bill = await _context.Bill
                .Include(b => b.User)!
                .Include(b => b.Voucher)!
                .Include(e=> e.detailsOrders)!.ThenInclude(e=>e.Product)!.ThenInclude(e=>e.productImages)!
                .FirstOrDefaultAsync(m => m.billID == id);
            if (bill == null)
            {
                return NotFound();
            }
            return View(bill);
        }
        [Route("Bills/updateActive/", Name = "updateActive")]
        public async Task<JsonResult> updateActive(string billID, int payment)
        {
            var bill = await _context.Bill.FindAsync(billID);

            if (ModelState.IsValid)
            {
                try
                {
                    if (bill!.payment == null) bill.billStatic = 0;
                    else bill!.billStatic = payment;
                    _context.Update(bill);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                }
                return Json(bill);
            }
            return Json(bill);
        }
    }
}
