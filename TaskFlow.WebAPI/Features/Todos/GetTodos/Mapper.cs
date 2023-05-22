namespace TaskFlow.WebAPI.Features.Todos.GetTodos;

using FastEndpoints;
using TaskFlow.Shared.Todos;
using TaskFlow.WebAPI.Features.Todos;

public class Mapper : ResponseMapper<List<TodoDto>, List<Todo>>
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
