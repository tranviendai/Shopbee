using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JZenoApp.Data;
using JZenoApp.Models;

namespace JZenoApp.Areas.Identity.Pages.Account.Manage.Bills
{
    public class EditModel : PageModel
    {
        private readonly JZenoApp.Data.JZenoDbContext _context;

        public EditModel(JZenoApp.Data.JZenoDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Bill Bill { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Bill == null)
            {
                return NotFound();
            }

            var bill =  await _context.Bill.FirstOrDefaultAsync(m => m.billID == id);
            if (bill == null)
            {
                return NotFound();
            }
            Bill = bill;
           ViewData["UserId"] = new SelectList(_context.User, "Id", "Id");
           ViewData["voucherID"] = new SelectList(_context.Voucher, "voucherID", "voucherID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Bill).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BillExists(Bill.billID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BillExists(string id)
        {
          return (_context.Bill?.Any(e => e.billID == id)).GetValueOrDefault();
        }
    }
}
