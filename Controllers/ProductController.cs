using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetCore.Models.Common;
using NetCore.Models.EntitiesFramework;
using NetCore.Models.ViewModel;

namespace NetCore.Controllers
{
    [CheckSite]
    public class ProductController : Controller
    {
        private readonly ProductContext _context;
        private readonly IMapper _mapper;
        private readonly IHostingEnvironment _environment;

        public ProductController(ProductContext context,
            IMapper mapper,
            IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _mapper = mapper;
            _environment = hostingEnvironment;
        }
        // GET: Product
        public async Task<ActionResult> GetById(string id)
        {
            var product = await _context.Product.Include(p => p.Category).Include(p => p.PictureNavigation).Where(p => !p.IsDeleted && p.ProductAlias == id).FirstOrDefaultAsync();
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
        public async Task<ActionResult> Create()
        {
            //  ViewBag.CategoryId = new SelectList(_context.Category.Where(m => !m.IsDeleted), "CategoryId", "Name");
            var itemCategory = _context.PostingCategory.Include(m => m.Category).Where(m => !m.IsDeleted).ToListAsync();
            var postingCategory = _context.ItemCategory.Include(m => m.Category).Where(m => !m.IsDeleted).ToListAsync();
            await Task.WhenAll(itemCategory, postingCategory);

            ViewBag.PostingCategoryId = itemCategory.Result;
            ViewBag.ItemCategoryId = postingCategory.Result;
            ViewBag.Provice = new SelectList(_context.CoreStateOrProvince, "Id", "Name");
            return View();
        }
        [HttpPost, NetCore.Controllers.ParameterBasedOnFormName("save-continue", "continueEditing")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProductDTO product,
           IFormFile fileUpload, bool continueEditing)
        {
            if (ModelState.IsValid)
            {
                product.CreatedOnUtc = DateTime.UtcNow;
                product.UpdatedOnUtc = DateTime.UtcNow;

                var model = _mapper.Map<Product>(product);
                if (fileUpload != null && fileUpload.Length > 0)
                {
                    var path = Path.Combine(_environment.WebRootPath, Constants.LocaltionFile);
                    var image = FileExtensions.Upload(fileUpload, path);
                    model.Picture = image;
                }
                model.ProductAlias = product.Name?.ToFriendlyUrl() + "_" + FileExtensions.GetUniqueKey(5);

                TempData["Message"] = "create";
                //Get ID address
                var address = new Address()
                {
                    CountryId = Constants.COUNTRY_VN,
                    ProviceId = product.Provice,
                    DistrictId = product.District,
                    NameAddress = product.NameAddress
                };
                model.AddressId = await this.SaveAddress(address);

                _context.Product.Add(model);
                await _context.SaveChangesAsync();

                if (continueEditing)
                {
                    return RedirectToAction("Create");
                }
                return Redirect("/Home");
            }

            // ViewBag.CategoryId = new SelectList(_context.Category.Where(m => !m.IsDeleted), "CategoryId", "Name");
            ViewBag.PostingCategoryId = new SelectList(_context.PostingCategory.Include(m => m.Category).Where(m => !m.IsDeleted), "Id", "NamePostingCategory");
            ViewBag.ItemCategoryId = await _context.ItemCategory.Include(m => m.Category).Where(m => !m.IsDeleted).ToListAsync();
            ViewBag.Provice = new SelectList(_context.CoreStateOrProvince, "Id", "Name");

            return View(product);
        }
        public async Task<int> SaveAddress(Address address)
        {
            var model = await _context.Address.Where(m => m.NameAddress == address.NameAddress &&
                                                 m.ProviceId == address.ProviceId &&
                                                 m.DistrictId == address.DistrictId).FirstOrDefaultAsync();
            if (model != null)
            {
                return model.Id;
            }
            else
            {
                await _context.Address.AddAsync(address);
                await _context.SaveChangesAsync();
                return address.Id;
            }

        }
        public async Task<JsonResult> GetDistrict(int? id)
        {
            if (id != 0)
            {
                return new JsonResult(await _context.CoreDistrict.Where(m => m.StateOrProvince.Id == id).ToListAsync());
            }
            return null;
        }
        public async Task<ActionResult> Compare(string id)
        {
            string siteId = ViewBag.SiteId;
            var product = await _context.Product.Include(p => p.Category).Include(p => p.PictureNavigation).Where(p => !p.IsDeleted && p.ProductAlias == id).FirstOrDefaultAsync();
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