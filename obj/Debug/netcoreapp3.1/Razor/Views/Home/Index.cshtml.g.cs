#pragma checksum "C:\Users\J suriyaa\source\repos\WebApplication8\WebApplication8\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e745b623adc1f55a6f8e71c411ca161ff7f7bea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e745b623adc1f55a6f8e71c411ca161ff7f7bea", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05c75d60125ca1fcf7eaf43fd5d582052ed3e12", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\J suriyaa\source\repos\WebApplication8\WebApplication8\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<fieldset>
    <legend>
        Restaurant Billing
    </legend>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""form-group"">
                    Customer Name :
                    <input type=""text"" id=""customer_name"" placeholder=""Full name"" name=""Customer Name"" class=""form-control"" />
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""form-group"">
                    Customer Phone:
                    <input type=""tel"" id=""phone"" name=""phone"" placeholder=""123-456-7890"" pattern=""[0-9]{3}-[0-9]{2}-[0-9]{3}"" class=""form-control"" required>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""form-group"">
                    Food Item:
                    <input type=""text"" id=""food_item"" placeholder=""item name"" name=""Item Name"" cl");
            WriteLiteral(@"ass=""form-control"" />
                </div>
            </div>
        </div>
        <div class=""row"">

        <div class=""col-md-6"">
            <div class=""form-group"">
                Unit Price:
                <input type=""text"" id=""price"" placeholder=""00.00"" pattern=""00.00"" name=""price"" class=""form-control"" />
            </div>
        </div>
            </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""form-group"">
                    Quantity:
                    <input type=""text"" id=""quantity"" placeholder=""0"" pattern=""0"" name=""quantity"" class=""form-control"" />
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""form-group"">
                    Total:
                    <input type=""text"" id=""total"" placeholder=""00.00"" name=""total"" class=""form-control"" />
                </div>
            </div>
        </div>
        <br />
  ");
            WriteLiteral("      <button type=\"button\" onclick=\"alert(\"Order placed!!!\")\">Submit</button>\r\n\r\n    </div>\r\n</fieldset>\r\n\r\n");
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
