using AQBlog.Model;
using System;

namespace AQBlog.Domain.Infrastructure
{
    public class EntityCommon
    {
        public static void Created(dynamic entity, UserDetail user)
        {
            entity.CreatedOn = DateTime.UtcNow;
            entity.ModifiedOn = DateTime.UtcNow;
            entity.CreatedBy = user.Id;
            entity.ModifiedBy = user.Id;
        }

        public static void Modified(dynamic entity, UserDetail user)
        {            
            entity.ModifiedOn = DateTime.UtcNow;         
            entity.ModifiedBy = user.Id;
        }
    }
}
