using System.ComponentModel.DataAnnotations;

namespace AQBlog.Model
{
    public class UserDetail : ParentEntity
    {
        [MaxLength(50)]
        public string UserName { get; set; }

        [MaxLength(100)]
        public string Password { get; set; }

        [MaxLength(150)]
        public string SaltPassword { get; set; }
    }
}
