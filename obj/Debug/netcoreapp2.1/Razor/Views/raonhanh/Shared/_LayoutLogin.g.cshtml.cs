#pragma checksum "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Shared\_LayoutLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "998a5ad764616bdbf231dd8ddd651f50bc84fe83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_raonhanh_Shared__LayoutLogin), @"mvc.1.0.view", @"/Views/raonhanh/Shared/_LayoutLogin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/raonhanh/Shared/_LayoutLogin.cshtml", typeof(AspNetCore.Views_raonhanh_Shared__LayoutLogin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"998a5ad764616bdbf231dd8ddd651f50bc84fe83", @"/Views/raonhanh/Shared/_LayoutLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63ef6bc4202829255d5abf999b026723ebddf88a", @"/Views/_ViewImports.cshtml")]
    public class Views_raonhanh_Shared__LayoutLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Shared\_LayoutLogin.cshtml"
  
    ViewBag.Title = "Log in";
    Layout = null;

#line default
#line hidden
            BeginContext(60, 191, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n<!-- Mirrored from hencework.com/theme/jetson/full-width-light/signup.html by HTTrack Website Copier/3.x [XR&CO\'2014], Sat, 04 Nov 2017 05:06:17 GMT -->\r\n");
            EndContext();
            BeginContext(251, 1202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f793dffba640498de51f88e1f62f32", async() => {
                BeginContext(257, 780, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"" />
    <title>Jetson I Fast build Admin dashboard for any platform</title>
    <meta name=""description"" content=""Jetson is a Dashboard & Admin Site Responsive Template by hencework."" />
    <meta name=""keywords"" content=""admin, admin dashboard, admin template, cms, crm, Jetson Admin, Jetsonadmin, premium admin templates, responsive admin, sass, panel, software, ui, visualization, web app, application"" />
    <meta name=""author"" content=""hencework"" />

    <!-- Favicon -->
    <link rel=""shortcut icon"" href=""favicon.ico"">
    <link rel=""icon"" href=""favicon.ico"" type=""image/x-icon"">

    <!-- vector map CSS -->
    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1037, "\"", 1148, 1);
#line 23 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Shared\_LayoutLogin.cshtml"
WriteAttributeValue("", 1044, Url.Content("~/Content/dist/vendors/bower_components/jasny-bootstrap/dist/css/jasny-bootstrap.min.css"), 1044, 104, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1149, 64, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1213, "\"", 1332, 1);
#line 24 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Shared\_LayoutLogin.cshtml"
WriteAttributeValue("", 1220, Url.Content("~/Content/dist/vendors/bower_components/bootstrap3-wysihtml5-bower/dist/bootstrap3-wysihtml5.css"), 1220, 112, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1333, 39, true);
                WriteLiteral(" />\r\n    <!-- Custom CSS -->\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1372, "\"", 1423, 1);
#line 26 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Shared\_LayoutLogin.cshtml"
WriteAttributeValue("", 1379, Url.Content("~/Content/dist/css/style.css"), 1379, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1424, 22, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n");
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
            BeginContext(1453, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1455, 862, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d6b8abd585048e38e72d6f95f0b0159", async() => {
                BeginContext(1461, 134, true);
                WriteLiteral("\r\n    <!--Preloader-->\r\n    <div class=\"preloader-it\">\r\n        <div class=\"la-anim-1\"></div>\r\n    </div>\r\n    <!--/Preloader-->\r\n    ");
                EndContext();
                BeginContext(1596, 12, false);
#line 34 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Shared\_LayoutLogin.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1608, 83, true);
                WriteLiteral("\r\n    <!-- /#wrapper -->\r\n    <!-- JavaScript -->\r\n    <!-- jQuery -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1691, "\"", 1778, 1);
#line 38 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Shared\_LayoutLogin.cshtml"
WriteAttributeValue("", 1697, Url.Content("~/Content/dist/vendors/bower_components/jquery/dist/jquery.min.js"), 1697, 81, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1779, 65, true);
                WriteLiteral("></script>\r\n\r\n    <!-- Bootstrap Core JavaScript -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1844, "\"", 1940, 1);
#line 41 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Shared\_LayoutLogin.cshtml"
WriteAttributeValue("", 1850, Url.Content("~/Content/dist/vendors/bower_components/bootstrap/dist/js/bootstrap.min.js"), 1850, 90, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1941, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1964, "\"", 2072, 1);
#line 42 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Shared\_LayoutLogin.cshtml"
WriteAttributeValue("", 1970, Url.Content("~/Content/dist/vendors/bower_components/jasny-bootstrap/dist/js/jasny-bootstrap.min.js"), 1970, 102, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2073, 61, true);
                WriteLiteral("></script>\r\n\r\n    <!-- Slimscroll JavaScript -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2134, "\"", 2194, 1);
#line 45 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Shared\_LayoutLogin.cshtml"
WriteAttributeValue("", 2140, Url.Content("~/Content/dist/js/jquery.slimscroll.js"), 2140, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2195, 55, true);
                WriteLiteral("></script>\r\n\r\n    <!-- Init JavaScript -->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2250, "\"", 2297, 1);
#line 48 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Shared\_LayoutLogin.cshtml"
WriteAttributeValue("", 2256, Url.Content("~/Content/dist/js/init.js"), 2256, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2298, 12, true);
                WriteLiteral("></script>\r\n");
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
            BeginContext(2317, 167, true);
            WriteLiteral("\r\n\r\n<!-- Mirrored from hencework.com/theme/jetson/full-width-light/signup.html by HTTrack Website Copier/3.x [XR&CO\'2014], Sat, 04 Nov 2017 05:06:17 GMT -->\r\n</html>\r\n");
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
