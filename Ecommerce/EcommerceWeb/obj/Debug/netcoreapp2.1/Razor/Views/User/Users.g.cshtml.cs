#pragma checksum "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f2b893693095e78c3b53c3164f8fe025e928196"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Users), @"mvc.1.0.view", @"/Views/User/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Users.cshtml", typeof(AspNetCore.Views_User_Users))]
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
#line 1 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\_ViewImports.cshtml"
using EcommerceWeb;

#line default
#line hidden
#line 2 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\_ViewImports.cshtml"
using EcommerceWeb.Models;

#line default
#line hidden
#line 2 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f2b893693095e78c3b53c3164f8fe025e928196", @"/Views/User/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce78e1d4d77ec10d8cfae6f3836627ebc0f7d5bd", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EcommerceWeb.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
            BeginContext(165, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 8 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
  
    string isConnected = @HttpContextAccessor.HttpContext.Session.GetString("connectedUser");
    var connectedUserId= @HttpContextAccessor.HttpContext.Session.GetInt32("connectedUserId");
    var isAdmin = @HttpContextAccessor.HttpContext.Session.GetInt32("isAdmin");

#line default
#line hidden
            BeginContext(440, 37, true);
            WriteLiteral("\n    <h2>Users</h2>\n\n    <p>\n        ");
            EndContext();
            BeginContext(477, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76ee9b2e926f482ca1c4290a7a478561", async() => {
                BeginContext(500, 12, true);
                WriteLiteral("Add New User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(516, 110, true);
            WriteLiteral("\n    </p>\n    <table class=\"table\">\n        <thead>\n            <tr>\n                <th>\n                    ");
            EndContext();
            BeginContext(627, 42, false);
#line 23 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
               Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(669, 64, true);
            WriteLiteral("\n                </th>\n                <th>\n                    ");
            EndContext();
            BeginContext(734, 45, false);
#line 26 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(779, 64, true);
            WriteLiteral("\n                </th>\n                <th>\n                    ");
            EndContext();
            BeginContext(844, 44, false);
#line 29 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(888, 64, true);
            WriteLiteral("\n                </th>\n                <th>\n                    ");
            EndContext();
            BeginContext(953, 43, false);
#line 32 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
               Write(Html.DisplayNameFor(model => model.IsAdmin));

#line default
#line hidden
            EndContext();
            BeginContext(996, 64, true);
            WriteLiteral("\n                </th>\n                <th>\n                    ");
            EndContext();
            BeginContext(1061, 41, false);
#line 35 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1102, 100, true);
            WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 41 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
             foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1245, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(1304, 41, false);
#line 44 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(1345, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1410, 44, false);
#line 47 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1454, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1519, 43, false);
#line 50 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 80, true);
            WriteLiteral("\n                </td>\n               \n                <td>\n                    ");
            EndContext();
            BeginContext(1643, 42, false);
#line 54 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsAdmin));

#line default
#line hidden
            EndContext();
            BeginContext(1685, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1750, 40, false);
#line 57 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1790, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1855, 63, false);
#line 60 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
               Write(Html.ActionLink("Details", "Profile", new { id = item.UserId }));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 4, true);
            WriteLiteral(" |\n\n");
            EndContext();
#line 62 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
                     if (item.IsAdmin && item.UserId == connectedUserId){
                    

#line default
#line hidden
            BeginContext(2017, 57, false);
#line 63 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.UserId }));

#line default
#line hidden
            EndContext();
#line 63 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
                                                                              
                    }
                    else{
                    

#line default
#line hidden
            BeginContext(2144, 61, false);
#line 66 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.UserId }));

#line default
#line hidden
            EndContext();
#line 66 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
                                                                                  
                    }

#line default
#line hidden
            BeginContext(2228, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 71 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\User\Users.cshtml"
}

#line default
#line hidden
            BeginContext(2271, 30, true);
            WriteLiteral("        </tbody>\n    </table>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EcommerceWeb.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
