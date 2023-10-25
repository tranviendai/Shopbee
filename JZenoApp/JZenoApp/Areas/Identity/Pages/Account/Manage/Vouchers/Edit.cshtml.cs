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

namespace JZenoApp.Areas.Identity.Pages.Account.Manage.Vouchers
{
    public class EditModel : PageModel
    {
        private readonly JZenoApp.Data.JZenoDbContext _context;

        public EditModel(JZenoApp.Data.JZenoDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Voucher Voucher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Voucher == null)
            {
                return NotFound();
            }

            var voucher =  await _context.Voucher.FirstOrDefaultAsync(m => m.voucherID == id);
            if (voucher == null)
            {
                return NotFound();
            }
            Voucher = voucher;
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

            _context.Attach(Voucher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoucherExists(Voucher.voucherID))
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

        private bool VoucherExists(int? id)
        {
          return (_context.Voucher?.Any(e => e.voucherID == id)).GetValueOrDefault();
        }
    }
}
