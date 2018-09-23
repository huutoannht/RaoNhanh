using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper _mapper;

        public ProductController(ProductContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        // GET: Product
        public async Task<ActionResult> GetById(string id)
        {
            var product = await _context.Product.Include(p => p.Category).Include(p => p.PictureNavigation).Where(p => !p.IsDeleted && p.ProductAlias == id ).FirstOrDefaultAsync();
            if (product == null)
            {
                return NotFound();
            }
            foreach (var image in product.PictureNavigation)
            {
                image.ImageUrl = image.ImageUrl.Replace("\\", "/");
            }
            return View(product);
        }
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(_context.Category.Where(m => !m.IsDeleted), "CategoryId", "Name");
            ViewBag.PostingCategoryId = new SelectList(_context.PostingCategory.Where(m => !m.IsDeleted), "Id", "NamePostingCategory");
            ViewBag.ItemCategoryId = new SelectList(_context.ItemCategory.Where(m => !m.IsDeleted), "Id", "NameItemCategory");
            return View();
        }
        public async Task<ActionResult> Compare(string id)
        {
            string siteId = ViewBag.SiteId;
            var product = await _context.Product.Include(p => p.Category).Include(p => p.PictureNavigation).Where(p => !p.IsDeleted && p.ProductAlias == id ).FirstOrDefaultAsync();
            if (product == null)
            {
                return NotFound();
            }
            foreach (var image in product.PictureNavigation)
            {
                image.ImageUrl = image.ImageUrl.Replace("\\", "/");
            }
            return View(product);
        }

    }
}