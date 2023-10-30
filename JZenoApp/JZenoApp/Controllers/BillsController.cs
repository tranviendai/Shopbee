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
        public DetailOrder DetailOrder { get; set; }

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
                .Include(b => b.User)!
                .Include(b => b.Voucher)!
                .Include(e=> e.detailsOrders)!.ThenInclude(e=>e.Product)!
                .FirstOrDefaultAsync(m => m.billID == id);
            DetailOrder = await _context.DetailOD.FirstOrDefaultAsync(o => o.billID == bill.billID);
            if (bill == null)
            {
                return NotFound();
            }

            return View(bill);
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
