using TaskFlow.Shared;
using TaskFlow.WebAPI.Users;

namespace TaskFlow.WebAPI.Tasks
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public Priority Priority { get; set; }
        public string CreatedByUserId { get; set; }
        public User CreatedByUser { get; set; }
        public string AssignedToUserId { get; set; }
        public User AssignedToUser { get; set; }
    }
}
