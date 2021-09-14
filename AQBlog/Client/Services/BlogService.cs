using AQBlog.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AQBlog.Client.Services
{
    public class BlogService : IBlogService
    {
        private IHttpService httpService;
        private ILocalStorageService localStorageService;
        private NavigationManager navigationManager;
        public BlogService(
            IHttpService httpService,
             ILocalStorageService localStorageService,
             NavigationManager navigationManager)
        {
            this.httpService = httpService;
            this.localStorageService = localStorageService;
            this.navigationManager = navigationManager;
        }
        public async Task AddBlog(AddBlogMetaData blog)
        {
            await this.httpService.Post<AddMasterMetaData>("blog/AcAddBlog", blog);
        }


        public async Task<EditBlogMetaData> GetBlogById(string id)
        {
            return await this.httpService.Get<EditBlogMetaData>("blog/FnGetBlogById?blogId=" + id);
        }

        public async Task<List<MangeBlogMetaData>> GetBlog()
        {
            return await this.httpService.Get<List<MangeBlogMetaData>>("blog/FnManageBlog");
        }

        public async Task Published(string id)
        {
            await this.httpService.Post<AddMasterMetaData>("blog/PublishedBlog", id);
        }
    }

    public interface IBlogService
    {
        Task AddBlog(AddBlogMetaData blog);
        Task<List<MangeBlogMetaData>> GetBlog();
        Task<EditBlogMetaData> GetBlogById(string id);
        Task Published(string id);
    }
}
