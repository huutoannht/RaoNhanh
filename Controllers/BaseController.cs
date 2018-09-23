using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace NetCore.Controllers
{
    public class CheckSiteAttribute : ActionFilterAttribute
    {
        // GET: Base
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.Controller as Controller;
            if (controller == null) return;
            controller.ViewBag.SiteId = "raonhanh";
        }
    }
}