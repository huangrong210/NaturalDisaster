#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d7e4029375f4d149a3d73fc684240bb784f389d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DisasterData_TimeForest), @"mvc.1.0.view", @"/Views/DisasterData/TimeForest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DisasterData/TimeForest.cshtml", typeof(AspNetCore.Views_DisasterData_TimeForest))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d7e4029375f4d149a3d73fc684240bb784f389d", @"/Views/DisasterData/TimeForest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_DisasterData_TimeForest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DisasterData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateForest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditForest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteForest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 20, true);
            WriteLiteral("<div style=\"\">\r\n    ");
            EndContext();
            BeginContext(20, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d817e3566b804292a7b90c935e4ecc03", async() => {
                BeginContext(79, 68, true);
                WriteLiteral("<i class=\"glyphicon glyphicon-plus\"></i><span>添加时刻灾害数据：森林生物灾害</span>");
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
            BeginContext(151, 792, true);
            WriteLiteral(@"
    <button onclick=""downloadtimeforest();"" class=""btn btn-success"" style=""float:right; padding:3px 6px; border-radius:0px; font-size:14px;"">导出EXCEL</button>
</div>
<table class=""table"" id=""recorddataforest"">
    <thead>
        <tr>
            <th style=""width:4%;"">序号</th>
            <th style=""width:8%;"">时间</th>
            <th style=""width:8%;"">经度(°)</th>
            <th style=""width:8%;"">维度(°)</th>
            <th style=""width:8%;"">损失(万元)</th>
            <th style=""width:8%;"">范围(公顷)</th>
            <th style=""width:13%;"">灾害类型</th>
            <th style=""width:13%;"">参考地点</th>
            <th style=""width:20%;"">详情</th>
            <th style=""width:6%;"">上报人</th>
            <th style=""width:4%;"" class=""noExl"">操作</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 22 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
          
            var i = 1;
            var count = 0;
            

#line default
#line hidden
#line 25 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
             foreach (var forest in ViewBag.foresttime)
            {

#line default
#line hidden
            BeginContext(1079, 63, true);
            WriteLiteral("                <tr>\r\n                    <td class=\"t_center\">");
            EndContext();
            BeginContext(1143, 1, false);
#line 28 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                                    Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1144, 59, true);
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center;\"> ");
            EndContext();
            BeginContext(1204, 77, false);
#line 29 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                                               Write(DateTime.Parse(@forest.foresttime.ToString()).ToString("yyyy-MM-dd HH:mm:ss"));

#line default
#line hidden
            EndContext();
            BeginContext(1281, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1313, 21, false);
#line 30 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                   Write(forest.forestlogitude);

#line default
#line hidden
            EndContext();
            BeginContext(1334, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1366, 22, false);
#line 31 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                   Write(forest.forestdimension);

#line default
#line hidden
            EndContext();
            BeginContext(1388, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1420, 17, false);
#line 32 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                   Write(forest.forestloss);

#line default
#line hidden
            EndContext();
            BeginContext(1437, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1469, 17, false);
#line 33 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                   Write(forest.forestarea);

#line default
#line hidden
            EndContext();
            BeginContext(1486, 161, true);
            WriteLiteral("</td>\r\n                    <td class=\"newsInfo\" style=\"text-align:justify; text-align-last:left;\">\r\n                        <div class=\"newInfoTruncation boxId\">");
            EndContext();
            BeginContext(1648, 18, false);
#line 35 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                                                        Write(forest.foreststyle);

#line default
#line hidden
            EndContext();
            BeginContext(1666, 38, true);
            WriteLiteral("</div>\r\n                        <span>");
            EndContext();
            BeginContext(1705, 18, false);
#line 36 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                         Write(forest.foreststyle);

#line default
#line hidden
            EndContext();
            BeginContext(1723, 190, true);
            WriteLiteral("</span>\r\n                    </td>\r\n                    <td class=\"newsInfo\" style=\"text-align:justify; text-align-last:left;\">\r\n                        <div class=\"newInfoTruncation boxId\">");
            EndContext();
            BeginContext(1914, 18, false);
#line 39 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                                                        Write(forest.forestplace);

#line default
#line hidden
            EndContext();
            BeginContext(1932, 38, true);
            WriteLiteral("</div>\r\n                        <span>");
            EndContext();
            BeginContext(1971, 18, false);
#line 40 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                         Write(forest.forestplace);

#line default
#line hidden
            EndContext();
            BeginContext(1989, 220, true);
            WriteLiteral("</span>\r\n                    </td>\r\n                    <td class=\"newsInfo\" style=\"text-align:justify; text-align-last:left;\">\r\n                        <div class=\"newInfoTruncation newInfoTruncation3 boxId\" id=\"boxId\">");
            EndContext();
            BeginContext(2210, 64, false);
#line 43 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                                                                                      Write(Html.Raw(System.Net.WebUtility.UrlDecode(@forest.forestdetails)));

#line default
#line hidden
            EndContext();
            BeginContext(2274, 38, true);
            WriteLiteral("</div>\r\n                        <span>");
            EndContext();
            BeginContext(2313, 64, false);
#line 44 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                         Write(Html.Raw(System.Net.WebUtility.UrlDecode(@forest.forestdetails)));

#line default
#line hidden
            EndContext();
            BeginContext(2377, 60, true);
            WriteLiteral("</span>\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(2438, 15, false);
#line 46 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                   Write(forest.username);

#line default
#line hidden
            EndContext();
            BeginContext(2453, 71, true);
            WriteLiteral("</td>\r\n                    <td class=\"noExl\">\r\n                        ");
            EndContext();
            BeginContext(2524, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ff69821fb8441c8284c9f82b5689bf", async() => {
                BeginContext(2607, 2, true);
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
#line 48 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                                                                                   WriteLiteral(forest.ID);

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
            BeginContext(2613, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2639, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cd4648b878f4b3fbae854e7b3d46d00", async() => {
                BeginContext(2724, 2, true);
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
#line 49 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                                                                                     WriteLiteral(forest.ID);

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
            BeginContext(2730, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 52 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\TimeForest.cshtml"
                i++;
                count = i - 1;
            }

#line default
#line hidden
            BeginContext(2887, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(2924, 538, true);
            WriteLiteral(@"<script>
    function downloadtimeforest() {
        //console.log(1);
        $("".boxId"").html("""");
        $.noConflict(); //请务必加上这一句，否则无法下载excel，因为$符号与其他jq版本冲突了
        $(""#recorddataforest"").table2excel({
            exclude: "".noExl"",
            name: new Date().getTime(),
            filename: new Date().getTime(),
            exclude_img: true,
            exclude_links: true,
            exclude_inputs: true
        });
        window.location.reload(); //强制刷新，因为 table2excel只执行一次，如果不刷新就不能再下载数据
    }
</script>");
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
