namespace TaskFlow.WebAPI.Features.Todos.UpdateTodo;

using FastEndpoints;
using TaskFlow.WebAPI.Features.Todos;

public class Mapper : RequestMapper<UpdateTodoRequest, Todo>
{
    public override Todo ToEntity(UpdateTodoRequest r) => new()
    {
        Id = r.Id,
        Title = r.Todo.Title,
        Description = r.Todo.Description,
        DueDate = r.Todo.DueDate,
        Priority = r.Todo.Priority
    };
}
