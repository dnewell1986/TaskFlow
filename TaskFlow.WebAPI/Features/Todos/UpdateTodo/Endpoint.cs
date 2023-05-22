namespace TaskFlow.WebAPI.Features.Todos.UpdateTodo;

using FastEndpoints;
using TaskFlow.Shared.Todos;

public class Endpoint : Endpoint<UpdateTodoRequest, TodoDto, Mapper>
{
    public override void Configure()
    {
        Put("/api/todos/{Id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(UpdateTodoRequest req, CancellationToken ct = default)
    {
        var todo = Map.ToEntity(req);

        await SendAsync(req.Todo, cancellation: ct);
    }
}
