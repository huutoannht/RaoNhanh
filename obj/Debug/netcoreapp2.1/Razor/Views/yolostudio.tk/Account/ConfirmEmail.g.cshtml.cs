#pragma checksum "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\yolostudio.tk\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b914cccd9f9d2ff588f7f3c37e1cb4bc76c75e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_yolostudio_tk_Account_ConfirmEmail), @"mvc.1.0.view", @"/Views/yolostudio.tk/Account/ConfirmEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/yolostudio.tk/Account/ConfirmEmail.cshtml", typeof(AspNetCore.Views_yolostudio_tk_Account_ConfirmEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b914cccd9f9d2ff588f7f3c37e1cb4bc76c75e", @"/Views/yolostudio.tk/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63ef6bc4202829255d5abf999b026723ebddf88a", @"/Views/_ViewImports.cshtml")]
    public class Views_yolostudio_tk_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\yolostudio.tk\Account\ConfirmEmail.cshtml"
  
    ViewBag.Title = "Confirm Email";

#line default
#line hidden
            BeginContext(45, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(52, 13, false);
#line 5 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\yolostudio.tk\Account\ConfirmEmail.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(65, 76, true);
            WriteLiteral(".</h2>\r\n<div>\r\n    <p>\r\n        Thank you for confirming your email. Please ");
            EndContext();
            BeginContext(142, 120, false);
#line 8 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\yolostudio.tk\Account\ConfirmEmail.cshtml"
                                               Write(Html.ActionLink("Click here to Log in", "Login", "Account", routeValues: null, htmlAttributes: new { id = "loginLink" }));

#line default
#line hidden
            EndContext();
            BeginContext(262, 20, true);
            WriteLiteral("\r\n    </p>\r\n</div>\r\n");
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
