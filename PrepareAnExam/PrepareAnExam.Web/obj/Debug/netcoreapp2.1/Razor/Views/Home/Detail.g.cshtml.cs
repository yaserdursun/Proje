#pragma checksum "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5190114a9addca209c0a6d692a46efba1e22b18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\_ViewImports.cshtml"
using PrepareAnExam.Web;

#line default
#line hidden
#line 2 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\_ViewImports.cshtml"
using PrepareAnExam.Web.Models;

#line default
#line hidden
#line 3 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\_ViewImports.cshtml"
using PrepareAnExam.Web.Models.AccountViewModels;

#line default
#line hidden
#line 4 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\_ViewImports.cshtml"
using PrepareAnExam.Web.Models.HomeViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5190114a9addca209c0a6d692a46efba1e22b18", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80f1629260ee87efa161a69395417b0acf013c74", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrepareAnExam.Web.Models.HomeViewModels.DetailExamViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-1.10.2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
  
    ViewData["Title"] = "Sınav Görüntüleme";

#line default
#line hidden
            BeginContext(243, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(248, 17, false);
#line 8 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(265, 102, true);
            WriteLiteral("</h2>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        <a class=\"list-group-item alert-info\">");
            EndContext();
            BeginContext(368, 16, false);
#line 13 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
                                         Write(ViewBag.RssTitle);

#line default
#line hidden
            EndContext();
            BeginContext(384, 183, true);
            WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(568, 28, false);
#line 23 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
               Write(Html.Raw(ViewBag.RssContent));

#line default
#line hidden
            EndContext();
            BeginContext(596, 70, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n\r\n        ");
            EndContext();
            BeginContext(666, 3672, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b2744d9988d4484ac4fc1839f3365c0", async() => {
                BeginContext(763, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(809, 63, true);
                WriteLiteral("            <div class=\"row form-group \" id=\"panel-question\">\r\n");
                EndContext();
#line 31 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
                 for (var i = 0; i < 4; i++)
                {







#line default
#line hidden
                BeginContext(949, 278, true);
                WriteLiteral(@"                    <div class=""col-md-6 form-group"">

                        <div class=""row form-group col-12 "">
                            <div class=""input-group input-group-lg "">
                                <span class=""input-group-addon"" id=""sizing-addon1"">Soru ");
                EndContext();
                BeginContext(1229, 5, false);
#line 43 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
                                                                                    Write(i + 1);

#line default
#line hidden
                EndContext();
                BeginContext(1235, 41, true);
                WriteLiteral("</span>\r\n                                ");
                EndContext();
                BeginContext(1277, 99, false);
#line 44 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
                           Write(Html.TextBoxFor(x => x.Question[i].Detail, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
                EndContext();
                BeginContext(1376, 113, true);
                WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row \"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1489, "\"", 1504, 2);
                WriteAttributeValue("", 1494, "answers-", 1494, 8, true);
#line 48 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
WriteAttributeValue("", 1502, i, 1502, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1505, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 49 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
                               List<string> a = new List<string>() { "A", "B", "C", "D" };
                            

#line default
#line hidden
                BeginContext(1631, 61, true);
                WriteLiteral("\r\n                           \r\n\r\n                        <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1692, "\"", 1734, 5);
                WriteAttributeValue("", 1700, "panel-answer-", 1700, 13, true);
#line 54 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
WriteAttributeValue("", 1713, i, 1713, 2, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1715, "col-12", 1716, 7, true);
                WriteAttributeValue(" ", 1722, "form-group", 1723, 11, true);
                WriteAttributeValue(" ", 1733, "", 1734, 1, true);
                EndWriteAttribute();
                BeginContext(1735, 35, true);
                WriteLiteral(">\r\n                            <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1770, "\"", 1813, 4);
                WriteAttributeValue("", 1778, "input-group", 1778, 11, true);
                WriteAttributeValue(" ", 1789, "input-group-sm", 1790, 15, true);
                WriteAttributeValue(" ", 1804, "cevap-", 1805, 7, true);
#line 55 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
WriteAttributeValue("", 1811, i, 1811, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1814, 129, true);
                WriteLiteral(">\r\n                                <span class=\"input-group-addon\" id=\"sizing-addon1\">A)</span>\r\n                                ");
                EndContext();
                BeginContext(1944, 118, false);
#line 57 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
                           Write(Html.TextBoxFor(x => x.Question[i].A, new { @class = "form-control", @readonly = "readonly", @required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(2062, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2186, 98, true);
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2284, "\"", 2326, 5);
                WriteAttributeValue("", 2292, "panel-answer-", 2292, 13, true);
#line 62 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
WriteAttributeValue("", 2305, i, 2305, 2, false);

#line default
#line hidden
                WriteAttributeValue(" ", 2307, "col-12", 2308, 7, true);
                WriteAttributeValue(" ", 2314, "form-group", 2315, 11, true);
                WriteAttributeValue(" ", 2325, "", 2326, 1, true);
                EndWriteAttribute();
                BeginContext(2327, 35, true);
                WriteLiteral(">\r\n                            <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2362, "\"", 2405, 4);
                WriteAttributeValue("", 2370, "input-group", 2370, 11, true);
                WriteAttributeValue(" ", 2381, "input-group-sm", 2382, 15, true);
                WriteAttributeValue(" ", 2396, "cevap-", 2397, 7, true);
#line 63 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
WriteAttributeValue("", 2403, i, 2403, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2406, 131, true);
                WriteLiteral(">\r\n\r\n                                <span class=\"input-group-addon\" id=\"sizing-addon1\">B)</span>\r\n                                ");
                EndContext();
                BeginContext(2538, 118, false);
#line 66 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
                           Write(Html.TextBoxFor(x => x.Question[i].B, new { @class = "form-control", @readonly = "readonly", @required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(2656, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2780, 98, true);
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2878, "\"", 2920, 5);
                WriteAttributeValue("", 2886, "panel-answer-", 2886, 13, true);
#line 71 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
WriteAttributeValue("", 2899, i, 2899, 2, false);

#line default
#line hidden
                WriteAttributeValue(" ", 2901, "col-12", 2902, 7, true);
                WriteAttributeValue(" ", 2908, "form-group", 2909, 11, true);
                WriteAttributeValue(" ", 2919, "", 2920, 1, true);
                EndWriteAttribute();
                BeginContext(2921, 35, true);
                WriteLiteral(">\r\n                            <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 2956, "\"", 2999, 4);
                WriteAttributeValue("", 2964, "input-group", 2964, 11, true);
                WriteAttributeValue(" ", 2975, "input-group-sm", 2976, 15, true);
                WriteAttributeValue(" ", 2990, "cevap-", 2991, 7, true);
#line 72 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
WriteAttributeValue("", 2997, i, 2997, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3000, 131, true);
                WriteLiteral(">\r\n\r\n                                <span class=\"input-group-addon\" id=\"sizing-addon1\">C)</span>\r\n                                ");
                EndContext();
                BeginContext(3132, 118, false);
#line 75 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
                           Write(Html.TextBoxFor(x => x.Question[i].C, new { @class = "form-control", @readonly = "readonly", @required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(3250, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(3374, 98, true);
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 3472, "\"", 3514, 5);
                WriteAttributeValue("", 3480, "panel-answer-", 3480, 13, true);
#line 80 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
WriteAttributeValue("", 3493, i, 3493, 2, false);

#line default
#line hidden
                WriteAttributeValue(" ", 3495, "col-12", 3496, 7, true);
                WriteAttributeValue(" ", 3502, "form-group", 3503, 11, true);
                WriteAttributeValue(" ", 3513, "", 3514, 1, true);
                EndWriteAttribute();
                BeginContext(3515, 35, true);
                WriteLiteral(">\r\n                            <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 3550, "\"", 3593, 4);
                WriteAttributeValue("", 3558, "input-group", 3558, 11, true);
                WriteAttributeValue(" ", 3569, "input-group-sm", 3570, 15, true);
                WriteAttributeValue(" ", 3584, "cevap-", 3585, 7, true);
#line 81 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
WriteAttributeValue("", 3591, i, 3591, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3594, 131, true);
                WriteLiteral(">\r\n\r\n                                <span class=\"input-group-addon\" id=\"sizing-addon1\">D)</span>\r\n                                ");
                EndContext();
                BeginContext(3726, 118, false);
#line 84 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
                           Write(Html.TextBoxFor(x => x.Question[i].D, new { @class = "form-control", @readonly = "readonly", @required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(3844, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(3968, 134, true);
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n");
                EndContext();
#line 93 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"



                }

#line default
#line hidden
                BeginContext(4127, 204, true);
                WriteLiteral("            </div>\r\n            <div class=\"row\">\r\n                <button class=\"btn btn-block btn-lg btn-primary \" id=\"btn-complete\" type=\"button\">Sınavı Tamamla</button>\r\n\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("@*action=\"@Url.Action(\"FinishExam\",\"Exam\")\"*@", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4338, 26, true);
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(4364, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81c6d8f172ad43c8ad1fdedc16f6d71d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4415, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4417, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de1928fb734948b9bab30c6c2f6e82f3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4471, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4473, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c516be28ac04879b886e5695393e076", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4527, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4529, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79319959050342369574a7ce78c39091", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4579, 1639, true);
            WriteLiteral(@"
<script>



    function hiddenFalseByID(id) {
        $.each([""0"", ""1"", ""2"", ""3""], function (i, deger) {
            $("".panel-answer-"" + id).find("".cevap-"" + deger).find(""#IsRight-"" + id).val(""false"");
        });
    }
    $.each([""0"", ""1"", ""2"", ""3""], function (i, value) {
        $.each([""0"", ""1"", ""2"", ""3""], function (i, deger) {
            $("".panel-answer-"" + value).find("".cevap-"" + deger).find(""#IsRight-"" + value).val(""false"");

        $("".panel-answer-"" + value).click(function () {
            debugger
            hiddenFalseByID(value);
            $(""#answers-"" + value).find("".grey"").removeClass(""grey"");
            $(this).addClass(""grey"");
            $("".panel-answer-"" + value).find("".cevap-"" + deger).find(""#IsRight-"" + value).val(""false"");




            $(this).find("":hidden"").val(""true"");

            return false;
        });
        });
    });
    $(""#btn-complete"").click(function () {
        if ($(this).text() == ""Sınavı Tamamla"") {
            $(this).");
            WriteLiteral(@"text(""Sınav Bitti - Anasayfa ya dönmek için tıkla"");
            $.each([""0"", ""1"", ""2"", ""3""], function (i, value) {

                $("".panel-answer-"" + value).removeClass(""grey"");

                $.each([""0"", ""1"", ""2"", ""3""], function (k, deger) {
                    debugger
                    var isRight = $("".panel-answer-"" + value).find("".cevap-""+deger).val()
                    var id = $(""#answers-"" + value).find(""#id-""+deger).val();
                    if (isRight==""true"") {

                        $.ajax({

                            type: ""post"",
                            url: '");
            EndContext();
            BeginContext(6219, 33, false);
#line 156 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
                             Write(Url.Action("CheckAnswer", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(6252, 1172, true);
            WriteLiteral(@"',
                            data: { id: id, IsRight:isRight},
                            datatype: ""json"",
                            success: function (data) {
                                if (data != null) {
                                    if (data == ""true"") {
                                        debugger

                                        var isRight = $("".panel-answer-"" + value).find("".cevap-"" + deger).parent().addClass(""green"");

                                    }
                                    if (data == ""false"") {
                                        debugger

                                        var isRight = $("".panel-answer-"" + value).find("".cevap-"" + deger).parent().addClass(""red"");

                                    }

                                }


                            },
                            error: function () {
                                alert(""İşlem Sırasında Hata Oluştu"");
                            }

 ");
            WriteLiteral("                       });\r\n\r\n                    }\r\n\r\n                });\r\n\r\n\r\n            });\r\n\r\n        } else {\r\n            window.location = \'");
            EndContext();
            BeginContext(7425, 27, false);
#line 192 "C:\Users\yaser\Source\Repos\PrepareAnExam\PrepareAnExam.Web\Views\Home\Detail.cshtml"
                          Write(Url.Action("Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(7452, 73, true);
            WriteLiteral("\';\r\n        }\r\n    });\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7543, 235, true);
                WriteLiteral("\r\n    <script>\r\n        $(function () {\r\n\r\n            //$.ajax({\r\n            //    type: \"GET\",\r\n            //    url: \"\",\r\n            //    dataType: \"json\",\r\n            //   //...\r\n            //});\r\n        });\r\n    </script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrepareAnExam.Web.Models.HomeViewModels.DetailExamViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
