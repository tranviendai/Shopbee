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

        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null || _context.Bill == null)
            {
                return NotFound();
            }

            var bill = await _context.Bill
                .FirstOrDefaultAsync(m => m.billID == id);
            if (bill == null)
            {
                return NotFound();
            }

            return View(bill);
        }

        // POST: Vouchers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string? id)
        {
            if (_context.Bill == null)
            {
                return Problem("Entity set 'JZenoDbContext.Voucher'  is null.");
            }
            var bill = await _context.Bill.FindAsync(id);
            if ( bill != null)
            {
                _context.Bill.Remove(bill);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
