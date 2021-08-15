using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AQBlog.Model
{
    public class BlogDetail : BaseEntity
    {
        public BlogDetail()
        {
            
        }

        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Subject { get; set; }
        [MaxLength(250)]
        public string UrlSlug { get; set; }
        public bool IsPublished { get; set; }
        public string Description { get; set; }

        [MaxLength(50)]
        public string CategoryId { get; set; }

        [MaxLength(500)]
        public string Tags { get; set; }
    }
}
