using System.ComponentModel.DataAnnotations;

namespace AQBlog.Model
{
    public class Comment : BaseEntity
    {
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string BlogId { get; set; }
    }
}
