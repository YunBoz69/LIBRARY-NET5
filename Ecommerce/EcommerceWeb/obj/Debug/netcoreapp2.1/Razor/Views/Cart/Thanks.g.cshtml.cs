#pragma checksum "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1fdc3169410afb6c9316edbf9662d7aa61db1a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Thanks), @"mvc.1.0.view", @"/Views/Cart/Thanks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Thanks.cshtml", typeof(AspNetCore.Views_Cart_Thanks))]
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
#line 2 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 3 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
using Newtonsoft.Json.Linq;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1fdc3169410afb6c9316edbf9662d7aa61db1a5", @"/Views/Cart/Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce78e1d4d77ec10d8cfae6f3836627ebc0f7d5bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EcommerceWeb.Models.Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PDFCreater", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePDF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
  
    ViewData["Title"] = "Thanks";

#line default
#line hidden
            BeginContext(125, 56, true);
            WriteLiteral("\n<h2>Thanks</h2>\n<h3>Here the detail of your order</h3>\n");
            EndContext();
            BeginContext(181, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1324cf90ae534221b4caa76f14fd9797", async() => {
                BeginContext(225, 12, true);
                WriteLiteral("< Go to Home");
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
            BeginContext(241, 8, true);
            WriteLiteral("\n<hr />\n");
            EndContext();
#line 13 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
  
    JObject o = (JObject)ViewData["OrderInfo"];
    Address billing = JsonConvert.DeserializeObject<Address>(o.GetValue("billing_addr").ToString());
    Address delivery = JsonConvert.DeserializeObject<Address>(o.GetValue("delivery_addr").ToString());
    List<CartProduct> products = JsonConvert.DeserializeObject<List<CartProduct>>(o.GetValue("products").ToString());
    var cartId = ViewData["cartId"];
    double total = 0;

#line default
#line hidden
            BeginContext(683, 233, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-lg-12 col-sm-12 col-xs-12\">\n        <h2>Payment detail</h2>\n        <hr />\n        <div class=\"col-lg-6 col-sm-12 col-lg-offset-6\" style=\"color:black;\">\n            <p style=\"text-align:right;\">");
            EndContext();
            BeginContext(916, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e4783d6769c4b628b23d71a76919359", async() => {
                BeginContext(1016, 63, true);
                WriteLiteral("Generate invoice <span class=\"glyphicon glyphicon-file\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
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
            BeginContext(1083, 130, true);
            WriteLiteral("</p>\n        </div>\n        <dl>\n            <dt>\n                Name on card\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(1214, 23, false);
#line 34 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
           Write(o.GetValue("card_name"));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 99, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                Card number\n            </dt>\n            <dd>\n");
            EndContext();
#line 40 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
                  
                    string s = (string)o.GetValue("card_number");
                

#line default
#line hidden
            BeginContext(1439, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1456, 17, false);
#line 43 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
           Write(s.Substring(0, 1));

#line default
#line hidden
            EndContext();
            BeginContext(1473, 127, true);
            WriteLiteral("XXXXXXXXXXXXX\n            </dd>\n            <dt>\n                Expiration\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(1601, 30, false);
#line 49 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
           Write(o.GetValue("expiration_month"));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 19, true);
            WriteLiteral(" /\n                ");
            EndContext();
            BeginContext(1651, 29, false);
#line 50 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
           Write(o.GetValue("expiration_year"));

#line default
#line hidden
            EndContext();
            BeginContext(1680, 294, true);
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
            BeginContext(1975, 17, false);
#line 65 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
           Write(billing.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1992, 113, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                Last Name\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(2106, 16, false);
#line 71 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
           Write(billing.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2122, 111, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                Address\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(2234, 20, false);
#line 77 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
           Write(billing.FirstAddress);

#line default
#line hidden
            EndContext();
            BeginContext(2254, 108, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                City\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(2363, 12, false);
#line 83 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
           Write(billing.City);

#line default
#line hidden
            EndContext();
            BeginContext(2375, 115, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                Postal Code\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(2491, 18, false);
#line 89 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
           Write(billing.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(2509, 269, true);
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
            BeginContext(2779, 18, false);
#line 101 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
           Write(delivery.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2797, 113, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                Last Name\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(2911, 17, false);
#line 107 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
           Write(delivery.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2928, 111, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                Address\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(3040, 21, false);
#line 113 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
           Write(delivery.FirstAddress);

#line default
#line hidden
            EndContext();
            BeginContext(3061, 108, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                City\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(3170, 13, false);
#line 119 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
           Write(delivery.City);

#line default
#line hidden
            EndContext();
            BeginContext(3183, 115, true);
            WriteLiteral("\n            </dd>\n            <dt>\n                Postal Code\n            </dt>\n            <dd>\n                ");
            EndContext();
            BeginContext(3299, 19, false);
#line 125 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
           Write(delivery.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(3318, 789, true);
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
#line 158 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
                 foreach (CartProduct item in products)
                {
                    total += (double)item.product.Price * item.Quantity;


#line default
#line hidden
            BeginContext(4255, 54, true);
            WriteLiteral("                    <tr>\n                        <td>\n");
            EndContext();
#line 164 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
                              var img = item.product.Image == null ? "noimg.png" : item.product.Image;

#line default
#line hidden
            BeginContext(4413, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(4441, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9969851ac47948649855c2d5988044b8", async() => {
                BeginContext(4541, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "87dfa3aa34ae464785fca9b315e7e634", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4551, "~/images/", 4551, 9, true);
#line 165 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
AddHtmlAttributeValue("", 4560, img, 4560, 4, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 165 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
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
            BeginContext(4620, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(4709, 47, false);
#line 168 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
                       Write(Html.DisplayFor(modelItem => item.product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4756, 60, true);
            WriteLiteral("\n                        </td>\n                        <td>\n");
            EndContext();
#line 171 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
                              var p = item.product.Price * item.Quantity;

#line default
#line hidden
            BeginContext(4891, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(4920, 1, false);
#line 172 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
                       Write(p);

#line default
#line hidden
            EndContext();
            BeginContext(4921, 90, true);
            WriteLiteral(" €\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(5012, 54, false);
#line 175 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
                       Write(Html.DisplayFor(modelItem => item.product.Description));

#line default
#line hidden
            EndContext();
            BeginContext(5066, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(5155, 51, false);
#line 178 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
                       Write(Html.DisplayFor(modelItem => item.product.Category));

#line default
#line hidden
            EndContext();
            BeginContext(5206, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(5295, 43, false);
#line 181 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(5338, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n");
            EndContext();
#line 184 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
                }

#line default
#line hidden
            BeginContext(5413, 114, true);
            WriteLiteral("            </tbody>\n        </table>\n        <div class=\"col-lg-2 col-lg-offset-10\">\n            <b>TOTAL : </b> ");
            EndContext();
            BeginContext(5528, 5, false);
#line 188 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Thanks.cshtml"
                       Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(5533, 37, true);
            WriteLiteral(" €\n        </div>\n    </div>\n </div>\n");
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
