namespace AQBlog.Domain.Infrastructure
{
    public class CommonMethod
    {
        public static string Slug(string title)
        {
            return title.Replace(' ', '-');
        }
    }
}
