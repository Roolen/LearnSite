using Core.Interfaces;

namespace Core.Entities.CourseAggregate
{
    public class TechLogo : BaseEntity, IAggregateRoot
    {
        public Course Course { get; set; }
        public string Image { get; set; }
    }
}
