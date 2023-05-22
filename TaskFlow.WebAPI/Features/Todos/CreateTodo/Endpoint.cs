namespace TaskFlow.WebAPI.Features.Todos.CreateTodo;

using FastEndpoints;
using TaskFlow.Shared.Todos;

public class Endpoint : EndpointWithMapper<TodoDto, Mapper>
{
    public override void Configure()
    {
        Post("/api/todos");
        AllowAnonymous();
    }

    public override async Task HandleAsync(TodoDto req, CancellationToken ct = default)
    {
        var todo = Map.ToEntity(req);

        await SendAsync(new EmptyResponse(), StatusCodes.Status201Created, ct);
    }
}
