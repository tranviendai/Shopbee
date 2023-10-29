using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JZenoApp.Data;
using JZenoApp.Models;

namespace JZenoApp.Areas.Identity.Pages.Account.Manage.Bills
{
    public class DetailsModel : PageModel
    {
        private readonly JZenoApp.Data.JZenoDbContext _context;

        public DetailsModel(JZenoApp.Data.JZenoDbContext context)
        {
            _context = context;
        }

      public Bill Bill { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Bill == null)
            {
                return NotFound();
            }

            var bill = await _context.Bill.FirstOrDefaultAsync(m => m.billID == id);
            if (bill == null)
            {
                return NotFound();
            }
            else 
            {
                Bill = bill;
            }
            return Page();
        }
    }
}
