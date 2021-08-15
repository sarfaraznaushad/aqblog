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
    
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private ICategoryRepository categoryRepo;
        private IBlogDetailRepository blogDetailRepo;

        public BlogController(
            ICategoryRepository categoryRepo,
            IBlogDetailRepository blogDetailRepo)
        {
            this.categoryRepo = categoryRepo;
            this.blogDetailRepo = blogDetailRepo;
        }

        [HttpGet]
        //[Route("FnGetCategory()")]        
        public async Task<IActionResult> Get()
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
    }
}
