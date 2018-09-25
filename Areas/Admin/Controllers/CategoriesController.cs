using System;
using System.Linq;
using System.Threading.Tasks;
using NetCore.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetCore.Models.EntitiesFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using NetCore.Models.Common;
using Microsoft.Extensions.Caching.Distributed;
using System.Text;

namespace NetCore.Areas.Admin.Controllers
{
    [Authorize]
    [CheckSite]
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly ProductContext _context;
        private readonly IHostingEnvironment _environment;
        private readonly IDistributedCache _distributedCache;

        public CategoriesController(ProductContext context, IHostingEnvironment hostingEnvironment,
            IDistributedCache distributedCache)
        {
            _context = context;
            _environment = hostingEnvironment;
            _distributedCache = distributedCache;
        }
        // GET: Admin/Categories
        public async Task<ActionResult> Index()
        {
           // string data=await CachingExtensions.GetSetObjectAsync<string>(_distributedCache, "a", "1");

            string siteId = ViewBag.SiteId;
            return View( await _context.Category.ToListAsync());
        }

        // GET: Admin/Categories/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
               return NotFound();
            }
            Category category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // GET: Admin/Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Categories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create( Category category, IFormFile filePicture)
        {
            if (ModelState.IsValid)
            {
                _context.Category.Add(category);
                category.CreatedOnUtc = DateTime.Now;
                category.UpdatedOnUtc = DateTime.Now;
                var path = Path.Combine(_environment.WebRootPath, Constants.LocaltionImage);
                var image = FileExtensions.Upload(filePicture, path);
                category.Picture = image;
                await _context.SaveChangesAsync();
                TempData["Message"] = "create";
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Admin/Categories/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
               return NotFound();
            }
            Category category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Admin/Categories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit( Category category, IFormFile filePicture)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(category).State = EntityState.Modified;
                category.UpdatedOnUtc = DateTime.Now;
                if (filePicture!=null && filePicture.Length>0)
                {
                    var path = Path.Combine(_environment.WebRootPath, Constants.LocaltionImage);
                    var image = FileExtensions.Upload(filePicture, path);
                    category.Picture = image;
                }
                await _context.SaveChangesAsync();
                TempData["Message"] = "update";
                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET: Admin/Categories/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            Category category = await _context.Category.FindAsync(id);
            category.IsDeleted = !category.IsDeleted;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
