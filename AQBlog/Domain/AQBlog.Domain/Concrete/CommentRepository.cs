using AQBlog.Domain.Abstract;
using AQBlog.Model;

namespace AQBlog.Domain.Concrete
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(AQContext context)
            : base(context)
        {

        }
    }
}
