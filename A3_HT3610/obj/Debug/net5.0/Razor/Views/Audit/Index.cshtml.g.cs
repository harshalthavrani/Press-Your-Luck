#pragma checksum "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a832a98c5c5d23ed6f76a8bd2985cb1595328183"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Audit_Index), @"mvc.1.0.view", @"/Views/Audit/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\_ViewImports.cshtml"
using A3_HT3610;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\_ViewImports.cshtml"
using A3_HT3610.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a832a98c5c5d23ed6f76a8bd2985cb1595328183", @"/Views/Audit/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d975e8591d591208f2c3a3003c3395d0e7e7dfc", @"/Views/_ViewImports.cshtml")]
    public class Views_Audit_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<A3_HT3610.Models.Audit>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Audit Records</h1>
<ul class=""nav nav-tabs"">
    <li class=""active""><a class=""text-dark"" data-toggle=""tab"" href=""#all"">All</a></li>
    &emsp;
    <li><a class=""text-dark"" data-toggle=""tab"" href=""#cashin"">Cash In</a></li>
    &emsp;
    <li><a class=""text-dark"" data-toggle=""tab"" href=""#cashout"">Cash Out</a></li>
    &emsp;
    <li><a class=""text-dark"" data-toggle=""tab"" href=""#win"">Win</a></li>
    &emsp;
    <li><a class=""text-dark"" data-toggle=""tab"" href=""#lose"">Lose</a></li>
</ul>
<div class=""tab-content"">
    <div id=""all"" class=""tab-pane show fade in active"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 28 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 31 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.PlayerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 34 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.AuditType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 37 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 42 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                 foreach (var t in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 46 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => t.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 49 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => t.PlayerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 52 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => t.AuditType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 55 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => t.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 58 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div id=\"cashin\" class=\"tab-pane fade\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 68 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 71 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.PlayerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 74 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.AuditType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 77 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 82 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                 foreach (var t in Model)
                {
                    if (t.AuditTypeId == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 88 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 91 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.PlayerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 94 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.AuditType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 97 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 100 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    <div id=\"cashout\" class=\"tab-pane fade\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 111 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 114 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.PlayerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 117 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.AuditType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 120 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 125 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                 foreach (var t in Model)
                {
                    if (t.AuditTypeId == 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 131 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 134 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.PlayerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 137 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.AuditType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 140 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 143 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                    }

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div id=\"win\" class=\"tab-pane fade\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 154 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 157 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.PlayerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 160 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.AuditType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 163 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 168 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                 foreach (var t in Model)
                {
                    if (t.AuditTypeId == 3)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 174 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 177 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.PlayerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 180 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.AuditType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 183 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 186 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <div id=\"lose\" class=\"tab-pane fade\">\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 196 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 199 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.PlayerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 202 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.AuditType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 205 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                   Write(Html.DisplayNameFor(t => t.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 210 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                 foreach (var t in Model)
                {
                    if (t.AuditTypeId == 4)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 216 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 219 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.PlayerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 222 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.AuditType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 225 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => t.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 228 "C:\Harshal\CPA\Fall 2021\PROG 2230\A3_HT3610\A3_HT3610\A3_HT3610\Views\Audit\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<A3_HT3610.Models.Audit>> Html { get; private set; }
    }
}
#pragma warning restore 1591
