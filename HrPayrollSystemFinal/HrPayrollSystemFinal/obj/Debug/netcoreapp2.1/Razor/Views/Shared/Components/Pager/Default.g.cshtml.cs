#pragma checksum "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a77dc5ab598a05f397f0866bf30ccd95b95c875b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Pager/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Pager_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77dc5ab598a05f397f0866bf30ccd95b95c875b", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7e33ea1fe9a0240e9f3d1f67c2cb0b4b08a0c52", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HrPayrollSystemFinal.Extensions.PagedResultBase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
  
    var urlTemplate = Url.Action() + "?page={0}";
    var request = ViewContext.HttpContext.Request;
    foreach (var key in request.Query.Keys)
    {
        if (key == "page")
        {
            continue;
        }

        urlTemplate += "&" + key + "=" + request.Query[key];
    }

    var startIndex = Math.Max(Model.CurrentPage - 5, 1);
    var finishIndex = Math.Min(Model.CurrentPage + 5, Model.PageCount);

#line default
#line hidden
            BeginContext(495, 78, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 col-sm-8 items-info\">\r\n         ");
            EndContext();
            BeginContext(574, 20, false);
#line 21 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
    Write(Model.FirstRowOnPage);

#line default
#line hidden
            EndContext();
            BeginContext(594, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(598, 19, false);
#line 21 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
                            Write(Model.LastRowOnPage);

#line default
#line hidden
            EndContext();
            BeginContext(617, 3, true);
            WriteLiteral("  (");
            EndContext();
            BeginContext(621, 14, false);
#line 21 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
                                                   Write(Model.RowCount);

#line default
#line hidden
            EndContext();
            BeginContext(635, 86, true);
            WriteLiteral(" ümumi)\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 col-sm-8 \">\r\n");
            EndContext();
#line 26 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageCount > 1)
        {

#line default
#line hidden
            BeginContext(767, 70, true);
            WriteLiteral("            <ul class=\"pagination pull-right\">\r\n                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 837, "\"", 876, 1);
#line 29 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 844, urlTemplate.Replace("{0}", "1"), 844, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(877, 19, true);
            WriteLiteral(">&laquo;</a></li>\r\n");
            EndContext();
#line 30 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
                 for (var i = startIndex; i <= finishIndex; i++)
                {
                    

#line default
#line hidden
#line 32 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
                     if (i == Model.CurrentPage)
                    {


#line default
#line hidden
            BeginContext(1056, 34, true);
            WriteLiteral("                        <li><span>");
            EndContext();
            BeginContext(1091, 1, false);
#line 35 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1092, 14, true);
            WriteLiteral("</span></li>\r\n");
            EndContext();
#line 36 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
                    }
                    else
                    {


#line default
#line hidden
            BeginContext(1180, 30, true);
            WriteLiteral("                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1210, "\"", 1258, 1);
#line 40 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1217, urlTemplate.Replace("{0}", i.ToString()), 1217, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1259, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1261, 1, false);
#line 40 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
                                                                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1262, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 41 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
                    }

#line default
#line hidden
#line 41 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(1315, 22, true);
            WriteLiteral("                <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1337, "\"", 1399, 1);
#line 43 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1344, urlTemplate.Replace("{0}", Model.PageCount.ToString()), 1344, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1400, 36, true);
            WriteLiteral(">&raquo;</a></li>\r\n            </ul>");
            EndContext();
#line 44 "C:\Users\Murad-PC\Desktop\HrManagementAndPayrollSystem\HrPayrollSystemFinal\HrPayrollSystemFinal\Views\Shared\Components\Pager\Default.cshtml"
                 }

#line default
#line hidden
            BeginContext(1439, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HrPayrollSystemFinal.Extensions.PagedResultBase> Html { get; private set; }
    }
}
#pragma warning restore 1591