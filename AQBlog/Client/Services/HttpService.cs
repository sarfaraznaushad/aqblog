using AQBlog.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AQBlog.Client.Services
{
    public class HttpService : IHttpService
    {
        private HttpClient httpClient;
        private NavigationManager navigationManager;
        private ILocalStorageService localStorageService;
        private IConfiguration configuration;
        public HttpService(
            HttpClient httpClient,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService,
            IConfiguration configuration
            )
        {
            this.httpClient = httpClient;
            this.navigationManager = navigationManager;
            this.localStorageService = localStorageService;
            this.configuration = configuration;
        }
       

        public async Task<T> Get<T>(string uri)
        {
            var req = new HttpRequestMessage(HttpMethod.Get, uri);
            return await SendRequest<T>(req);
        }

        public async Task<T> Post<T>(string uri, object value)
        {
            var req = new HttpRequestMessage(HttpMethod.Post, uri);
            req.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            return await SendRequest<T>(req);
        }

        private async Task<T> SendRequest<T>(HttpRequestMessage req)
        {
            var user = await localStorageService.GetItem<AuthResponseMetaData>("TOKEN");
           // var isApiUrl = !req.RequestUri.IsAbsoluteUri;

            if (user != null)
            {
                req.Headers.Authorization = new AuthenticationHeaderValue("Bearer", user.Token);
            }
                

            var resp = await httpClient.SendAsync(req);

            if(resp.StatusCode == HttpStatusCode.Unauthorized)
            {
                navigationManager.NavigateTo("logout");
                return default;
            }

            if (!resp.IsSuccessStatusCode)
            {
                var err = await resp.Content.ReadFromJsonAsync<Dictionary<string, string>>();
                throw new Exception(err["message"]);
            }
            return await resp.Content.ReadFromJsonAsync<T>();
        }
    }

    public interface IHttpService
    {
        Task<T> Get<T>(string uri);
        Task<T> Post<T>(string uri, object value);
    }
}
