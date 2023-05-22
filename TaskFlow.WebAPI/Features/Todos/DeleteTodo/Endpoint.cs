namespace TaskFlow.WebAPI.Features.Todos.DeleteTodo;

using FastEndpoints;

public class Endpoint : Endpoint<DeleteTodoRequest, EmptyResponse>
{
    public override void Configure()
    {
        Delete("/api/todos/{Id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(DeleteTodoRequest req, CancellationToken ct = default)
    {
        await SendAsync(Response, 204, ct);
    }
}
