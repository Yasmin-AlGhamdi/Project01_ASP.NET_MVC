#pragma checksum "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\Project01_ASP.NET_MVC\FlowerShop\FlowerShop\Views\Home\CustomerReviews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e962687b1a35d88734fa98a1e3c7bb53879f605d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CustomerReviews), @"mvc.1.0.view", @"/Views/Home/CustomerReviews.cshtml")]
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
#line 1 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\Project01_ASP.NET_MVC\FlowerShop\FlowerShop\Views\_ViewImports.cshtml"
using FlowerShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\Project01_ASP.NET_MVC\FlowerShop\FlowerShop\Views\_ViewImports.cshtml"
using FlowerShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e962687b1a35d88734fa98a1e3c7bb53879f605d", @"/Views/Home/CustomerReviews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ce5f4c6cc0c8aec2433ffd7f904d541e015dcc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CustomerReviews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\Project01_ASP.NET_MVC\FlowerShop\FlowerShop\Views\Home\CustomerReviews.cshtml"
  
    ViewData["Title"] = "CustomerReviews";
    var revs = (List<ReviewModel>)ViewData["Review"];
    Layout = "WebLayout";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<center>
    <nav class=""navbar navbar-expand-sm bg-dark navbar-dark"">

        <a class=""navbar-brand"" href=""/Home""><img style=""height:30px; width:30px;"" src=""https://cdn0.iconfinder.com/data/icons/flowers-and-leaves/47/flower_9-512.png"" /></a>

        <ul class=""navbar-nav"">
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Products/Flowers"">Flowers</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Home/Privacy"">Privacy</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" href=""/Home/CustomerReviews"">Customers Reviews</a>
            </li>
        </ul>
    </nav>
</center>

<h1 style=""color: #ff8080; font-family: 'Arial Nova'; font-style: italic;""><center>Customer Reviews </center></h1>

");
#nullable restore
#line 29 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\Project01_ASP.NET_MVC\FlowerShop\FlowerShop\Views\Home\CustomerReviews.cshtml"
 foreach (var review in revs)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <tbody>\r\n        <tr>\r\n            <td>\r\n                <img style=\"height:50px; width:50px;\" src=\"https://icon-library.com/images/anon-icon/anon-icon-6.jpg\" />\r\n            </td>\r\n            <td>\r\n                <b>Username:</b> ");
#nullable restore
#line 38 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\Project01_ASP.NET_MVC\FlowerShop\FlowerShop\Views\Home\CustomerReviews.cshtml"
                            Write(review.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <b>User ID:</b> ");
#nullable restore
#line 41 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\Project01_ASP.NET_MVC\FlowerShop\FlowerShop\Views\Home\CustomerReviews.cshtml"
                           Write(review.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"3\">\r\n                <br />\r\n                <p>");
#nullable restore
#line 47 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\Project01_ASP.NET_MVC\FlowerShop\FlowerShop\Views\Home\CustomerReviews.cshtml"
              Write(review.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </td>
        </tr>

        
    </tbody>
</table>
    <p style=""color: #ff8080;"">
        _____________________________________________________________________________________________________________________________________________________________________________________________
    </p>
");
#nullable restore
#line 57 "C:\Users\Yasmin\Documents\.NET\ASP.NET MVC\Project01_ASP.NET_MVC\FlowerShop\FlowerShop\Views\Home\CustomerReviews.cshtml"
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
