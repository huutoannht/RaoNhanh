#pragma checksum "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40855653446472292ba2b27bab72b4ec1cbd8a18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Pictures_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Pictures/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Pictures/Create.cshtml", typeof(AspNetCore.Areas_Admin_Views_Pictures_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40855653446472292ba2b27bab72b4ec1cbd8a18", @"/Areas/Admin/Views/Pictures/Create.cshtml")]
    public class Areas_Admin_Views_Pictures_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NetCore.Models.PictureDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\Create.cshtml"
  
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(139, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\Create.cshtml"
 using (Html.BeginForm(
   null, null, FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
            BeginContext(249, 23, false);
#line 11 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(276, 58, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Sản phẩm : ");
            EndContext();
            BeginContext(335, 19, false);
#line 14 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\Create.cshtml"
                  Write(ViewBag.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(354, 32, true);
            WriteLiteral(" </h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(387, 64, false);
#line 16 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(451, 47, true);
            WriteLiteral("\r\n        <input type=\"hidden\" name=\"ProductId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 498, "\"", 524, 1);
#line 17 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\Create.cshtml"
WriteAttributeValue("", 506, ViewBag.ProductId, 506, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(525, 504, true);
            WriteLiteral(@" />
        <div class=""form-group"">
            <label class=""control-label"" for=""image-create"">Ảnh</label>
            <div class=""file-loading"">
                <input id=""image-update"" name=""filePicture"" type=""file"" multiple class=""file"" data-overwrite-initial=""false"">
            </div>
        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Cập nhật"" class=""btn btn-success"" />
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1029, "\"", 1068, 1);
#line 28 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\Create.cshtml"
WriteAttributeValue("", 1036, Url.Content("~/Admin/Products"), 1036, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1069, 87, true);
            WriteLiteral(" class=\"btn btn-default\">Quay lại</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 32 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\Create.cshtml"
}

#line default
#line hidden
            BeginContext(1159, 47, true);
            WriteLiteral("\r\n<script>\r\n    var existedProductAlbumFiles = ");
            EndContext();
            BeginContext(1207, 31, false);
#line 35 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\Create.cshtml"
                              Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 3, true);
            WriteLiteral(";\r\n");
            EndContext();
#line 36 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Pictures\Create.cshtml"
      
        var listPicture = (List<NetCore.Models.PictureDTO>)@Model;
        var arProductAlbums = listPicture.Select(m => m.ImageUrl);

    

#line default
#line hidden
            BeginContext(1394, 1005, true);
            WriteLiteral(@"    if (existedProductAlbumFiles == null || existedProductAlbumFiles.length === 0) {
        $(""#image-update"").fileinput({
            uploadUrl: '/file-upload-batch/2',
            maxFilePreviewSize: 10240,
            overwriteInitial: false,
            showUpload: false
        });
    }
    else {
        var fileUrls = [];
        var fileInputs = [];
        $.each(existedProductAlbumFiles, function (index, album) {
            fileUrls.push(album.imageUrl);
            fileInputs.push({
                url: ""/Admin/Pictures/Delete/"" + album.productId + """",
                key: album.pictureId
            });

        })
        $(""#image-update"").fileinput({
            uploadUrl: ""/file-upload-batch/1"",
            uploadAsync: false,
            maxFileCount: 50,
            overwriteInitial: false,
            initialPreviewAsData: true,
            initialPreview:  fileUrls,
            initialPreviewConfig: fileInputs
        });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NetCore.Models.PictureDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
