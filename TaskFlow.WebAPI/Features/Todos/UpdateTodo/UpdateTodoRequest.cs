namespace TaskFlow.WebAPI.Features.Todos.UpdateTodo;

using TaskFlow.Shared.Todos;

public class UpdateTodoRequest
{
    public Guid Id { get; set; }
    public TodoDto Todo { get; set; }
}
