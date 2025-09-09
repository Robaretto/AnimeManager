using AnimeManager.Models;
using System.Net.Http.Json;

namespace AnimeManager.Services
{
    public class TodoService
    {
        private readonly HttpClient _http;

        public TodoService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Todo>> ObtenerTodosAsync()
        {
            var resultado = await _http.GetFromJsonAsync<List<Todo>>("https://jsonplaceholder.typicode.com/todos");
            return resultado ?? new List<Todo>();
        }
    }
}