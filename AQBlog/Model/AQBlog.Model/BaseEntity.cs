using System;
using System.ComponentModel.DataAnnotations;

namespace AQBlog.Model
{
    public abstract class BaseEntity : ParentEntity
    {
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        [MaxLength(50)]
        public string CreatedBy { get; set; }
        [MaxLength(50)]
        public string ModifiedBy { get; set; }
    }
}
