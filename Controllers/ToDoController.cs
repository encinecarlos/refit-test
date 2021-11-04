using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Refit;
using refit_test.Abstractions;
using refit_test.Configuration;
using refit_test.Services;

namespace refit_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly ITodoService _todoService;
        private IApiConfig _config { get; }

        public ToDoController(ITodoService todoService, IApiConfig config)
        {
            _todoService = todoService;
            _config = config;
        }

        [HttpGet("GetTodo/{id}")]
        public async Task<ActionResult> GetTodo(int id)
        {
            return Ok(await _todoService.GetTodo(id));
        }

        [HttpGet("GetTodos")]
        public async Task<ActionResult> GetAllTodos()
        {
            var bff = RestService.For<ITodoApi>($"{_config.BaseUrl}");

            return Ok(await bff.GetTodos());
        }

        [HttpGet("say-hello")]
        public async Task<ActionResult> SayHello()
        {
            var bff = RestService.For<ITodoApi>($"{_config.InternalUrl}");

            return Ok(await bff.Hello());
        }
    }
}