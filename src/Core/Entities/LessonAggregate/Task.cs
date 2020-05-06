using Core.Interfaces;

namespace Core.Entities.LessonAggregate
{
    public class Task : BaseEntity, IAggregateRoot
    {
        public Lesson Lesson { get; set; }
        public TypeTask Type { get; set; }
        public string Text { get; set; }
        public string Test { get; set; }
    }
}
