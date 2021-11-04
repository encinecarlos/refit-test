using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using refit_test.Models;
using Refit;

namespace refit_test.Abstractions
{
    public interface ITodoApi
    {
        [Get("/todos")]
        Task<IEnumerable<TodoModel>> GetTodos();

        [Get("/Home")]
        Task<string> Hello();
    }
}