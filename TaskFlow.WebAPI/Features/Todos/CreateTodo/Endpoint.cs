namespace TaskFlow.WebAPI.Features.Todos.CreateTodo;

using FastEndpoints;
using TaskFlow.Shared.Todos;
using TaskFlow.WebAPI.Data;

public class Endpoint : EndpointWithMapper<TodoDto, Mapper>
{
    private readonly AppDbContext _appDbContext;

    public Endpoint(AppDbContext appDbContext) => _appDbContext = appDbContext;

    public override void Configure()
    {
        Post("/api/todos");
        AllowAnonymous();
    }

    public override async Task HandleAsync(TodoDto req, CancellationToken ct = default)
    {
        var todo = Map.ToEntity(req);

        _appDbContext.Todos.Add(todo);
        await _appDbContext.SaveChangesAsync(ct);

        await SendAsync(new EmptyResponse(), StatusCodes.Status201Created, ct);
    }
}
