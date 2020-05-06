using Core.Interfaces;

namespace Core.Entities.LessonAggregate
{
    public class Lesson : BaseEntity, IAggregateRoot
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Video { get; set; }
        public double TravelTime { get; set; }
        public int CompleteConditions { get; set; }
        public int Difficult { get; set; }
    }
}
