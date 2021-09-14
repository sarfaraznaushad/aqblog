using System.ComponentModel.DataAnnotations;

namespace AQBlog.Shared
{
    public class CategoryMetaData
    {
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }

    public class AddCategoryMetaData
    {
        public string Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Category should be between 1 to 50 character long", MinimumLength = 1)]
        public string CategoryName { get; set; }
        public string ParentCategoryId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Slug should be between 1 to 50 character long", MinimumLength = 1)]
        public string Slug { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public bool IsActive { get; set; }
    }
    
}
