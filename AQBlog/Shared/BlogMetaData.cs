using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AQBlog.Shared
{
    public class BlogDetailPagingMetaData
    {        
        public int PageSize { get; set; }
        public int PageNo { get; set; }
        public string Search { get; set; }
        public string CategoryId { get; set; }
    }

    public class BlogRespons
    {
        public BlogRespons()
        {
            Blogs = new List<BlogFrontDetailMetaData>();
        }
        public int TotalRecord { get; set; }
        public List<BlogFrontDetailMetaData> Blogs { get; set; }
    }

    public class MangeBlogMetaData
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }        
        public bool IsPublished { get; set; }      
        public string CategoryId { get; set; }
        public List<string> Tags { get; set; }
    }

    public class AddBlogMetaData
    {
        public string Id { get; set; }

        [Required]
        [StringLength(150, ErrorMessage = "Title should be between 1 to 150 character long", MinimumLength = 1)]

        public string Title { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "Subject should be between 1 to 250 character long", MinimumLength = 1)]
        public string Subject { get; set; }

      
        public string UrlSlug { get; set; }
        public bool IsPublished { get; set; }

       
        public string Description { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Category  should be between 1 to 50 character long", MinimumLength = 1)]

        public string CategoryId { get; set; }
        public List<string> Tags { get; set; }
    }

    public class EditBlogMetaData
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string UrlSlug { get; set; }
        public bool IsPublished { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }
        public List<string> Tags { get; set; }
        public bool IsActive { get; set; }
    }
}
