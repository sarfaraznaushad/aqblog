using AQBlog.Domain.Abstract;
using AQBlog.Domain.Infrastructure;
using AQBlog.Model;
using AQBlog.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AQBlog.Server.Controllers
{

    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class BlogController : ControllerBase
    {
        private ICategoryRepository categoryRepo;
        private IBlogDetailRepository blogDetailRepo;
        private IMasterDetailRepository masterRepo;


        public BlogController(
            ICategoryRepository categoryRepo,
            IBlogDetailRepository blogDetailRepo,
            IMasterDetailRepository masterRepo)
        {
            this.categoryRepo = categoryRepo;
            this.blogDetailRepo = blogDetailRepo;
            this.masterRepo = masterRepo;
        }

        #region Category


        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> FnGetCategory()
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

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> FnGetCategoryDropdown()
        {
            var category = await Task.Run(() => this.categoryRepo.FindByFilterDefinition(x => x.IsDeleted == false)
                            .Select(z => new DropdownMetaData()
                            {
                                Id = z.Id,
                                Text = z.Title
                            }).ToList());
            return Ok(category);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> AcAddCategory(AddCategoryMetaData category)
        {
            var userDetail = Encryption.UserDetail(User.Claims.ToList());
            Category cat;

            if (string.IsNullOrEmpty(category.Id))
            {
                cat = new Category
                {
                    Title = category.CategoryName,
                    Icon = category.Icon,
                    IsActive = category.IsActive,
                    ParentId = category.ParentCategoryId,
                    UrlSlug = category.Slug,
                    Description = category.Description,
                };

                EntityCommon.Created(cat, userDetail);
                await this.categoryRepo.InsertAsync(cat);
            }
            else
            {
                cat = this.categoryRepo.FindByFilterDefinition(x => x.Id == category.Id).FirstOrDefault();
                cat.Title = category.CategoryName;
                cat.Icon = category.Icon;
                cat.IsActive = category.IsActive;
                cat.ParentId = category.ParentCategoryId;
                cat.UrlSlug = category.Slug;
                cat.Description = category.Description;

                EntityCommon.Modified(cat, userDetail);
                await this.categoryRepo.UpdateAsync(cat);
            }
            return Ok(category);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> FnGetCategoryById(string id)
        {
            var category = await Task.Run(() => this.categoryRepo.FindByFilterDefinition(x => x.IsDeleted == false
                            && x.Id == id)
                            .Select(z => new AddCategoryMetaData()
                            {
                                CategoryName = z.Title,
                                Description = z.Description,
                                Icon = z.Icon,
                                Slug = z.UrlSlug,
                                Id = z.Id,
                                IsActive = z.IsActive,
                                ParentCategoryId = z.ParentId
                            }).FirstOrDefault());
            return Ok(category);
        }


        #endregion

        #region Master

        [HttpGet]
        [Route("[action]")]
        public IActionResult FnGetMaster()
        {
            var master = new List<MasterDetailMetaData>();
            master.Add(new MasterDetailMetaData() { MasterCode = "TAG", Title = "Tag" });
            return Ok(master);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> AcAddMaster(AddMasterMetaData master)
        {
            MasterDetail md;
            if (string.IsNullOrEmpty(master.Id))
            {
                md = new MasterDetail();
                md.MasterCode = master.MasterCode;
                md.MasterContent = master.Content;
                md.IsDeleted = false;
                md.ModifiedOn = DateTime.UtcNow;
                md.CreatedOn = DateTime.UtcNow;
                await this.masterRepo.InsertAsync(md);
            }
            else
            {
                md = this.masterRepo.FindByFilterDefinition(x => x.Id == master.Id).FirstOrDefault();
                if (md == null)
                    throw new Exception("Master not found");

                md.MasterContent = master.Content;
                md.ModifiedOn = DateTime.UtcNow;
                await this.masterRepo.UpdateAsync(md);
            }
            return Ok(md);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> FnManageMaster(string masterCode)
        {
            var category = await Task.Run(() => this.masterRepo.FindByFilterDefinition(x => x.IsDeleted == false
                                && x.MasterCode == masterCode)
                            .Select(z => new MasterMetaData()
                            {
                                CreatedBy = z.CreatedBy,
                                CreatedDate = z.CreatedOn,
                                Status = true,
                                Title = z.MasterContent,
                                Id = z.Id
                            }).ToList());
            return Ok(category);
        }


        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> FnGetMasterById(string id)
        {
            var category = await Task.Run(() => this.masterRepo.FindByFilterDefinition(x => x.IsDeleted == false
                                && x.Id == id)
                            .Select(z => new AddMasterMetaData()
                            {
                                MasterCode = z.MasterCode,
                                Content = z.MasterCode,
                                Id = z.Id
                            }).FirstOrDefault());
            return Ok(category);
        }


        #endregion

        #region Blog Detail

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> AcAddBlog(AddBlogMetaData blog)
        {
            BlogDetail bd;
            if (string.IsNullOrEmpty(blog.Id))
            {
                bd = new BlogDetail
                {
                    CategoryId = blog.CategoryId,
                    Description = blog.Description,
                    IsPublished = blog.IsPublished,
                    Subject = blog.Subject,
                    Tags = String.Join(",", blog.Tags),
                    Title = blog.Title,
                    UrlSlug = CommonMethod.Slug(blog.Title)
                };

                await blogDetailRepo.InsertAsync(bd);
            }
            else
            {
                bd = blogDetailRepo.GetById(blog.Id);
                bd.Title = blog.Title;
                bd.CategoryId = blog.CategoryId;
                bd.Description = blog.Description;
                bd.IsPublished = blog.IsPublished;
                bd.Subject = blog.Subject;
                bd.Tags = String.Join(",", blog.Tags);
                bd.Title = blog.Title;
                bd.UrlSlug = CommonMethod.Slug(blog.Title);

                await blogDetailRepo.UpdateAsync(bd);
            }
            return Ok(bd);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> FnGetBlogById(string blogId)
        {
            var blog = await Task.Run(() => this.blogDetailRepo.FindByFilterDefinition(x => x.IsDeleted == false
                            && x.Id == blogId)
                            .Select(z => new
                            {
                                CategoryId = z.CategoryId,
                                Tags = z.Tags,
                                IsPublished = z.IsPublished,
                                Id = z.Id,
                                Title = z.Title,
                                Description = z.Description,
                                Subject = z.Subject,
                            }).FirstOrDefault());

            var detail = new EditBlogMetaData();
            detail.CategoryId = blog.CategoryId;
            detail.Id = blog.Id;
            detail.IsPublished = blog.IsPublished;
            detail.Subject = blog.Subject;
            detail.Tags = blog.Tags.Split(',').ToList();
            detail.Title = blog.Title;
            detail.Description = blog.Description;
            detail.Subject = blog.Subject;

            return Ok(detail);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> FnManageBlog()
        {
            var blogs = await Task.Run(() => this.blogDetailRepo.FindByFilterDefinition(x => x.IsDeleted == false)
                            .Select(z => new
                            {
                                CategoryId = z.CategoryId,
                                Tags = z.Tags,
                                Subject = z.Subject,
                                IsPublished = z.IsPublished,
                                Id = z.Id,
                                Title = z.Title
                            }).ToList());

            var detail = new List<MangeBlogMetaData>();
            foreach (var b in blogs)
            {
                MangeBlogMetaData mb = new MangeBlogMetaData
                {
                    CategoryId = b.CategoryId,
                    Id = b.Id,
                    IsPublished = b.IsPublished,
                    Subject = b.Subject,
                    Tags = b.Tags.Split(",").ToList(),
                    Title = b.Title
                };
                detail.Add(mb);
            }
            return Ok(detail);
        }


        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> PublishedBlog([FromBody] string id)
        {
            var bd = this.blogDetailRepo.FindByFilterDefinition(x => x.IsDeleted == false
                            && x.Id == id).FirstOrDefault();

            if(bd != null)
            {
                bd.IsPublished = !bd.IsPublished;
                bd.ModifiedOn = DateTime.Now;
                await blogDetailRepo.UpdateAsync(bd);
            }           
            return Ok(bd);
        }

        #endregion
    }
}
