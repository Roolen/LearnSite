using Core.Interfaces;

namespace Core.Entities.CourseAggregate
{
    public class Course : BaseEntity, IAggregateRoot
    {
        public User Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double TravelTime { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
    }
}
