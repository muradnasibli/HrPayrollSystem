#pragma checksum "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7f7be314c9d40cfae92e5e3ee0f2bacd40b628d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendance_Index), @"mvc.1.0.view", @"/Views/Attendance/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Attendance/Index.cshtml", typeof(AspNetCore.Views_Attendance_Index))]
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
#line 1 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\_ViewImports.cshtml"
using HrPayrollSystemFinal;

#line default
#line hidden
#line 2 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\_ViewImports.cshtml"
using HrPayrollSystemFinal.Models;

#line default
#line hidden
#line 3 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\_ViewImports.cshtml"
using HrPayrollSystemFinal.Viewmodels;

#line default
#line hidden
#line 4 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\_ViewImports.cshtml"
using HrPayrollSystemFinal.Models.Enums;

#line default
#line hidden
#line 6 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\_ViewImports.cshtml"
using HrPayrollSystemFinal.Utilities;

#line default
#line hidden
#line 7 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\_ViewImports.cshtml"
using HrPayrollSystemFinal.ViewComponents;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7f7be314c9d40cfae92e5e3ee0f2bacd40b628d", @"/Views/Attendance/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7e33ea1fe9a0240e9f3d1f67c2cb0b4b08a0c52", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendance_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Continuity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary confirm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "WorkerAttendance", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\Index.cshtml"
  
    ViewData["Title"] = "Davamiyyət";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 40, true);
            WriteLiteral("\r\n<h2>Davamiyyət cədvəli</h2>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(167, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26331c93daad43d1b3943886c0b6784d", async() => {
                BeginContext(187, 8, true);
                WriteLiteral("Əlavə et");
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
            BeginContext(199, 636, true);
            WriteLiteral(@"
</p>
<div>
    <div class=""card shadow mb-4"">
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Işçinin A.S.A</th>
                            <th>Tarix </th>
                            <th>Səbəb növü</th>
                            <th>Davamiyyət</th>
                            <th>Hansı səbəbə</th>
                        </tr>
                    </thead>
                    <tbody id=""myTable"">

");
            EndContext();
#line 28 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(916, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1025, 16, false);
#line 32 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\Index.cshtml"
                               Write(item.Worker.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1041, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1080, 19, false);
#line 33 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\Index.cshtml"
                               Write(item.Worker.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(1099, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1138, 22, false);
#line 34 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\Index.cshtml"
                               Write(item.Worker.FatherName);

#line default
#line hidden
            EndContext();
            BeginContext(1160, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1276, 39, false);
#line 37 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1431, 11, false);
#line 40 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\Index.cshtml"
                               Write(item.Reason);

#line default
#line hidden
            EndContext();
            BeginContext(1442, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1558, 11, false);
#line 43 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\Index.cshtml"
                               Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1569, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1685, 15, false);
#line 46 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\Index.cshtml"
                               Write(item.ReasonName);

#line default
#line hidden
            EndContext();
            BeginContext(1700, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1815, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b3165348e8340f7a6226388335b4a91", async() => {
                BeginContext(1911, 19, true);
                WriteLiteral("Qaib limitini yoxla");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\Index.cshtml"
                                                                                                       WriteLiteral(item.Worker.Id);

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
            BeginContext(1934, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2037, 110, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Continuity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
