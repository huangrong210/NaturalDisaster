#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2352e4cb38cf2a442c16ed8f93e3e8b1da217b9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DisasterData_EditGeology), @"mvc.1.0.view", @"/Views/DisasterData/EditGeology.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DisasterData/EditGeology.cshtml", typeof(AspNetCore.Views_DisasterData_EditGeology))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2352e4cb38cf2a442c16ed8f93e3e8b1da217b9c", @"/Views/DisasterData/EditGeology.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_DisasterData_EditGeology : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/ueditor-1.4.3.3/ueditor.parse.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DisasterData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right; padding-top:5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditGeology", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
  
    Layout = "_BackLayout";
    ViewData["Title"] = "编辑地质灾害时刻数据";

#line default
#line hidden
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(77, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f29d0094086944b49ca54c245d9b47fe", async() => {
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
            BeginContext(139, 406, true);
            WriteLiteral(@"

<style>
    .content_nav {
        font-size: 16px;
        font-weight: 500;
        margin-top: 10px;
    }

    .form-control {
        display: inline-block;
        width: auto;
    }

    .diflex {
        display: flex;
        justify-content: space-between;
    }

    label {
        width: 100px;
        text-align: center;
    }
</style>
<p class=""content_nav"">
    ");
            EndContext();
            BeginContext(546, 17, false);
#line 31 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(563, 84, true);
            WriteLiteral("\r\n    <input type=\"submit\" value=\"保 存\" class=\"btn btn-warning\" form=\"form1\" />\r\n    ");
            EndContext();
            BeginContext(647, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b268920eea1c47c29b04c016db42db1d", async() => {
                BeginContext(737, 10, true);
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
            BeginContext(751, 139, true);
            WriteLiteral("\r\n</p>\r\n<hr style=\"margin-top:12px;\" />\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\" style=\"margin:0 auto; text-align:center;\">\r\n        ");
            EndContext();
            BeginContext(890, 3868, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c80ffcb1fd1d4996b23f3407fc2aaa86", async() => {
                BeginContext(975, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(989, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a855b255e0740a9a09b1feaec934de5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 39 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
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
                BeginContext(1055, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 40 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
             foreach (var geologyedit in ViewBag.geologyedit)
            {

#line default
#line hidden
                BeginContext(1135, 46, true);
                WriteLiteral("                <input name=\"ID\" type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1181, "\"", 1204, 1);
#line 42 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
WriteAttributeValue("", 1189, geologyedit.ID, 1189, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1205, 143, true);
                WriteLiteral(" />\r\n                <div class=\"form-group\">\r\n                    <label>时&emsp;&emsp;间</label>\r\n                    <input name=\"geologytime\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1348, "\"", 1440, 1);
#line 45 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
WriteAttributeValue("", 1356, DateTime.Parse(@geologyedit.geologytime.ToString()).ToString("yyyy-MM-dd HH:mm:ss"), 1356, 84, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1441, 201, true);
                WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"form-group right\">\r\n                    <label>经&emsp;&emsp;度(°)</label>\r\n                    <input name=\"geologylogitude\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1642, "\"", 1678, 1);
#line 49 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
WriteAttributeValue("", 1650, geologyedit.geologylogitude, 1650, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1679, 196, true);
                WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>维&emsp;&emsp;度(°)</label>\r\n                    <input name=\"geologydimension\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1875, "\"", 1912, 1);
#line 53 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
WriteAttributeValue("", 1883, geologyedit.geologydimension, 1883, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1913, 185, true);
                WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"form-group right\">\r\n                    <label>灾害级别</label>\r\n                    <input name=\"geologylevel\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2098, "\"", 2131, 1);
#line 57 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
WriteAttributeValue("", 2106, geologyedit.geologylevel, 2106, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2132, 191, true);
                WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"form-group right\">\r\n                    <label>伤亡人数(人)</label>\r\n                    <input name=\"geologycasualty\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2323, "\"", 2359, 1);
#line 61 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
WriteAttributeValue("", 2331, geologyedit.geologycasualty, 2331, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2360, 185, true);
                WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"form-group right\">\r\n                    <label>灾害类型</label>\r\n                    <input name=\"geologystyle\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2545, "\"", 2578, 1);
#line 65 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
WriteAttributeValue("", 2553, geologyedit.geologystyle, 2553, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2579, 179, true);
                WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>参考位置</label>\r\n                    <input name=\"geologyplace\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2758, "\"", 2791, 1);
#line 69 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
WriteAttributeValue("", 2766, geologyedit.geologyplace, 2766, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2792, 188, true);
                WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"form-group right\">\r\n                    <label>经济损失(万元)</label>\r\n                    <input name=\"geologyloss\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2980, "\"", 3012, 1);
#line 73 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
WriteAttributeValue("", 2988, geologyedit.geologyloss, 2988, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3013, 182, true);
                WriteLiteral(" class=\"form-control\" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>受灾范围(公顷)</label>\r\n                    <input name=\"geologyarea\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3195, "\"", 3227, 1);
#line 77 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
WriteAttributeValue("", 3203, geologyedit.geologyarea, 3203, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3228, 386, true);
                WriteLiteral(@" class=""form-control"" />
                </div>
                <div class=""form-group"">
                    <span style=""font-weight: 600;"">详&emsp;&emsp;情</span>
                    <input name=""geologydetails"" type=""hidden"" class=""form-control"" id=""content"" />

                    <script id=""editor"" type=""text/plain"" style=""width:100%;height:auto;"">
                        ");
                EndContext();
                BeginContext(3615, 70, false);
#line 84 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
                   Write(Html.Raw(System.Net.WebUtility.UrlDecode(@geologyedit.geologydetails)));

#line default
#line hidden
                EndContext();
                BeginContext(3685, 1041, true);
                WriteLiteral(@"
                    </script>
                    <script type=""text/javascript"">
                        $(function () {
                            UE.delEditor('editor');
                            var ue = UE.getEditor('editor', {
                                allowDivTransToP: false,//阻止div标签自动转换为p标签
                                autoHeightEnabled: true,
                                autoFloatEnabled: true
                            });
                            ue.ready(function () {
                                $("".edui-editor-messageholder.edui-default"").css({ ""visibility"": ""hidden"" });
                            })
                        });
                        function cc() {
                            document.getElementById('content').value = UE.getEditor('editor').getContent();
                        }
                        setInterval(function () {
                            cc();
                        }, 100);
                    </script>
       ");
                WriteLiteral("         </div>\r\n");
                EndContext();
#line 106 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
            }

#line default
#line hidden
                BeginContext(4741, 10, true);
                WriteLiteral("\r\n        ");
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
            BeginContext(4758, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4800, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 113 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\DisasterData\EditGeology.cshtml"
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
