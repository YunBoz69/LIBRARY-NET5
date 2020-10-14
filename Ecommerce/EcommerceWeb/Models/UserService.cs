using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using System.Threading;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWeb.Models
{
    public class UserService
    {
        HttpClient _client = new HttpClient();

        public User Connect(String email, String password)
        {
            var address = "http://localhost:49364/api/session";
            var uri = new Uri(address, UriKind.Absolute);
            var objectDataToPost = new User { Email = email, Password = password };

            var response = _client.PostAsJsonAsync(uri, objectDataToPost, CancellationToken.None).Result;
            var jsonString = response.Content.ReadAsStringAsync();

            User connectedUser = JsonConvert.DeserializeObject<User>(jsonString.Result);

            if (response.IsSuccessStatusCode)
            {
                return connectedUser;
            }
            else
            {
                return null;
            }

        }

        public User Create(User user)
        {
            var address = "http://localhost:49364/api/users/";
            var uri = new Uri(address, UriKind.Absolute);
            var response = _client.PostAsJsonAsync(uri, user, CancellationToken.None).Result;
            var jsonString = response.Content.ReadAsStringAsync();

            Console.WriteLine(jsonString);
            Console.WriteLine(response);
            User createdUser = JsonConvert.DeserializeObject<User>(jsonString.Result);

            if (response.IsSuccessStatusCode)
            {
                return createdUser;
            }
            else
            {
                return null;
            }

        }

        public List<User> GetAll()
        {
            var resp = _client.GetAsync("http://localhost:49364/api/users/").Result;
            if (resp.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<List<User>>(resp.Content.ReadAsStringAsync().Result);
            return null;
        }

        public User Update(User user)
        {
            var address = "http://localhost:49364/api/users/";
            var uri = new Uri(address, UriKind.Absolute);
            var response = _client.PutAsJsonAsync(uri, user, CancellationToken.None).Result;

            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<User>(jsonString.Result); ;
            }
            else
            {
                return null;
            }

        }

        public User GetById(int id)
        {

            var response = _client.GetAsync("http://localhost:49364/api/users/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<User>(jsonString.Result);
            }
            else
            {
                return null;
            }

        }

        public bool Delete(int id)
        {
            var address = "http://localhost:49364/api/users/" + id;
            var uri = new Uri(address, UriKind.Absolute);
            var response = _client.DeleteAsync(uri).Result;

            if (response.IsSuccessStatusCode)
                return true;
            else
                return false;
        }



    }
}