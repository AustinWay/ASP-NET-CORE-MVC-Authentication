#pragma checksum "C:\Users\austinway.BGE\source\repos\ASP NET CORE MVC Authentication\Reach-Core\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cbeb5d96857e8b84672d5e840ec6a49580b9e2b"
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
#line 1 "C:\Users\austinway.BGE\source\repos\ASP NET CORE MVC Authentication\Reach-Core\Views\_ViewImports.cshtml"
using Reach_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\austinway.BGE\source\repos\ASP NET CORE MVC Authentication\Reach-Core\Views\_ViewImports.cshtml"
using Reach_Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\austinway.BGE\source\repos\ASP NET CORE MVC Authentication\Reach-Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\austinway.BGE\source\repos\ASP NET CORE MVC Authentication\Reach-Core\Views\Home\Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cbeb5d96857e8b84672d5e840ec6a49580b9e2b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f394cc6749fec6a441e312b4333e32663cfae40f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\austinway.BGE\source\repos\ASP NET CORE MVC Authentication\Reach-Core\Views\Home\Index.cshtml"
  
    
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\austinway.BGE\source\repos\ASP NET CORE MVC Authentication\Reach-Core\Views\Home\Index.cshtml"
 if(User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Hello, authenticated user!</h1>\r\n    <ul>\r\n");
#nullable restore
#line 16 "C:\Users\austinway.BGE\source\repos\ASP NET CORE MVC Authentication\Reach-Core\Views\Home\Index.cshtml"
         foreach(Claim claim in User.Claims)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 18 "C:\Users\austinway.BGE\source\repos\ASP NET CORE MVC Authentication\Reach-Core\Views\Home\Index.cshtml"
           Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "C:\Users\austinway.BGE\source\repos\ASP NET CORE MVC Authentication\Reach-Core\Views\Home\Index.cshtml"
                         Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "C:\Users\austinway.BGE\source\repos\ASP NET CORE MVC Authentication\Reach-Core\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 21 "C:\Users\austinway.BGE\source\repos\ASP NET CORE MVC Authentication\Reach-Core\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
