#pragma checksum "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b58b28544413c0b3c3da42fd4b1da080fc7dad32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\_ViewImports.cshtml"
using NetCore;

#line default
#line hidden
#line 3 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\_ViewImports.cshtml"
using NetCore.Models;

#line default
#line hidden
#line 4 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\_ViewImports.cshtml"
using NetCore.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\_ViewImports.cshtml"
using NetCore.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b58b28544413c0b3c3da42fd4b1da080fc7dad32", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63ef6bc4202829255d5abf999b026723ebddf88a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/raonhanh/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/raonhanh/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/raonhanh/img/dangtinmienphi.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post_info img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo_footer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(37, 1405, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7b509e62fce4f84a84bb91cd4ea51c8", async() => {
                BeginContext(43, 399, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Trang Chủ</title>
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.3.1/css/all.css"" integrity=""sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU"" crossorigin=""anonymous"">
    ");
                EndContext();
                BeginContext(442, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "683ca0e10eb54a98b7cc372783460810", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                BeginContext(507, 928, true);
                WriteLiteral(@"
    <!-- <script src=""homepage.js""></script> -->
    <!-- <link rel=""stylesheet"" href=""homepage.js""> -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.3.1.min.js""
            integrity=""sha256-FgpCb/KJQlLNfOu91ta32o/NMZxltwRo8QtmkMRdAu8=""
            crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1442, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1446, 7122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ab879699282459989bdcfed6fa57b5c", async() => {
                BeginContext(1452, 193, true);
                WriteLiteral("\r\n    <!-- menu nhỏ -->\r\n    <nav class=\"navbar navbar-expand-lg navbar-dark bg-dark\" style=\"background:#392F30!important;height: 35px;padding: 0px;\">\r\n        <a class=\"navbar-brand\" href=\"#\">");
                EndContext();
                BeginContext(1645, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc18ec290159469a8da3246bdf8ebe28", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1708, 2824, true);
                WriteLiteral(@"</a>
        <!-- <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
              <span class=""navbar-toggler-icon""></span>
                </button> -->

        <div class=""collapse navbar-collapse menuSmall"" id=""menuCon"">
            <ul class=""navbar-nav mr-auto hotline"">
                <li class=""nav-item"">
                    <a class=""nav-link active"" href=""#"">Đăng Nhập</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link active sohotline"" href=""#"">HOTLINE: 0989.888.888</a>
                </li>
            </ul>
        </div>
    </nav>

    <!-- end menu nhỏ -->
    <!-- menu lớn -->
    <nav class=""navbar navbar-expand-lg navbar-light bg-light"" style=""background-color:white!important;box-shadow: 0px 0px 5px grey;"">
        <button class=""navbar-toggler"" type=""button"" data-toggle=""co");
                WriteLiteral(@"llapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>
        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-sm-12"">
                        <ul class=""navbar-nav mr-auto"">
                            <div class=""col-sm-3"">
                                <li class=""nav-item active"">
                                    <a class=""nav-link home"" href=""index.html"">HOME<span class=""sr-only"">(current)</span></a>
                                </li>
                            </div>
                            <div class=""col-sm-6 danhmuc"" style=""display:flex;"">
                                <li class=""nav-item"">
                                    <a class=""nav-link active"" href=""gioithieu.html"">Giới Thiệu</a>
");
                WriteLiteral(@"                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link active"" href=""batdongsan.html"">Bất Động Sản</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link active"" href=""dichvuvieclam.html"">Dịch Vụ Việc Làm</a>
                                </li>
                                <li class=""nav-item"">
                                    <a class=""nav-link active"" href=""dichvuquangcao.html"">Dịch Vụ Quảng Cáo</a>
                                </li>
                            </div>
                            <div class=""col-sm-3 search"">
                                ");
                EndContext();
                BeginContext(4532, 365, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "238a8dfe720d467188d8595212247fa5", async() => {
                    BeginContext(4592, 298, true);
                    WriteLiteral(@"
                                    <input class=""form-control mr-sm-2"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                                    <button class=""btn btn-success my-2 my-sm-0"" type=""submit""><i class=""fas fa-search""></i></button>
                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4897, 428, true);
                WriteLiteral(@"
                            </div>
                        </ul>

                    </div>
                </div>
            </div>
        </div>
    </nav>
    <!-- end menuLon -->
    <!-- tin tức -->
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-3 sidebar_left"">
                <br>
                <a href=""dangtin.html"" id=""post_info"">
                    ");
                EndContext();
                BeginContext(5325, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0315d119a0dd42f5954c5ecf2e7533a1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5413, 2222, true);
                WriteLiteral(@"
                </a>
                <br>
                <br>
                <ul class=""list-group hide"">
                    <li class=""list-group-item card-header dm_left"">BẤT ĐỘNG SẢN</li>
                    <a href="""">
                        <li class=""list-group-item"">Cần Bán Nhà</li>
                    </a>
                    <a href="""">
                        <li class=""list-group-item"">Cần Bán Đất</li>
                    </a>
                    <a href="""">
                        <li class=""list-group-item"">Cần Mua Nhà</li>
                    </a>
                    <a href="""">
                        <li class=""list-group-item"">Cần Mua Đất</li>
                    </a>
                </ul>
                <br><br><br><br>
                <ul class=""list-group hide"">
                    <li class=""list-group-item card-header dm_left"">DỊCH VỤ VIỆC LÀM</li>
                    <a href="""">
                        <li class=""list-group-item"">Người Tìm Việc</li>
       ");
                WriteLiteral(@"             </a>
                    <a href="""">
                        <li class=""list-group-item"">Việc Tìm Người</li>
                    </a>
                </ul>
                <br><br><br><br>
                <ul class=""list-group hide"">
                    <li class=""list-group-item card-header dm_left"">DỊCH VỤ QUẢNG CÁO</li>
                    <a href="""">
                        <li class=""list-group-item"">Giới Thiệu Dịch Vụ</li>
                    </a>
                    <a href="""">
                        <li class=""list-group-item"">Giới Thiệu Công Ty</li>
                    </a>
                </ul>
                <br><br><br><br><br>
                <iframe class=""hide"" src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3834.95156422788!2d108.204689815956!3d16.016036702605938!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31421a26c7838505%3A0xd53d0e7a2b58bba3!2zMTE3IFBo4bqhbSBU4bupLCBLaHXDqsO1IFRydW5nLCBD4bqpbSBM4buHLCDEkMOgIE7hurVuZyA1NTAwMDAsIFZpZXRuYW0!5e0!");
                WriteLiteral("3m2!1sen!2s!4v1537519828206\"\r\n                        width=\"100%\" height=\"350\" frameborder=\"0\" style=\"border:0\" allowfullscreen></iframe>\r\n\r\n            </div>\r\n            ");
                EndContext();
                BeginContext(7636, 12, false);
#line 136 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(7648, 264, true);
                WriteLiteral(@"
            <!-- hết col-sm-9 -->
        </div>
    </div>
    <!-- hết tin tức -->
    <!-- footer -->
    <div class=""container-fluid"">
        <div class=""row _footer"">
            <div class=""col-sm-12 footer"">
                <div class=""col-sm-4"">");
                EndContext();
                BeginContext(7912, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d4b427cad41346a7b63f1a67fe951387", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7982, 579, true);
                WriteLiteral(@"</div>
                <div class=""col-sm-4 information"">
                    <div class=""info_detail"">
                        <p>Location:</p>
                        <p>Hotline:</p>
                        <p>Support:</p>
                        <p>Copy-right 2018 Design by web1s.net</p>
                    </div>
                </div>
                <div class=""col-sm-4"">

                </div>
            </div>
        </div>
    </div>
    <!-- hết footer -->
    <div class=""container-fluid"">
        <div class=""row _footer2""></div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8568, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
