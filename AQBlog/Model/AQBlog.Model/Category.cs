using System.ComponentModel.DataAnnotations;

namespace AQBlog.Model
{
    public class Category : BaseEntity
    {
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string ParentId { get; set; }

        [MaxLength(50)]
        public string Icon { get; set; }

        [MaxLength(150)]
        public string UrlSlug { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
