using AQBlog.Domain.Abstract;
using AQBlog.Model;

namespace AQBlog.Domain.Concrete
{
    public class BlogDetailRepository :Repository<BlogDetail>, IBlogDetailRepository
    {
        public BlogDetailRepository(AQContext context)
            : base(context)
        {

        }
    }
}
