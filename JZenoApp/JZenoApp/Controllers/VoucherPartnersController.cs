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
using Microsoft.AspNetCore.Identity;

namespace JZenoApp.Controllers
{
    [Authorize(Roles ="Partner")]
    public class VoucherPartnersController : Controller
    {
        private readonly JZenoDbContext _context;
        private readonly UserManager<User> _userManager;

        public VoucherPartnersController(JZenoDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: VoucherPartners
        public async Task<IActionResult> Index()
        {
            var jZenoDbContext = _context.VoucherPartner.Include(v => v.Partner).Where(e=>e.partnerId == _userManager.GetUserId(User));
            return View(await jZenoDbContext.ToListAsync());
        }


        // GET: VoucherPartners/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("vID,quantity,price,partnerId")] VoucherPartner voucherPartner)
        {
            if (ModelState.IsValid)
            {
                voucherPartner.partnerId = _userManager.GetUserId(User);
                _context.Add(voucherPartner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(voucherPartner);
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.VoucherPartner == null)
            {
                return NotFound();
            }

            var voucherPartner = await _context.VoucherPartner.FindAsync(id);
            if (voucherPartner == null)
            {
                return NotFound();
            }
            return View(voucherPartner);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("vID,quantity,price,partnerId")] VoucherPartner voucherPartner)
        {
            if (id != voucherPartner.vID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(voucherPartner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VoucherPartnerExists(voucherPartner.vID))
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
            ViewData["partnerId"] = new SelectList(_context.Partner, "partnerId", "partnerId", voucherPartner.partnerId);
            return View(voucherPartner);
        }

        private bool VoucherPartnerExists(string id)
        {
          return (_context.VoucherPartner?.Any(e => e.vID == id)).GetValueOrDefault();
        }
    }
}
