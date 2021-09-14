using System;
using System.ComponentModel.DataAnnotations;

namespace AQBlog.Shared
{
    public class MasterMetaData
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public bool Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class AddMasterMetaData
    {
        public string Id { get; set; }
        
        public string MasterCode { get; set; }

        [Required]
        public string Content { get; set; }
        public bool IsActive { get; set; }
    }

    public class MasterDetailMetaData
    {
        public string MasterCode { get; set; }
        public string Title { get; set; }
    }
}
