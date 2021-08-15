using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AQBlog.Model
{
    public class MasterDetail : BaseEntity
    {
        [MaxLength(5)]
        public string MasterCode { get; set; }

        [MaxLength(50)]
        public string MasterContent { get; set; }
    }
}
