using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading;

namespace EcommerceWeb.Models
{
    public class ProductService

    {
        HttpClient _client = new HttpClient();

        public Product Get(int id)
        {
            var resp = _client.GetAsync("http://localhost:49364/api/products/" + id).Result;

            if (resp.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<Product>(resp.Content.ReadAsStringAsync().Result);
            return null;

        }

        public List<Product> GetProductsByRange(int skip, int nb)
        {
            var resp = _client.GetAsync("http://localhost:49364/api/products/" + skip + "/" + nb).Result;
            if (resp.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<List<Product>>(resp.Content.ReadAsStringAsync().Result);
            return null;
        }

        public List<string> GetCategories()
        {
            var resp = _client.GetAsync("http://localhost:49364/api/products/categories/").Result;
            if (resp.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<List<string>>(resp.Content.ReadAsStringAsync().Result);
            return null;
        }

        /*public List<Product> GetAll()
        {
            var resp = _client.GetAsync("http://localhost:49364/api/products/").Result;
            if (resp.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<List<Product>>(resp.Content.ReadAsStringAsync().Result);
            return null;
        }*/

        public List<Product> GetAll(int skip, int nb)
        {
            var resp = _client.GetAsync("http://localhost:49364/api/products/"+skip+"/"+nb).Result;
            if (resp.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<List<Product>>(resp.Content.ReadAsStringAsync().Result);
            return null;
        }

        public Product CreateProduct(Product product)
        {
            var address = "http://localhost:49364/api/products/";
            var uri = new Uri(address, UriKind.Absolute);
            var response = _client.PostAsJsonAsync(uri, product, CancellationToken.None).Result;

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<Product>(response.Content.ReadAsStringAsync().Result);
            else
                return null;
        }

        public Product EditProduct(Product p)
        {
            var address = "http://localhost:49364/api/products/";
            var uri = new Uri(address, UriKind.Absolute);
            var response = _client.PutAsJsonAsync(uri, p, CancellationToken.None).Result;

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<Product>(response.Content.ReadAsStringAsync().Result);
            else
                return null;
        }

        public bool DeleteProduct(int id)
        {
            var address = "http://localhost:49364/api/products/" + id;
            var uri = new Uri(address, UriKind.Absolute);
            var response = _client.DeleteAsync(uri).Result;

            if (response.IsSuccessStatusCode)
                return true;
            else
                return false;
        }
    }
}
