#pragma checksum "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\Account\AddUserToRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b77acabe3cdd81399b1490fa11c223976b82e33a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AddUserToRole), @"mvc.1.0.view", @"/Views/Account/AddUserToRole.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b77acabe3cdd81399b1490fa11c223976b82e33a", @"/Views/Account/AddUserToRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d461ded6e09098db95a073556a8220bd028415f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_AddUserToRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cinema.Domain.DomainModels.AddToRoleModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Add user with this email to a role:</h2>\n");
#nullable restore
#line 4 "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\Account\AddUserToRole.cshtml"
 using (Html.BeginForm("AddUserToRole", "Account"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 7 "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\Account\AddUserToRole.cshtml"
   Write(Html.LabelFor(z => z.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 8 "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\Account\AddUserToRole.cshtml"
   Write(Html.TextBoxFor(z => z.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"form-group\">\n        <p>Roles</p>\n        ");
#nullable restore
#line 12 "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\Account\AddUserToRole.cshtml"
   Write(Html.DropDownListFor(z => z.SelectedRole, new SelectList(Model.Roles), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    </div>\n    <div class=\"form-group\">\n        <button type=\"submit\" class=\"btn btn-success\">Save</button>\n    </div>\n");
#nullable restore
#line 18 "C:\Users\STUDENT\Documents\IS\IS_Cinema-main\IS_Cinema-main\Cinema.Web\Views\Account\AddUserToRole.cshtml"
    
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cinema.Domain.DomainModels.AddToRoleModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591