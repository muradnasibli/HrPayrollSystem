#pragma checksum "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "087ab06aa51dd0066f5c9221244a37f86255cc7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payroll_PaidSalaries), @"mvc.1.0.view", @"/Views/Payroll/PaidSalaries.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Payroll/PaidSalaries.cshtml", typeof(AspNetCore.Views_Payroll_PaidSalaries))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"087ab06aa51dd0066f5c9221244a37f86255cc7a", @"/Views/Payroll/PaidSalaries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7e33ea1fe9a0240e9f3d1f67c2cb0b4b08a0c52", @"/Views/_ViewImports.cshtml")]
    public class Views_Payroll_PaidSalaries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HrPayrollSystemFinal.Models.Payroll>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "enteredMonth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Payroll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml"
  
    ViewData["Title"] = "Ödənilmiş maaşlar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(159, 512, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c83b60a7810840d4a8ff0aa62245c474", async() => {
                BeginContext(222, 85, true);
                WriteLiteral("\r\n    <div class=\"form-row\">\r\n        <div class=\"form-group col-md-2\">\r\n            ");
                EndContext();
                BeginContext(307, 180, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee33bb1c84f24529a305abea31563011", async() => {
                    BeginContext(400, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(418, 46, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4e8c1be0c3a418286c8f28e3817f57b", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(464, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 10 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<Month>();

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(487, 177, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group col-md-3\">\r\n            <input type=\"submit\" value=\"Axtarış et\" class=\"btn btn-outline-primary\" />\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(671, 1190, true);
            WriteLiteral(@"
<h2>Maaş almış işçilər</h2>
<div class=""card shadow mb-4"">
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>
                            İşçinin A.S.A
                        </th>
                        <th>
                            Vəzifə
                        </th>
                        <th>
                            Gəlmədiyi günlərin sayı
                        </th>
                        <th>
                            Bonus
                        </th>
                        <th>
                            Mağaza Bonus
                        </th>

                        <th>
                            Məzuniyyət bonus
                        </th>

                        <th>
                            Ümumi maaş
                        </th>
                     ");
            WriteLiteral("   <th>\r\n                            Tarix\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody id=\"myTable\">\r\n");
            EndContext();
#line 55 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1934, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2031, 46, false);
#line 59 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Worker.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2077, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2112, 49, false);
#line 60 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Worker.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(2161, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2196, 52, false);
#line 61 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Worker.FatherName));

#line default
#line hidden
            EndContext();
            BeginContext(2248, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2352, 48, false);
#line 64 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Position.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2400, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2504, 52, false);
#line 67 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CountofAbsentDays));

#line default
#line hidden
            EndContext();
            BeginContext(2556, 107, true);
            WriteLiteral(" gün\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2664, 40, false);
#line 70 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Bonus));

#line default
#line hidden
            EndContext();
            BeginContext(2704, 113, true);
            WriteLiteral(" ₼ (AZN)\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2818, 44, false);
#line 74 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ShopBonus));

#line default
#line hidden
            EndContext();
            BeginContext(2862, 113, true);
            WriteLiteral(" ₼ (AZN)\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2976, 48, false);
#line 78 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml"
                           Write(Html.DisplayFor(modelItem => item.VacationBonus));

#line default
#line hidden
            EndContext();
            BeginContext(3024, 113, true);
            WriteLiteral(" ₼ (AZN)\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3138, 46, false);
#line 82 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml"
                           Write(Html.DisplayFor(modelItem => item.TotalSalary));

#line default
#line hidden
            EndContext();
            BeginContext(3184, 111, true);
            WriteLiteral(" ₼ (AZN)\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3296, 53, false);
#line 85 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DateOfPaidSalaries));

#line default
#line hidden
            EndContext();
            BeginContext(3349, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 88 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Payroll\PaidSalaries.cshtml"
                    }

#line default
#line hidden
            BeginContext(3440, 82, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HrPayrollSystemFinal.Models.Payroll>> Html { get; private set; }
    }
}
#pragma warning restore 1591
