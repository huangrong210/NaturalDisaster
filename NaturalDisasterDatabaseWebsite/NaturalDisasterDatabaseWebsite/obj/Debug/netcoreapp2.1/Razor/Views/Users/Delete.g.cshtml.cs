#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fd62e061aba26b5b6b0b5ee22312efc4c339122"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Delete), @"mvc.1.0.view", @"/Views/Users/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Users/Delete.cshtml", typeof(AspNetCore.Views_Users_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd62e061aba26b5b6b0b5ee22312efc4c339122", @"/Views/Users/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("头像"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
  
    Layout = "_BackLayout";
    ViewData["Title"] = "删除用户";

#line default
#line hidden
            BeginContext(159, 896, true);
            WriteLiteral(@"<style>
    p {
        padding-top: 20px;
        font-size: 16px;
    }

    dt, dd {
        margin-bottom: 8px;
    }

        dt::after {
            content: ""：""
        }

    .icon {
        margin: 0 auto;
        text-align: center;
        border-radius: 50%;
        width: 100px;
        height: auto;
    }

        .icon img {
            border-radius: 50%;
            width: 100%;
            height: 100%;
            margin-bottom: 16px;
        }

    .dl {
        margin: 0 auto;
        text-align: center;
    }

    dt, dd {
        display: inline-block;
        width: 500px;
    }

    dt {
        text-align: right;
    }

    dd {
        text-align: left;
        vertical-align: middle;
    }

    .block {
        display: block;
    }

        .block::after {
            content: '';
        }
</style>
");
            EndContext();
            BeginContext(1074, 48, true);
            WriteLiteral("\r\n<p>你确定要删除该用户吗?</p>\r\n<span class=\"text-danger\">");
            EndContext();
            BeginContext(1123, 24, false);
#line 67 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
                     Write(ViewData["ErrorMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(1147, 60, true);
            WriteLiteral("</span>\r\n<div>\r\n    <hr />\r\n    <div class=\"icon\">\r\n        ");
            EndContext();
            BeginContext(1207, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "185639ff70944dc3bf2c747604113684", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1226, "~/upfiles/", 1226, 10, true);
#line 71 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
AddHtmlAttributeValue("", 1236, Html.DisplayFor(model => model.img), 1236, 36, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1276, 84, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"dl\">\r\n        <dl>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1361, 44, false);
#line 76 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.username));

#line default
#line hidden
            EndContext();
            BeginContext(1405, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1461, 40, false);
#line 79 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayFor(model => model.username));

#line default
#line hidden
            EndContext();
            BeginContext(1501, 92, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"block\"></dt>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1594, 44, false);
#line 83 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(1638, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1694, 40, false);
#line 86 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(1734, 92, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"block\"></dt>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1827, 41, false);
#line 90 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(1868, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1924, 37, false);
#line 93 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 92, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"block\"></dt>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2054, 42, false);
#line 97 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(2096, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2152, 38, false);
#line 100 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(2190, 92, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"block\"></dt>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2283, 45, false);
#line 104 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.telephone));

#line default
#line hidden
            EndContext();
            BeginContext(2328, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2384, 41, false);
#line 107 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayFor(model => model.telephone));

#line default
#line hidden
            EndContext();
            BeginContext(2425, 92, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"block\"></dt>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2518, 45, false);
#line 111 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.workplace));

#line default
#line hidden
            EndContext();
            BeginContext(2563, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2619, 41, false);
#line 114 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayFor(model => model.workplace));

#line default
#line hidden
            EndContext();
            BeginContext(2660, 92, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"block\"></dt>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(2753, 46, false);
#line 118 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.occupation));

#line default
#line hidden
            EndContext();
            BeginContext(2799, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(2855, 42, false);
#line 121 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayFor(model => model.occupation));

#line default
#line hidden
            EndContext();
            BeginContext(2897, 119, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"block\"></dt>\r\n            <dt style=\"margin-bottom:0px;\">\r\n                ");
            EndContext();
            BeginContext(3017, 43, false);
#line 125 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(3060, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(3116, 39, false);
#line 128 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
           Write(Html.DisplayFor(model => model.address));

#line default
#line hidden
            EndContext();
            BeginContext(3155, 54, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n\r\n    ");
            EndContext();
            BeginContext(3209, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85eef06f754d457abcc6ffbc86eacac0", async() => {
                BeginContext(3235, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3245, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "41f1335d03494f26b22272bed99826ea", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 134 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Users\Delete.cshtml"
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
                BeginContext(3281, 80, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"删除\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3361, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96376af7ebff456bb7308e9620a01c18", async() => {
                    BeginContext(3383, 8, true);
                    WriteLiteral("返回用户管理列表");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3395, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3408, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591