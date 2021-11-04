using System;
using System.Threading.Tasks;
using refit_test.Models;

namespace refit_test.Services
{
    public interface ITodoService
    {
        Task<TodoModel> GetTodo(int id);
    }
}