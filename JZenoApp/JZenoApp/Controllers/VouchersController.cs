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
    public class VouchersController : Controller
    {
        private readonly JZenoDbContext _context;

        public VouchersController(JZenoDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
              return _context.Voucher != null ? 
                          View(await _context.Voucher.ToListAsync()) :
                          Problem("Entity set 'JZenoDbContext.Voucher'  is null.");
        }
        [Authorize(Roles ="Admin")]
        public IActionResult Create()
        {
            return View();
        }

  
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("voucherID,name,price,quantity,startDate,endDate")] Voucher voucher)
        {
            if (ModelState.IsValid)
            {
                _context.Add(voucher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(voucher);
        }

        [Authorize(Roles ="Admin")]

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Voucher == null)
            {
                return NotFound();
            }

            var voucher = await _context.Voucher.FindAsync(id);
            if (voucher == null)
            {
                return NotFound();
            }
            return View(voucher);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("voucherID,name,price,quantity,startDate,endDate")] Voucher voucher)
        {
            if (id != voucher.voucherID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(voucher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VoucherExists(voucher.voucherID))
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
            return View(voucher);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Voucher == null)
            {
                return NotFound();
            }

            var voucher = await _context.Voucher
                .FirstOrDefaultAsync(m => m.voucherID == id);
            if (voucher == null)
            {
                return NotFound();
            }

            return View(voucher);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (_context.Voucher == null)
            {
                return Problem("Entity set 'JZenoDbContext.Voucher'  is null.");
            }
            var voucher = await _context.Voucher.FindAsync(id);
            if (voucher != null)
            {
                _context.Voucher.Remove(voucher);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VoucherExists(int? id)
        {
          return (_context.Voucher?.Any(e => e.voucherID == id)).GetValueOrDefault();
        }
    }
}
