#pragma checksum "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ed0171eb79fc4a33091b57985330896d0555553"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Products/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Products_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ed0171eb79fc4a33091b57985330896d0555553", @"/Areas/Admin/Views/Products/Details.cshtml")]
    public class Areas_Admin_Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetCore.Models.EntitiesFramework.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(142, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(264, 40, false);
#line 15 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(304, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(350, 36, false);
#line 19 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(386, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(432, 52, false);
#line 23 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShortDescription));

#line default
#line hidden
            EndContext();
            BeginContext(484, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(530, 48, false);
#line 27 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShortDescription));

#line default
#line hidden
            EndContext();
            BeginContext(578, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(624, 51, false);
#line 31 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FullDescription));

#line default
#line hidden
            EndContext();
            BeginContext(675, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(721, 47, false);
#line 35 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.FullDescription));

#line default
#line hidden
            EndContext();
            BeginContext(768, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(814, 50, false);
#line 39 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShowOnHomePage));

#line default
#line hidden
            EndContext();
            BeginContext(864, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(910, 46, false);
#line 43 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShowOnHomePage));

#line default
#line hidden
            EndContext();
            BeginContext(956, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1002, 48, false);
#line 47 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MetaKeywords));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1096, 44, false);
#line 51 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.MetaKeywords));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1186, 51, false);
#line 55 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MetaDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1283, 47, false);
#line 59 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.MetaDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1376, 41, false);
#line 63 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1417, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1463, 37, false);
#line 67 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1546, 44, false);
#line 71 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OldPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1636, 40, false);
#line 75 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.OldPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1722, 48, false);
#line 79 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DisplayOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1770, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1816, 44, false);
#line 83 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.DisplayOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1860, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1906, 47, false);
#line 87 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsPublished));

#line default
#line hidden
            EndContext();
            BeginContext(1953, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1999, 43, false);
#line 91 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsPublished));

#line default
#line hidden
            EndContext();
            BeginContext(2042, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2088, 45, false);
#line 95 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(2133, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2179, 41, false);
#line 99 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(2220, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2266, 48, false);
#line 103 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOnUtc));

#line default
#line hidden
            EndContext();
            BeginContext(2314, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2360, 44, false);
#line 107 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedOnUtc));

#line default
#line hidden
            EndContext();
            BeginContext(2404, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2450, 48, false);
#line 111 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedOnUtc));

#line default
#line hidden
            EndContext();
            BeginContext(2498, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2544, 44, false);
#line 115 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedOnUtc));

#line default
#line hidden
            EndContext();
            BeginContext(2588, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2634, 42, false);
#line 119 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SiteId));

#line default
#line hidden
            EndContext();
            BeginContext(2676, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2722, 38, false);
#line 123 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.SiteId));

#line default
#line hidden
            EndContext();
            BeginContext(2760, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2806, 49, false);
#line 127 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2855, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2901, 45, false);
#line 131 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2946, 47, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(2994, 61, false);
#line 137 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(3055, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3064, 40, false);
#line 138 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(3104, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCore.Models.EntitiesFramework.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
