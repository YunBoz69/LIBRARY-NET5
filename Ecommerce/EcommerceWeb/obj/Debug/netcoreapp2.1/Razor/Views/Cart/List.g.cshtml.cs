#pragma checksum "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d72779e6e578103bb554e7370fef3ec0d3e8844"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_List), @"mvc.1.0.view", @"/Views/Cart/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/List.cshtml", typeof(AspNetCore.Views_Cart_List))]
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
#line 2 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\List.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 3 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\List.cshtml"
using Newtonsoft.Json.Linq;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d72779e6e578103bb554e7370fef3ec0d3e8844", @"/Views/Cart/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce78e1d4d77ec10d8cfae6f3836627ebc0f7d5bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EcommerceWeb.Models.Cart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(98, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(136, 62, true);
            WriteLiteral("    <div class=\"row\">\n        <h2>List of orders</h2>\n        ");
            EndContext();
            BeginContext(198, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9001a975309047b090a894ae1c2b7a4f", async() => {
                BeginContext(242, 14, true);
                WriteLiteral("< Go back Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(260, 205, true);
            WriteLiteral("\n        <table class=\"table\">\n            <thead>\n                <tr>\n                    <th>\n                        Order ID\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(466, 45, false);
#line 18 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\List.cshtml"
                   Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(511, 201, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        Total\n                    </th>\n                    <th></th>\n                </tr>\n            </thead>\n            <tbody>\n");
            EndContext();
#line 27 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\List.cshtml"
                  
                    foreach (var item in Model)
                    {
                        JObject o = JsonConvert.DeserializeObject<JObject>(item.OrderInfo);
                        Address billing = JsonConvert.DeserializeObject<Address>(o.GetValue("billing_addr").ToString());
                        Address delivery = JsonConvert.DeserializeObject<Address>(o.GetValue("delivery_addr").ToString());
                        List<CartProduct> products = JsonConvert.DeserializeObject<List<CartProduct>>(o.GetValue("products").ToString());
                        double total = 0;

#line default
#line hidden
            BeginContext(1317, 94, true);
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1412, 41, false);
#line 37 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\List.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CartId));

#line default
#line hidden
            EndContext();
            BeginContext(1453, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(1554, 44, false);
#line 40 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\List.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1598, 68, true);
            WriteLiteral("\n                            </td>\n                            <td>\n");
            EndContext();
#line 43 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\List.cshtml"
                                 foreach (CartProduct cp in products)
                                {
                                    total += (double)cp.product.Price * cp.Quantity;
                                }

#line default
#line hidden
            BeginContext(1889, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1922, 5, false);
#line 47 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\List.cshtml"
                           Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(1927, 102, true);
            WriteLiteral(" €\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(2030, 63, false);
#line 50 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\List.cshtml"
                           Write(Html.ActionLink("Details", "Details", new { id = item.CartId }));

#line default
#line hidden
            EndContext();
            BeginContext(2093, 65, true);
            WriteLiteral("\n                            </td>\n                        </tr>\n");
            EndContext();
#line 53 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\List.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2198, 48, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EcommerceWeb.Models.Cart>> Html { get; private set; }
    }
}
#pragma warning restore 1591
