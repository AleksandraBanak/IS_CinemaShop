#pragma checksum "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\Order\GetDetailsForTicket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1e633eff42d497efc9a434dc47059e80934c4c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_GetDetailsForTicket), @"mvc.1.0.view", @"/Views/Order/GetDetailsForTicket.cshtml")]
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
#line 1 "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Domain.DomainModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1e633eff42d497efc9a434dc47059e80934c4c0", @"/Views/Order/GetDetailsForTicket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d461ded6e09098db95a073556a8220bd028415f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_GetDetailsForTicket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cinema.Domain.DomainModels.Order>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"container\">\n\n    <p>\n        <a class=\"btn btn-secondary rounded-0\">");
#nullable restore
#line 6 "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\Order\GetDetailsForTicket.cshtml"
                                          Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n    </p>\n\n");
#nullable restore
#line 9 "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\Order\GetDetailsForTicket.cshtml"
     for (int i = 0; i < Model.Tickets.Count(); i++)
    {
        var item = Model.Tickets.ElementAt(i).SelectedTicket;

        if (i % 3 == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("<div class=\"row\">\n");
#nullable restore
#line 16 "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\Order\GetDetailsForTicket.cshtml"
            }


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-3 m-4\">\n                <div class=\"card\" style=\"width: 18rem; height: 10rem;\">\n");
            WriteLiteral("                    <div class=\"card-body\">\n                        <h3>");
#nullable restore
#line 22 "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\Order\GetDetailsForTicket.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                        <p>");
#nullable restore
#line 23 "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\Order\GetDetailsForTicket.cshtml"
                      Write(item.TicketPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" MKD</p>\n                    </div>\n\n                </div>\n            </div>\n");
#nullable restore
#line 28 "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\Order\GetDetailsForTicket.cshtml"

            if (i % 3 == 2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("</div>\n");
#nullable restore
#line 32 "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\Order\GetDetailsForTicket.cshtml"
        }

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cinema.Domain.DomainModels.Order> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
