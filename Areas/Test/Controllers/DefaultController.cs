using Microsoft.AspNetCore.Mvc;

namespace NetCore.Areas.Test.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}