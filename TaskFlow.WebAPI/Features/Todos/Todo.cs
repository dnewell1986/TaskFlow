namespace TaskFlow.WebAPI.Features.Todos;

using TaskFlow.Shared;
using TaskFlow.WebAPI.Features.Users;

public class Todo
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTimeOffset? DueDate { get; set; }
    public Priority Priority { get; set; }
    public string CreatedByUserId { get; set; }
    public User CreatedByUser { get; set; }
    public string AssignedToUserId { get; set; }
    public User AssignedToUser { get; set; }
}
