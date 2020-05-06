using Core.Interfaces;

namespace Core.Entities.CourseAggregate
{
    public class BuyCourse : BaseEntity, IAggregateRoot
    {
        public User User { get; set; }
        public Course Course { get; set; }
    }
}
