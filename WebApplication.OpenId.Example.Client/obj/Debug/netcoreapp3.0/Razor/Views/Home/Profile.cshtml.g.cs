#pragma checksum "/home/pawel/projects/conf/openid-connect/WebApplication.OpenId.Example.Client/Views/Home/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aa684308b47638de0c406dc3d299e6775e1562d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
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
#line 1 "/home/pawel/projects/conf/openid-connect/WebApplication.OpenId.Example.Client/Views/_ViewImports.cshtml"
using WebApplication.OpenId.Example.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/pawel/projects/conf/openid-connect/WebApplication.OpenId.Example.Client/Views/_ViewImports.cshtml"
using WebApplication.OpenId.Example.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/pawel/projects/conf/openid-connect/WebApplication.OpenId.Example.Client/Views/Home/Profile.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa684308b47638de0c406dc3d299e6775e1562d", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64ab3d74878fec084502dfc9c31b6408a0da3b75", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/pawel/projects/conf/openid-connect/WebApplication.OpenId.Example.Client/Views/Home/Profile.cshtml"
  
    ClaimsPrincipal user = Context.User;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h1>Profile Page</h1>\n\n<p>Is Authenticated: ");
#nullable restore
#line 9 "/home/pawel/projects/conf/openid-connect/WebApplication.OpenId.Example.Client/Views/Home/Profile.cshtml"
                Write(user.Identity.IsAuthenticated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<ul>\n");
#nullable restore
#line 12 "/home/pawel/projects/conf/openid-connect/WebApplication.OpenId.Example.Client/Views/Home/Profile.cshtml"
 foreach (var claim in user.Claims)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li><b>");
#nullable restore
#line 14 "/home/pawel/projects/conf/openid-connect/WebApplication.OpenId.Example.Client/Views/Home/Profile.cshtml"
      Write(claim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\n");
#nullable restore
#line 15 "/home/pawel/projects/conf/openid-connect/WebApplication.OpenId.Example.Client/Views/Home/Profile.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n");
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