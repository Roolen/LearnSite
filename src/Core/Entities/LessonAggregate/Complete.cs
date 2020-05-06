using Core.Interfaces;

namespace Core.Entities.LessonAggregate
{
    public class Complete : BaseEntity, IAggregateRoot
    {
        public User User { get; set; }
        public Lesson Lesson { get; set; }
    }
}
