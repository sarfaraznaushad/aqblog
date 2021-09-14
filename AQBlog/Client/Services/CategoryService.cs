using AQBlog.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AQBlog.Client.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryMetaData>> GetCategory();
        Task<List<DropdownMetaData>> GetDropdownCategory();
        Task AddCategory(AddCategoryMetaData category);
        Task<AddCategoryMetaData> GetCategoryById(string id);
    }
    public class CategoryService : ICategoryService
    {
        private IHttpService httpService;
        private ILocalStorageService localStorageService;
        private NavigationManager navigationManager;

        public CategoryService(
            IHttpService httpService,
            ILocalStorageService localStorageService,
            NavigationManager navigationManager)
        {
            this.httpService = httpService;
            this.localStorageService = localStorageService;
            this.navigationManager = navigationManager;
        }

        public async Task<List<CategoryMetaData>> GetCategory()
        {
            var categories = await this.httpService.Get<List<CategoryMetaData>>("blog/FnGetCategory");
            return categories;
        }

        public async Task<AddCategoryMetaData> GetCategoryById(string id)
        {
            var categories = await this.httpService.Get<AddCategoryMetaData>("blog/FnGetCategoryById?id="+id);
            return categories;
        }

        public async Task<List<DropdownMetaData>> GetDropdownCategory()
        {
            var categories = await this.httpService.Get<List<DropdownMetaData>>("blog/FnGetCategoryDropdown");
            return categories;
        }

        public async Task AddCategory(AddCategoryMetaData category)
        {
            await this.httpService.Post<AddCategoryMetaData>("blog/AcAddCategory", category);
        }


    }
}
