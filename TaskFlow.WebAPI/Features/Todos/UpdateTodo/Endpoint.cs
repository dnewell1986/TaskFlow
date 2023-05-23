namespace TaskFlow.WebAPI.Features.Todos.UpdateTodo;

using FastEndpoints;
using TaskFlow.WebAPI.Data;

public class Endpoint : EndpointWithMapper<UpdateTodoRequest, Mapper>
{
    private readonly AppDbContext _appDbContext;

    public Endpoint(AppDbContext appDbContext) => _appDbContext = appDbContext;

    public override void Configure()
    {
        Put("/api/todos/{Id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(UpdateTodoRequest req, CancellationToken ct = default)
    {
        if (req.Id != req.Todo.Id)
        {
            AddError("The id provided in the route must match the id of the object to be updated.");
            await SendErrorsAsync(StatusCodes.Status400BadRequest, ct);
        }
        else
        {
            var todo = await _appDbContext.Todos.FindAsync(new object[] { req.Id }, ct);
            if (todo is null)
            {
                await SendNotFoundAsync(ct);
            }
            else
            {
                var mappedTodo = Map.ToEntity(req);
                _appDbContext.Update(mappedTodo);
                await _appDbContext.SaveChangesAsync(ct);

                await SendNoContentAsync(ct);
            }
        }
    }
}
