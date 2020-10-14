using EcommerceWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWeb.Utils
{
    public class InvoiceGenerator
    {
        public InvoiceGenerator()
        {

        }

        public static string CreateInvoice(JObject jObject, int cartNo)
        {
            Address billing = JsonConvert.DeserializeObject<Address>(jObject.GetValue("billing_addr").ToString());

            List<CartProduct> cartProducts = JsonConvert.DeserializeObject<List<CartProduct>>(jObject.GetValue("products").ToString());
            double totalGlobal = 0;

            var sb = new StringBuilder();

            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <header>
                                    <div style='text-align:right;'>
                                    <div>BiblioLivre 2020</div>
                                    </div>
                                    <div id='project'>");
            sb.AppendFormat(@"<div><span> CLIENT : {0}  {1} </span></div>
                                 <div><span> ADDRESS : {2}, {3}</span></div>", 
                                 @billing.FirstName.ToString(), @billing.LastName.ToString(), @billing.FirstAddress.ToString(), @billing.City.ToString());

            sb.Append(@"</div>
                            </div>
                               <p>
                               </p>
                               </header>
                                <div class='header'>");

            sb.AppendFormat(@"<h1>Invoice No. {0}</h1></div>", @cartNo.ToString());

            sb.Append(@"<table align='center'>
                            <tr>
                                <th>Product</th>
                                <th>Qty</th>
                                <th>Price</th>
                                <th>Total</th>
                            </tr>");
            foreach (CartProduct cartProduct in cartProducts)
            {
                double total = 0;
                total = (double)cartProduct.product.Price * cartProduct.Quantity;
                totalGlobal += (double)cartProduct.product.Price * cartProduct.Quantity;
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                  </tr>", cartProduct.product.Name, cartProduct.Quantity + " pcs", cartProduct.product.Price + " €", total + " €");
            }
            sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                  </tr>","", "", "", totalGlobal.ToString() + " €");

            sb.AppendFormat(@"
                                </table>
                                </div>
                                 <div style='text-align:right; margin-right:120px; margin-top: 120px; font-size: 20px;'>
                                    <div>Total : {0}</div>", totalGlobal.ToString() +
                                 " €</div>");
            sb.Append(@"</body>
                        </html>");

            return sb.ToString();
        }
    }
}
