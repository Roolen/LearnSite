using Core.Interfaces;

namespace Core.Entities.CourseAggregate
{
    public class Category : BaseEntity, IAggregateRoot
    {
        public string Title { get; set; }
        public string Image { get; set; }
    }
}
