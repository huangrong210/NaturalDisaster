#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\CreateMeteorology.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc8874c5d41a68dbfee22ba197b85435a71be903"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DisasterData_CreateMeteorology), @"mvc.1.0.view", @"/Views/DisasterData/CreateMeteorology.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DisasterData/CreateMeteorology.cshtml", typeof(AspNetCore.Views_DisasterData_CreateMeteorology))]
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
#line 1 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\CreateMeteorology.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc8874c5d41a68dbfee22ba197b85435a71be903", @"/Views/DisasterData/CreateMeteorology.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_DisasterData_CreateMeteorology : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/ueditor-1.4.3.3/ueditor.parse.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DisasterData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-top: 5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateMeteorology", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\CreateMeteorology.cshtml"
  
    Layout = "_BackLayout";
    ViewData["Title"] = "添加气象灾害时刻数据";

#line default
#line hidden
            BeginContext(106, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd122c4def1a4cf6b904c791158fd218", async() => {
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
            BeginContext(168, 512, true);
            WriteLiteral(@"
<style>
    .content_nav {
        font-size: 16px;
        font-weight: 500;
        margin-top: 15px;
        margin-bottom: 0px;
        display: flex;
        justify-content: space-between;
    }

    label {
        width: 100px;
        text-align: center;
    }

    .form-control {
        display: inline-block;
        width: auto;
    }
</style>
<div class=""content_nav"">
    <div>
        <a href=""javascript:void(0)"" style=""text-decoration:none;"" onclick=""getLongDimen1();"">");
            EndContext();
            BeginContext(681, 17, false);
#line 29 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\CreateMeteorology.cshtml"
                                                                                         Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(698, 282, true);
            WriteLiteral(@"</a>&emsp;
        <input type=""submit"" value=""提交"" class=""btn btn-default"" form=""form1"" />
    </div>
    <div>
        <a href=""javascript:void(0)"" style=""text-decoration:none;display: inline-block;padding-top: 6px;"" onclick=""getLongDimen2();"">获取经纬度</a>&emsp;
    </div>
    ");
            EndContext();
            BeginContext(980, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1530977bf43744bf824fedcdc23e41f8", async() => {
                BeginContext(1058, 10, true);
                WriteLiteral("返回灾害数据管理列表");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1072, 122, true);
            WriteLiteral("\r\n</div>\r\n\r\n<hr style=\"margin-top:15px;\" />\r\n<div style=\"margin:0 auto; text-align:center;\" class=\"meteorologyform\">\r\n    ");
            EndContext();
            BeginContext(1194, 3346, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8adc06e6b6ed41ce800afe9cc30cc056", async() => {
                BeginContext(1285, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1295, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ddf1b35352b4ed4b22df9c4de293111", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 41 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\CreateMeteorology.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1361, 44, true);
                WriteLiteral("\r\n        <input name=\"userID\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1405, "\"", 1439, 1);
#line 42 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\CreateMeteorology.cshtml"
WriteAttributeValue("", 1413, User.FindFirstValue("ID"), 1413, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1440, 3093, true);
                WriteLiteral(@" class=""form-control"" />
        <table id=""addTable"">
            <tbody style="""">
                <tr>
                    <td>
                        <div class=""form-group"">
                            <label>时&emsp;&emsp;间</label>
                            <input name=""qixiangtime"" class=""form-control"" />
                        </div>
                    </td>
                    <td>
                        <div class=""form-group"">
                            <label>经&emsp;&emsp;度(°)</label>
                            <input name=""qixianglogitude"" class=""form-control"" />
                        </div>
                    </td>
                    <td>
                        <div class=""form-group"">
                            <label>纬&emsp;&emsp;度(°)</label>
                            <input name=""qixiangdimension"" class=""form-control"" />
                        </div>
                    </td>
                    <td>
                        <div class=""form-group"">
     ");
                WriteLiteral(@"                       <label>参考位置</label>
                            <input name=""qixiangplace"" class=""form-control"" />
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class=""form-group"">
                            <label>灾害类型</label>
                            <input name=""qixiangstyle"" class=""form-control"" />
                        </div>
                    </td>
                    <td>
                        <div class=""form-group"">
                            <label>伤亡人数(人)</label>
                            <input name=""qixiangcasualty"" class=""form-control"" />
                        </div>
                    </td>
                    <td>
                        <div class=""form-group"">
                            <label>经济损失(万元)</label>
                            <input name=""qixiangloss"" class=""form-control"" />
                        </div>
                    </");
                WriteLiteral(@"td>    
                    <td>
                        <div class=""form-group"">
                            <label>灾害范围(公顷)</label>
                            <input name=""qixiangarea"" class=""form-control"" />
                        </div>
                    </td>
                </tr>
                <tr>
                    <td colspan=""2"">
                        <span style=""font-weight:600;"">详情</span>
                        <input name=""qixiangdetails"" class=""form-control"" id=""content"" type=""hidden"" />
                        <div style=""width:500px;margin:0 auto; text-align:center;"">
                            <textarea class=""A4page"" id=""myEditor"" name=""NewsContent""></textarea>
                        </div>
                    </td>
                    <td></td>
                    <td></td>
                </tr>
                <tr>
                    <td colspan=""4""><hr /></td>
                </tr>
            </tbody>

            <tbody class=""footTbody""></tbody>
 ");
                WriteLiteral("       </table>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4540, 913, true);
            WriteLiteral(@"
</div>
<div style=""display:none;"" class=""longdimen"">
    <p style=""color:red;"">获取坐标并复制,皆是经度在前，维度在后</p>
    <iframe id=""pickupZuobiao"" name=""pickupZuobiao"" scrolling=""no"" style=""width:100%; min-height:500px;"" allowfullscreen=""true"" frameborder=""0"" src=""https://api.map.baidu.com/lbsapi/getpoint/index.html"" onload=""frameauto()""></iframe>
    <script>
        function frameauto() {
            window.onerror = function () { return true; }
            $(function () {
                headerH = 0;
                var h = $(window).height();
                $(""#pickupZuobiao"").height((h - headerH) + ""px"");
            });
        }
    </script>
</div>
<script>
    function getLongDimen1() {
        $("".meteorologyform"").show();
        $("".longdimen"").hide();
    }
    function getLongDimen2() {
        $("".meteorologyform"").hide();
        $("".longdimen"").show();
    }
</script>
");
            EndContext();
            BeginContext(5461, 760, true);
            WriteLiteral(@"<script type=""text/javascript"">
    $(function () {
        UE.delEditor('myEditor');
        var ue = UE.getEditor('myEditor', {
            toolbars: [

            ],
            allowDivTransToP: false,//阻止div标签自动转换为p标签
            autoHeightEnabled: true,
            autoFloatEnabled: true,
            maximumWords: 10000,
            wordCount: false
        });
        //对编辑器的操作最好在编辑器ready之后再做
        ue.ready(function () {

            $("".edui-editor-messageholder.edui-default"").css({ ""visibility"": ""hidden"" });
        })

    });
    function cc() {
        document.getElementById('content').value = UE.getEditor('myEditor').getContent();
    }
    setInterval(function () {
        cc();
    }, 100);
</script>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6239, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 172 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\CreateMeteorology.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
