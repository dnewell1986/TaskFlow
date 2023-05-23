namespace TaskFlow.WebAPI.Features.Todos.GetTodoById;

using FastEndpoints;
using TaskFlow.Shared.Todos;
using TaskFlow.WebAPI.Data;

public class Endpoint : Endpoint<GetTodoByIdRequest, TodoDto, Mapper>
{
    private readonly AppDbContext _appDbContext;

    public Endpoint(AppDbContext appDbContext) => _appDbContext = appDbContext;

    public override void Configure()
    {
        Get("/api/todos/{Id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetTodoByIdRequest req, CancellationToken ct = default)
    {
        var todo = await _appDbContext.Todos.FindAsync(new object[] { req.Id }, ct);

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
