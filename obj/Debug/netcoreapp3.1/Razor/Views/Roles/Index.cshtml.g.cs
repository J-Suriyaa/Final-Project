#pragma checksum "C:\Users\J suriyaa\source\repos\WebApplication8\WebApplication8\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea52828f8a9fa32a32d9b2a2f0c6f3c7604dee46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Index), @"mvc.1.0.view", @"/Views/Roles/Index.cshtml")]
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
#line 1 "C:\Users\J suriyaa\source\repos\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\J suriyaa\source\repos\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea52828f8a9fa32a32d9b2a2f0c6f3c7604dee46", @"/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05c75d60125ca1fcf7eaf43fd5d582052ed3e12", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Data.DataTable>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\J suriyaa\source\repos\WebApplication8\WebApplication8\Views\Roles\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered table-striped\">\r\n    <tr>\r\n\r\n        <th>Role name</th>\r\n       \r\n        <th>Role password</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\J suriyaa\source\repos\WebApplication8\WebApplication8\Views\Roles\Index.cshtml"
     for (int i = 0; i < Model.Rows.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 18 "C:\Users\J suriyaa\source\repos\WebApplication8\WebApplication8\Views\Roles\Index.cshtml"
   Write(Model.Rows[i][1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 19 "C:\Users\J suriyaa\source\repos\WebApplication8\WebApplication8\Views\Roles\Index.cshtml"
   Write(Model.Rows[i][2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n   \r\n    <td>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 434, "\"", 496, 1);
#nullable restore
#line 22 "C:\Users\J suriyaa\source\repos\WebApplication8\WebApplication8\Views\Roles\Index.cshtml"
WriteAttributeValue("", 441, Url.Action("Edit","Roles", new {@id=Model.Rows[i][0]}), 441, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 519, "\"", 583, 1);
#nullable restore
#line 23 "C:\Users\J suriyaa\source\repos\WebApplication8\WebApplication8\Views\Roles\Index.cshtml"
WriteAttributeValue("", 526, Url.Action("Delete","Roles", new {@id=Model.Rows[i][0]}), 526, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">| Delete</a>\r\n    </td>\r\n\r\n</tr>\r\n");
#nullable restore
#line 27 "C:\Users\J suriyaa\source\repos\WebApplication8\WebApplication8\Views\Roles\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 642, "\"", 678, 1);
#nullable restore
#line 31 "C:\Users\J suriyaa\source\repos\WebApplication8\WebApplication8\Views\Roles\Index.cshtml"
WriteAttributeValue("", 649, Url.Action("Create","Roles"), 649, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add a Role</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Data.DataTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
