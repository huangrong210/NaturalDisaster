#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Forum_msg\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "234fac3f7ee61c668d25f58a3cadec89ca75e56d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_msg_Delete), @"mvc.1.0.view", @"/Views/Forum_msg/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forum_msg/Delete.cshtml", typeof(AspNetCore.Views_Forum_msg_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"234fac3f7ee61c668d25f58a3cadec89ca75e56d", @"/Views/Forum_msg/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_Forum_msg_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NaturalDisasterDatabaseWebsite.Models.Forum_msgViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Forum_msg\Delete.cshtml"
  
    Layout = "_BackLayout";
    ViewData["Title"] = "删除留言";

#line default
#line hidden
            BeginContext(136, 261, true);
            WriteLiteral(@"<style>
    p{
        padding-top:20px;
        font-size:16px;
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
</style>
");
            EndContext();
            BeginContext(418, 21, true);
            WriteLiteral("\r\n<p>你确定要删除用户<strong>");
            EndContext();
            BeginContext(440, 45, false);
#line 26 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Forum_msg\Delete.cshtml"
              Write(Html.DisplayFor(model => model.user.username));

#line default
#line hidden
            EndContext();
            BeginContext(485, 28, true);
            WriteLiteral("</strong>的此留言吗?</p>\r\n<div>\r\n");
            EndContext();
            BeginContext(550, 70, true);
            WriteLiteral("    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(621, 43, false);
#line 32 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Forum_msg\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.comment));

#line default
#line hidden
            EndContext();
            BeginContext(664, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(708, 39, false);
#line 35 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Forum_msg\Delete.cshtml"
       Write(Html.DisplayFor(model => model.comment));

#line default
#line hidden
            EndContext();
            BeginContext(747, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(791, 48, false);
#line 38 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Forum_msg\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.comment_time));

#line default
#line hidden
            EndContext();
            BeginContext(839, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(883, 44, false);
#line 41 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Forum_msg\Delete.cshtml"
       Write(Html.DisplayFor(model => model.comment_time));

#line default
#line hidden
            EndContext();
            BeginContext(927, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(1121, 54, true);
            WriteLiteral("        <dt style=\"margin-bottom: 0px;\">\r\n            ");
            EndContext();
            BeginContext(1176, 41, false);
#line 50 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Forum_msg\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.essay));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1261, 43, false);
#line 53 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Forum_msg\Delete.cshtml"
       Write(Html.DisplayFor(model => model.essay.title));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1342, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ac81e819a414f7990ad52e353bf117f", async() => {
                BeginContext(1368, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1378, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef2141a63f874f3087eb4161dffbfaa4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 58 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Forum_msg\Delete.cshtml"
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
                BeginContext(1414, 80, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"删除\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1494, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "287dbfa3676c4adaa46384635867d2fc", async() => {
                    BeginContext(1516, 8, true);
                    WriteLiteral("返回论坛管理列表");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1528, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1541, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NaturalDisasterDatabaseWebsite.Models.Forum_msgViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
