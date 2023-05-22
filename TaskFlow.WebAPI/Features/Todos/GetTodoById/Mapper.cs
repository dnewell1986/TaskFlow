namespace TaskFlow.WebAPI.Features.Todos.GetTodoById;

using FastEndpoints;
using TaskFlow.Shared.Todos;
using TaskFlow.WebAPI.Features.Todos;

public class Mapper : ResponseMapper<TodoDto, Todo>
{
    public override TodoDto FromEntity(Todo e) => new()
    {
        Id = e.Id,
        Title = e.Title,
        Description = e.Description,
        DueDate = e.DueDate,
        Priority = e.Priority
    };
}
