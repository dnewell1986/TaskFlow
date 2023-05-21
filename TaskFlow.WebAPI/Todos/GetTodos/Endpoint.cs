namespace TaskFlow.WebAPI.Todos.GetTodos;

using FastEndpoints;
using TaskFlow.Shared.Todos;

public class Endpoint : EndpointWithoutRequest<List<TodoDto>, TodoMapper>
{
    public override void Configure()
    {
        Get("/api/todos");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken cancellationToken)
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

        await SendAsync(Map.FromEntity(todos), cancellation: cancellationToken);
    }
}
