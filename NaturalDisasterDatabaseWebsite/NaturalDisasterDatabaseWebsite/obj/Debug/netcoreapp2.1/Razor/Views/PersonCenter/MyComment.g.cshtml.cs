#pragma checksum "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9edcc4ec7ec2639d009056102e8abe1b760cb2f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonCenter_MyComment), @"mvc.1.0.view", @"/Views/PersonCenter/MyComment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PersonCenter/MyComment.cshtml", typeof(AspNetCore.Views_PersonCenter_MyComment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9edcc4ec7ec2639d009056102e8abe1b760cb2f3", @"/Views/PersonCenter/MyComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d8d6a67f7ada271b014efa1a910242944a815", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonCenter_MyComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PersonCenter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("article-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteForumMsg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: rgb(202, 12, 22); text-decoration:none; cursor:pointer;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 193, true);
            WriteLiteral("<div class=\"comment-nav-tabs\">\r\n    <div class=\"comment-nav-item activecomment\">我的文章评论</div>\r\n    <div class=\"comment-nav-item\">我发表的评论</div>\r\n</div>\r\n<div class=\"box\">\r\n    <div class=\"con0\">\r\n");
            EndContext();
#line 7 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
         foreach (var p in ViewBag.othermsg)
        {

#line default
#line hidden
            BeginContext(250, 88, true);
            WriteLiteral("            <div class=\"comment-list-box\">\r\n                <div class=\"img-avatar-box\">");
            EndContext();
            BeginContext(338, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2eccba5537c140afac081155b41c93a8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 348, "~/upfiles/", 348, 10, true);
#line 10 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
AddHtmlAttributeValue("", 358, p.img, 358, 6, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(389, 253, true);
            WriteLiteral("</div>\r\n                <div class=\"comment-item-content\">\r\n                    <div class=\"comment-item-title\">\r\n                        <div class=\"item-title-left\">\r\n                            <span class=\"user-name\" style=\"color: rgb(79, 79, 79);\">");
            EndContext();
            BeginContext(643, 10, false);
#line 14 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
                                                                               Write(p.username);

#line default
#line hidden
            EndContext();
            BeginContext(653, 56, true);
            WriteLiteral("</span>\r\n                            <span class=\"date\">");
            EndContext();
            BeginContext(710, 169, false);
#line 15 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
                                          Write(Html.TextBox("txtTime", @p.time, "{0:yyyy-MM-dd HH:mm:ss}", new { @class = "dateInput", @id = "", @readonly = "true", style = "outline:none; border:none;width:140px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(879, 87, true);
            WriteLiteral("</span>\r\n                            <span>回复了你的文章</span>\r\n                            ");
            EndContext();
            BeginContext(966, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a065a847b9ab4c66992ce700ef946cab", async() => {
                BeginContext(1066, 7, false);
#line 17 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
                                                                                                                          Write(p.title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
                                                                                    WriteLiteral(p.seid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1077, 109, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"opt-box\">\r\n                            ");
            EndContext();
            BeginContext(1186, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "323b1b20226347f3a9c78bc20a152c27", async() => {
                BeginContext(1341, 2, true);
                WriteLiteral("删除");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
                                                                                           WriteLiteral(p.fmid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1347, 947, true);
            WriteLiteral(@"
                        </div>
                        <div style=""clear:both;""></div>
                    </div>
                    <div class=""comment-item-box"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""18"" viewBox=""0 0 32 32"" class=""zuo-icon icon"">
                            <path d=""M14.75 26c0 2.05-1.65 3.7-3.7 3.7H3.7C1.65 29.7 0 28.05 0 26V12.45C0 7.05 4.4 2.6 9.85 2.6h1.25c.65 0 1.25.55 1.25 1.25V6.3c0 .65-.55 1.25-1.25 1.25H9.85c-2.7 0-4.9 2.2-4.9 4.9v.6c0 1 .85 1.85 1.85 1.85h4.3c2.05 0 3.7 1.65 3.7 3.7V26zM32 26c0 2.05-1.65 3.7-3.7 3.7h-7.4c-2.05 0-3.7-1.65-3.7-3.7V12.45c0-5.4 4.4-9.85 9.85-9.85h1.25c.65 0 1.25.55 1.25 1.25V6.3c0 .65-.55 1.25-1.25 1.25h-1.25c-2.7 0-4.9 2.2-4.9 4.9v.6c0 1 .85 1.85 1.85 1.85h4.3c2.05 0 3.7 1.65 3.7 3.7V26z""></path>
                        </svg>
                        <span style=""font-size:15px; height:25px;line-height:25px;"" class=""comment-ue nop"">");
            EndContext();
            BeginContext(2295, 53, false);
#line 28 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
                                                                                                      Write(Html.Raw(System.Net.WebUtility.UrlDecode(@p.comment)));

#line default
#line hidden
            EndContext();
            BeginContext(2348, 755, true);
            WriteLiteral(@"</span>
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""18"" viewBox=""0 0 32 32"" class=""you-icon icon"">
                            <path d=""M14.9 19.6c0 5.4-4.4 9.85-9.85 9.85H3.8c-.65 0-1.25-.55-1.25-1.25v-2.45c0-.65.55-1.25 1.25-1.25h1.25c2.7 0 4.9-2.2 4.9-4.9V19c0-1-.85-1.85-1.85-1.85H3.8c-2.05 0-3.7-1.65-3.7-3.7v-7.4c0-2.05 1.65-3.7 3.7-3.7h7.4c2.05 0 3.7 1.65 3.7 3.7V19.6zm17.2 0c0 5.4-4.4 9.85-9.85 9.85H21c-.65 0-1.25-.55-1.25-1.25v-2.45c0-.65.55-1.25 1.25-1.25h1.25c2.7 0 4.9-2.2 4.9-4.9V19c0-1-.85-1.85-1.85-1.85H21c-2.05 0-3.7-1.65-3.7-3.7v-7.4c0-2.05 1.65-3.7 3.7-3.7h7.4c2.05 0 3.7 1.65 3.7 3.7V19.6z""></path>
                        </svg>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 35 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
        }

#line default
#line hidden
            BeginContext(3114, 58, true);
            WriteLiteral("    </div>\r\n    <div class=\"con1\" style=\"display: none\">\r\n");
            EndContext();
#line 39 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
         foreach (var q in ViewBag.allsmg)
        {

#line default
#line hidden
            BeginContext(3247, 428, true);
            WriteLiteral(@"            <div data-v-46b7af3d="""" class=""comment-list-box"">
                <div class=""comment-item-content"">
                    <div class=""comment-item-title"">
                        <div class=""item-title-left"">
                            <span class=""user-name"" style=""color: rgb(79, 79, 79);"">我</span>
                            <span class=""date"" style=""font-weight: normal;"">
                                ");
            EndContext();
            BeginContext(3676, 169, false);
#line 47 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
                           Write(Html.TextBox("txtTime", @q.time, "{0:yyyy-MM-dd HH:mm:ss}", new { @class = "dateInput", @id = "", @readonly = "true", style = "outline:none; border:none;width:140px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(3845, 175, true);
            WriteLiteral("\r\n                            </span>\r\n                            <span>评论了</span>\r\n                            <span><span class=\"user-name\" style=\"color: rgb(79, 79, 79);\">");
            EndContext();
            BeginContext(4021, 6, false);
#line 50 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
                                                                                     Write(q.name);

#line default
#line hidden
            EndContext();
            BeginContext(4027, 47, true);
            WriteLiteral("</span>的文章</span>\r\n                            ");
            EndContext();
            BeginContext(4074, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8de9f84d09e841ffac27e3bdac1059c6", async() => {
                BeginContext(4173, 7, false);
#line 51 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
                                                                                                                         Write(q.title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
                                                                                    WriteLiteral(q.eid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4184, 109, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"opt-box\">\r\n                            ");
            EndContext();
            BeginContext(4293, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edd3425067554abfb61e6c525fb2b8f9", async() => {
                BeginContext(4447, 2, true);
                WriteLiteral("删除");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
                                                                                           WriteLiteral(q.fid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4453, 776, true);
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""comment-item-box"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""18"" viewBox=""0 0 32 32"" class=""zuo-icon icon""><path d=""M14.75 26c0 2.05-1.65 3.7-3.7 3.7H3.7C1.65 29.7 0 28.05 0 26V12.45C0 7.05 4.4 2.6 9.85 2.6h1.25c.65 0 1.25.55 1.25 1.25V6.3c0 .65-.55 1.25-1.25 1.25H9.85c-2.7 0-4.9 2.2-4.9 4.9v.6c0 1 .85 1.85 1.85 1.85h4.3c2.05 0 3.7 1.65 3.7 3.7V26zM32 26c0 2.05-1.65 3.7-3.7 3.7h-7.4c-2.05 0-3.7-1.65-3.7-3.7V12.45c0-5.4 4.4-9.85 9.85-9.85h1.25c.65 0 1.25.55 1.25 1.25V6.3c0 .65-.55 1.25-1.25 1.25h-1.25c-2.7 0-4.9 2.2-4.9 4.9v.6c0 1 .85 1.85 1.85 1.85h4.3c2.05 0 3.7 1.65 3.7 3.7V26z""></path></svg>
                        <span class=""comment-ue"">");
            EndContext();
            BeginContext(5230, 53, false);
#line 59 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
                                            Write(Html.Raw(System.Net.WebUtility.UrlDecode(@q.comment)));

#line default
#line hidden
            EndContext();
            BeginContext(5283, 699, true);
            WriteLiteral(@"</span>
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""18"" viewBox=""0 0 32 32"" class=""you-icon icon""><path d=""M14.9 19.6c0 5.4-4.4 9.85-9.85 9.85H3.8c-.65 0-1.25-.55-1.25-1.25v-2.45c0-.65.55-1.25 1.25-1.25h1.25c2.7 0 4.9-2.2 4.9-4.9V19c0-1-.85-1.85-1.85-1.85H3.8c-2.05 0-3.7-1.65-3.7-3.7v-7.4c0-2.05 1.65-3.7 3.7-3.7h7.4c2.05 0 3.7 1.65 3.7 3.7V19.6zm17.2 0c0 5.4-4.4 9.85-9.85 9.85H21c-.65 0-1.25-.55-1.25-1.25v-2.45c0-.65.55-1.25 1.25-1.25h1.25c2.7 0 4.9-2.2 4.9-4.9V19c0-1-.85-1.85-1.85-1.85H21c-2.05 0-3.7-1.65-3.7-3.7v-7.4c0-2.05 1.65-3.7 3.7-3.7h7.4c2.05 0 3.7 1.65 3.7 3.7V19.6z""></path></svg>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 64 "F:\bishe\NaturalDisasterDatabaseWebsite\NaturalDisasterDatabaseWebsite\Views\PersonCenter\MyComment.cshtml"
        }

#line default
#line hidden
            BeginContext(5993, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
