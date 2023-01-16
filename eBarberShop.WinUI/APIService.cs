using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBarberShop.Models;
using eBarberShop.WinUI.Properties;

namespace eBarberShop.WinUI
{
    public class APIService
    {
        public static string Username = null;
        public static string Password = null;
        public static Korisnik Korisnik = null;
        public string Endpoint = Resources.LocalAPI;
        public string Resource;

        public APIService(string resource)
        {
            Resource = resource;
        }

        public async Task<T> GetAll<T>(object search = null)
        {
            try
            {
                var Query = "";

                if (search != null)
                    Query = await search.ToQueryString();

                var result = await $"{Endpoint}{Resource}?{Query}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

                return result;
            }

            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> Add<T>(object entity)
        {
            try
            {
                var result = await $"{Endpoint}{Resource}".WithBasicAuth(Username, Password).PostJsonAsync(entity).ReceiveJson<T>();

                return result;
            }

            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> Update<T>(int id,object entity)
        {
            try
            {
                var result = await $"{Endpoint}{Resource}/{id}".WithBasicAuth(Username, Password).PutJsonAsync(entity).ReceiveJson<T>();

                return result;
            }

            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> Delete<T>(int id)
        {
            try
            {
                var result = await $"{Endpoint}{Resource}/{id}".WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();

                return result;
            }

            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<Models.Korisnik> AddUloga(int id, object request)
        {
            try
            {
                var result = await $"{Endpoint}{Resource}/{id}/AddUloga".WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<Models.Korisnik>();

                return result;
            }

            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(Models.Korisnik);
            }
        }

        public async Task<Models.Korisnik> DeleteUloga(int id, object request)
        {
            try
            {
                var result = await $"{Endpoint}{Resource}/{id}/DeleteUloga".WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<Models.Korisnik>();

                return result;
            }

            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(Models.Korisnik);
            }
        }

        public async Task<Models.Korisnik> Authenticate()
        {
            try
            {
                var result = await $"{Endpoint}{Resource}/Authenticate".WithBasicAuth(Username, Password).GetJsonAsync<Models.Korisnik>();

                return result;
            }

            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(Models.Korisnik);
            }
        }
    }
}
