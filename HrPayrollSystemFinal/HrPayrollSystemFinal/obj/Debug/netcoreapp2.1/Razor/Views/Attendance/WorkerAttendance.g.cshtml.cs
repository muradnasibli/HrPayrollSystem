#pragma checksum "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93984b9eaab0ebb85507969523c0c02ea857841e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendance_WorkerAttendance), @"mvc.1.0.view", @"/Views/Attendance/WorkerAttendance.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Attendance/WorkerAttendance.cshtml", typeof(AspNetCore.Views_Attendance_WorkerAttendance))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93984b9eaab0ebb85507969523c0c02ea857841e", @"/Views/Attendance/WorkerAttendance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7e33ea1fe9a0240e9f3d1f67c2cb0b4b08a0c52", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendance_WorkerAttendance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HrPayrollSystemFinal.Models.Continuity>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
  
    ViewData["Title"] = "İşçi davamiyyəti";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(161, 40, true);
            WriteLiteral("\r\n<h2>WorkerAttendance</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(201, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bc4af7d643c40b29e32bc7a921e319e", async() => {
                BeginContext(224, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(238, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(331, 42, false);
#line 17 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
           Write(Html.DisplayNameFor(model => model.Worker));

#line default
#line hidden
            EndContext();
            BeginContext(373, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(429, 40, false);
#line 20 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(469, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(525, 42, false);
#line 23 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(567, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(623, 46, false);
#line 26 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
           Write(Html.DisplayNameFor(model => model.ReasonName));

#line default
#line hidden
            EndContext();
            BeginContext(669, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(725, 42, false);
#line 29 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
           Write(Html.DisplayNameFor(model => model.Reason));

#line default
#line hidden
            EndContext();
            BeginContext(767, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(885, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(934, 46, false);
#line 38 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
           Write(Html.DisplayFor(modelItem => item.Worker.Name));

#line default
#line hidden
            EndContext();
            BeginContext(980, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(999, 49, false);
#line 39 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
           Write(Html.DisplayFor(modelItem => item.Worker.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1067, 52, false);
#line 40 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
           Write(Html.DisplayFor(modelItem => item.Worker.FatherName));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1175, 39, false);
#line 43 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1214, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1270, 41, false);
#line 46 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1367, 45, false);
#line 49 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReasonName));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1468, 41, false);
#line 52 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
           Write(Html.DisplayFor(modelItem => item.Reason));

#line default
#line hidden
            EndContext();
            BeginContext(1509, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1564, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd4db6c64605472397ae238463f82b66", async() => {
                BeginContext(1609, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
                                       WriteLiteral(item.Id);

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
            BeginContext(1617, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1637, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fefacbcbd205405ea3a57482ab38d2d8", async() => {
                BeginContext(1685, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
                                          WriteLiteral(item.Id);

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
            BeginContext(1696, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1716, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91f519eba7d94df193e3e557e45c510e", async() => {
                BeginContext(1763, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
                                         WriteLiteral(item.Id);

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
            BeginContext(1773, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 60 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Attendance\WorkerAttendance.cshtml"
}

#line default
#line hidden
            BeginContext(1812, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HrPayrollSystemFinal.Models.Continuity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
