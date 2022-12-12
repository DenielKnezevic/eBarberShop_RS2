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
        public static Korisnik Korisnik = null;
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

            var result = await $"{Endpoint}{Resource}?{Query}".WithBasicAuth(Username,Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> Add<T>(object entity)
        {
            var result = await $"{Endpoint}{Resource}".WithBasicAuth(Username, Password).PostJsonAsync(entity).ReceiveJson<T>();

            return result;
        }

        public async Task<T> Update<T>(int id,object entity)
        {
            var result = await $"{Endpoint}{Resource}/{id}".WithBasicAuth(Username, Password).PutJsonAsync(entity).ReceiveJson<T>();

            return result;
        }

        public async Task<Models.Korisnik> Authenticate()
        {
            var result = await $"{Endpoint}{Resource}/Authenticate".WithBasicAuth(Username, Password).GetJsonAsync<Models.Korisnik>();

            return result;
        }
    }
}
