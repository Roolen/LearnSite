using Core.Interfaces;

namespace Core.Entities.LessonAggregate
{
    public class Comment : BaseEntity, IAggregateRoot
    {
        public User Author { get; set; }
        public Lesson Lesson { get; set; }
        public string Text { get; set; }
    }
}
