using TestAPI.Domain.Enums;

namespace TestAPI.Domain.Entities
{
    public class TaskCard : BaseEntity
    {
        public User? Author { get; set; }
        public User? Performer { get; set; }
        public CardStatus Status { get; set; }
        public CardPriority Priority { get; set; }
        public IList<TaskCard> Related { get; private set; } = [];
        public IList<TaskCard> Subtasks { get; private set; } = [];
    }
}
