using AQBlog.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AQBlog.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services
                    .AddScoped<ILocalStorageService, LocalStorageService>()
                    .AddScoped<IHttpService, HttpService>()
                    .AddScoped<IAuthenticationService, AuthenticationService>()
                    .AddScoped<ICategoryService, CategoryService>()
                    .AddScoped<IMasterService, MasterService>()
                    .AddScoped<IBlogService, BlogService>()
                    .AddScoped<IFrontService, FrontService>();

            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            });

            builder.Services.AddMudServices();

            await builder.Build().RunAsync();
        }
    }
}
