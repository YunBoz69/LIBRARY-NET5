#pragma checksum "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b89c7376a77a5a39a6bfd20041f1dc8a69fe46f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Details), @"mvc.1.0.view", @"/Views/Cart/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Details.cshtml", typeof(AspNetCore.Views_Cart_Details))]
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
#line 2 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 3 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
using Newtonsoft.Json.Linq;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b89c7376a77a5a39a6bfd20041f1dc8a69fe46f", @"/Views/Cart/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce78e1d4d77ec10d8cfae6f3836627ebc0f7d5bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EcommerceWeb.Models.Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PDFCreater", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePDF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(126, 25, true);
            WriteLiteral("\n<h2>Details</h2>\n<hr />\n");
            EndContext();
#line 11 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
  
    JObject o = JsonConvert.DeserializeObject<JObject>(Model.OrderInfo);
    Address billing = JsonConvert.DeserializeObject<Address>(o.GetValue("billing_addr").ToString());
    Address delivery = JsonConvert.DeserializeObject<Address>(o.GetValue("delivery_addr").ToString());
    List<CartProduct> products = JsonConvert.DeserializeObject<List<CartProduct>>(o.GetValue("products").ToString());
    var cartId = ViewData["cartId"];
    double total = 0;

#line default
#line hidden
            BeginContext(610, 218, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-lg-12 col-sm-12 col-xs-12\">\n        <h2>Payment detail</h2>\n        <div class=\"col-lg-6 col-sm-12 col-lg-offset-6\" style=\"color:black;\" >\n            <p style=\"text-align:right;\">");
            EndContext();
            BeginContext(828, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8766f10487e0472b94943f937840176d", async() => {
                BeginContext(928, 63, true);
                WriteLiteral("Generate invoice <span class=\"glyphicon glyphicon-file\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
                                                                                                             WriteLiteral(cartId.ToString());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(995, 145, true);
            WriteLiteral("</p>\n        </div>\n        <hr />\n        <dl>\n            <dt>\n                Name on card\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(1141, 23, false);
#line 31 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
           Write(o.GetValue("card_name"));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 99, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                Card number\n            </dt>\n            <dd>\n");
            EndContext();
#line 37 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
                  
                    string s = (string)o.GetValue("card_number");
                

#line default
#line hidden
            BeginContext(1366, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1383, 17, false);
#line 40 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
           Write(s.Substring(0, 1));

#line default
#line hidden
            EndContext();
            BeginContext(1400, 127, true);
            WriteLiteral("XXXXXXXXXXXXX\n            </dd>\n            <dt>\n                Expiration\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(1528, 30, false);
#line 46 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
           Write(o.GetValue("expiration_month"));

#line default
#line hidden
            EndContext();
            BeginContext(1558, 19, true);
            WriteLiteral(" /\n                ");
            EndContext();
            BeginContext(1578, 29, false);
#line 47 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
           Write(o.GetValue("expiration_year"));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 294, true);
            WriteLiteral(@"
            </dd>
        </dl>
    </div>
</div>

<div class=""row"">
    <div class=""col-lg-6 col-sm-6 col-xs-12"">
        <h2>Billing Address</h2>
        <hr />
        <dl class=""dl-horizontal"">
            <dt>
                First Name
            </dt>
            <dd>
                ");
            EndContext();
            BeginContext(1902, 17, false);
#line 62 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
           Write(billing.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1919, 113, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                Last Name\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(2033, 16, false);
#line 68 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
           Write(billing.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2049, 111, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                Address\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(2161, 20, false);
#line 74 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
           Write(billing.FirstAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2181, 108, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                City\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(2290, 12, false);
#line 80 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
           Write(billing.City);

#line default
#line hidden
            EndContext();
            BeginContext(2302, 115, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                Postal Code\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(2418, 18, false);
#line 86 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
           Write(billing.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(2436, 269, true);
            WriteLiteral(@"
            </dd>
        </dl>
    </div>
    <div class=""col-lg-6 col-sm-6 col-xs-12"">
        <h2>Delivery Address</h2>
        <hr />
        <dl class=""dl-horizontal"">
            <dt>
                First Name
            </dt>
            <dd>
                ");
            EndContext();
            BeginContext(2706, 18, false);
#line 98 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
           Write(delivery.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2724, 113, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                Last Name\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(2838, 17, false);
#line 104 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
           Write(delivery.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2855, 111, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                Address\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(2967, 21, false);
#line 110 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
           Write(delivery.FirstAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2988, 108, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                City\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(3097, 13, false);
#line 116 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
           Write(delivery.City);

#line default
#line hidden
            EndContext();
            BeginContext(3110, 115, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                Postal Code\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(3226, 19, false);
#line 122 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
           Write(delivery.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(3245, 789, true);
            WriteLiteral(@"
            </dd>
        </dl>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12 col-sm-12 col-xs-12"">
        <h2>Products</h2>
        <hr />
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Image
                    </th>
                    <th>
                        Name
                    </th>
                    <th>
                        Price
                    </th>
                    <th>
                        Description
                    </th>
                    <th>
                        Category
                    </th>
                    <th>
                        Quantity
                    </th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 155 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
                 foreach (CartProduct item in products)
                {
                    total += (double)item.product.Price * item.Quantity;

#line default
#line hidden
            BeginContext(4181, 54, true);
            WriteLiteral("                    <tr>\n                        <td>\n");
            EndContext();
#line 160 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
                              var img = item.product.Image == null ? "noimg.png" : item.product.Image;

#line default
#line hidden
            BeginContext(4339, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(4367, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff477694dd94e2fb155d0779bd65cf2", async() => {
                BeginContext(4467, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86586ca50e0945fd8b315413a28ffcfd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4477, "~/images/", 4477, 9, true);
#line 161 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
AddHtmlAttributeValue("", 4486, img, 4486, 4, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 161 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
                                                                                           WriteLiteral(item.product.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4546, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(4635, 47, false);
#line 164 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4682, 60, true);
            WriteLiteral("\n                        </td>\n                        <td>\n");
            EndContext();
#line 167 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
                              var p = item.product.Price * item.Quantity;

#line default
#line hidden
            BeginContext(4817, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(4846, 1, false);
#line 168 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
                       Write(p);

#line default
#line hidden
            EndContext();
            BeginContext(4847, 90, true);
            WriteLiteral(" €\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(4938, 54, false);
#line 171 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.product.Description));

#line default
#line hidden
            EndContext();
            BeginContext(4992, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(5081, 51, false);
#line 174 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.product.Category));

#line default
#line hidden
            EndContext();
            BeginContext(5132, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(5221, 43, false);
#line 177 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(5264, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n");
            EndContext();
#line 180 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(5339, 114, true);
            WriteLiteral("            </tbody>\n        </table>\n        <div class=\"col-lg-2 col-lg-offset-10\">\n            <b>TOTAL : </b> ");
            EndContext();
            BeginContext(5454, 5, false);
#line 184 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Details.cshtml"
                       Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(5459, 36, true);
            WriteLiteral(" €\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EcommerceWeb.Models.Cart> Html { get; private set; }
    }
}
#pragma warning restore 1591