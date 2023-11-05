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
    public class DetailOrdersController : Controller
    {
        private readonly JZenoDbContext _context;

        public DetailOrdersController(JZenoDbContext context)
        {
            _context = context;
        }

        // GET: DetailOrders
        public async Task<IActionResult> Index()
        {
            var jZenoDbContext = _context.DetailOD.Include(d => d.Product).ThenInclude(e=>e.productImages).Include(e=>e.Bill).ThenInclude(e=>e.User);
            return View(await jZenoDbContext.ToListAsync());
        }
        [Route("DetailOrders/updateOD/", Name = "updateOD")]
        public async Task<JsonResult> updateOD(int detailID, int payment)
        {
            var detail = await _context.DetailOD.FindAsync(detailID);
            if (ModelState.IsValid)
            {
                try
                {
                    detail!.detailStatic = payment;
                    _context.Update(detail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                }
                return Json(detail);
            }
            return Json(detail);
        }
    }
}
