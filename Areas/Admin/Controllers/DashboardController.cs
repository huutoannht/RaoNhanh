using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetCore.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetCore.Areas.Admin.Controllers
{
   // [Authorize]
    [CheckSite]
    [Area("Admin")]
    public class DashboardController : Controller
    {
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}