using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using EcommerceWeb.Models;
using EcommerceWeb.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EcommerceWeb.Controllers
{
    public class PDFCreaterController : ControllerBase
    {
        private IConverter _converter;

        private readonly CartService _cartService;

        public PDFCreaterController(CartService cartService, IConverter converter)
        {
            _cartService = cartService;
            _converter = converter;
        }

        public IActionResult CreatePDF([FromRoute] int id)
        {

            Cart cart = _cartService.GetCart(id);

            if (Request.Method == "GET") {

                if (HttpContext.Session.GetInt32("connectedUserId") == cart.UserId)
                {
                    JObject jObject = JsonConvert.DeserializeObject<JObject>(cart.OrderInfo);

                    var globalSettings = new GlobalSettings
                    {
                        ColorMode = ColorMode.Color,
                        Orientation = Orientation.Portrait,
                        PaperSize = PaperKind.A4,
                        Margins = new MarginSettings { Top = 10 },
                        DocumentTitle = "PDF Report"
                    };

                    var objectSettings = new ObjectSettings
                    {
                        PagesCount = true,
                        HtmlContent = InvoiceGenerator.CreateInvoice(jObject, cart.CartId),
                        WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "assets", "style.css") },
                        HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                        FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Biblio Livre 2020" }
                    };

                    var pdf = new HtmlToPdfDocument()
                    {
                        GlobalSettings = globalSettings,
                        Objects = { objectSettings }
                    };

                    var file = _converter.Convert(pdf);

                    return File(file, "application/pdf");

                }
                else
                {
                    return BadRequest();
                }
     
            }

            return BadRequest();
        }
    }
}