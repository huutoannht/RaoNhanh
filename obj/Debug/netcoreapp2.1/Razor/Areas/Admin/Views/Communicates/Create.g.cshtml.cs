#pragma checksum "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcba29be0d9f317ee272052c553135cc0d872153"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Communicates_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Communicates/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Communicates/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_Communicates_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcba29be0d9f317ee272052c553135cc0d872153", @"/Areas/Admin/Views/Communicates/Create.cshtml")]
    public class Areas_Admin_Views_Communicates_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetCore.Models.EntitiesFramework.Communicate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/phuoc.com.vn/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(153, 21, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
            BeginContext(210, 23, false);
#line 12 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(241, 89, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Communicate</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(331, 64, false);
#line 17 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(395, 48, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(444, 95, false);
#line 19 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
       Write(Html.LabelFor(model => model.SiteId, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(539, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(595, 95, false);
#line 21 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
           Write(Html.EditorFor(model => model.SiteId, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(690, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(709, 84, false);
#line 22 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.SiteId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(793, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(880, 93, false);
#line 27 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
       Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(973, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1029, 93, false);
#line 29 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1141, 82, false);
#line 30 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1310, 94, false);
#line 35 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
       Write(Html.LabelFor(model => model.Phone, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1460, 94, false);
#line 37 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
           Write(Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1573, 83, false);
#line 38 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1656, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1743, 96, false);
#line 43 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
       Write(Html.LabelFor(model => model.Message, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1839, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1895, 96, false);
#line 45 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
           Write(Html.EditorFor(model => model.Message, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1991, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2010, 85, false);
#line 46 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Message, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2095, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2182, 94, false);
#line 51 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2276, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2332, 94, false);
#line 53 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2426, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2445, 83, false);
#line 54 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2528, 255, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 64 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
}

#line default
#line hidden
            BeginContext(2786, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2800, 40, false);
#line 67 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Communicates\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2840, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCore.Models.EntitiesFramework.Communicate> Html { get; private set; }
    }
}
#pragma warning restore 1591