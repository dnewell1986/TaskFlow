namespace TaskFlow.WebAPI.Features.Todos.GetTodos;

using FastEndpoints;
using TaskFlow.Shared.Todos;
using TaskFlow.WebAPI.Features.Todos;

public class Endpoint : EndpointWithoutRequest<List<TodoDto>, Mapper>
{
    public override void Configure()
    {
        Get("/api/todos");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct = default)
    {
        var todos = new List<Todo>()
        {
            new Todo()
            {
                Id = Guid.NewGuid(),
                Title = "Test Todo",
                Description = "This is a test todo while setting up the API",
                DueDate = DateTimeOffset.Now,
                Priority = Shared.Priority.Medium
            }
        };

        await SendAsync(Map.FromEntity(todos), cancellation: ct);
    }
}
