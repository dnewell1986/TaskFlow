namespace TaskFlow.UI.Todos;

using Refit;
using TaskFlow.Shared.Todos;

public interface ITodoApi
{
    [Get("/api/todos")]
    Task<ApiResponse<List<TodoDto>>> GetTodosAsync();

    [Get("/api/todos/{id}")]
    Task<ApiResponse<TodoDto>> GetTodoByIdAsync(Guid id);

    [Post("/api/todos")]
    Task CreateTodoAsync([Body] TodoDto todoDto);

    [Put("/api/todos/{id}")]
    Task UpdateTodoAsync(Guid id, [Body] UpdateTodoRequest request);
}

public class TodoService
{
    private readonly ITodoApi _todoApi;
    private readonly ILogger<TodoService> _logger;

    public TodoService(ITodoApi todoApi, ILogger<TodoService> logger)
    {
        _todoApi = todoApi;
        _logger = logger;
    }

    public async Task<List<TodoDto>> GetTodosAsync()
    {
        try
        {
            var response = await _todoApi.GetTodosAsync();
            return response.Content ?? new List<TodoDto>();
        }
        catch (ApiException ex)
        {
            _logger.LogError(ex, ex.Message);
            throw;
        }
    }

    public async Task<TodoDto> GetTodoByIdAsync(Guid id)
    {
        try
        {
            var response = await _todoApi.GetTodoByIdAsync(id);
            return response.Content;
        }
        catch (ApiException ex)
        {
            _logger.LogError(ex, ex.Message);
            throw;
        }
    }

    public async Task CreateTodoAsync(TodoDto todoDto)
    {
        try
        {
            await _todoApi.CreateTodoAsync(todoDto);
        }
        catch (ApiException ex)
        {
            _logger.LogError(ex, "Failed to Create Task, Reason: {Reason}", ex.ReasonPhrase);
        }
    }

    public async Task UpdateTodoAsync(TodoDto todoDto)
    {
        try
        {
            await _todoApi.UpdateTodoAsync(todoDto.Id, new UpdateTodoRequest { Id = new(), Todo = todoDto });
        }
        catch (ApiException ex)
        {
            _logger.LogError(ex, "Error updating todo: {ErrorMessage}", ex.Message);
            throw;
        }
    }
}
