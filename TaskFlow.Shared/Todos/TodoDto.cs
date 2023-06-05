namespace TaskFlow.Shared.Todos;

using System.Text.Json.Serialization;

public class TodoDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTimeOffset? DueDate { get; set; }
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Priority Priority { get; set; }
    public string CreatedByUserId { get; set; }
    public string AssignedToUserId { get; set; }
}
