#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aedba76160e510f5e5ad5bf628032f0a0f1773a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Science_essay_Index), @"mvc.1.0.view", @"/Views/Science_essay/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Science_essay/Index.cshtml", typeof(AspNetCore.Views_Science_essay_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aedba76160e510f5e5ad5bf628032f0a0f1773a0", @"/Views/Science_essay/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_Science_essay_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NaturalDisasterDatabaseWebsite.Models.Science_essayViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Science_essay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form_search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(82, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
  
    Layout = "_BackLayout";
    ViewData["Title"] = "文章管理";

#line default
#line hidden
            BeginContext(153, 1406, true);
            WriteLiteral(@"<style>
    .essaymanage {
        text-align: center;
        width: 100%;
        font-size: 18px;
        font-weight: 500;
        color: #808080;
        letter-spacing: 3px;
        margin-top: 20px;
    }
    .createessay {
        display: inline-block;
    }
    .createessay i {
        color: #333;
    }
    .createessay i, .createessay a {
        font-size: 14px;
    }
    .createessay a span {
        display: inline-block;
        width: 60px;
        height: 28px;
        line-height: 28px;
        background: #F1F3F4;
        text-align: center;
    }
    .form_search {
        float: right;
    }

    .table {
        table-layout: fixed;
    }

    th, td {
        text-align: center;
    }

    .td_noAlign {
        text-align: left;
    }

    .text-overflow {
        overflow: hidden;
        /*text-overflow: -o-ellipsis-lastline;*/
        text-overflow: ellipsis;
        display: -webkit-box;
        -webkit-line-clamp: 2;
        /*line-");
            WriteLiteral(@"clamp: 2;*/
        -webkit-box-orient: vertical;
        word-break: break-all;
    }

    .overflow-img {
        overflow: hidden;
        white-space: nowrap;
        text-overflow: ellipsis;
    }

    .th_owidth {
        width: 6.5%;
    }

    .th_swidth {
        width: 8%;
    }
</style>
<p class=""essaymanage"">文章管理</p>
<div class=""createessay"">
    ");
            EndContext();
            BeginContext(1559, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4d865ea5b3e4d229bf9ca04183910d1", async() => {
                BeginContext(1582, 57, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-plus\"></i><span>新添文章</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1643, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(1653, 266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f862da577784e8bb06d1d89248ae883", async() => {
                BeginContext(1742, 64, true);
                WriteLiteral("\r\n    <input type=\"text\" name=\"SearchString\" placeholder=\"关键词搜索\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1806, "\"", 1840, 1);
#line 80 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
WriteAttributeValue("", 1814, ViewData["currentFilter"], 1814, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1841, 71, true);
                WriteLiteral(" style=\"padding-left:6px;\" />\r\n    <input type=\"submit\" value=\"搜索\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
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
            BeginContext(1919, 249, true);
            WriteLiteral("\r\n<hr style=\"margin-bottom:0px; border-width:2px; color:#DDDDDD;\" />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th style=\"width:4%;\">\r\n                序号\r\n            </th>\r\n            <th style=\"width: 16%;\">\r\n                ");
            EndContext();
            BeginContext(2169, 41, false);
#line 91 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
            EndContext();
            BeginContext(2210, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th_owidth\">\r\n                ");
            EndContext();
            BeginContext(2284, 42, false);
#line 94 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.author));

#line default
#line hidden
            EndContext();
            BeginContext(2326, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th_swidth\">\r\n                ");
            EndContext();
            BeginContext(2400, 42, false);
#line 97 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.source));

#line default
#line hidden
            EndContext();
            BeginContext(2442, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th_swidth\">\r\n                ");
            EndContext();
            BeginContext(2516, 43, false);
#line 100 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.fb_time));

#line default
#line hidden
            EndContext();
            BeginContext(2559, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width:31%;\">\r\n                ");
            EndContext();
            BeginContext(2634, 46, false);
#line 103 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.wz_content));

#line default
#line hidden
            EndContext();
            BeginContext(2680, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(2822, 52, true);
            WriteLiteral("            <th class=\"th_owidth\">\r\n                ");
            EndContext();
            BeginContext(2875, 44, false);
#line 109 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.wz_style));

#line default
#line hidden
            EndContext();
            BeginContext(2919, 74, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width:5.5%\">\r\n                ");
            EndContext();
            BeginContext(2994, 41, false);
#line 112 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.state));

#line default
#line hidden
            EndContext();
            BeginContext(3035, 73, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th_owidth\">\r\n                ");
            EndContext();
            BeginContext(3109, 40, false);
#line 115 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.user));

#line default
#line hidden
            EndContext();
            BeginContext(3149, 106, true);
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th_swidth\">操作</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 121 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
          
            var i = 1;
            

#line default
#line hidden
#line 123 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(3348, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3421, 1, false);
#line 127 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3422, 155, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"td_noAlign\">\r\n                        <div class=\"text-overflow\">\r\n                            ");
            EndContext();
            BeginContext(3578, 40, false);
#line 131 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
            EndContext();
            BeginContext(3618, 111, true);
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3730, 41, false);
#line 135 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.author));

#line default
#line hidden
            EndContext();
            BeginContext(3771, 136, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"text-overflow\">\r\n                            ");
            EndContext();
            BeginContext(3908, 41, false);
#line 139 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.source));

#line default
#line hidden
            EndContext();
            BeginContext(3949, 111, true);
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(4061, 42, false);
#line 143 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.fb_time));

#line default
#line hidden
            EndContext();
            BeginContext(4103, 333, true);
            WriteLiteral(@"
                    </td>
                    <td class=""td_noAlign"">
                        <div class=""text-overflow"" style=""overflow: hidden;
        text-overflow: ellipsis;
        display: -webkit-box;
        -webkit-line-clamp: 2;
        -webkit-box-orient: vertical;
        word-break: break-all;height:40px;"">
");
            EndContext();
            BeginContext(4516, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(4545, 59, false);
#line 153 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
                       Write(Html.Raw(System.Net.WebUtility.UrlDecode(@item.wz_content)));

#line default
#line hidden
            EndContext();
            BeginContext(4604, 61, true);
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n");
            EndContext();
            BeginContext(4811, 107, true);
            WriteLiteral("                    <td>\r\n                        <div class=\"text-overflow\">\r\n                            ");
            EndContext();
            BeginContext(4919, 43, false);
#line 161 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.wz_style));

#line default
#line hidden
            EndContext();
            BeginContext(4962, 111, true);
            WriteLiteral("\r\n                        </div>\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5074, 40, false);
#line 165 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.state));

#line default
#line hidden
            EndContext();
            BeginContext(5114, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(5194, 48, false);
#line 168 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.user.username));

#line default
#line hidden
            EndContext();
            BeginContext(5242, 97, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"td_center\">\r\n                        ");
            EndContext();
            BeginContext(5339, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10d1d8bfad664f52ae6b058fad5e0d31", async() => {
                BeginContext(5384, 2, true);
                WriteLiteral("编辑");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 171 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
                                               WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5390, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(5418, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "224109e8957b4050b33f338cb8b44f62", async() => {
                BeginContext(5466, 2, true);
                WriteLiteral("详情");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 172 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
                                                  WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5472, 27, true);
            WriteLiteral(" \r\n                        ");
            EndContext();
            BeginContext(5499, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "226d64e5454249e8aad3475e7152ed2f", async() => {
                BeginContext(5546, 2, true);
                WriteLiteral("删除");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 173 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
                                                 WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5552, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 176 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\Science_essay\Index.cshtml"
                i++;
            }

#line default
#line hidden
            BeginContext(5652, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NaturalDisasterDatabaseWebsite.Models.Science_essayViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
