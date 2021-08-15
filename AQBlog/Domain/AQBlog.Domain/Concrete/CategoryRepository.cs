using AQBlog.Domain.Abstract;
using AQBlog.Model;

namespace AQBlog.Domain.Concrete
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AQContext context)
            : base(context)
        {

        }
    }
}
