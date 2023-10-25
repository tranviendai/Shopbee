using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JZenoApp.Data;
using JZenoApp.Models;

namespace JZenoApp.Areas.Identity.Pages.Account.Manage.Vouchers
{
    public class CreateModel : PageModel
    {
        private readonly JZenoApp.Data.JZenoDbContext _context;

        public CreateModel(JZenoApp.Data.JZenoDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Voucher Voucher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Voucher == null || Voucher == null)
            {
                return Page();
            }

            _context.Voucher.Add(Voucher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
