namespace TaskFlow.WebAPI.Todos.GetTodos;

using FastEndpoints;
using TaskFlow.Shared.Todos;
using TaskFlow.WebAPI.Todos;

public class TodoMapper : ResponseMapper<List<TodoDto>, List<Todo>>
{
    public override List<TodoDto> FromEntity(List<Todo> e) => e.Select(x => new TodoDto
    {
        Id = x.Id,
        Title = x.Title,
        Description = x.Description,
        DueDate = x.DueDate,
        Priority = x.Priority
    }).ToList();
}
