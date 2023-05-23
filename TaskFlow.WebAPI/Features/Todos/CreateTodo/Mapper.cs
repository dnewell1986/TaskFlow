namespace TaskFlow.WebAPI.Features.Todos.CreateTodo;

using FastEndpoints;
using TaskFlow.Shared.Todos;

public class Mapper : RequestMapper<TodoDto, Todo>
{
    public override Todo ToEntity(TodoDto r) => new()
    {
        Title = r.Title,
        Description = r.Description,
        DueDate = r.DueDate,
        Priority = r.Priority
    };
}
