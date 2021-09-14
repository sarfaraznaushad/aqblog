using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AQBlog.Client.Services
{   
    public class LocalStorageService : ILocalStorageService
    {
        private IJSRuntime jsRunTime;
        public LocalStorageService(IJSRuntime jsRunTime)
        {
            this.jsRunTime = jsRunTime;
        }
        public async Task<T> GetItem<T>(string key)
        {
            var val = await jsRunTime.InvokeAsync<string>("localStorage.getItem", key);
            if (val == null)
                return default;

            return JsonSerializer.Deserialize<T>(val);
        }

        public async Task RemoveItem(string key)
        {
            await jsRunTime.InvokeVoidAsync("localStorage.removeItem", key);
        }

        public async Task SetItem<T>(string key, T value)
        {
            await jsRunTime.InvokeVoidAsync("localStorage.setItem", key, JsonSerializer.Serialize(value));
        }
    }

    public interface ILocalStorageService
    {
        Task<T> GetItem<T>(string key);
        Task SetItem<T>(string key, T value);
        Task RemoveItem(string Key);
    }
}
