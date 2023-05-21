namespace TaskFlow.Shared.Todos;

public class TodoDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime? DueDate { get; set; }
    public Priority Priority { get; set; }
    public string CreatedByUserId { get; set; }
    public string AssignedToUserId { get; set; }
}
