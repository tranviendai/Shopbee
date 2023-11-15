using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JZenoApp.Data;
using JZenoApp.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Hosting;
using PayPal.Api;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace JZenoApp.Controllers
{
    public class PartnersController : Controller
    {
        private readonly JZenoDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly UserManager<User> _userManager;
        public PartnersController(JZenoDbContext context, IWebHostEnvironment webHostEnvironment, UserManager<User> userManager)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _userManager = userManager;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,image,address,description,dateCreated,file,isActive")] Partner partner)
        {
            if (ModelState.IsValid)
            {
                string stringFileName = UploadFile(partner.file!);
                partner.image = stringFileName;
                partner.partnerId = _userManager.GetUserId(User);
                partner.isActive = false;
                partner.dateCreated = DateTime.Now;
                _context.Add(partner);
                await _context.SaveChangesAsync();
                return Redirect("/");
            }
            return View(partner);
        }
        [Authorize(Roles = "Partner")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Partner == null)
            {
                return NotFound();
            }
            var partner = await _context.Partner.FindAsync(id);

            if (partner == null)
            {
                return NotFound();
            }
            return View(partner);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Partner")]
        public async Task<IActionResult> Edit(string id, [Bind("partnerId,name,image,address,description,dateCreated,file,isActive")] Partner partner)
        {
            if (id != partner.partnerId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    if (partner.image != null)
                    {
                        DeleteFile(partner.image!);
                        UploadFile(partner.file!);
                        partner.image = UploadFile(partner.file!);
                    }
                    else
                    {
                        UploadFile(partner.file!);
                        partner.image = UploadFile(partner.file!);
                    }
                    _context.Update(partner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartnerExists(partner.partnerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Partners/Details/"+id);
            }
            return View(partner);
        }
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Partner == null)
            {
                return NotFound();
            }
            var partner = await _context.Partner.Include(e=>e.products)!.ThenInclude(e=>e.productImages)
                .FirstOrDefaultAsync(m => m.partnerId == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }

        private bool PartnerExists(string id)
        {
          return (_context.Partner?.Any(e => e.partnerId == id)).GetValueOrDefault();
        }
        private void DeleteFile(string file)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\partner", file);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }
        private string UploadFile(IFormFile file)
        {
            string? fileName = null;
            if (file != null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images/partner");
                fileName = Guid.NewGuid().ToString() + "-" + file.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            return fileName!;
        }
    }
}
