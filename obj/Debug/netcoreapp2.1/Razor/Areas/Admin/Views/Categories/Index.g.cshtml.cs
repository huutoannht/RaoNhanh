#pragma checksum "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "354f870bfd28be6935c11281588ec032b57bbb14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Categories/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Categories_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"354f870bfd28be6935c11281588ec032b57bbb14", @"/Areas/Admin/Views/Categories/Index.cshtml")]
    public class Areas_Admin_Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NetCore.Models.EntitiesFramework.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Chỉnh sửa"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(154, 96, true);
            WriteLiteral("\r\n<div class=\"row heading-bg\">\r\n    <div class=\"col-lg-3 col-md-4 col-sm-4 col-xs-12\">\r\n        ");
            EndContext();
            BeginContext(251, 83, false);
#line 10 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
   Write(Html.ActionLink("Thêm mới ", "Create", new { }, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(334, 694, true);
            WriteLiteral(@"
    </div>
    <!-- Breadcrumb -->
    <div class=""col-lg-9 col-sm-8 col-md-8 col-xs-12"">
        <ol class=""breadcrumb"">
            <li><a href=""#"">Trang chủ</a></li>
            <li class=""active""><span>Loại sản phẩm</span></li>
        </ol>
    </div>
    <!-- /Breadcrumb -->
</div>
<div class=""col-sm-12"">
    <div class=""panel panel-default card-view"">
        <div class=""panel-heading"">
            <div class=""pull-left"">
                <h6 class=""panel-title txt-dark""> Danh sách loại sản phẩm</h6>
            </div>
            <div class=""clearfix""></div>
        </div>
        <div class=""panel-wrapper collapse in"">
            <div class=""panel-body"">
");
            EndContext();
#line 31 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
                 if (Model.Count() == 0)
                {

#line default
#line hidden
            BeginContext(1089, 307, true);
            WriteLiteral(@"                    <div class=""alert alert-success alert-dismissable alert-style-1"">
                        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">×</button>
                        <i class=""zmdi zmdi-check""></i>Loại sản phẩm chưa tạo.
                    </div>
");
            EndContext();
#line 37 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1456, 1194, true);
            WriteLiteral(@"                    <div class=""table-wrap"">
                        <div class=""table-responsive"">
                            <table class=""table table-hover table-bordered mb-0 data-table"">
                                <thead>
                                    <tr>
                                        <th>
                                            Tên
                                        </th>
                                        <th>
                                            Ảnh
                                        </th>
                                        <th>
                                            Mô tả
                                        </th>
                                        <th>
                                            Thời gian tạo
                                        </th>
                                        <th>
                                            Trạng thái
                                        </th>
                ");
            WriteLiteral("                        <th>Hành động</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
            EndContext();
#line 64 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(2755, 144, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2900, 39, false);
#line 68 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2939, 187, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                <img style=\"height:50px; width:50px\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3126, "\"", 3145, 1);
#line 71 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
WriteAttributeValue("", 3132, item.Picture, 3132, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3146, 154, true);
            WriteLiteral(" />\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3301, 46, false);
#line 74 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3347, 160, true);
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                            <td>\r\n                                                <span> ");
            EndContext();
            BeginContext(3508, 46, false);
#line 78 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
                                                  Write(item.CreatedOnUtc.ToString("dd/MM/yyyy hh:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(3554, 110, true);
            WriteLiteral("</span>\r\n                                            </td>\r\n                                            <td>\r\n");
            EndContext();
#line 81 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
                                                 if (!item.IsDeleted)
                                                {

#line default
#line hidden
            BeginContext(3786, 103, true);
            WriteLiteral("                                                    <span class=\"label label-success\">chưa xóa</span>\r\n");
            EndContext();
#line 84 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(4045, 101, true);
            WriteLiteral("                                                    <span class=\"label label-warning\">đã xóa</span>\r\n");
            EndContext();
#line 88 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(4197, 149, true);
            WriteLiteral("                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4346, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e1affcb113f4bde8842a2b47e7dd470", async() => {
                BeginContext(4424, 29, true);
                WriteLiteral("<i class=\"fa  fa-pencil\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4355, "~/Admin/Categories/Edit/", 4355, 24, true);
#line 91 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
AddHtmlAttributeValue("", 4379, item.CategoryId, 4379, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4457, 52, true);
            WriteLiteral("\r\n                                                <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4509, "\"", 4573, 3);
            WriteAttributeValue("", 4519, "changeRecord(\'", 4519, 14, true);
#line 92 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
WriteAttributeValue("", 4533, item.CategoryId, 4533, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 4549, "\',\'Categories\',\'Delete\')", 4549, 24, true);
            EndWriteAttribute();
            BeginContext(4574, 175, true);
            WriteLiteral(" class=\"\" title=\"Thay đổi trạng thái\">| <i class=\"fa   fa-refresh\"></i></a>\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 95 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4788, 144, true);
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 102 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Areas\Admin\Views\Categories\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4951, 56, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NetCore.Models.EntitiesFramework.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
