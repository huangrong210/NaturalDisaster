#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\CreateCrop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70c7e40355f8cb8edcf1e0a96c55a59fa4afb99e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DisasterData_CreateCrop), @"mvc.1.0.view", @"/Views/DisasterData/CreateCrop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DisasterData/CreateCrop.cshtml", typeof(AspNetCore.Views_DisasterData_CreateCrop))]
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
#line 1 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\CreateCrop.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c7e40355f8cb8edcf1e0a96c55a59fa4afb99e", @"/Views/DisasterData/CreateCrop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_DisasterData_CreateCrop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/ueditor-1.4.3.3/ueditor.parse.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DisasterData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding-top: 5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCrop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\CreateCrop.cshtml"
  
    Layout = "_BackLayout";
    ViewData["Title"] = "添加农作物生物灾害时刻数据";

#line default
#line hidden
            BeginContext(109, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f761a103a39843429617e83a4303e98b", async() => {
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
            BeginContext(171, 510, true);
            WriteLiteral(@"
<style>
    .content_nav {
        font-size: 16px;
        font-weight: 500;
        margin-top: 15px;
        margin-bottom: 0px;
        display:flex;
        justify-content:space-between;
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
            BeginContext(682, 17, false);
#line 29 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\CreateCrop.cshtml"
                                                                                         Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(699, 282, true);
            WriteLiteral(@"</a>&emsp;
        <input type=""submit"" value=""提交"" class=""btn btn-default"" form=""form1"" />
    </div>
    <div>
        <a href=""javascript:void(0)"" style=""text-decoration:none;display: inline-block;padding-top: 6px;"" onclick=""getLongDimen2();"">获取经纬度</a>&emsp;
    </div>
    ");
            EndContext();
            BeginContext(981, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92c8d5c3987e40daa9f9c750cde3604c", async() => {
                BeginContext(1059, 10, true);
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
            BeginContext(1073, 115, true);
            WriteLiteral("\r\n</div>\r\n\r\n<hr style=\"margin-top:15px;\" />\r\n<div style=\"margin:0 auto; text-align:center;\" class=\"cropform\">\r\n    ");
            EndContext();
            BeginContext(1188, 3140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e72a3b743aa345369519e80f2dbcf440", async() => {
                BeginContext(1272, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1282, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "014e2f28b44b47a99673e1bcbc046c1a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 41 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\CreateCrop.cshtml"
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
                BeginContext(1348, 44, true);
                WriteLiteral("\r\n        <input name=\"userID\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1392, "\"", 1426, 1);
#line 42 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\CreateCrop.cshtml"
WriteAttributeValue("", 1400, User.FindFirstValue("ID"), 1400, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1427, 2894, true);
                WriteLiteral(@" class=""form-control userID"" />
        <table id=""addTable"">
            <tbody style="""">
                <tr>
                    <td>
                        <div class=""form-group"">
                            <label>时&emsp;&emsp;间</label>
                            <input name=""croptime"" class=""form-control croptime"" />
                        </div>
                    </td>
                    <td>
                        <div class=""form-group"">
                            <label>经&emsp;&emsp;度(°)</label>
                            <input name=""croplongitude"" class=""form-control croplongitude"" />
                        </div>
                    </td>
                    <td>
                        <div class=""form-group"">
                            <label>纬&emsp;&emsp;度(°)</label>
                            <input name=""cropdimension"" class=""form-control cropdimension"" />
                        </div>
                    </td>
                    <td>
                   ");
                WriteLiteral(@"     <div class=""form-group"">
                            <label>参考位置</label>
                            <input name=""cropplace"" class=""form-control cropplace"" />
                        </div>
                    </td>
                    <td>
                        <div class=""form-group"">
                            <label>灾害类型</label>
                            <input name=""cropstyle"" class=""form-control cropstyle"" />
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class=""form-group"">
                            <label>经济损失(万元)</label>
                            <input name=""croploss"" class=""form-control croploss"" />
                        </div>
                    </td>
                    <td>
                        <div class=""form-group"">
                            <label>灾害范围(公顷)</label>
                            <input name=""croparea"" class=""form-control croparea""");
                WriteLiteral(@" />
                        </div>
                    </td>
                    <td colspan=""2"">
                        <span style=""font-weight:600;"">详情</span>
                        <input name=""cropdetails"" class=""form-control cropdetails"" id=""content"" type=""hidden"" />
                        <div style=""width:500px; margin:0 auto;text-align:center;"">
                            <textarea class=""A4page"" id=""myEditor"" name=""NewsContent""></textarea>
                        </div>
                    </td>
                    <td><input type=""button"" value=""-"" onclick=""deleteRow(this)"" class=""form-control"" /></td>
                </tr>
                <tr>
                    <td colspan=""5""><hr /></td>
                </tr>
            </tbody>

            <tbody class=""footTbody""></tbody>
        </table>
    ");
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
            BeginContext(4328, 171, true);
            WriteLiteral("\r\n    <input type=\"button\" value=\"+\" onclick=\"setValue()\" class=\"form-control\"><p style=\"font-size:1px; color:#ccc;\">批量插入数据失败,请问操作</p>\r\n    <table style=\"display:none;\">\r\n");
            EndContext();
            BeginContext(4515, 2088, true);
            WriteLiteral(@"        <tbody class=""templeteTBody"" style="""">
            <tr>
                <td>
                    <div class=""form-group"">
                        <label>时&emsp;&emsp;间</label>
                        <input name=""croptime"" class=""form-control croptime"" />
                    </div>
                </td>
                <td>
                    <div class=""form-group"">
                        <label>经&emsp;&emsp;度</label>
                        <input name=""croplongitude"" class=""form-control croplongitude"" />
                    </div>
                </td>
                <td>
                    <div class=""form-group"">
                        <label>纬&emsp;&emsp;度</label>
                        <input name=""cropdimension"" class=""form-control cropdimension"" />
                    </div>
                </td>

                <td>
                    <div class=""form-group"">
                        <label>参考位置</label>
                        <input name=""cropplace"" class=""for");
            WriteLiteral(@"m-control cropplace"" />
                    </div>
                </td>

                <td>
                    <div class=""form-group"">
                        <label>灾害类型</label>
                        <input name=""cropstyle"" class=""form-control cropstyle"" />
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <div class=""form-group"">
                        <label>经济损失(万元)</label>
                        <input name=""croploss"" class=""form-control croploss"" />
                    </div>
                </td>
                <td>
                    <div class=""form-group"">
                        <label>灾害范围(公顷)</label>
                        <input name=""croparea"" class=""form-control croparea"" />
                    </div>
                </td>
                <td colspan=""2"">
                    <p style=""font-weight:600; margin:0"">详情</p>
                    <textarea name=""cropdetails"" class=""form-cont");
            WriteLiteral("rol cropdetails\" cols=\"65\"></textarea>\r\n");
            EndContext();
            BeginContext(6898, 1160, true);
            WriteLiteral(@"                </td>
                <td><input type=""button"" value=""-"" onclick=""deleteRow(this)"" class=""form-control"" /></td>
            </tr>
            <tr>
                <td colspan=""5""><hr /></td>
            </tr>
        </tbody>
    </table>
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
        $("".cropform"").show();
        $("".longdim");
            WriteLiteral("en\").hide();\r\n    }\r\n    function getLongDimen2() {\r\n        $(\".cropform\").hide();\r\n        $(\".longdimen\").show();\r\n    }\r\n</script>\r\n");
            EndContext();
            BeginContext(8068, 708, true);
            WriteLiteral(@"<script type=""text/javascript"">
    /*
    *增加模板行
    */
    function addRow() {
        var table = document.getElementById(""addTable"");
        var tbody = $("".templeteTBody"");
        var newTBody = tbody[0].cloneNode(true);
        newTBody.style.display = """";
        var footTBody = $("".footTbody"")[0];
        return table.insertBefore(newTBody, footTBody);
    }
    /*
    *删除模板行
    */
    function deleteRow(obj) {
        var tbody = obj.parentNode.parentNode.parentNode;
        var table = document.getElementById(""addTable"");
        table.removeChild(tbody);
    }
    /**
    *向模板中填充值
    */
    function setValue() {
        var tbody = addRow();
    }
</script>
");
            EndContext();
            BeginContext(8784, 760, true);
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
            BeginContext(11562, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(11582, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 297 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\CreateCrop.cshtml"
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