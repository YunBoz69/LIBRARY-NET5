using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace EcommerceWeb.Models
{
    public class AddressService
    {
        private HttpClient _client = new HttpClient();

        internal Address Create([FromBody] Address addr, int userId)
        {
            var address = "http://localhost:49364/api/addresses/"+userId;
            var uri = new Uri(address, UriKind.Absolute);
            var response = _client.PostAsJsonAsync(uri, addr, CancellationToken.None).Result;

            if (response.IsSuccessStatusCode)
                return null;
            else
                return null;
        }

        public bool Delete(int userId, int addressId)
        {
            var resp = _client.DeleteAsync("http://localhost:49364/api/addresses/" + userId + "/" + addressId).Result;

            if (resp.IsSuccessStatusCode)
                return true;
            return false;
        }
    }
}
