using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCore.Models.EntitiesFramework;
using Microsoft.EntityFrameworkCore;

namespace NetCore.Controllers
{
    [CheckSite]
    public class ConnectController : Controller
    {
        private readonly ProductContext _context;

        public ConnectController(ProductContext context)
        {
            _context = context;
        }
        // GET: Connect
        string urlSite = "~/Views/satmanhcuong.com/Connect";
        public async Task<ActionResult> Index()
        {
            urlSite = "~/Views/" + ViewBag.SiteId + "/Connect";
            string siteId = ViewBag.SiteId;
            Contact contact = await _context.Contact.Where(m => m.SiteId == siteId).FirstOrDefaultAsync();
            if (contact==null)
            {
                contact = new Contact();
            }
            return View(urlSite + "/Index.cshtml", contact);
        }
    }
}