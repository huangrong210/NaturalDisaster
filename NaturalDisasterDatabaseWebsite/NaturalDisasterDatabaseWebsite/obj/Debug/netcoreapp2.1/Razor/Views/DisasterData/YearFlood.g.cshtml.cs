#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e46602cb8ef5a9ba1bfe7fb376e097d706a43acb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DisasterData_YearFlood), @"mvc.1.0.view", @"/Views/DisasterData/YearFlood.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DisasterData/YearFlood.cshtml", typeof(AspNetCore.Views_DisasterData_YearFlood))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e46602cb8ef5a9ba1bfe7fb376e097d706a43acb", @"/Views/DisasterData/YearFlood.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_DisasterData_YearFlood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DisasterData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "YearCreateFlood", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "YearEditFlood", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "YearDeleteFlood", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd99b57b8dee47bb90086f7aaa94a102", async() => {
                BeginContext(62, 66, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-plus\"></i><span>添加年度灾害数据：洪水灾害</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(132, 685, true);
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th style=""width:4%;"">序号</th>
            <th style=""width:4%;"">年份</th>
            <th style=""width:10%;"">农业受灾面积(千公顷)</th>
            <th style=""width:10%;"">农业成灾面积(千公顷)</th>
            <th style=""width:10%;"">水灾受灾面积(千公顷)</th>
            <th style=""width:10%;"">水灾成灾面积(千公顷)</th>
            <th style=""width:10%;"">旱灾受灾面积(千公顷)</th>
            <th style=""width:10%;"">旱灾成灾面积(千公顷)</th>
            <th style=""width:7%;"">除涝面积(千公顷)</th>
            <th style=""width:10%;"">经济损失(亿元)</th>
            <th style=""width:11%;"">备注</th>
            <th style=""width:4%;"">操作</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
          
            var i = 1;
            var count = 0;
            

#line default
#line hidden
#line 23 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
             foreach (var floodyear in ViewBag.floodyear)
            {

#line default
#line hidden
            BeginContext(955, 47, true);
            WriteLiteral("        <tr>\r\n            <td class=\"t_center\">");
            EndContext();
            BeginContext(1003, 1, false);
#line 26 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
                            Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1004, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1028, 16, false);
#line 27 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
           Write(floodyear.fYears);

#line default
#line hidden
            EndContext();
            BeginContext(1044, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1068, 24, false);
#line 28 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
           Write(floodyear.fAgrishouzArea);

#line default
#line hidden
            EndContext();
            BeginContext(1092, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1116, 25, false);
#line 29 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
           Write(floodyear.fAgrichengzArea);

#line default
#line hidden
            EndContext();
            BeginContext(1141, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1165, 25, false);
#line 30 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
           Write(floodyear.fWatershouzArea);

#line default
#line hidden
            EndContext();
            BeginContext(1190, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1214, 26, false);
#line 31 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
           Write(floodyear.fWaterchengzArea);

#line default
#line hidden
            EndContext();
            BeginContext(1240, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1264, 27, false);
#line 32 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
           Write(floodyear.fDroughtshouzArea);

#line default
#line hidden
            EndContext();
            BeginContext(1291, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1315, 28, false);
#line 33 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
           Write(floodyear.fDroughtchengzArea);

#line default
#line hidden
            EndContext();
            BeginContext(1343, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1367, 23, false);
#line 34 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
           Write(floodyear.fDrainageArea);

#line default
#line hidden
            EndContext();
            BeginContext(1390, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1414, 25, false);
#line 35 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
           Write(floodyear.fEconomicLosses);

#line default
#line hidden
            EndContext();
            BeginContext(1439, 169, true);
            WriteLiteral("</td>\r\n            <td class=\"newsInfo\" style=\"text-align:justify; text-align-last:left;\">\r\n                <div class=\"newInfoTruncation newInfoTruncation3\" id=\"boxId\">");
            EndContext();
            BeginContext(1609, 62, false);
#line 37 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
                                                                        Write(Html.Raw(System.Net.WebUtility.UrlDecode(@floodyear.fRemarks)));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 30, true);
            WriteLiteral("</div>\r\n                <span>");
            EndContext();
            BeginContext(1702, 62, false);
#line 38 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
                 Write(Html.Raw(System.Net.WebUtility.UrlDecode(@floodyear.fRemarks)));

#line default
#line hidden
            EndContext();
            BeginContext(1764, 62, true);
            WriteLiteral("</span>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1826, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11b5731d13a64321b66721f5c4e722a2", async() => {
                BeginContext(1915, 2, true);
                WriteLiteral("编辑");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
                                                                              WriteLiteral(floodyear.ID);

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
            BeginContext(1921, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1939, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c7e0745218940c683bfc082275a9679", async() => {
                BeginContext(2030, 2, true);
                WriteLiteral("删除");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
                                                                                WriteLiteral(floodyear.ID);

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
            BeginContext(2036, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\YearFlood.cshtml"
                i++;
                count = i - 1;
            }

#line default
#line hidden
            BeginContext(2177, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591