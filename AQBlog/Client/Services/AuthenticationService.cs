using AQBlog.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AQBlog.Client.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private IHttpService httpService;
        private ILocalStorageService localStorageService;
        private NavigationManager navigationManager;
        public AuthResponseMetaData Token { get; private set; }
        public AuthenticationService(
            IHttpService httpService,
            ILocalStorageService localStorageService,
            NavigationManager navigationManager)
        {
            this.httpService = httpService;
            this.localStorageService = localStorageService;
            this.navigationManager = navigationManager;
        }

        public async Task Login(string userName, string password)
        {
            Token = await httpService.Post<AuthResponseMetaData>("/api/user/LoginUser", new { UserName = userName, Password = password });
            await localStorageService.SetItem("TOKEN", Token);
        }

        public async Task Logout()
        {            
            await localStorageService.RemoveItem("TOKEN");
            navigationManager.NavigateTo("/");
        }
    }

    public interface IAuthenticationService
    {
        Task Login(string userName, string password);
        Task Logout();
    }
}
