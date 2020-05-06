using Core.Interfaces;

namespace Core.Entities.LessonAggregate
{
    public class TypeTask : BaseEntity, IAggregateRoot
    {
        public string Name { get; set; }
    }
}
