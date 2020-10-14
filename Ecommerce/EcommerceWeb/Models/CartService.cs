using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EcommerceWeb.Models
{
    public class CartService
    {
        private HttpClient _client = new HttpClient();

        public Cart GetCartProducts(int id)
        {
            var resp = _client.GetAsync("http://localhost:49364/api/carts/" + id).Result;

            if (resp.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<Cart>(resp.Content.ReadAsStringAsync().Result);
            return null;
        }

        public Cart GetCart(int id)
        {
            var resp = _client.GetAsync("http://localhost:49364/api/carts/cart/" + id).Result;

            if (resp.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<Cart>(resp.Content.ReadAsStringAsync().Result);
            return null;
        }

        public List<Cart> GetCartsByUser(int id)
        {
            var resp = _client.GetAsync("http://localhost:49364/api/carts/carts/" + id).Result;

            if (resp.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<List<Cart>>(resp.Content.ReadAsStringAsync().Result);
            return null;
        }

        public Cart Order(int id, Object o)
        {
            var address = "http://localhost:49364/api/carts/order/" + id;
            var uri = new Uri(address, UriKind.Absolute);
            var response = _client.PostAsJsonAsync(uri, o, CancellationToken.None).Result;

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<Cart>(response.Content.ReadAsStringAsync().Result);
            return null;
        }

        internal Cart AddProductToCart(int id, int userId)
        {
            var address = "http://localhost:49364/api/carts/addproduct/";
            var uri = new Uri(address, UriKind.Absolute);
            var response = _client.PostAsJsonAsync(uri, new { productData = new { productId = id }, userData = new { userId = userId } }, CancellationToken.None).Result;

            if (response.IsSuccessStatusCode)
                return null;
            return null;
        }

        internal Cart RemoveProductToCart(int id, int userId)
        {
            var address = "http://localhost:49364/api/carts/removeproduct/";
            var uri = new Uri(address, UriKind.Absolute);
            var response = _client.PostAsJsonAsync(uri, new { productData = new { productId = id }, userData = new { userId = userId } }, CancellationToken.None).Result;

            if (response.IsSuccessStatusCode)
                return null;
            return null;
        }
    }
}

 
