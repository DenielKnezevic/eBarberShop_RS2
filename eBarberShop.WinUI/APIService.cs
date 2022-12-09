using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBarberShop.Models;

namespace eBarberShop.WinUI
{
    public class APIService
    {
        public static string Username = null;
        public static string Password = null;
        public string Endpoint = "https://localhost:44379/api/";
        public string Resource;

        public APIService(string resource)
        {
            Resource = resource;
        }

        public async Task<T> GetAll<T>(object search = null)
        {
            var Query = "";

            if (search != null)
                Query = await search.ToQueryString();

            var result = await $"{Endpoint}{Resource}?{Query}".GetJsonAsync<T>();

            return result;
        }
    }
}
