#pragma checksum "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b69598754b0cf6c9c452d2dcf1013311ffc1cd27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Order), @"mvc.1.0.view", @"/Views/Cart/Order.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Order.cshtml", typeof(AspNetCore.Views_Cart_Order))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b69598754b0cf6c9c452d2dcf1013311ffc1cd27", @"/Views/Cart/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce78e1d4d77ec10d8cfae6f3836627ebc0f7d5bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EcommerceWeb.Models.Cart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("create_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
            BeginContext(71, 17, true);
            WriteLiteral("\n<h2>Order</h2>\n\n");
            EndContext();
#line 9 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
  
    if (Model.ListCartProducts.Count() == 0)
    {

#line default
#line hidden
            BeginContext(142, 52, true);
            WriteLiteral("        <h2>You can\'t order, you cart is empty</h2>\n");
            EndContext();
#line 13 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(215, 196, true);
            WriteLiteral("        <div class=\"row\">\n            <div class=\"col-lg-12\">\n                <h2>Choose addresses</h2>\n                <hr />\n                <h3>Your billing address</h3>\n                <hr />\n");
            EndContext();
#line 22 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                  
                    int i = 0;
                    User user = (User)ViewData["user"];
                

#line default
#line hidden
            BeginContext(535, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 26 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                 foreach (Address addr in user.ListAddresses as IList<Address>)
                {
                    

#line default
#line hidden
#line 28 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                     if (addr.IsBill)
                    {

#line default
#line hidden
            BeginContext(693, 269, true);
            WriteLiteral(@"                        <dl class=""dl-horizontal"" style=""border-left : solid lightgrey 1px;"">
                            <dt>
                                First name
                            </dt>
                            <dd>
                                ");
            EndContext();
            BeginContext(963, 14, false);
#line 35 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                           Write(addr.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(977, 209, true);
            WriteLiteral("\n                            </dd>\n                            <dt>\n                                Last name\n                            </dt>\n                            <dd>\n                                ");
            EndContext();
            BeginContext(1187, 13, false);
#line 41 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                           Write(addr.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1200, 207, true);
            WriteLiteral("\n                            </dd>\n                            <dt>\n                                Address\n                            </dt>\n                            <dd>\n                                ");
            EndContext();
            BeginContext(1408, 17, false);
#line 47 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                           Write(addr.FirstAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1425, 204, true);
            WriteLiteral("\n                            </dd>\n                            <dt>\n                                City\n                            </dt>\n                            <dd>\n                                ");
            EndContext();
            BeginContext(1630, 9, false);
#line 53 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                           Write(addr.City);

#line default
#line hidden
            EndContext();
            BeginContext(1639, 211, true);
            WriteLiteral("\n                            </dd>\n                            <dt>\n                                Postal Code\n                            </dt>\n                            <dd>\n                                ");
            EndContext();
            BeginContext(1851, 15, false);
#line 59 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                           Write(addr.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(1866, 308, true);
            WriteLiteral(@"

                            </dd>
                            <dd>
                                <div class=""form-group"">
                                    <div class=""checkbox"">
                                        <label>
                                            <input type=""radio"" name=""bill""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2174, "\"", 2197, 1);
#line 66 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
WriteAttributeValue("", 2182, addr.AddressId, 2182, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2198, 200, true);
            WriteLiteral(" />\n                                        </label>\n                                    </div>\n                                </div>\n                            </dd>\n\n                        </dl>\n");
            EndContext();
#line 73 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                        i++;
                        if (i == 0)
                        {

#line default
#line hidden
            BeginContext(2489, 56, true);
            WriteLiteral("                            <h4>No billing address</h4>\n");
            EndContext();
#line 77 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                        }
                    }

#line default
#line hidden
#line 78 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(2611, 20, true);
            WriteLiteral("            </div>\n\n");
            EndContext();
#line 82 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
              
                i = 0;
            

#line default
#line hidden
            BeginContext(2683, 131, true);
            WriteLiteral("            <div class=\"col-lg-12 col-sm-12\" col-xs-12\"\">\n                <h3>Your delivery addresses</h3>\n                <hr />\n\n");
            EndContext();
#line 89 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                 foreach (Address addr in user.ListAddresses as IList<Address>)
                {
                    

#line default
#line hidden
#line 91 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                     if (addr.IsDelivery)
                    {

#line default
#line hidden
            BeginContext(2976, 340, true);
            WriteLiteral(@"                        <div class=""col-lg-6"" style=""border-left : solid lightgrey 1px;"">
                            <dl class=""dl-horizontal"">
                                <dt>
                                    First name
                                </dt>
                                <dd>
                                    ");
            EndContext();
            BeginContext(3317, 14, false);
#line 99 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                               Write(addr.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3331, 233, true);
            WriteLiteral("\n                                </dd>\n                                <dt>\n                                    Last name\n                                </dt>\n                                <dd>\n                                    ");
            EndContext();
            BeginContext(3565, 13, false);
#line 105 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                               Write(addr.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3578, 231, true);
            WriteLiteral("\n                                </dd>\n                                <dt>\n                                    Address\n                                </dt>\n                                <dd>\n                                    ");
            EndContext();
            BeginContext(3810, 17, false);
#line 111 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                               Write(addr.FirstAddress);

#line default
#line hidden
            EndContext();
            BeginContext(3827, 228, true);
            WriteLiteral("\n                                </dd>\n                                <dt>\n                                    City\n                                </dt>\n                                <dd>\n                                    ");
            EndContext();
            BeginContext(4056, 9, false);
#line 117 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                               Write(addr.City);

#line default
#line hidden
            EndContext();
            BeginContext(4065, 235, true);
            WriteLiteral("\n                                </dd>\n                                <dt>\n                                    Postal Code\n                                </dt>\n                                <dd>\n                                    ");
            EndContext();
            BeginContext(4301, 15, false);
#line 123 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                               Write(addr.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(4316, 336, true);
            WriteLiteral(@"

                                </dd>
                                <dd>
                                    <div class=""form-group"">
                                        <div class=""checkbox"">
                                            <label>
                                                <input type=""radio"" name=""delivery""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4652, "\"", 4675, 1);
#line 130 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
WriteAttributeValue("", 4660, addr.AddressId, 4660, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4676, 251, true);
            WriteLiteral(" />\n                                            </label>\n                                        </div>\n                                    </div>\n                                </dd>\n\n                            </dl>\n                        </div>\n");
            EndContext();
#line 138 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                        i++;
                        if (i == 0)
                        {

#line default
#line hidden
            BeginContext(5018, 59, true);
            WriteLiteral("                            <h4>No delivery addresses</h4>\n");
            EndContext();
#line 142 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                        }
                    }

#line default
#line hidden
#line 143 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(5143, 173, true);
            WriteLiteral("            </div>\n        </div>\n        <div class=\"row\">\n            <h2>Payment informations</h2>\n            <hr />\n\n            <div class=\'col-lg-5\'>\n                ");
            EndContext();
            BeginContext(5316, 1796, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4853239f6e1a4e4e80066fb2430bff5d", async() => {
                BeginContext(5322, 1783, true);
                WriteLiteral(@"
                    <div class='form-row'>
                        <div class='col-xs-12 form-group required'>
                            <label class='control-label'>Name on Card</label>
                            <input class='form-control' name=""card_name"" size='4' type='text'>
                        </div>
                    </div>
                    <div class='form-row'>
                        <div class='col-xs-12 form-group card required'>
                            <label class='control-label'>Card Number</label>
                            <input autocomplete='off' name=""card_number"" class='form-control card-number' maxlength='20' type='text'>
                        </div>
                    </div>
                    <div class='form-row'>
                        <div class='col-xs-4 form-group cvc required'>
                            <label class='control-label'>CVC</label>
                            <input autocomplete='off' name=""cvc"" class='form-control card-cvc' placeholder='ex. 3");
                WriteLiteral(@"11' maxlength='3' type='text'>
                        </div>
                        <div class='col-xs-4 form-group expiration required'>
                            <label class='control-label'>Expiration</label>
                            <input class='form-control card-expiry-month' name=""expiration_month"" placeholder='MM' maxlength='2' type='text'>
                        </div>
                        <div class='col-xs-4 form-group expiration required'>
                            <label class='control-label'> </label>
                            <input class='form-control card-expiry-year' name=""expiration_year"" name=""cvc"" placeholder='YY' maxlength='2' type='text'>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7112, 785, true);
            WriteLiteral(@"
            </div>
            <div class=""col-lg-7""></div>
        </div>
        <hr />
        <h2>Summary</h2>
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        Image
                    </th>
                    <th>
                        Product Name
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
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 210 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                 foreach (var item in Model.ListCartProducts)
                {

#line default
#line hidden
            BeginContext(7977, 54, true);
            WriteLiteral("                    <tr>\n                        <td>\n");
            EndContext();
#line 214 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                              var img = item.product.Image == null ? "noimg.png" : item.product.Image;

#line default
#line hidden
            BeginContext(8135, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(8163, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18e10a7721584566b396064776ff25c4", async() => {
                BeginContext(8263, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5934555988df42a78d07633d0ff26c8a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 8273, "~/images/", 8273, 9, true);
#line 215 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
AddHtmlAttributeValue("", 8282, img, 8282, 4, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 215 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
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
            BeginContext(8342, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(8431, 47, false);
#line 218 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                       Write(Html.DisplayFor(modelItem => item.product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(8478, 60, true);
            WriteLiteral("\n                        </td>\n                        <td>\n");
            EndContext();
#line 221 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                              var p = item.product.Price * item.Quantity;

#line default
#line hidden
            BeginContext(8613, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(8642, 1, false);
#line 222 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                       Write(p);

#line default
#line hidden
            EndContext();
            BeginContext(8643, 90, true);
            WriteLiteral(" €\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(8734, 54, false);
#line 225 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                       Write(Html.DisplayFor(modelItem => item.product.Description));

#line default
#line hidden
            EndContext();
            BeginContext(8788, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(8877, 51, false);
#line 228 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                       Write(Html.DisplayFor(modelItem => item.product.Category));

#line default
#line hidden
            EndContext();
            BeginContext(8928, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(9017, 43, false);
#line 231 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(9060, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n");
            EndContext();
#line 234 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
                }

#line default
#line hidden
            BeginContext(9135, 132, true);
            WriteLiteral("            </tbody>\n        </table>\n        <div class=\"row\">\n            <div class=\"col-lg-2 col-lg-offset-10\">\n                ");
            EndContext();
            BeginContext(9267, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c635e1a95a4b43d380a7f99b0dd50e42", async() => {
                BeginContext(9292, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(9313, 139, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d37a02fb8854861a0c226c57d4d4caa", async() => {
                    BeginContext(9427, 16, true);
                    WriteLiteral("Confirm my Order");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9452, 17, true);
                WriteLiteral("\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9476, 35, true);
            WriteLiteral("\n            </div>\n        </div>\n");
            EndContext();
#line 244 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
    }

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(9537, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 247 "C:\Users\ybozkurt\IDVNET\group-777867\Ecommerce\EcommerceWeb\Views\Cart\Order.cshtml"
      await Html.RenderPartialAsync("_ScriptOrder");

#line default
#line hidden
            }
            );
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
