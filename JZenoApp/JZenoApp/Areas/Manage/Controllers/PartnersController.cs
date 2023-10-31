using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JZenoApp.Data;
using JZenoApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace JZenoApp.Areas.QuanLy
{
    [Area("Manage")]
    [Authorize("Admin")]
    public class PartnersController : Controller
    {
        private readonly JZenoDbContext _context;
        private readonly UserManager<User> _userManager;

        public PartnersController(JZenoDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [Route("Manage/Partners")]
        public async Task<IActionResult> Index()
        {
              return _context.Partner != null ? 
                          View(await _context.Partner.ToListAsync()) :
                          Problem("Entity set 'JZenoDbContext.Partner'  is null.");
        }

        [HttpPost]
        [Route("Manage/Partners/activePartner/{id?}")]
        public async Task<IActionResult> activePartner(string id)
        {
            try
            {
                var partner =  await _context.Partner
              .FirstOrDefaultAsync(m => m.partnerId == id);
                partner!.isActive = !partner.isActive;
                User user =  _context.User!.Where(s => s.Id! == id)!.FirstOrDefault()!;
                if (partner!.isActive == true)
                {
                    _userManager.AddToRoleAsync(user, "Partner").Wait();
                    _userManager.RemoveFromRoleAsync(user, "Customer").Wait();
                }
                else
                {
                    _userManager.AddToRoleAsync(user, "Customer").Wait();
                    _userManager.RemoveFromRoleAsync(user, "Partner").Wait();
                }
                 _context.Update(partner);
                 _context.SaveChanges();
                return Json(partner);
            }
            catch (Exception ex) 
            {
                return Json(new { error = ex.Message });
            }
           
        }
    }
}
