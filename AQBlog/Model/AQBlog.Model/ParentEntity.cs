using System.ComponentModel.DataAnnotations;

namespace AQBlog.Model
{
    public abstract class ParentEntity
    {
        [MaxLength(50)]
        private string _id;
        public ParentEntity()
        {
            _id = System.Guid.NewGuid().ToString();
        }

        public bool IsDeleted { get; set; }
      
        public string Id
        {
            get { return _id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _id = System.Guid.NewGuid().ToString();
                else
                    _id = value;

            }
        }
    }
}
