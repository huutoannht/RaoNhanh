#pragma checksum "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "659783da43ee68212eaa594bd817685570fae2ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Pictures_EditSlide), @"mvc.1.0.view", @"/Areas/Admin/Views/Pictures/EditSlide.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Pictures/EditSlide.cshtml", typeof(AspNetCore.Areas_Admin_Views_Pictures_EditSlide))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"659783da43ee68212eaa594bd817685570fae2ba", @"/Areas/Admin/Views/Pictures/EditSlide.cshtml")]
    public class Areas_Admin_Views_Pictures_EditSlide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetCore.Models.EntitiesFramework.Picture>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
  
    ViewBag.Title = "AddSlide";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
 using (Html.BeginForm(
                            null, null, FormMethod.Post, new { enctype = "multipart/form-data" }))

{
    

#line default
#line hidden
            BeginContext(280, 23, false);
#line 12 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(307, 97, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Chỉnh sửa ảnh slide</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(405, 64, false);
#line 17 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(469, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(480, 40, false);
#line 18 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
   Write(Html.HiddenFor(model => model.PictureId));

#line default
#line hidden
            EndContext();
            BeginContext(520, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(531, 42, false);
#line 19 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
   Write(Html.HiddenFor(model => model.TypePicture));

#line default
#line hidden
            EndContext();
            BeginContext(573, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(584, 43, false);
#line 20 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
   Write(Html.HiddenFor(model => model.CreatedOnUtc));

#line default
#line hidden
            EndContext();
            BeginContext(627, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(638, 39, false);
#line 21 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
   Write(Html.HiddenFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(677, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(688, 41, false);
#line 22 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
   Write(Html.HiddenFor(model => model.ImageAlias));

#line default
#line hidden
            EndContext();
            BeginContext(729, 312, true);
            WriteLiteral(@"
        <div class=""form-group"">

            <label class=""control-label col-md-2"" for=""Price"">Ảnh</label>
            <div class=""col-md-5"">
                <input type=""file"" class=""dropify"" name=""filePicture"" data-height=""300"" data-max-file-size-preview=""3M"" data-max-file-size=""3M"" data-default-file=""");
            EndContext();
            BeginContext(1042, 14, false);
#line 27 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
                                                                                                                                                              Write(Model.ImageUrl);

#line default
#line hidden
            EndContext();
            BeginContext(1056, 226, true);
            WriteLiteral("\" />\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\" for=\"ShortDecription\">Dòng hiển thị 1</label>\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1283, 104, false);
#line 33 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
           Write(Html.EditorFor(model => model.ShortDecription, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 268, true);
            WriteLiteral(@"
            </div>
        </div>

        <div class=""form-group"">
            <label class=""control-label col-md-2"" for=""Description"">Dòng hiển thị 2</label>
            <div class=""col-md-10"">
                <textarea name=""Description"" class=""summernote"">");
            EndContext();
            BeginContext(1656, 17, false);
#line 40 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
                                                           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1673, 232, true);
            WriteLiteral("</textarea>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-2\" for=\"DisplayOrder\">Thứ tự hiển thị</label>\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1906, 101, false);
#line 47 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
           Write(Html.EditorFor(model => model.DisplayOrder, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2007, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2026, 90, false);
#line 48 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
           Write(Html.ValidationMessageFor(model => model.DisplayOrder, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2116, 291, true);
            WriteLiteral(@"
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <div class=""col-md-offset-1 col-md-5"">
                    <input type=""submit"" value=""Cập nhật"" class=""btn btn-success"" />
                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2407, "\"", 2446, 1);
#line 56 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
WriteAttributeValue("", 2414, Url.Content("~/Admin/Pictures"), 2414, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2447, 111, true);
            WriteLiteral(" class=\"btn btn-default\">Quay lại</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 61 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\EditSlide.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCore.Models.EntitiesFramework.Picture> Html { get; private set; }
    }
}
#pragma warning restore 1591
