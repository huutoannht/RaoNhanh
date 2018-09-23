#pragma checksum "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3f0b1cf355f502622dea33392157a7df206c9ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Products/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_Products_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3f0b1cf355f502622dea33392157a7df206c9ad", @"/Areas/Admin/Views/Products/Create.cshtml")]
    public class Areas_Admin_Views_Products_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetCore.Models.EntitiesFramework.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(141, 314, true);
            WriteLiteral(@"<div class=""row heading-bg"">
    <!-- Breadcrumb -->
    <div class="" col-xs-12"">
        <ol class=""breadcrumb"">
            <li><a href=""/Admin/Products""><span>Danh sách</span></a></li>
            <li class=""active""><span>Tạo mới</span></li>
        </ol>
    </div>
    <!-- /Breadcrumb -->
</div>

");
            EndContext();
#line 18 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
 using (Html.BeginForm(
                null, null, FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
            BeginContext(576, 23, false);
#line 21 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(607, 95, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Thêm mới sản phẩm</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(703, 64, false);
#line 26 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(767, 178, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\" for=\"CategoryId\">Loại sản phẩm</label>\r\n            <div class=\"col-md-5\">\r\n                ");
            EndContext();
            BeginContext(946, 86, false);
#line 30 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
           Write(Html.DropDownList("CategoryId", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1032, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1051, 88, false);
#line 31 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.CategoryId, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 215, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\" for=\"CategoryId\">Tên sản phẩm</label>\r\n            <div class=\"col-md-7\">\r\n                ");
            EndContext();
            BeginContext(1355, 93, false);
#line 38 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1448, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1467, 82, false);
#line 39 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 922, true);
            WriteLiteral(@"
            </div>
        </div>

        <div class=""form-group"">
            <label class=""control-label col-md-2"" for=""ShortDescription"">Mô tả ngắn</label>
            <div class=""col-md-10"">
                <textarea name=""ShortDescription"" class="""" rows=""4"" cols=""120""></textarea>
            </div>
        </div>

        <div class=""form-group"">
            <label class=""control-label col-md-2"" for=""FullDescription"">Mô tả</label>
            <div class=""col-md-10"">
                <textarea name=""FullDescription"" class=""summernote""></textarea>
            </div>
        </div>

        <div class=""form-group"">
            <label class=""control-label col-md-2"" for=""Price"">Ảnh</label>
            <div class=""col-md-5"">
                <input type=""file"" class=""dropify"" name=""filePicture"" data-height=""300"" data-max-file-size-preview=""3M""  data-max-file-size=""3M""  />
                ");
            EndContext();
            BeginContext(2472, 86, false);
#line 61 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Picture , "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2558, 201, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\" for=\"Price\">Giá</label>\r\n            <div class=\"col-md-5\">\r\n                ");
            EndContext();
            BeginContext(2760, 110, false);
#line 68 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
           Write(Html.EditorFor(model => model.Price, new { htmlAttributes = new { @class = "form-control", @type="number" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2870, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2889, 83, false);
#line 69 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2972, 207, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\" for=\"OldPrice\">Giá cũ</label>\r\n            <div class=\"col-md-5\">\r\n                ");
            EndContext();
            BeginContext(3180, 115, false);
#line 76 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
           Write(Html.EditorFor(model => model.OldPrice, new { htmlAttributes = new { @class = "form-control", @type = "number" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3295, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3314, 86, false);
#line 77 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.OldPrice, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3400, 206, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\" for=\"ShowOnHomePage\"></label>\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(3607, 90, false);
#line 83 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
           Write(Html.CheckBoxFor(model => model.ShowOnHomePage, new { @class = "", @checked = "checked" }));

#line default
#line hidden
            EndContext();
            BeginContext(3697, 73, true);
            WriteLiteral("<label for=\"ShowOnHomePage\">Hiển thị trang chủ?</label>\r\n                ");
            EndContext();
            BeginContext(3771, 92, false);
#line 84 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.ShowOnHomePage, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3863, 512, true);
            WriteLiteral(@"
            </div>
        </div>
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <div class=""col-md-offset-1 col-md-7"">
                    <button type=""submit"" class=""btn btn-space btn-success"" c><i class=""icon icon-left s7-diskette""></i>Thêm mới</button>
                    <button type=""submit"" class=""btn btn-space btn-success"" name=""save-continue""><i class=""icon icon-left s7-diskette""></i>Thêm mới và tiếp tục</button>
                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4375, "\"", 4414, 1);
#line 92 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
WriteAttributeValue("", 4382, Url.Content("~/Admin/Products"), 4382, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4415, 111, true);
            WriteLiteral(" class=\"btn btn-default\">Quay lại</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 97 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Products\Create.cshtml"
}

#line default
#line hidden
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