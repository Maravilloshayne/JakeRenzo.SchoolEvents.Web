#pragma checksum "C:\Users\Shayne Maravillo\source\repos\Jake.Calendar\JakeRenzo.Calander\JakeRenzo.Calander.Web\Areas\Manage\Views\SchoolEvents\Banner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a34a54773d1d2408a6bb12a814242748790cc19a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_SchoolEvents_Banner), @"mvc.1.0.view", @"/Areas/Manage/Views/SchoolEvents/Banner.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/SchoolEvents/Banner.cshtml", typeof(AspNetCore.Areas_Manage_Views_SchoolEvents_Banner))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34a54773d1d2408a6bb12a814242748790cc19a", @"/Areas/Manage/Views/SchoolEvents/Banner.cshtml")]
    public class Areas_Manage_Views_SchoolEvents_Banner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JakeRenzo.Calander.Web.Areas.Manage.ViewModels.BannerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:750px;max-height:300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/schoolevents/update-banner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Shayne Maravillo\source\repos\Jake.Calendar\JakeRenzo.Calander\JakeRenzo.Calander.Web\Areas\Manage\Views\SchoolEvents\Banner.cshtml"
  
    ViewData["Title"] = "Banner";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(160, 79, true);
            WriteLiteral("<h2>Thread Banner</h2>\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            EndContext();
            BeginContext(239, 750, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faec64a4d3e84fbc9077787db358dd26", async() => {
                BeginContext(334, 97, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"hidden\" name=\"SchoolEventId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 431, "\"", 459, 1);
#line 11 "C:\Users\Shayne Maravillo\source\repos\Jake.Calendar\JakeRenzo.Calander\JakeRenzo.Calander.Web\Areas\Manage\Views\SchoolEvents\Banner.cshtml"
WriteAttributeValue("", 439, Model.SchoolEventId, 439, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(460, 80, true);
                WriteLiteral(" />\r\n                <label for=\"Banner\">Banner:</label><br />\r\n                ");
                EndContext();
                BeginContext(540, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d65bbc3f7b244f4e85b0ab24e596dba6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 550, "~/schoolevents/", 550, 15, true);
#line 13 "C:\Users\Shayne Maravillo\source\repos\Jake.Calendar\JakeRenzo.Calander\JakeRenzo.Calander.Web\Areas\Manage\Views\SchoolEvents\Banner.cshtml"
AddHtmlAttributeValue("", 565, Model.SchoolEventId, 565, 20, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 585, "/banner.png", 585, 11, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(642, 102, true);
                WriteLiteral("</br></br>\r\n                <input type=\"file\" class=\"form-control\" name=\"banner\" />\r\n                ");
                EndContext();
                BeginContext(745, 24, false);
#line 15 "C:\Users\Shayne Maravillo\source\repos\Jake.Calendar\JakeRenzo.Calander\JakeRenzo.Calander.Web\Areas\Manage\Views\SchoolEvents\Banner.cshtml"
           Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(769, 213, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <div class=\"col-md-10\">\r\n                    <input type=\"submit\" value=\"Upload\" />\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(989, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JakeRenzo.Calander.Web.Areas.Manage.ViewModels.BannerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
