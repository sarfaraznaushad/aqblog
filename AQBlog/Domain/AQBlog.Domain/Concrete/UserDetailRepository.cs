using AQBlog.Domain.Abstract;
using AQBlog.Model;

namespace AQBlog.Domain.Concrete
{
    public class UserDetailRepository : ParentRepository<UserDetail>,
        IUserDetailRepository
    {
        public UserDetailRepository(AQContext context)
            : base(context)
        {

        }
    }
}
