using AQBlog.Domain.Abstract;
using AQBlog.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AQBlog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrontController : ControllerBase
    {
        private ICategoryRepository categoryRepo;
        private IBlogDetailRepository blogDetailRepo;
        private IMasterDetailRepository masterRepo;
        public FrontController(
            ICategoryRepository categoryRepo,
            IBlogDetailRepository blogDetailRepo,
            IMasterDetailRepository masterRepo
            )
        {
            this.blogDetailRepo = blogDetailRepo;
            this.categoryRepo = categoryRepo;
            this.masterRepo = masterRepo;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> FnGetCategoryDetail()
        {
            var category = await Task.Run(() => this.categoryRepo.FindByFilterDefinition(x => x.IsDeleted == false)
                            .Select(z => new CategoryMetaData()
                            {
                                CategoryName = z.Title,
                                Description = z.Description,
                                Icon = z.Icon,
                                Slug = z.UrlSlug,
                                Id = z.Id
                            }).ToList());
            return Ok(category);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> FnGetBlog()
        {
            var blogs = await Task.Run(() => this.blogDetailRepo.Table.Where(x => x.IsDeleted == false
                            && x.IsPublished == true)
                            .Select(z => new BlogFrontDetailMetaData()
                            {
                                Id = z.Id,
                                Title = z.Title,
                                Subject = z.Subject,
                                PublishDate = z.ModifiedOn,
                                Slug = z.UrlSlug
                            })
                            .OrderByDescending(y => y.PublishDate)
                            .ToList());
            return Ok(blogs);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> FnGetBlogBySlug(string slug)
        {
            var blogs = await Task.Run(() => this.blogDetailRepo.Table.Where(x => x.IsDeleted == false
                         && x.UrlSlug == slug )
                            .Select(z => new BlogFrontViewMetaData()
                            {
                                Id = z.Id,
                                Title = z.Title,
                                Subject = z.Subject,
                                PublishDate = z.ModifiedOn,
                                Slug = z.UrlSlug,
                                Description = z.Description
                            })
                            .OrderByDescending(y => y.PublishDate)
                            .FirstOrDefault());
            return Ok(blogs);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> FnGetBlogs(BlogDetailPagingMetaData search)
        {
            var qry = this.blogDetailRepo.Table.Where(x => x.IsDeleted == false && x.IsPublished == true);
            if (!string.IsNullOrEmpty(search.Search))
            {
                var str = search.Search.Replace('-', ' ');
                qry = qry.Where(x => x.Title.Contains(str) || x.Subject.Contains(str));
            }

            if (!string.IsNullOrEmpty(search.CategoryId))
            {
                qry = qry.Where(x => x.CategoryId == search.CategoryId);
            }

            BlogRespons resp = new BlogRespons();
            resp.TotalRecord = qry.Count();

            var skip = search.PageSize * search.PageNo;
            var blogs = await Task.Run(() => qry
                            .Skip(skip)
                            .Take(search.PageSize)
                            .Select(z => new
                            {
                                Id = z.Id,
                                Title = z.Title,
                                Subject = z.Subject,
                                PublishDate = z.ModifiedOn,
                                Slug = z.UrlSlug
                            }).ToList());

            var detail = new List<BlogFrontDetailMetaData>();
            foreach (var b in blogs)
            {
                BlogFrontDetailMetaData mb = new BlogFrontDetailMetaData
                {
                    Id = b.Id,
                    Title = b.Title,
                    Subject = b.Subject,
                    PublishDate = b.PublishDate,
                    Slug = b.Slug,                     
                };
                detail.Add(mb);
            }
            resp.Blogs = detail;
            return Ok(resp);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> FnSearch(SearchMetaData search)
        {
            var qry = this.blogDetailRepo.Table.Where(x => x.IsDeleted == false 
                        && x.Title.Contains(search.Search) && x.IsPublished == true)
                        .Take(10)
                        .Select(z => z.Title)                        
                        .ToList();
          
            return Ok(qry);
        }


    }
}
