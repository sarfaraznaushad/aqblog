using System;

namespace AQBlog.Shared
{
    public class BlogFrontDetailMetaData
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public DateTime PublishDate { get; set; }
        public string Slug { get; set; }
    }

    public class BlogFrontViewMetaData
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public DateTime PublishDate { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
    }

    public class SearchMetaData
    {
        public string Search { get; set; }
    }
}
