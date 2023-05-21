namespace TaskFlow.UI.Todos;

using Refit;
using TaskFlow.Shared.Todos;

public interface ITodoApi
{
    [Get("/api/todos")]
    Task<ApiResponse<List<TodoDto>>> GetTodosAsync();
}

public class TodoService
{
    private readonly ITodoApi _todoApi;

    public TodoService(ITodoApi todoApi) => _todoApi = todoApi;

    public async Task<List<TodoDto>> GetTodosAsync()
    {
        try
        {
            var response = await _todoApi.GetTodosAsync();

            if (response.IsSuccessStatusCode)
            {
                return response.Content;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return new List<TodoDto>();
            }
            else
            {
                throw new Exception($"Failed to retrieve todos. Status code: {response.StatusCode}, Error: {response.Error}");
            }
        }
        catch (ApiException ex)
        {
            throw;
        }
        catch (Exception ex)
        {

            throw;
        }
    }
}
