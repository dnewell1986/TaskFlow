namespace TaskFlow.WebAPI.Features.Todos.DeleteTodo;

using FastEndpoints;
using TaskFlow.WebAPI.Data;

public class Endpoint : Endpoint<DeleteTodoRequest>
{
    private readonly AppDbContext _appDbContext;

    public Endpoint(AppDbContext appDbContext) => _appDbContext = appDbContext;

    public override void Configure()
    {
        Delete("/api/todos/{Id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(DeleteTodoRequest req, CancellationToken ct = default)
    {
        var todo = await _appDbContext.Todos.FindAsync(new object[] { req.Id }, cancellationToken: ct);

        if (todo is null)
        {
            await SendNotFoundAsync(ct);
        }
        else
        {
            _appDbContext.Todos.Remove(todo);
            await _appDbContext.SaveChangesAsync(ct);
            await SendNoContentAsync(ct);
        }
    }
}
