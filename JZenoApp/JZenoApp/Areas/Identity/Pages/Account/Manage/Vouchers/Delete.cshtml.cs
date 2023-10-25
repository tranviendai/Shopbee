using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JZenoApp.Data;
using JZenoApp.Models;

namespace JZenoApp.Areas.Identity.Pages.Account.Manage.Vouchers
{
    public class DeleteModel : PageModel
    {
        private readonly JZenoApp.Data.JZenoDbContext _context;

        public DeleteModel(JZenoApp.Data.JZenoDbContext context)
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

            var voucher = await _context.Voucher.FirstOrDefaultAsync(m => m.voucherID == id);

            if (voucher == null)
            {
                return NotFound();
            }
            else 
            {
                Voucher = voucher;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Voucher == null)
            {
                return NotFound();
            }
            var voucher = await _context.Voucher.FindAsync(id);

            if (voucher != null)
            {
                Voucher = voucher;
                _context.Voucher.Remove(Voucher);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
