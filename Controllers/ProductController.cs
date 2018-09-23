using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetCore.Models.EntitiesFramework;

namespace NetCore.Controllers
{
    [CheckSite]
    public class ProductController : Controller
    {
        private readonly ProductContext _context;

        public ProductController(ProductContext context)
        {
            _context = context;
        }
        // GET: Product
        string urlSite = "~/Views/satmanhcuong.com/Home";
        public async Task<ActionResult> GetById(string id)
        {
            string siteId = ViewBag.SiteId;
            var product = await _context.Product.Include(p => p.Category).Include(p => p.PictureNavigation).Where(p => !p.Deleted && p.ProductAlias == id && p.SiteId == siteId).FirstOrDefaultAsync();
            if (product == null)
            {
                return NotFound();
            }
            foreach (var image in product.PictureNavigation)
            {
                image.ImageUrl = image.ImageUrl.Replace("\\", "/");
            }
            urlSite = "~/Views/" + ViewBag.SiteId + "/Product";
            return View(urlSite + "/Index.cshtml",product);
        }
        public async Task<ActionResult> Compare(string id)
        {
            string siteId = ViewBag.SiteId;
            var product = await _context.Product.Include(p => p.Category).Include(p => p.PictureNavigation).Where(p => !p.Deleted && p.ProductAlias == id && p.SiteId == siteId).FirstOrDefaultAsync();
            if (product == null)
            {
                return NotFound();
            }
            foreach (var image in product.PictureNavigation)
            {
                image.ImageUrl = image.ImageUrl.Replace("\\", "/");
            }
            urlSite = "~/Views/" + ViewBag.SiteId + "/Product";
            return View(urlSite + "/Compare.cshtml", product);
        }

    }
}