namespace TaskFlow.WebAPI.Features.Todos.GetTodoById;

using FastEndpoints;
using TaskFlow.Shared.Todos;

public class Endpoint : Endpoint<GetTodoByIdRequest, TodoDto, Mapper>
{
    public override void Configure()
    {
        Get("/api/todos/{Id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetTodoByIdRequest req, CancellationToken ct = default)
    {
        var todo = new Todo()
        {
            Id = req.Id,
            Title = "Test Todo",
            Description = "This is a test todo while setting up the API",
            DueDate = DateTimeOffset.Now,
            Priority = Shared.Priority.Medium
        };

        if (todo is null)
        {
            await SendNotFoundAsync(ct);
        }
        else
        {
            await SendAsync(Map.FromEntity(todo), cancellation: ct);
        }
    }
}
