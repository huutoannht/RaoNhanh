#pragma checksum "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "659ecb0327c466cae601cdd9ca15a88b7b84ec4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contacts_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Contacts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Contacts/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Contacts_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"659ecb0327c466cae601cdd9ca15a88b7b84ec4b", @"/Areas/Admin/Views/Contacts/Details.cshtml")]
    public class Areas_Admin_Views_Contacts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetCore.Models.EntitiesFramework.Contact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(142, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Contact</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(264, 41, false);
#line 15 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(305, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(351, 37, false);
#line 19 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(388, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(434, 41, false);
#line 23 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(475, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(521, 37, false);
#line 27 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(558, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(604, 40, false);
#line 31 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(644, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(690, 36, false);
#line 35 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(726, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(772, 45, false);
#line 39 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Longitude));

#line default
#line hidden
            EndContext();
            BeginContext(817, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(863, 41, false);
#line 43 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Longitude));

#line default
#line hidden
            EndContext();
            BeginContext(904, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(950, 44, false);
#line 47 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Latitude));

#line default
#line hidden
            EndContext();
            BeginContext(994, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1040, 40, false);
#line 51 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Latitude));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1126, 42, false);
#line 55 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SiteId));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1214, 38, false);
#line 59 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
       Write(Html.DisplayFor(model => model.SiteId));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 47, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(1300, 61, false);
#line 65 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.ContactId }));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1370, 40, false);
#line 66 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Contacts\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCore.Models.EntitiesFramework.Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591