#pragma checksum "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Home\Slide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b558ad6906295010e8dc2aca57c97b93603788a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_raonhanh_Home_Slide), @"mvc.1.0.view", @"/Views/raonhanh/Home/Slide.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/raonhanh/Home/Slide.cshtml", typeof(AspNetCore.Views_raonhanh_Home_Slide))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b558ad6906295010e8dc2aca57c97b93603788a2", @"/Views/raonhanh/Home/Slide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63ef6bc4202829255d5abf999b026723ebddf88a", @"/Views/_ViewImports.cshtml")]
    public class Views_raonhanh_Home_Slide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NetCore.Models.EntitiesFramework.Picture>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/studio/js/jquery-3.2.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/studio/js/ribbon_slider.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/studio/js/jquery.event.swipe.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 329, true);
            WriteLiteral(@"<div class=""photobooth_ribbon_slider_wrapper"">
    <div class=""photobooth_ribbon_slider wait4load"" data-nav=""arrows"" data-autoplay=""no"" data-interval="""">
        <div class=""photobooth_ribbon_slide photobooth_ribbon_slide1 photobooth_preload_slide"" data-count=""1"" data-title="""" data-descr="""" data-ratio=""1.6"">
            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 384, "\"", 422, 1);
#line 5 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Home\Slide.cshtml"
WriteAttributeValue("", 390, Model.FirstOrDefault().ImageUrl, 390, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(423, 258, true);
            WriteLiteral(@" alt="""">
            <div class=""photobooth_ribbon_overlay""></div>
        </div>
        <div class=""photobooth_ribbon_slide photobooth_ribbon_slide2 photobooth_preload_slide"" data-count=""2"" data-title="""" data-descr="""" data-ratio=""1.6"">
            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 681, "\"", 758, 1);
#line 9 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Home\Slide.cshtml"
WriteAttributeValue("", 687, Model.Count()>=2? Model[1].ImageUrl: Model.FirstOrDefault().ImageUrl, 687, 71, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(759, 258, true);
            WriteLiteral(@" alt="""">
            <div class=""photobooth_ribbon_overlay""></div>
        </div>
        <div class=""photobooth_ribbon_slide photobooth_ribbon_slide3 photobooth_preload_slide"" data-count=""3"" data-title="""" data-descr="""" data-ratio=""1.6"">
            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1017, "\"", 1093, 1);
#line 13 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Home\Slide.cshtml"
WriteAttributeValue("", 1023, Model.Count()>=3? Model[2].ImageUrl:Model.FirstOrDefault().ImageUrl, 1023, 70, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1094, 258, true);
            WriteLiteral(@" alt="""">
            <div class=""photobooth_ribbon_overlay""></div>
        </div>
        <div class=""photobooth_ribbon_slide photobooth_ribbon_slide4 photobooth_preload_slide"" data-count=""4"" data-title="""" data-descr="""" data-ratio=""1.6"">
            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1352, "\"", 1428, 1);
#line 17 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Home\Slide.cshtml"
WriteAttributeValue("", 1358, Model.Count()>=4? Model[3].ImageUrl:Model.FirstOrDefault().ImageUrl, 1358, 70, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1429, 258, true);
            WriteLiteral(@" alt="""">
            <div class=""photobooth_ribbon_overlay""></div>
        </div>
        <div class=""photobooth_ribbon_slide photobooth_ribbon_slide5 photobooth_preload_slide"" data-count=""5"" data-title="""" data-descr="""" data-ratio=""1.6"">
            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1687, "\"", 1763, 1);
#line 21 "C:\Users\huuto\OneDrive\Desktop\SourceCode\TestBanhMy\RaoNhanh\Views\raonhanh\Home\Slide.cshtml"
WriteAttributeValue("", 1693, Model.Count()>=5? Model[4].ImageUrl:Model.FirstOrDefault().ImageUrl, 1693, 70, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1764, 514, true);
            WriteLiteral(@" alt="""">
            <div class=""photobooth_ribbon_overlay""></div>
        </div>

    </div>
    <div class=""photobooth_ribbon_title_wrapper"">
        <h2 class=""photobooth_ribbon_title"">&nbsp;</h2>
        <div class=""photobooth_ribbon_caption"">&nbsp;</div>
    </div>
    <a href=""javascript:void(0)"" class=""photobooth_ribbon_btn_prev""></a>
    <a href=""javascript:void(0)"" class=""photobooth_ribbon_btn_next""></a>
    <a href=""javascript:void(0)"" class=""photobooth_ribbon_btn_fullview""></a>
</div>
");
            EndContext();
            BeginContext(2278, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "80ce88b70a1340728e7999e061f70f0a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2341, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2343, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5310f9000e7e4857959389d8425c678f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2403, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2405, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08e15eb7c88141d7b3543e65e4f4e3e5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2470, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NetCore.Models.EntitiesFramework.Picture>> Html { get; private set; }
    }
}
#pragma warning restore 1591
