namespace TaskFlow.WebAPI.Features.Todos.GetTodos;

using FastEndpoints;
using Microsoft.EntityFrameworkCore;
using TaskFlow.Shared.Todos;
using TaskFlow.WebAPI.Data;

public class Endpoint : EndpointWithoutRequest<List<TodoDto>, Mapper>
{
    private readonly AppDbContext _appDbContext;

    public Endpoint(AppDbContext appDbContext) => _appDbContext = appDbContext;

    public override void Configure()
    {
        Get("/api/todos");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct = default)
    {
        var todos = await _appDbContext.Todos.ToListAsync(ct);

        await SendAsync(Map.FromEntity(todos), cancellation: ct);
    }
}
