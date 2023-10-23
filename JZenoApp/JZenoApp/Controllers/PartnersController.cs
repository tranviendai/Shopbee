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

        // GET: Partners
        public async Task<IActionResult> Index()
        {
              return _context.Partner != null ? 
                          View(await _context.Partner.ToListAsync()) :
                          Problem("Entity set 'JZenoDbContext.Partner'  is null.");
        }

        // GET: Partners/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Partner == null)
            {
                return NotFound();
            }

            var partner = await _context.Partner
                .FirstOrDefaultAsync(m => m.partnerId == id);
            if (partner == null)
            {
                return NotFound();
            }

            return View(partner);
        }

        // GET: Partners/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,image,description,dateCreated,file,isActive")] Partner partner)
        {
            if (ModelState.IsValid)
            {
                string stringFileName = UploadFile(partner.file!);
                partner.image = stringFileName;
                partner.partnerId = User.FindFirstValue(ClaimTypes.Name);
                partner.isActive = false;
                partner.dateCreated = DateTime.Now;
                _context.Add(partner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(partner);
        }

        // GET: Partners/Edit/5
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

        // POST: Partners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,name,image,file,description,dateCreated,isActive")] Partner partner)
        {
            string image = partner.image!;
            if (id != partner.partnerId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    if(User.FindFirstValue(ClaimTypes.Role) != "Admin")
                    {
                        DeleteFile(partner.image!);
                    }
                    partner.image = UploadFile(partner.file!);
                    if(partner.image == null)
                    {
                        partner.image = image;
                    }
                    User user = _context.User.Where(s => s.UserName == partner.partnerId).FirstOrDefault()!;
                    if (partner.isActive == true)
                    {
                        _userManager.AddToRoleAsync(user,"Partner").Wait();
                        _userManager.RemoveFromRoleAsync(user, "Customer").Wait();
                    }
                    else
                    {
                        _userManager.AddToRoleAsync(user, "Customer").Wait();
                        _userManager.RemoveFromRoleAsync(user,"Partner").Wait();
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
                return RedirectToAction(nameof(Index));
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
