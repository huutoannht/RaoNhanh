using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCore.Models.EntitiesFramework;
using Microsoft.EntityFrameworkCore;

namespace NetCore.Controllers
{
    [CheckSite]
    public class PriceController : Controller
    {
        private readonly ProductContext _context;

        public PriceController(ProductContext context)
        {
            _context = context;
        }
        // GET: Connect
        string urlSite = "~/Views/satmanhcuong.com/Price";
        public async Task<ActionResult> Index()
        {
            urlSite = "~/Views/" + ViewBag.SiteId + "/Price";
            string siteId = ViewBag.SiteId;
            Contact contact = await _context.Contact.FirstOrDefaultAsync();
            if (contact==null)
            {
                contact = new Contact();
            }
            return View(urlSite + "/Index.cshtml", contact);
        }
    }
}