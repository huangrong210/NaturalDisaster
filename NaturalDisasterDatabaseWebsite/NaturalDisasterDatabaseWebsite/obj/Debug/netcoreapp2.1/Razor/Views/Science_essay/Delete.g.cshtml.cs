#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2df32fc46fc3454ac1abbaaf7863b372df4b52ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Science_essay_Delete), @"mvc.1.0.view", @"/Views/Science_essay/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Science_essay/Delete.cshtml", typeof(AspNetCore.Views_Science_essay_Delete))]
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
#line 1 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\_ViewImports.cshtml"
using NaturalDisasterDatabaseWebsite;

#line default
#line hidden
#line 2 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\_ViewImports.cshtml"
using NaturalDisasterDatabaseWebsite.Models;

#line default
#line hidden
#line 5 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\_ViewImports.cshtml"
using NaturalDisasterDatabaseWebsite.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2df32fc46fc3454ac1abbaaf7863b372df4b52ad", @"/Views/Science_essay/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_Science_essay_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NaturalDisasterDatabaseWebsite.Models.Science_essayViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline-block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("back"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Delete.cshtml"
  
    Layout = "_BackLayout";
    ViewData["Title"] = "删除文章";

#line default
#line hidden
            BeginContext(140, 989, true);
            WriteLiteral(@"<style>
    p {
        padding-top: 20px;
        font-size: 16px;
    }
    p strong{
        display:inline-block;
        margin:0 10px;
    }
    dt, dd {
        margin-bottom: 8px;
    }
    dt::after {
        content: ""：""
    }
    .content_title {
        text-align: center;
        font-weight: 700;
        padding-top: 0px;
    }
    .content_source {
        text-align: center;
        color: #7E8489;
        margin-bottom:12px;
    }
    .content_source .span, .content_nav .span {
        display: inline-block;
        margin-right: 2em;
    }
    .content_txt {
        /*padding: 15px 0 50px 0;*/
        line-height: 30px;
    }
    #imgCent {
        margin: 0 auto;
        text-align: center;
        width: 300px;
        height: auto;
    }
    #imgCent img {
        width: 300px;
        height: auto;
    }
    .back {
        margin-top: 20px;
        font-size: 16px;
        float: right;
    }
</style>

");
            EndContext();
            BeginContext(1150, 79, true);
            WriteLiteral("\r\n<p style=\"display:inline-block; margin-right:18px;\">\r\n    你确定要删除该篇由用户<strong>");
            EndContext();
            BeginContext(1230, 45, false);
#line 60 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Delete.cshtml"
                  Write(Html.DisplayFor(model => model.user.username));

#line default
#line hidden
            EndContext();
            BeginContext(1275, 23, true);
            WriteLiteral("</strong>所发布的属于<strong>");
            EndContext();
            BeginContext(1299, 40, false);
#line 60 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Delete.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.wz_style));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 25, true);
            WriteLiteral("</strong>类型，当前状态为<strong>");
            EndContext();
            BeginContext(1365, 37, false);
#line 60 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Delete.cshtml"
                                                                                                                                                         Write(Html.DisplayFor(model => model.state));

#line default
#line hidden
            EndContext();
            BeginContext(1402, 22, true);
            WriteLiteral("</strong>的文章吗?\r\n</p>\r\n");
            EndContext();
            BeginContext(1424, 171, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea4156e4551946c98f7e1edeb01573a6", async() => {
                BeginContext(1480, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1486, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "611ce0c26f2045a3b0a68a619d0a7f7e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 63 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1522, 66, true);
                WriteLiteral("\r\n    <input type=\"submit\" value=\"删除\" class=\"btn btn-default\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1595, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1597, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57343c27a9b74f84ae4992a81958f203", async() => {
                BeginContext(1632, 8, true);
                WriteLiteral("返回文章管理列表");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1644, 9, true);
            WriteLiteral("\r\n<div>\r\n");
            EndContext();
            BeginContext(1694, 41, true);
            WriteLiteral("    <hr />\r\n    <p class=\"content_title\">");
            EndContext();
            BeginContext(1736, 37, false);
#line 70 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Delete.cshtml"
                        Write(Html.DisplayFor(model => model.title));

#line default
#line hidden
            EndContext();
            BeginContext(1773, 72, true);
            WriteLiteral("</p>\r\n    <div class=\"content_source\">\r\n        <span class=\"span\">发布时间：");
            EndContext();
            BeginContext(1846, 39, false);
#line 72 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Delete.cshtml"
                           Write(Html.DisplayFor(model => model.fb_time));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 39, true);
            WriteLiteral("</span>\r\n        <span class=\"span\">来源：");
            EndContext();
            BeginContext(1925, 38, false);
#line 73 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Delete.cshtml"
                         Write(Html.DisplayFor(model => model.source));

#line default
#line hidden
            EndContext();
            BeginContext(1963, 26, true);
            WriteLiteral("</span>\r\n        <span>作者：");
            EndContext();
            BeginContext(1990, 38, false);
#line 74 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Delete.cshtml"
            Write(Html.DisplayFor(model => model.author));

#line default
#line hidden
            EndContext();
            BeginContext(2028, 79, true);
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"content_txt\">\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(2108, 60, false);
#line 78 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Delete.cshtml"
       Write(Html.Raw(System.Net.WebUtility.UrlDecode(@Model.wz_content)));

#line default
#line hidden
            EndContext();
            BeginContext(2168, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2231, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
            BeginContext(2396, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
            BeginContext(2452, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NaturalDisasterDatabaseWebsite.Models.Science_essayViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
