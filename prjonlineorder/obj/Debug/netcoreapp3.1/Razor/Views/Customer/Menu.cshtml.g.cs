#pragma checksum "C:\Users\tracy\source\repos\slnonlineorder\prjonlineorder\Views\Customer\Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "574f2e742b883a6d181056ed6a145c048942c1d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Menu), @"mvc.1.0.view", @"/Views/Customer/Menu.cshtml")]
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
#line 1 "C:\Users\tracy\source\repos\slnonlineorder\prjonlineorder\Views\_ViewImports.cshtml"
using prjonlineorder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tracy\source\repos\slnonlineorder\prjonlineorder\Views\_ViewImports.cshtml"
using prjonlineorder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"574f2e742b883a6d181056ed6a145c048942c1d9", @"/Views/Customer/Menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"328f7c8f49f27479ccc573032d4830eb8defe071", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjonlineorder.Models.TableC>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tracy\source\repos\slnonlineorder\prjonlineorder\Views\Customer\Menu.cshtml"
  
    ViewData["Title"] = "Menu";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>菜單</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\tracy\source\repos\slnonlineorder\prjonlineorder\Views\Customer\Menu.cshtml"
           Write(Html.DisplayNameFor(model => model.TMeal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\tracy\source\repos\slnonlineorder\prjonlineorder\Views\Customer\Menu.cshtml"
           Write(Html.DisplayNameFor(model => model.TPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\tracy\source\repos\slnonlineorder\prjonlineorder\Views\Customer\Menu.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "C:\Users\tracy\source\repos\slnonlineorder\prjonlineorder\Views\Customer\Menu.cshtml"
           Write(Html.DisplayFor(modelItem => item.TMeal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\tracy\source\repos\slnonlineorder\prjonlineorder\Views\Customer\Menu.cshtml"
           Write(Html.DisplayFor(modelItem => item.TPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\tracy\source\repos\slnonlineorder\prjonlineorder\Views\Customer\Menu.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjonlineorder.Models.TableC>> Html { get; private set; }
    }
}
#pragma warning restore 1591
