using System.Net.Http;
using System;
using System.Threading.Tasks;
using refit_test.Models;
using refit_test.Configuration;
using System.Net.Http.Json;

namespace refit_test.Services
{
    public class TodoService : ITodoService
    {
        private readonly IApiConfig _config;
        private readonly HttpClient _httpClient;

        public TodoService(IApiConfig config, HttpClient httpClient)
        {
            _config = config;
            _httpClient = httpClient;
        }

        public async Task<TodoModel> GetTodo(int id)
        {
            return await _httpClient.GetFromJsonAsync<TodoModel>(
                $"{_config.BaseUrl}/todos/{id}"
            );
        }
    }
}