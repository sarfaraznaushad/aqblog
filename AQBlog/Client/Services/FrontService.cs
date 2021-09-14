using AQBlog.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AQBlog.Client.Services
{
    public class FrontService : IFrontService
    {
        private IHttpService httpService;
        public FrontService(
            IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<CategoryMetaData>> GetCategory()
        {
            var categories = await this.httpService.Get<List<CategoryMetaData>>("api/front/FnGetCategoryDetail");
            return categories;
        }

        public async Task<List<BlogFrontDetailMetaData>> GetBlog()
        {
            var categories = await this.httpService.Post<List<BlogFrontDetailMetaData>>("api/front/FnGetBlog", "");
            return categories;
        }

        public async Task<BlogFrontViewMetaData> FnGetBlogBySlug(string slug)
        {
            var blog = await this.httpService.Get<BlogFrontViewMetaData>("api/front/FnGetBlogBySlug?slug="+ slug);
            return blog;
        }

        public async Task<BlogRespons> GetBlogs(BlogDetailPagingMetaData blog)
        {
            return await this.httpService.Post<BlogRespons>("api/front/FnGetBlogs", blog);
        }

        public async Task<List<string>> SearchBlog(string search)
        {
            SearchMetaData searchMetaData = new SearchMetaData
            {
                Search = search
            };
            return await this.httpService.Post<List<string>>("api/front/FnSearch", searchMetaData);
        }
    }

    public interface IFrontService
    {
        Task<List<CategoryMetaData>> GetCategory();
        Task<List<BlogFrontDetailMetaData>> GetBlog();
        Task<BlogFrontViewMetaData> FnGetBlogBySlug(string slug);
        Task<BlogRespons> GetBlogs(BlogDetailPagingMetaData blog);

        Task<List<string>> SearchBlog(string search);
    }
}
