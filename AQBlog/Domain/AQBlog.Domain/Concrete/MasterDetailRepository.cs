using AQBlog.Domain.Abstract;
using AQBlog.Model;

namespace AQBlog.Domain.Concrete
{
    public class MasterDetailRepository :Repository<MasterDetail>,
        IMasterDetailRepository
    {
        public MasterDetailRepository(AQContext context)
            : base(context)
        {

        }
    }
}
