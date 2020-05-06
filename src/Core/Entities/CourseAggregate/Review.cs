using Core.Interfaces;

namespace Core.Entities.CourseAggregate
{
    public class Review : BaseEntity, IAggregateRoot
    {
        public string Text { get; set; }
        public int Assessment { get; set; }
        public User Author { get; set; }
        public Course Course { get; set; }
    }
}
